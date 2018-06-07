using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using SisCreWin.BD;
using SisCreWin.Modelo;
using SisCreWin.Sistema;

namespace SisCreWin.Negocio.Buro
{
    public partial class frmCSVIndividuales : Form
    {
        #region Variables

        private string FechaReporte = string.Empty;
        private string DirectorioReporte = string.Empty;
        private string ErrorProceso = string.Empty;
        private string ArchivoProceso = string.Empty;
        private DateTime FechaDoc = DateTime.Now;
        private DataTable dtCSV = new DataTable();
        private string ArchivoCSV = string.Empty;
        private string CSV_Clave = string.Empty;
        private string CSV_Fecha = string.Empty;
        private string CSV_Total = string.Empty;
        private bool CSV_Continuar = false;
        private bool EnProceso = false;

        #endregion Variables

        #region Metodos

        public frmCSVIndividuales()
        {
            InitializeComponent();
        }

        protected void ProcesarDatos(DataTable DT, string Archivo)
        {
            string Linea = string.Empty;

            using (StreamWriter outfile = new StreamWriter(Archivo, true, Encoding.Default))
            {
                outfile.AutoFlush = true;
                outfile.NewLine = Environment.NewLine;

                for (int w = 0; w < DT.Columns.Count; w++)
                {
                    Linea += DT.Columns[w].ColumnName + ",";
                }

                outfile.WriteLine(Linea);

                for (int w = 0; w < DT.Rows.Count; w++)
                {
                    Linea = string.Empty;

                    for (int w2 = 0; w2 < DT.Columns.Count; w2++)
                    {
                        Linea += DT.Rows[w][w2].ToString() + ",";
                    }

                    outfile.WriteLine(Linea);
                }
            }
        }

        private void CargaValoresIniciales()
        {
            cboFechas.DisplayMember = "Descripcion";
            cboFechas.ValueMember = "Valor";
            cboFechas.DataSource = clsBD.Buro_C_PeriodosDisponiblesIndividuales().Resultado;

            if (cboFechas.Items.Count == 0)
            {
                btnCrear.Enabled = false;
                MessageBox.Show("No hay periodos disponibles para generar el CSV", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnCrear.Enabled = true;
            }
        }

        private void CargarPeriodosCreados()
        {
            cboPeriodosCreados.DisplayMember = "Descripcion";
            cboPeriodosCreados.ValueMember = "Valor";
            cboPeriodosCreados.DataSource = clsBD.Buro_C_PeriodosDisponiblesIndividuales(true).Resultado;

            if (cboPeriodosCreados.Items.Count == 0)
                btnAutorizar.Enabled = false;
            else
                btnAutorizar.Enabled = true;
        }

        private void ConvertirCSVaDataTable(DataTable dt, string Archivo, bool PrimeraEsEncabezado)
        {
            int LControl = 0;

            try
            {
                string[] campos = null;

                using (var csvReader = new TextFieldParser(Archivo, Encoding.Default, true))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    campos = csvReader.ReadFields();

                    for (int w = 0; w < campos.Length; w++)
                    {
                        if (PrimeraEsEncabezado)
                            dt.Columns.Add(campos[w]);
                        else
                            dt.Columns.Add("Columna_" + w.ToString());
                    }

                    if (!PrimeraEsEncabezado)
                    {
                        DataRow dr = dt.NewRow();

                        dr.ItemArray = campos;
                        dt.Rows.Add(dr);
                    }

                    while (csvReader.PeekChars(1) != null)
                    {
                        LControl++;
                        campos = csvReader.ReadFields();

                        DataRow dr = dt.NewRow();

                        dr.ItemArray = campos;
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorProceso = "Error al convertir CSV: " + ex.Message + Environment.NewLine + "Línea: " + LControl.ToString(); ;
            }
        }

        private void CargarGridAsync(DataTable d, DataGridView dg)
        {
            try
            {
                if (dg.InvokeRequired)
                {
                    dg.BeginInvoke((MethodInvoker)delegate()
                    {
                        dg.Rows.Clear();
                        dg.ColumnCount = d.Columns.Count;

                        for (int w = 0; w < d.Columns.Count; w++)
                        {
                            dg.Columns[w].Name = d.Columns[w].ColumnName;
                        }
                    });

                    foreach (DataRow row in d.Rows)
                    {
                        if (dg.InvokeRequired)
                        {
                            List<string> Datos = new List<string>();

                            for (int w = 0; w < d.Columns.Count; w++)
                            {
                                Datos.Add(row[w].ToString());
                            }

                            dg.BeginInvoke((MethodInvoker)delegate() { dg.Rows.Add(Datos.ToArray()); });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorProceso = "Error al cargar visualizador: " + ex.Message;
            }
        }

        #endregion Metodos

        #region Eventos

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab01.SelectedIndex == 0)
            {
                CargaValoresIniciales();
            }
            else if (tab01.SelectedIndex == 1)
            {
                clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();

                Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Individuales_RegenerarCSV);

                if (!Respuesta.Permitido)
                {
                    MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
                    tab01.SelectedIndex = 0;
                }
                else
                {
                    CargarPeriodosCreados();
                }
            }
        }

        private void frmCSVIndividuales_Load(object sender, EventArgs e)
        {
            CargaValoresIniciales();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            fbd01.ShowDialog(this);

            if (!Directory.Exists(fbd01.SelectedPath))
            {
                MessageBox.Show("El directorio seleccionado no existe.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DirectorioReporte = fbd01.SelectedPath;
            FechaReporte = cboFechas.SelectedValue.ToString();
            FechaDoc = clsGeneral.ObtieneFecha(cboFechas.Text);
            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            ErrorProceso = string.Empty;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;
            wkr01.RunWorkerAsync();
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.ReportesBuro_C_CreditosIndividuales, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @FECHA_DEL_REPORTE = " + FechaReporte));
            Resultado = clsBD.ReportesBuro_C_CreditosIndividuales(FechaReporte);

            if (!Resultado.HayError)
            {
                ArchivoProceso = Path.Combine(DirectorioReporte, clsGeneral.GeneraNombreArchivoRnd("BuroInd_", "csv"));
                ProcesarDatos(Resultado.Resultado, ArchivoProceso);

                clsGeneral.BuroHistoricoIndividuales Buro = new clsGeneral.BuroHistoricoIndividuales(Sistema.Global.Usr_Id, vBHI_Documento: clsGeneral.Zip(System.IO.File.ReadAllText(ArchivoProceso, Encoding.Default), clsGeneral.Codificaciones.ANSI));
                clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Global.Usr_Id, FechaDoc.Year, FechaDoc.Month, "I", vBDG_Documento: clsGeneral.Zip(System.IO.File.ReadAllText(ArchivoProceso, Encoding.Default), clsGeneral.Codificaciones.ANSI));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Buro_I_HistoricoIndividuales(Buro);
                clsBD.Buro_M_Documentos(BuroDoc);
            }
            else
            {
                ErrorProceso = Resultado.Error;
            }
        }

        private void wkr01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ArchivoProceso);
            }
            catch { }

            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;
            CargaValoresIniciales();

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmCSVIndividuales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            DateTime FechaReporteAut = clsGeneral.ObtieneFecha(cboPeriodosCreados.Text);
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(
                Sistema.Global.Usr_Id,
                CatalogoStoreds.Buro_U_AutorizarRecreacion,
                vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @BDG_Anno = " + FechaReporteAut.Year.ToString() +
                    " BDG_Mes = " + FechaReporteAut.Month.ToString() +
                    " BDG_Tipo = I"));

