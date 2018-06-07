using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmHistCred : Form
    {
        #region Variables

        private ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        private int? NumeroPrestamo = null;
        private DateTime? FechaIni = null;
        private DateTime? FechaFin = null;
        private TipoProceso tipoProceso;
        private string Archivo;
        private bool EnProceso = false;

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
                cboNumeroPrestamo.DataSource = clsBD.Puentes_C_ObtenerPrestamos(true).Resultado;

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

                //Ajustes
                dtpAFechaInicial.MinDate = new DateTime(2005, 01, 01);
                dtpAFechaInicial.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpAFechaInicial.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpAFechaFinal.MinDate = new DateTime(2005, 01, 01);
                dtpAFechaFinal.MaxDate = clsGeneral.ObtieneFecha(Resultado.Resultado);
                dtpAFechaFinal.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);
                cboANumeroPrestamo.DisplayMember = "Descripcion";
                cboANumeroPrestamo.ValueMember = "Valor";
                cboANumeroPrestamo.DataSource = clsBD.Puentes_C_ObtenerPrestamos(true).Resultado;
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

                //for (int w = 0; w < grdDatos.Rows.Count; w++)
                //{
                //    if (Convert.ToDateTime(grdDatos.Rows[w].Cells[0].Value).ToString("dd/MM/yyyy") == dtpFechaInicial.Value.ToString("dd/MM/yyyy"))
                //    {
                //        grdDatos.Rows[w].Selected = true;
                //        grdDatos.CurrentCell = grdDatos.Rows[w].Cells[0];
                //        break;
                //    }
                //}
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarGridA()
        {
            if (!ResultadoGrid.HayError)
            {
                grdADatos.DataSource = ResultadoGrid.Resultado;

                for (int w = 0; w < grdADatos.Columns.Count; w++)
                {
                    grdADatos.Columns[w].ReadOnly = true;
                }

                grdADatos.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ExportarA()
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

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_ReporteDeAjustes, paramC);

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

        private void ProcesarA()
        {
            NumeroPrestamo = (chkAUsarCredito.Checked) ? (int?)cboANumeroPrestamo.SelectedValue : null;
            FechaIni = (chkAUsarFechaInicial.Checked) ? (DateTime?)dtpAFechaInicial.Value : null;
            FechaFin = (chkAUsarFechaFinal.Checked) ? (DateTime?)dtpAFechaFinal.Value : null;

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr03.RunWorkerAsync();
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
            if (grdDatos.Rows.Count == 0)
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

        private void wkr03_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteDeAjustes(NumeroPrestamo, FechaIni, FechaFin);

            if (tipoProceso == TipoProceso.Extraccion)
                ExportarA();
        }

        private void btnAVisualizar_Click(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.Visualizacion;
            ProcesarA();
        }

        private void btnAExportar_Click(object sender, EventArgs e)
        {
            if (grdADatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Archivo = string.Empty;
            tipoProceso = TipoProceso.Extraccion;
            ProcesarA();
        }

        private void wkr03_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tipoProceso == TipoProceso.Visualizacion)
            {
                CargarGridA();
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

        private void grdADatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResultadoStored_DT Resultado = new ResultadoStored_DT();
                Guid idArchivos;
                long Tamanno;

                grdAArchivos.DataSource = null;

                if (Guid.TryParse(grdADatos[16, e.RowIndex].Value.ToString(), out idArchivos))
                {
                    Resultado = clsBD.Puentes_C_AdjuntosPorAjuste(idArchivos);

                    if (!Resultado.HayError)
                    {
                        Resultado.Resultado.Columns[2].ReadOnly = false;

                        for (int w = 0; w < Resultado.Resultado.Rows.Count; w++)
                        {
                            if (long.TryParse(Resultado.Resultado.Rows[w][2].ToString(), out Tamanno))
                                Resultado.Resultado.Rows[w][2] = clsGeneral.GetBytesReadable(Tamanno);
                        }

                        grdAArchivos.DataSource = Resultado.Resultado;
                    }
                    else
                    {
                        MessageBox.Show(Resultado.Error, "Error al obtener adjuntos de ajuste", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al procesar adjuntos de ajuste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Eventos

        private void grdAArchivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAArchivos.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = grdAArchivos.SelectedRows[0];
                ResultadoStored_Byte Resultado = new ResultadoStored_Byte();
                string Archivo = string.Empty;

                Resultado = clsBD.Puentes_C_DatosAdjuntoAjuste(Convert.ToInt32(dr.Cells[0].Value));

                if (!Resultado.HayError)
                {
                    try
                    {
                        fbd01.ShowDialog(this);

                        if (!Directory.Exists(fbd01.SelectedPath))
                        {
                            MessageBox.Show("El directorio seleccionado no existe", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Archivo = Path.Combine(fbd01.SelectedPath, dr.Cells[1].Value.ToString());

                        while (File.Exists(Archivo))
                        {
                            Archivo = Path.Combine(fbd01.SelectedPath, Path.GetFileNameWithoutExtension(dr.Cells[1].Value.ToString()) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(dr.Cells[1].Value.ToString()));
                        }

                        File.WriteAllBytes(Archivo, Resultado.Resultado);

                        if (File.Exists(Archivo))
                        {
                            System.Diagnostics.Process.Start(Archivo);
                        }
                        else
                        {
                            MessageBox.Show("No se puede abrir el archivo correspondiente al registro solicitado", "Error al generar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al generar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al obtener datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdPDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResultadoStored_DT Resultado = new ResultadoStored_DT();
                Guid idArchivos;
                long Tamanno;

                grdPArchivos.DataSource = null;

                if (Guid.TryParse(grdPDatos[16, e.RowIndex].Value.ToString(), out idArchivos))
                {
                    Resultado = clsBD.Puentes_C_AdjuntosPorAjuste(idArchivos);

                    if (!Resultado.HayError)
                    {
                        Resultado.Resultado.Columns[2].ReadOnly = false;

                        for (int w = 0; w < Resultado.Resultado.Rows.Count; w++)
                        {
                            if (long.TryParse(Resultado.Resultado.Rows[w][2].ToString(), out Tamanno))
                                Resultado.Resultado.Rows[w][2] = clsGeneral.GetBytesReadable(Tamanno);
                        }

                        grdPArchivos.DataSource = Resultado.Resultado;
                    }
                    else
                    {
                        MessageBox.Show(Resultado.Error, "Error al obtener adjuntos de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al procesar adjuntos de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdPArchivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdPArchivos.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = grdPArchivos.SelectedRows[0];
                ResultadoStored_Byte Resultado = new ResultadoStored_Byte();
                string Archivo = string.Empty;

                Resultado = clsBD.Puentes_C_DatosAdjuntoAjuste(Convert.ToInt32(dr.Cells[0].Value));

                if (!Resultado.HayError)
                {
                    try
                    {
                        fbd01.ShowDialog(this);

                        if (!Directory.Exists(fbd01.SelectedPath))
                        {
                            MessageBox.Show("El directorio seleccionado no existe", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Archivo = Path.Combine(fbd01.SelectedPath, dr.Cells[1].Value.ToString());

                        while (File.Exists(Archivo))
                        {
                            Archivo = Path.Combine(fbd01.SelectedPath, Path.GetFileNameWithoutExtension(dr.Cells[1].Value.ToString()) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(dr.Cells[1].Value.ToString()));
                        }

                        File.WriteAllBytes(Archivo, Resultado.Resultado);

                        if (File.Exists(Archivo))
                        {
                            System.Diagnostics.Process.Start(Archivo);
                        }
                        else
                        {
                            MessageBox.Show("No se puede abrir el archivo correspondiente al registro solicitado", "Error al generar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al generar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al obtener datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}