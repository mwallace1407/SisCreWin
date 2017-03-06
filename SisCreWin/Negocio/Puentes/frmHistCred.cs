using SisCreWin.BD;
using SisCreWin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmHistCred : Form
    {
        #region Variables
        ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        int? NumeroPrestamo = null;
        DateTime? FechaIni = null;
        DateTime? FechaFin = null;
        TipoProceso tipoProceso;
        string Archivo;
        bool EnProceso = false;
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
            ResultadoStored_Str Resultado = new BD.ResultadoStored_Str();

            Resultado = clsBD.Puentes_C_ObtenerFechaUltimoCierre();

            if (!Resultado.HayError)
            {
                dtpFechaInicial.MinDate = new DateTime(2005, 01, 01);
                dtpFechaInicial.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpFechaInicial.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpFechaFinal.MinDate = new DateTime(2005, 01, 01);
                dtpFechaFinal.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpFechaFinal.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                cboNumeroPrestamo.DisplayMember = "Descripcion";
                cboNumeroPrestamo.ValueMember = "Valor";
                cboNumeroPrestamo.DataSource = clsBD.Puentes_C_ObtenerPrestamos().Resultado;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarGrid()
        {
            if (!ResultadoGrid.HayError)
            {
                grdDatos.DataSource = ResultadoGrid.Resultado;

                for (int w = 0; w < grdDatos.Columns.Count; w++)
                {
                    grdDatos.Columns[w].ReadOnly = true;
                }

                grdDatos.ClearSelection();

                for (int w = 0; w < grdDatos.Rows.Count; w++)
                {
                    if (Convert.ToDateTime(grdDatos.Rows[w].Cells[0].Value).ToString("dd/MM/yyyy") == dtpFechaInicial.Value.ToString("dd/MM/yyyy"))
                    {
                        grdDatos.Rows[w].Selected = true;
                        grdDatos.CurrentCell = grdDatos.Rows[w].Cells[0];
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exportar()
        {
            ResultadoExport exp = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@SCP_PRESTAMO", SqlDbType.Int);
            param.Value = NumeroPrestamo;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Ini", SqlDbType.DateTime);
            param.Value = FechaIni;
            paramC.Add(param);
            param = new SqlParameter("@Fecha_Fin", SqlDbType.DateTime);
            param.Value = FechaFin;
            paramC.Add(param);

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_MovimientosPrestamo, paramC);

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

        private void Procesar()
        {
            NumeroPrestamo = (chkUsarCredito.Checked) ? (int?)cboNumeroPrestamo.SelectedValue : null;
            FechaIni = (chkUsarFechaInicial.Checked) ? (DateTime?)dtpFechaInicial.Value : null;
            FechaFin = (chkUsarFechaFinal.Checked) ? (DateTime?)dtpFechaFinal.Value : null;

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr01.RunWorkerAsync();
        }
        public frmHistCred()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos

        private void frmHistCred_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.Visualizacion;
            Procesar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(grdDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Archivo = string.Empty;
            tipoProceso = TipoProceso.Extraccion;
            Procesar();
        }

        private void chkUsarCredito_CheckedChanged(object sender, EventArgs e)
        {
            cboNumeroPrestamo.Enabled = chkUsarCredito.Checked;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicial.Enabled = chkUsarFechaInicial.Checked;
        }

        private void chkUsarFechaFinal_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFinal.Enabled = chkUsarFechaFinal.Checked;
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaInicial.MaxDate = clsGeneral.ObtieneFecha(dtpFechaFinal.Value.ToString("dd/MM/yyyy"));

            if (dtpFechaFinal.Value < dtpFechaInicial.Value)
                dtpFechaInicial.Value = dtpFechaInicial.MaxDate;
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_MovimientosPrestamo(NumeroPrestamo, FechaIni, FechaFin);

            if (tipoProceso == TipoProceso.Extraccion)
                Exportar();
        }

        private void wkr01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tipoProceso == TipoProceso.Visualizacion)
            {
                CargarGrid();
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

        private void frmHistCred_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void grdDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResultadoStored_DT Resultado = new ResultadoStored_DT();
                DateTime FechaPago = clsGeneral.ObtieneFecha(grdDatos[0, e.RowIndex].Value.ToString());
                int NumeroPrestamo = (int)grdDatos[1, e.RowIndex].Value;

                Resultado = clsBD.Puentes_C_HistoricoDePago(NumeroPrestamo, FechaPago);

                if (!Resultado.HayError)
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

        private void btnExportarDet_Click(object sender, EventArgs e)
        {
            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ExportarDetalle();
        }
        #endregion Eventos
    }
}
