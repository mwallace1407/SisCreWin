using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;
using System.IO;
using System.Data.SqlClient;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmRegistroAjuste : Form
    {
        #region Variables
        clsGeneral.PuentesPagos Puente;
        clsGeneral.PuentesPagos PuenteQ;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
        bool EnProceso = false;
        int NumeroPrestamoAnt = 0;

        DataTable Propiedades;
        DataTable Archivos;
        List<string> ListaArchivos;
        #endregion Variables
        #region Enumeraciones
        private enum TipoProceso
        {
            Visualizacion,
            Extraccion
        }
        #endregion Enumeraciones
        #region Metodos
        public frmRegistroAjuste()
        {
            InitializeComponent();
        }
        
        private void ValoresIniciales()
        {
            ResultadoStored_Str Resultado = new BD.ResultadoStored_Str();

            Resultado = clsBD.Puentes_C_ObtenerFechaUltimoCierre();

            if (!Resultado.HayError)
            {
                dtpFechaPago.MinDate = new DateTime(2005, 01, 01);
                dtpFechaPago.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpFechaPago.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                cboNumeroPrestamo.DisplayMember = "Descripcion";
                cboNumeroPrestamo.ValueMember = "Valor";
                cboNumeroPrestamo.DataSource = clsBD.Puentes_C_ObtenerPrestamos().Resultado;
                txtComiAplicacion.Value = 0;
                txtInteresCapVenc.Value = 0;
                txtInteresCubierto.Value = 0;
                txtMontoTotal.Value = 0;
                txtPagoCapital.Value = 0;
                txtPagoIntMoratorios.Value = 0;
                btnCrear.Enabled = false;
                txtObservaciones.Text = string.Empty;
                
                ListaArchivos = new List<string>();
                Archivos = new DataTable();
                Archivos.Columns.Add("Archivo");
                Archivos.Columns.Add("Ubicación");
                grdArchivos.DataSource = null;
                grdPropiedades.DataSource = null;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Valida()
        {
            decimal Suma = txtPagoCapital.Value + txtInteresCubierto.Value + txtInteresCapVenc.Value + txtComiAplicacion.Value + txtPagoIntMoratorios.Value;

            if (txtMontoTotal.Value > Suma)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "El monto aplicado en la dispersión es menor al monto total";
                btnCrear.Enabled = false;
            }
            else if (txtMontoTotal.Value < Suma)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "El monto aplicado en la dispersión es mayor al monto total";
                btnCrear.Enabled = false;
            }
            else
            {
                lblMensaje.Visible = false;
                btnCrear.Enabled = true;
            }

            if (cboNumeroPrestamo.SelectedIndex < 0 || (cboNumeroPrestamo.SelectedIndex >= 0 && Convert.ToInt32(cboNumeroPrestamo.SelectedValue) <= 0))
                btnCrear.Enabled = false;
        }
        #endregion Metodos
        #region Eventos
        private void frmRegistroPago_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
            Valida();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtMontoTotal.Value == 0)
            {
                if (MessageBox.Show("Está a punto de registrar un ajuste en CEROS para el crédito " + cboNumeroPrestamo.Text + Environment.NewLine + "Está función se considera sólo para hacer una reconstrucción de créditos. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (txtMontoTotal.Value < 0)
            {
                if (MessageBox.Show("Está a punto de registrar un ajuste en monto NEGATIVO para el crédito " + cboNumeroPrestamo.Text + Environment.NewLine + "¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (dtpFechaPago.Value < dtpFechaPago.MaxDate)
            {
                if (MessageBox.Show("El sistema reconstruirá los registros posteriores a la fecha seleccionada, eliminando movimientos y pagos realizados hasta alcanzar la fecha del mismo. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (dtpFechaPago.Value == dtpFechaPago.MaxDate)
            {
                if (MessageBox.Show("¿Está seguro de realizar el ajuste para el crédito " + cboNumeroPrestamo.Text + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            ErrorProceso = string.Empty;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            NumeroPrestamoAnt = Convert.ToInt32(cboNumeroPrestamo.Text);
            PuenteQ = new clsGeneral.PuentesPagos(Sistema.Global.Usr_Id, Convert.ToInt32(clsGeneral.TiposPagoPuentesEnum.Ajuste), dtpFechaPago.Value, Convert.ToInt32(cboNumeroPrestamo.Text), txtPagoCapital.Value, txtInteresCubierto.Value, txtInteresCapVenc.Value, txtComiAplicacion.Value, txtPagoIntMoratorios.Value, vPHP_Observaciones: txtObservaciones.Text.Trim());
            //Puente = new clsGeneral.PuentesPagos(Sistema.Global.Usr_Id, Convert.ToInt32(clsGeneral.TiposPagoPuentes.Ajuste), dtpFechaPago.Value, Convert.ToInt32(cboNumeroPrestamo.Text), txtQPagoCapital.Value, txtQInteresCubierto.Value, txtQInteresCapVenc.Value, txtQComiAplicacion.Value, txtQPagoIntMoratorios.Value, vPHP_Observaciones: txtQObservaciones.Text.Trim());
            Puente = new clsGeneral.PuentesPagos(Sistema.Global.Usr_Id, Convert.ToInt32(clsGeneral.TiposPagoPuentesEnum.Ajuste), dtpFechaPago.Value, Convert.ToInt32(cboNumeroPrestamo.Text), 0, 0, 0, 0, 0, vPHP_Observaciones: "");
            wkr01.RunWorkerAsync();
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_M_RegistrarPago, vBit_DatosPrevios: clsGeneral.Zip("Préstamo: " + Puente.PHP_NumeroPrestamo.ToString()));
            //Adjuntar archivos
            Guid idArchivos = new Guid();
            idArchivos = Guid.NewGuid();
            //************

            clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

            if (ListaArchivos.Count > 0)
                Resultado = clsBD.Puentes_M_RegistrarPago(Puente, PuenteQ, idArchivos);
            else
                Resultado = clsBD.Puentes_M_RegistrarPago(Puente, PuenteQ);

            if (Resultado.HayError)
                ErrorProceso = Resultado.Error;

            if (ListaArchivos.Count > 0)
            {
                foreach (string Archivo in ListaArchivos)
                {
                    try
                    {
                        if (File.Exists(Archivo))
                        {
                            FileInfo fi = new FileInfo(Archivo);

                            Resultado = new ResultadoStored_Str();
                            Resultado = clsBD.Puentes_I_ArchivosAjustes(idArchivos, fi.Name, fi.Length, File.ReadAllBytes(Archivo));

                            if (Resultado.HayError)
                                ErrorProceso += "Error con carga de " + Path.GetFileName(Archivo) + ": " + Resultado.Error;
                        }
                        else
                        {
                            ErrorProceso += "No se encontró el archivo " + Path.GetFileName(Archivo);
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorProceso += "Error con carga de " + Path.GetFileName(Archivo) + ": " + ex.Message;
                    }
                }
            }
        }

        private void wkr01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Se han realizado los movimientos de aplicación de ajuste.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ValoresIniciales();
            
            if (cboNumeroPrestamo.FindString(NumeroPrestamoAnt.ToString()) >= 0)
            {
                cboNumeroPrestamo.SelectedValue = NumeroPrestamoAnt;
            }
            else
            {
                MessageBox.Show("El número de crédito procesado (" + NumeroPrestamoAnt.ToString() + ") no se encuentra en el listado. Esto puede deberse a que se encuentra liquidado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmRegistroPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void txtMontoTotal_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtPagoCapital_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtInteresCubierto_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtInteresCapVenc_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtComiAplicacion_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtPagoIntMoratorios_ValueChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void cboNumeroPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMontoTotal_Enter(object sender, EventArgs e)
        {
            txtMontoTotal.Select(0, txtMontoTotal.Text.Length);
        }

        private void txtPagoCapital_Enter(object sender, EventArgs e)
        {
            txtPagoCapital.Select(0, txtPagoCapital.Text.Length);
        }

        private void txtInteresCubierto_Enter(object sender, EventArgs e)
        {
            txtInteresCubierto.Select(0, txtInteresCubierto.Text.Length);
        }

        private void txtInteresCapVenc_Enter(object sender, EventArgs e)
        {
            txtInteresCapVenc.Select(0, txtInteresCapVenc.Text.Length);
        }

        private void txtComiAplicacion_Enter(object sender, EventArgs e)
        {
            txtComiAplicacion.Select(0, txtComiAplicacion.Text.Length);
        }

        private void txtPagoIntMoratorios_Enter(object sender, EventArgs e)
        {
            txtPagoIntMoratorios.Select(0, txtPagoIntMoratorios.Text.Length);
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            ofd01.ShowDialog(this);
            btnAgregar.Enabled = false;

            if (File.Exists(ofd01.FileName))
            {
                try
                {
                    DataRow dr;
                    FileInfo fi = new FileInfo(ofd01.FileName);

                    Propiedades = new DataTable();
                    Propiedades.Columns.Add("Concepto");
                    Propiedades.Columns.Add("Valor");

                    dr = Propiedades.NewRow();
                    dr[0] = "Nombre";
                    dr[1] = fi.Name;
                    Propiedades.Rows.Add(dr);

                    dr = Propiedades.NewRow();
                    dr[0] = "Ubicación";
                    dr[1] = fi.DirectoryName;
                    Propiedades.Rows.Add(dr);

                    dr = Propiedades.NewRow();
                    dr[0] = "Tamaño";
                    dr[1] = clsGeneral.GetBytesReadable(fi.Length);
                    Propiedades.Rows.Add(dr);

                    dr = Propiedades.NewRow();
                    dr[0] = "Creado";
                    dr[1] = fi.CreationTime.ToLongDateString() + " " + fi.CreationTime.ToLongTimeString();
                    Propiedades.Rows.Add(dr);

                    dr = Propiedades.NewRow();
                    dr[0] = "Modificado";
                    dr[1] = fi.LastWriteTime.ToLongDateString() + " " + fi.CreationTime.ToLongTimeString();
                    Propiedades.Rows.Add(dr);

                    grdPropiedades.DataSource = Propiedades;

                    if (fi.Length <= 524288000)
                    {
                        btnAgregar.Enabled = true;
                        btnAgregar.Select();
                    }
                    else
                    {
                        MessageBox.Show("El archivo es demasiado grande para ser cargado en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al leer información del archivo seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRow dr = Archivos.NewRow();

            if (File.Exists(ofd01.FileName))
            {
                FileInfo fi = new FileInfo(ofd01.FileName);

                if (!ListaArchivos.Contains(ofd01.FileName))
                {
                    dr[0] = fi.Name;
                    dr[1] = fi.DirectoryName;
                    Archivos.Rows.Add(dr);
                    ListaArchivos.Add(ofd01.FileName);

                    ofd01.FileName = null;
                    Propiedades = null;
                    grdPropiedades.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Ya agregó este archivo a la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            grdArchivos.DataSource = Archivos;
            btnAgregar.Enabled = false;
            btnExaminar.Select();
        }
        #endregion Eventos
    }
}