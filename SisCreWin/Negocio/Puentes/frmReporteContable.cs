using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmReporteContable : Form
    {
        #region Variables

        private ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        private TipoProceso tipoProceso;
        private string Archivo;
        private bool EnProceso = false;
        private string ErrorProceso = string.Empty;

        private DateTime? Fecha_Ini = null;
        private DateTime? Fecha_Fin = null;

        #endregion Variables

        #region Enumeraciones

        private enum TipoProceso
        {
            Visualizacion,
            Extraccion
        }

        #endregion Enumeraciones

        #region Metodos

        private void ValoresIniciales()
        {
            dtpPFechaFinal.MaxDate = clsGeneral.ObtenerUltimoDiaMes(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, true);
            dtpPFechaFinal.Value = dtpPFechaFinal.MaxDate;
            dtpPFechaInicial.MaxDate = clsGeneral.ObtieneFecha(dtpPFechaFinal.MaxDate.ToString("dd/MM/yyyy"));
            dtpPFechaInicial.Value = dtpPFechaInicial.MaxDate;
        }

        public frmReporteContable()
        {
            InitializeComponent();
        }

        private void ProcesarP()
        {
            dtpPFechaFinal.Value = clsGeneral.ObtenerUltimoDiaMes(dtpPFechaInicial.Value.Year, dtpPFechaInicial.Value.Month, true);
            dtpPFechaInicial.Value = new DateTime(dtpPFechaFinal.Value.Year, dtpPFechaFinal.Value.Month, dtpPFechaFinal.Value.Day);
            Fecha_Ini = (chkPUsarFechaInicial.Checked) ? (DateTime?)dtpPFechaInicial.Value : null;
            Fecha_Fin = (chkPUsarFechaFinal.Checked) ? (DateTime?)dtpPFechaFinal.Value : null;

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr04.RunWorkerAsync();
        }

        private void ExportarP()
        {
            ResultadoExport exp = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@Fecha_Ini", SqlDbType.DateTime);
            param.Value = Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Fin", SqlDbType.DateTime);
            param.Value = Fecha_Fin;
            paramC.Add(param);

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_CarteraFechaDeterminada, paramC);

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

                try
                {
                    grdPDatos.Columns[1].DefaultCellStyle = Sistema.Global.CeldaFecha;
                    grdPDatos.Columns[4].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdPDatos.Columns[5].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdPDatos.Columns[6].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdPDatos.Columns[7].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al presentar datos del reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                grdPDatos.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;
                grdPDatos.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Metodos

        #region Eventos

        private void frmReporteContable_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        private void frmReporteContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValoresIniciales();
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

        private void wkr04_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_CarteraFechaDeterminada(Fecha_Ini, Fecha_Fin);

            if (tipoProceso == TipoProceso.Extraccion)
                ExportarP();
        }

        private void wkr04_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        private void dtpPFechaInicial_ValueChanged(object sender, EventArgs e)
        {
        }

        #endregion Eventos
    }
}