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
    public partial class frmRegistroPago : Form
    {
        #region Enumeraciones
        private enum TipoProceso
        {
            Visualizacion,
            Extraccion
        }
        #endregion Enumeraciones
        #region Variables
        clsGeneral.PuentesPagos Puente;
        clsGeneral.PuentesPagos PuenteQ;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
        bool EnProceso = false;
        //Pagos
        ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        int? NumeroPrestamo = null;
        DateTime? FechaIni = null;
        DateTime? FechaFin = null;
        TipoProceso tipoProceso;
        string Archivo;
        #endregion Variables
        #region Metodos
        public frmRegistroPago()
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
                cboTipoPago.DisplayMember = "Descripcion";
                cboTipoPago.ValueMember = "Valor";
                cboTipoPago.DataSource = clsBD.Puentes_C_TiposPago().Resultado;
                txtComiAplicacion.Value = 0;
                txtInteresCapVenc.Value = 0;
                txtInteresCubierto.Value = 0;
                txtMontoTotal.Value = 0;
                txtPagoCapital.Value = 0;
                txtPagoIntMoratorios.Value = 0;
                txtQComiAplicacion.Value = 0;
                txtQInteresCapVenc.Value = 0;
                txtQInteresCubierto.Value = 0;
                txtQMontoTotal.Value = 0;
                txtQPagoCapital.Value = 0;
                txtQPagoIntMoratorios.Value = 0;
                btnCrear.Enabled = false;
                txtObservaciones.Text = string.Empty;
                txtQObservaciones.Text = string.Empty;
                //Pagos
                dtpPFechaInicial.MinDate = new DateTime(2005, 01, 01);
                dtpPFechaInicial.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpPFechaInicial.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpPFechaFinal.MinDate = new DateTime(2005, 01, 01);
                dtpPFechaFinal.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpPFechaFinal.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                cboPNumeroPrestamo.DisplayMember = "Descripcion";
                cboPNumeroPrestamo.ValueMember = "Valor";
                cboPNumeroPrestamo.DataSource = clsBD.Puentes_C_ObtenerPrestamos(true).Resultado;
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

        private void ValidaQ()
        {
            if (cboTipoPago.Text == "Normal")
                return;

            decimal Suma = txtQPagoCapital.Value + txtQInteresCubierto.Value + txtQInteresCapVenc.Value + txtQComiAplicacion.Value + txtQPagoIntMoratorios.Value;

            if (txtQMontoTotal.Value > Suma)
            {
                lblQMensaje.Visible = true;
                lblQMensaje.Text = "El monto aplicado en la dispersión es menor al monto total";
                btnCrear.Enabled = false;
            }
            else if (txtQMontoTotal.Value < Suma)
            {
                lblQMensaje.Visible = true;
                lblQMensaje.Text = "El monto aplicado en la dispersión es mayor al monto total";
                btnCrear.Enabled = false;
            }
            else if (cboTipoPago.Text != "Normal" && (txtQMontoTotal.Value == 0 || Suma == 0))
            {
                lblQMensaje.Visible = true;
                lblQMensaje.Text = "El monto debe ser mayor a cero";
                btnCrear.Enabled = false;
            }
            else
            {
                lblQMensaje.Visible = false;
                btnCrear.Enabled = true;
            }

            if (cboNumeroPrestamo.SelectedIndex < 0 || (cboNumeroPrestamo.SelectedIndex >= 0 && Convert.ToInt32(cboNumeroPrestamo.SelectedValue) <= 0))
                btnCrear.Enabled = false;
        }

        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Puentes_C_MovimientosPrestamo((int)cboNumeroPrestamo.SelectedValue, dtpFechaPago.Value.AddDays(-5), dtpFechaPago.MaxDate);

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;

                for (int w = 0; w < grdDatos.Columns.Count; w++)
                {
                    grdDatos.Columns[w].ReadOnly = true;
                }

                grdDatos.ClearSelection();

                for (int w = 0; w < grdDatos.Rows.Count; w++)
                {
                    if(Convert.ToDateTime(grdDatos.Rows[w].Cells[0].Value).ToString("dd/MM/yyyy") == dtpFechaPago.Value.ToString("dd/MM/yyyy"))
                    {
                        grdDatos.Rows[w].Selected = true;
                        grdDatos.CurrentCell = grdDatos.Rows[w].Cells[0];
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtQMontoTotal.Enabled = true;
            txtQPagoCapital.Enabled = true;
            txtQInteresCubierto.Enabled = true;
            txtQInteresCapVenc.Enabled = true;
            txtQComiAplicacion.Enabled = true;
            txtQPagoIntMoratorios.Enabled = true;
            dtpFechaPago.Enabled = true;
            clsGeneral.EnableTab(tabP01, true);

            txtMontoTotal.Value = 0;
            txtPagoCapital.Value = 0;
            txtInteresCubierto.Value = 0;
            txtInteresCapVenc.Value = 0;
            txtComiAplicacion.Value = 0;
            txtPagoIntMoratorios.Value = 0;
            txtObservaciones.Text = string.Empty;

            txtQMontoTotal.Value = 0;
            txtQPagoCapital.Value = 0;
            txtQInteresCubierto.Value = 0;
            txtQInteresCapVenc.Value = 0;
            txtQComiAplicacion.Value = 0;
            txtQPagoIntMoratorios.Value = 0;
            txtQObservaciones.Text = string.Empty;

            if (cboTipoPago.Text == "Normal")
            {
                clsGeneral.EnableTab(tabP02, false);
                tabPagos.SelectedIndex = 0;
                Valida();
            }
            else
            {
                clsGeneral.EnableTab(tabP02, true);

                switch (cboTipoPago.Text.ToLowerInvariant())
                {
                    case "dación":
                        CargarSaldos((int)cboNumeroPrestamo.SelectedValue);
                        break;
                    case "adjudicación":
                        CargarSaldos((int)cboNumeroPrestamo.SelectedValue);
                        break;
                    default:
                        break;

                }

                ValidaQ();
            }
        }

        private void ExportarSaldos()
        {
            ResultadoExport exp = new ResultadoExport();
            DataTable dt = new DataTable();
            dt = (DataTable)grdDatos.DataSource;

            exp = clsBD.ExportarExcel(dt);

            if (!exp.HayError)
            {
                try
                {
                    if (System.IO.File.Exists(exp.Archivo))
                        System.Diagnostics.Process.Start(exp.Archivo);
                    else
                        MessageBox.Show("No existe el archivo especificado", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(exp.Error, "Error al generar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarDetalle()
        {
            ResultadoExport exp = new ResultadoExport();
            DataTable dt = new DataTable();
            dt = (DataTable)grdDetalle.DataSource;

            exp = clsBD.ExportarExcel(dt);

            if (!exp.HayError)
            {
                try
                {
                    if (System.IO.File.Exists(exp.Archivo))
                        System.Diagnostics.Process.Start(exp.Archivo);
                    else
                        MessageBox.Show("No existe el archivo especificado", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(exp.Error, "Error al generar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarP()
        {
            NumeroPrestamo = (chkPUsarCredito.Checked) ? (int?)cboPNumeroPrestamo.SelectedValue : null;
            FechaIni = (chkPUsarFechaInicial.Checked) ? (DateTime?)dtpPFechaInicial.Value : null;
            FechaFin = (chkPUsarFechaFinal.Checked) ? (DateTime?)dtpPFechaFinal.Value : null;

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr02.RunWorkerAsync();
        }

        private void ExportarP()
        {
            ResultadoExport exp = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHP_NumeroPrestamo", SqlDbType.Int);
            param.Value = NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Ini", SqlDbType.DateTime);
            param.Value = FechaIni;
            paramC.Add(param);
            param = new SqlParameter("@PHP_FechaPago_Fin", SqlDbType.DateTime);
            param.Value = FechaFin;
            paramC.Add(param);

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_ReporteDePagos, paramC);

            if (!exp.HayError)
            {
                try
                {
                    Archivo = exp.Archivo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(exp.Error, "Error al generar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridP()
        {
            if (!ResultadoGrid.HayError)
            {
                grdPDatos.DataSource = ResultadoGrid.Resultado;

                for (int w = 0; w < grdPDatos.Columns.Count; w++)
                {
                    grdPDatos.Columns[w].ReadOnly = true;
                }

                grdPDatos.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ValidaMontos(ref NumericUpDown ctrl, object Valor)
        {
            int Res = 0;

            try
            {
                if ((decimal)Valor >= 0)
                    ctrl.Value = (decimal)Valor;
                else
                    Res = 1;
            }
            catch
            {
                Res = 1;
            }

            return Res;
        }

        private void CargarSaldos(int NumeroPrestamo)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Puentes_C_ObtenerSaldosParaLiquidar(NumeroPrestamo);
            txtQMontoTotal.Enabled = false;
            txtQPagoCapital.Enabled = false;
            txtQInteresCubierto.Enabled = false;
            txtQInteresCapVenc.Enabled = false;
            txtQComiAplicacion.Enabled = false;
            txtQPagoIntMoratorios.Enabled = false;
            dtpFechaPago.Enabled = false;
            txtComiAplicacion.Value = 0;
            txtInteresCapVenc.Value = 0;
            txtInteresCubierto.Value = 0;
            txtMontoTotal.Value = 0;
            txtPagoCapital.Value = 0;
            txtPagoIntMoratorios.Value = 0;
            clsGeneral.EnableTab(tabP01, false);
            tabPagos.SelectedIndex = 1;

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado.Rows.Count > 0)
                {
                    int HayNegativos = 0;

                    dtpFechaPago.Value = (DateTime)Resultado.Resultado.Rows[0]["FechaMax"];
                    HayNegativos += ValidaMontos(ref txtQPagoCapital, (decimal)Resultado.Resultado.Rows[0]["SCP_CAPITAL"]);
                    HayNegativos += ValidaMontos(ref txtQInteresCubierto, (decimal)Resultado.Resultado.Rows[0]["SCP_TOTAL_INTERESES"]);
                    HayNegativos += ValidaMontos(ref txtQInteresCapVenc, (decimal)Resultado.Resultado.Rows[0]["SCP_INT_ORD_S_CAPVENC"]);
                    HayNegativos += ValidaMontos(ref txtQComiAplicacion, (decimal)Resultado.Resultado.Rows[0]["SCP_CUOTA_RENOV_COM_PROR"]);
                    HayNegativos += ValidaMontos(ref txtQPagoIntMoratorios, (decimal)Resultado.Resultado.Rows[0]["SCP_INT_MORATORIOS"]);

                    if (HayNegativos == 0)
                    {
                        txtQMontoTotal.Value = txtQPagoCapital.Value + txtQInteresCubierto.Value + txtQInteresCapVenc.Value +
                            txtQComiAplicacion.Value + txtQPagoIntMoratorios.Value;
                    }
                    else
                    {
                        btnCrear.Enabled = false;
                        MessageBox.Show("Existen saldos con montos incorrectos que impiden hacer un registro del tipo de pago seleccionado. Revise por favor", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros para el crédito", "Saldos del crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener saldos del crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Metodos
        #region Eventos
        private void frmRegistroPago_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
            Valida();
            ValidaQ();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtMontoTotal.Value == 0 && (int)cboTipoPago.SelectedValue == 1)
            {
                if (MessageBox.Show("Está a punto de registrar un pago normal en CEROS para el crédito " + cboNumeroPrestamo.Text + Environment.NewLine + "Está función se considera sólo para hacer una reconstrucción de créditos. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (dtpFechaPago.Value < dtpFechaPago.MaxDate)
            {
                if (MessageBox.Show("El sistema reconstruirá los registros posteriores a la fecha seleccionada, eliminando movimientos y pagos realizados hasta alcanzar la fecha del mismo. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (dtpFechaPago.Value == dtpFechaPago.MaxDate)
            {
                if (MessageBox.Show("¿Está seguro de realizar el pago para el crédito " + cboNumeroPrestamo.Text + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            ErrorProceso = string.Empty;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;
            Puente = new clsGeneral.PuentesPagos(Sistema.Global.Usr_Id, Convert.ToInt32(cboTipoPago.SelectedValue), dtpFechaPago.Value, Convert.ToInt32(cboNumeroPrestamo.Text), txtPagoCapital.Value, txtInteresCubierto.Value, txtInteresCapVenc.Value, txtComiAplicacion.Value, txtPagoIntMoratorios.Value, vPHP_Observaciones: txtObservaciones.Text.Trim());
            PuenteQ = new clsGeneral.PuentesPagos(Sistema.Global.Usr_Id, Convert.ToInt32(cboTipoPago.SelectedValue), dtpFechaPago.Value, Convert.ToInt32(cboNumeroPrestamo.Text), txtQPagoCapital.Value, txtQInteresCubierto.Value, txtQInteresCapVenc.Value, txtQComiAplicacion.Value, txtQPagoIntMoratorios.Value, vPHP_Observaciones: txtQObservaciones.Text.Trim());
            wkr01.RunWorkerAsync();
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_M_RegistrarPago, vBit_DatosPrevios: clsGeneral.Zip("Préstamo: " + Puente.PHP_NumeroPrestamo.ToString()));

            clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
            Resultado = clsBD.Puentes_M_RegistrarPago(Puente, PuenteQ);

            if (Resultado.HayError)
                ErrorProceso = Resultado.Error;
        }

        private void wkr01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Se han realizado los movimientos de aplicación de pago.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ValoresIniciales();
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
            if ((int)cboNumeroPrestamo.SelectedValue > 0)
                CargarGrid();
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            if (cboNumeroPrestamo.SelectedValue != null && (int)cboNumeroPrestamo.SelectedValue > 0)
                CargarGrid();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void txtQMontoTotal_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void txtQPagoCapital_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void txtQInteresCubierto_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void txtQInteresCapVenc_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void txtQComiAplicacion_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void txtQPagoIntMoratorios_ValueChanged(object sender, EventArgs e)
        {
            ValidaQ();
        }

        private void grdDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResultadoStored_DT Resultado = new ResultadoStored_DT();
                DateTime FechaPago = clsGeneral.ObtieneFecha(grdDatos[0, e.RowIndex].Value.ToString());
                int NumeroPrestamo = (int)grdDatos[1, e.RowIndex].Value;

                Resultado = clsBD.Puentes_C_HistoricoDePago(NumeroPrestamo, FechaPago);

                if(!Resultado.HayError)
                {
                    grdDetalle.DataSource = Resultado.Resultado;
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al obtener detalle de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al procesar detalle de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if ((int)cboNumeroPrestamo.SelectedValue > 0)
            {
                if (grdDatos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ExportarSaldos();
            }

            //System.Diagnostics.Process.Start(lblArchivo.Text);
        }

        private void btnExportarDet_Click(object sender, EventArgs e)
        {
            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ExportarDetalle();
        }

        private void cboTipoPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                txtMontoTotal.Focus();
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

        private void txtQMontoTotal_Enter(object sender, EventArgs e)
        {
            txtQMontoTotal.Select(0, txtQMontoTotal.Text.Length);
        }

        private void txtQPagoCapital_Enter(object sender, EventArgs e)
        {
            txtQPagoCapital.Select(0, txtQPagoCapital.Text.Length);
        }

        private void txtQInteresCubierto_Enter(object sender, EventArgs e)
        {
            txtQInteresCubierto.Select(0, txtQInteresCubierto.Text.Length);
        }

        private void txtQInteresCapVenc_Enter(object sender, EventArgs e)
        {
            txtQInteresCapVenc.Select(0, txtQInteresCapVenc.Text.Length);
        }

        private void txtQComiAplicacion_Enter(object sender, EventArgs e)
        {
            txtQComiAplicacion.Select(0, txtQComiAplicacion.Text.Length);
        }

        private void txtQPagoIntMoratorios_Enter(object sender, EventArgs e)
        {
            txtQPagoIntMoratorios.Select(0, txtQPagoIntMoratorios.Text.Length);
        }
        #endregion Eventos

        private void chkPUsarCredito_CheckedChanged(object sender, EventArgs e)
        {
            cboPNumeroPrestamo.Enabled = chkPUsarCredito.Checked;
        }

        private void chkPUsarFechaInicial_CheckedChanged(object sender, EventArgs e)
        {
            dtpPFechaInicial.Enabled = chkPUsarFechaInicial.Checked;
        }

        private void chkPUsarFechaFinal_CheckedChanged(object sender, EventArgs e)
        {
            dtpPFechaInicial.MaxDate = clsGeneral.ObtieneFecha(dtpPFechaFinal.Value.ToString("dd/MM/yyyy"));

            if (dtpPFechaFinal.Value < dtpPFechaInicial.Value)
                dtpPFechaInicial.Value = dtpPFechaInicial.MaxDate;
        }

        private void dtpPFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpPFechaInicial.MaxDate = clsGeneral.ObtieneFecha(dtpPFechaFinal.Value.ToString("dd/MM/yyyy"));

            if (dtpPFechaFinal.Value < dtpPFechaInicial.Value)
                dtpPFechaInicial.Value = dtpPFechaInicial.MaxDate;
        }

        private void btnPVisualizar_Click(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.Visualizacion;
            ProcesarP();
        }

        private void btnPExportar_Click(object sender, EventArgs e)
        {
            if (grdPDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Archivo = string.Empty;
            tipoProceso = TipoProceso.Extraccion;
            ProcesarP();
        }

        private void wkr02_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteDePagos(NumeroPrestamo, FechaIni, FechaFin);

            if (tipoProceso == TipoProceso.Extraccion)
                ExportarP();
        }

        private void wkr02_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tipoProceso == TipoProceso.Visualizacion)
            {
                CargarGridP();
            }
            else
            {
                try
                {
                    if (System.IO.File.Exists(Archivo))
                        System.Diagnostics.Process.Start(Archivo);
                    else
                        MessageBox.Show("No existe el archivo especificado", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;
        }
    }
}