            ResultadoStored_Str Resultado2 = new ResultadoStored_Str();
            clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Global.Usr_Id, FechaReporteAut.Year, FechaReporteAut.Month, "I");

            if (MessageBox.Show("¿Está seguro de autorizar el reproceso de el documento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                Resultado2 = clsBD.Buro_U_AutorizarRecreacion(BuroDoc);

                if (!Resultado.HayError)
                {
                    CargarPeriodosCreados();
                    MessageBox.Show("Se ha autorizado el reproceso del documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al autorizar periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Eventos

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            ofd01.ShowDialog(this);

            if (!File.Exists(ofd01.FileName))
            {
                MessageBox.Show("El archivo seleccionado no existe.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CSV_Clave = "Clave: N/A";
            CSV_Fecha = "Fecha: N/A";
            CSV_Total = "Total de registros: N/A";
            CSV_Continuar = false;
            ArchivoCSV = ofd01.FileName;
            dtCSV = new DataTable();
            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            ErrorProceso = string.Empty;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;
            wkr02.RunWorkerAsync();
        }

        private void wkr02_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertirCSVaDataTable(dtCSV, ArchivoCSV, true);

            try
            {
                DataView view = new DataView(dtCSV);
                DataTable dtr = view.ToTable(true, new string[] { "CLAVE_OTORGANTE_1", "FECHA DEL REPORTE" });

                CSV_Clave = "Clave: " + dtr.Rows[0][0].ToString();
                CSV_Fecha = "Fecha: " + dtr.Rows[0][1].ToString();
                CSV_Total = "Total de registros: " + dtCSV.Rows.Count.ToString();

                if (dtCSV.Rows.Count > 0)
                {
                    CSV_Continuar = true;

                    DataTable dtp = clsBD.Buro_C_PeriodosExistentesIndividuales().Resultado;

                    for (int w = 0; w < dtp.Rows.Count; w++)
                    {
                        if (dtr.Rows[0][1].ToString() == dtp.Rows[w][0].ToString())
                        {
                            CSV_Continuar = false;
                            CSV_Fecha = "Fecha: " + dtr.Rows[0][1].ToString() + " (ya existen datos para el periodo)";
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorProceso = "Error al obtener resumen: " + ex.Message;
            }
        }

        private void wkr02_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblClave.Text = CSV_Clave;
            lblFecha.Text = CSV_Fecha;
            lblTotalReg.Text = CSV_Total;
            btnCargarDatos.Enabled = CSV_Continuar;
            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de comenzar un proceso que implica una importación masiva a la base de datos. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, "Buro_I_InsercionMasivaIndividuales", vBit_DatosPrevios: clsGeneral.Zip("Parámetros: " + Environment.NewLine + lblClave.Text + Environment.NewLine + lblFecha.Text + Environment.NewLine + lblTotalReg.Text));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
                pnlProgreso.Location = new Point(3, 3);
                pnlProgreso.Visible = true;
                ErrorProceso = string.Empty;
                EnProceso = true;
                Sistema.Global.ProcesosPendientes = true;
                wkr03.RunWorkerAsync();
            }
        }

        private void wkr03_DoWork(object sender, DoWorkEventArgs e)
        {
            ErrorProceso = clsBD.Buro_I_InsercionMasivaIndividuales(ref dtCSV);
        }

        private void wkr03_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtCSV = new DataTable();
            btnCargarDatos.Enabled = false;
            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Proceso finalizado satisfactoriamente", "Carga masiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}