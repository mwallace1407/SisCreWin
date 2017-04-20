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
    public partial class frmCierreMensual : Form
    {
        #region Variables
        ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        DateTime? Fecha = null;
        TipoProceso tipoProceso;
        string Archivo;
        bool EnProceso = false;
        string ErrorProceso = string.Empty;

        List<string> FechasProceso = new List<string>();

        private DateTime? Fecha_Ini = null;
        private DateTime? Fecha_Fin = null;
        private DateTime? Periodo = null;
        private int? Usr_Id = null;
        private int TopSel = 100;

        DataTable DetalleCierre;
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
            try
            {
                grdDatos.DataSource = null;
                grdDatosDet.DataSource = null;
                grdDatosR.DataSource = null;
                txtTopSel.Value = 100;
                dtpFechaFin.MaxDate = clsGeneral.ObtieneFecha(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")).AddMilliseconds(-2);
                dtpFechaFin.Value = dtpFechaFin.MaxDate;
                dtpFechaIni.MaxDate = clsGeneral.ObtieneFecha(DateTime.Now.ToString("dd/MM/yyyy"));
                dtpFechaIni.Value = dtpFechaIni.MaxDate;

                cboUsuarios.DisplayMember = "Usr_Nombre";
                cboUsuarios.ValueMember = "Usr_Id";
                cboUsuarios.DataSource = clsBD.Usuarios_C_Usuarios().Resultado;

                cboFechasGen.DisplayMember = "Descripcion";
                cboFechasGen.ValueMember = "Valor";
                cboFechasGen.DataSource = clsBD.Puentes_C_ObtenerFechasCierre().Resultado;

                cboFechas.DisplayMember = "Descripcion";
                cboFechas.ValueMember = "Valor";
                cboFechas.DataSource = clsBD.Puentes_C_ObtenerFechasCierre(true).Resultado;

                cboCierresGenerados.DisplayMember = "Descripcion";
                cboCierresGenerados.ValueMember = "Valor";
                cboCierresGenerados.DataSource = clsBD.Puentes_C_ObtenerFechasCierre(true).Resultado;

                if (tab01.SelectedIndex == 0)
                {
                    if (cboFechasGen.Items.Count == 0)
                    {
                        btnGenerar.Enabled = false;
                        btnExportarExcel.Enabled = false;
                        MessageBox.Show("No hay periodos disponibles para realizar el cierre mensual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btnGenerar.Enabled = true;
                        btnExportarExcel.Enabled = true;
                    }
                }

                if (tab01.SelectedIndex == 1)
                {
                    if (cboFechas.Items.Count == 0)
                    {
                        btnProcesar.Enabled = false;
                        MessageBox.Show("No hay periodos disponibles para visualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btnProcesar.Enabled = true;
                    }
                }

                if (tab01.SelectedIndex == 2)
                {
                    if (cboCierresGenerados.Items.Count == 0)
                    {
                        btnAutorizar.Enabled = false;
                        MessageBox.Show("No hay periodos disponibles para autorizar un cierre mensual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btnAutorizar.Enabled = true;
                    }
                }

                ResultadoStored_DT Resultado = new BD.ResultadoStored_DT();

                Resultado = clsBD.Puentes_C_VerificarPosibilidadCierre();
                DateTime FechaSistema = clsGeneral.ObtieneFecha(Resultado.Resultado.Rows[0]["FechaSistema"].ToString());

                if (cboFechasGen.Items.Count > 0)
                {
                    DateTime FechaCierreCbo = clsGeneral.ObtieneFecha(cboFechasGen.GetItemText(cboFechasGen.Items[cboFechasGen.Items.Count - 1]));

                    if (FechaSistema >= FechaCierreCbo)
                        btnGenerar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                btnGenerar.Enabled = false;
                MessageBox.Show("Error al cargar valores iniciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmCierreMensual()
        {
            InitializeComponent();
        }

        private void Procesar()
        {
            Fecha = (DateTime?)cboFechasGen.SelectedValue;
            Fecha_Ini = new DateTime(Fecha.Value.Year, Fecha.Value.Month, 1);
            Fecha_Fin = Fecha_Ini.Value.AddMonths(1).AddMilliseconds(-2);

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr01.RunWorkerAsync();
        }

        private void ProcesarGen()
        {
            Fecha = (DateTime?)cboFechasGen.SelectedValue;
            Fecha_Ini = new DateTime(Fecha.Value.Year, Fecha.Value.Month, 1);
            Fecha_Fin = Fecha_Ini.Value.AddMonths(1).AddMilliseconds(-2);

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr02.RunWorkerAsync();
        }

        private void ProcesarDT()
        {
            TopSel = (int)txtTopSel.Value;

            if (chkFI.Checked)
            {
                Fecha_Ini = clsGeneral.ObtieneFecha(dtpFechaIni.Value.ToString("dd/MM/yyyy"));
                dtpFechaIni.Enabled = true;
            }
            else
            {
                Fecha_Ini = null;
                dtpFechaIni.Enabled = false;
            }

            if (chkFF.Checked)
            {
                Fecha_Fin = dtpFechaFin.Value;
                dtpFechaFin.Enabled = true;
            }
            else
            {
                Fecha_Fin = null;
                dtpFechaFin.Enabled = false;
            }

            if (chkU.Checked)
            {
                Usr_Id = (int)cboUsuarios.SelectedValue;
                cboUsuarios.Enabled = true;
            }
            else
            {
                Usr_Id = null;
                cboUsuarios.Enabled = false;
            }

            if (chkP.Checked)
            {
                Periodo = (DateTime?)cboFechas.SelectedValue;
                cboFechas.Enabled = true;
            }
            else
            {
                Periodo = null;
                cboFechas.Enabled = false;
            }

            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;

            wkr03.RunWorkerAsync();
        }

        private void Exportar()
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

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_ReporteContableMensual, paramC);

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

        private void ExportarR()
        {
            ResultadoExport exp = new ResultadoExport();
            SqlParameter param;
            List<SqlParameter> paramC = new List<SqlParameter>();

            param = new SqlParameter("@PHCM_Fecha_Ini", SqlDbType.DateTime);
            param.Value = Fecha_Ini;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Fecha_Fin", SqlDbType.DateTime);
            param.Value = Fecha_Fin;
            paramC.Add(param);
            param = new SqlParameter("@PHCM_Periodo", SqlDbType.DateTime);
            param.Value = Periodo;
            paramC.Add(param);
            param = new SqlParameter("@Usr_Id", SqlDbType.Int);
            param.Value = Usr_Id;
            paramC.Add(param);
            param = new SqlParameter("@TopSel", SqlDbType.Int);
            param.Value = TopSel;
            paramC.Add(param);

            exp = clsBD.ExportarExcel(CatalogoStoreds.Puentes_C_HistoricoCierresMensuales, paramC);

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

        private void CargarGrid()
        {
            if (!ResultadoGrid.HayError)
            {
                grdDatos.DataSource = ResultadoGrid.Resultado;

                for (int w = 0; w < grdDatos.Columns.Count; w++)
                {
                    grdDatos.Columns[w].ReadOnly = true;
                }

                if (ResultadoGrid.Resultado.Rows.Count <= 100)
                    grdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                grdDatos.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;

                try
                {
                    grdDatos.Columns[5].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[6].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[7].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[8].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[9].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[10].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[11].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[12].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[13].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[14].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[15].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[16].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[17].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[18].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                    grdDatos.Columns[1].DefaultCellStyle = Sistema.Global.CeldaFecha;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al presentar datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                grdDatos.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de cierre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridR()
        {
            if (!ResultadoGrid.HayError)
            {
                grdDatosR.DataSource = ResultadoGrid.Resultado;

                for (int w = 0; w < grdDatosR.Columns.Count; w++)
                {
                    grdDatosR.Columns[w].ReadOnly = true;
                }

                if (ResultadoGrid.Resultado.Rows.Count <= 100)
                    grdDatosR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                grdDatosR.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;
                grdDatosR.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de cierres generados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Metodos
        #region Eventos
        private void frmCierreMensual_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteContableMensual(Fecha_Ini, Fecha_Fin);

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

        private void frmCierreMensual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ErrorProceso = string.Empty;

            if (cboFechasGen.SelectedIndex != 0)
            {
                MessageBox.Show("Sólo se puede realizar el cierre del periodo más antiguo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboFechasGen.SelectedIndex = 0;
                return;
            }

            if (MessageBox.Show("¿Está seguro de realizar el cierre mensual?" + Environment.NewLine + "Este es un procedimiento que no tiene reverso", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                ProcesarGen();
        }
        
        private void wkr02_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_M_CierreMensual, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: Periodo = " + Fecha.Value.ToString("MMyyyy")));
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteContableMensual(Fecha_Ini, Fecha_Fin);

            if(!ResultadoGrid.HayError)
            {
                ds.Tables.Add(ResultadoGrid.Resultado);

                string dsXML = ds.GetXml();
                clsGeneral.PuentesCierreMensual Cierre = new clsGeneral.PuentesCierreMensual(Sistema.Global.Usr_Id, Fecha.Value.Year, Fecha.Value.Month, vPCM_Datos: clsGeneral.Zip(dsXML));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Puentes_I_HistoricoCierreMensual(Sistema.Global.Usr_Id, Fecha.Value, clsGeneral.Zip(dsXML));
                clsBD.Puentes_M_CierreMensual(Cierre);
            }
            else
            {
                ErrorProceso = ResultadoGrid.Error;
            }
        }

        private void wkr02_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;
            ValoresIniciales();

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Se ha generado el cierre", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValoresIniciales();

            if (tab01.SelectedIndex == 2)
            {
                clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();

                Respuesta = clsGeneral.ValidarAccesoUsuario(Sistema.Global.Usr_Id, CatalogoModulos.Puentes_RegenerarCierreMensual);

                if (!Respuesta.Permitido)
                {
                    MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
                    tab01.SelectedIndex = 0;
                }
            }
            //else if (tab01.SelectedIndex == 1)
            //{
            //    clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();

            //    Respuesta = clsGeneral.ValidarAccesoUsuario(Sistema.Global.Usr_Id, CatalogoModulos.Puentes_GenerarCierreMensual);

            //    if (!Respuesta.Permitido)
            //    {
            //        MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            //        tab01.SelectedIndex = 0;
            //    }
            //}
        }

        private void cboFechasGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFechasGen.Items.Count > 0)
            {
                tipoProceso = TipoProceso.Visualizacion;
                Procesar();
            }
        }

        private void wkr03_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_HistoricoCierresMensuales(Fecha_Ini, Fecha_Fin, Periodo, Usr_Id, TopSel);

            if (tipoProceso == TipoProceso.Extraccion)
                ExportarR();
        }

        private void wkr03_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tipoProceso == TipoProceso.Visualizacion)
            {
                CargarGridR();
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

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Archivo = string.Empty;
            tipoProceso = TipoProceso.Extraccion;
            Procesar();
        }

        private void btnAyudaP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para descargar el archivo asociado al registro se debe dar doble clic sobre el mismo.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.Visualizacion;
            ProcesarDT();
        }

        private void chkFI_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaIni.Enabled = chkFI.Checked;
        }

        private void chkFF_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFin.Enabled = chkFF.Checked;
        }

        private void chkP_CheckedChanged(object sender, EventArgs e)
        {
            cboFechas.Enabled = chkP.Checked;
        }

        private void chkU_CheckedChanged(object sender, EventArgs e)
        {
            cboUsuarios.Enabled = chkU.Checked;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaIni.Value)
            {
                dtpFechaIni.MaxDate = clsGeneral.ObtieneFecha(dtpFechaFin.Value.ToString("dd/MM/yyyy"));
                dtpFechaIni.Value = dtpFechaIni.MaxDate;
            }
        }

        private void grdDatosR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatosR.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = grdDatosR.SelectedRows[0];
                ResultadoStored_Byte Resultado = new ResultadoStored_Byte();
                string Archivo = string.Empty;

                Resultado = clsBD.Puentes_C_HistoricoDatos(Convert.ToInt32(dr.Cells["Id"].Value));

                if (!Resultado.HayError)
                {
                    try
                    {
                        DataSet ds = new DataSet();

                        ds.ReadXml(new System.IO.StringReader(clsGeneral.Unzip(Resultado.Resultado)));
                        DetalleCierre = new DataTable();
                        DetalleCierre = ds.Tables[0];
                        grdDatosDet.DataSource = DetalleCierre;
                        pnlDetalle.Size = new Size(tabPage1.Width - 16, tabPage1.Height - 16);
                        pnlDetalle.Location = new Point(8, 8);
                        pnlDetalle.Visible = true;

                        grdDatosDet.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;

                        try
                        {
                            grdDatosDet.Columns[5].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[6].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[7].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[8].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[9].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[10].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[11].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[12].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[13].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[14].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[15].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[16].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[17].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[18].DefaultCellStyle = Sistema.Global.CeldaNumerica_2Dec;
                            grdDatosDet.Columns[1].DefaultCellStyle = Sistema.Global.CeldaFecha;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al presentar datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al extraer datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al obtener datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarRExcel_Click(object sender, EventArgs e)
        {
            Archivo = string.Empty;
            tipoProceso = TipoProceso.Extraccion;
            ProcesarDT();
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            pnlDetalle.Visible = false;
        }

        private void btnExportarDetalle_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new ResultadoExport();

            exp = clsBD.ExportarExcel(DetalleCierre);

            if (!exp.HayError)
            {
                try
                {
                    System.Diagnostics.Process.Start(exp.Archivo);
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

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de autorizar el reproceso del cierre?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (cboCierresGenerados.SelectedIndex != 0)
                {
                    if (MessageBox.Show("Si realiza la autorización de este periodo automaticamente se cancelarán los cierres correspondientes a los periodos posteriores. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        cboCierresGenerados.SelectedIndex = 0;
                        return;
                    }
                }

                FechasProceso = new List<string>();

                for (int w = cboCierresGenerados.SelectedIndex; w >= 0; w--)
                {
                    FechasProceso.Add(cboCierresGenerados.GetItemText(cboCierresGenerados.Items[w]));
                }
                
                pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
                pnlProgreso.Location = new Point(3, 3);
                pnlProgreso.Visible = true;
                EnProceso = true;
                ErrorProceso = string.Empty;
                Sistema.Global.ProcesosPendientes = true;

                wkr04.RunWorkerAsync();
            }
        }

        private void wkr04_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string Fecha in FechasProceso)
            {
                DateTime FechaReporteAut = clsGeneral.ObtieneFecha(Fecha);
                clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(
                    Sistema.Global.Usr_Id,
                    CatalogoStoreds.Puentes_U_AutorizarRegeneracionCierreMensual,
                    vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @PCM_Anno = " + FechaReporteAut.Year.ToString() +
                        " PCM_Mes = " + FechaReporteAut.Month.ToString()));

                ResultadoStored_Str Resultado = new ResultadoStored_Str();

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                Resultado = clsBD.Puentes_U_AutorizarRegeneracionCierreMensual(FechaReporteAut.Year, FechaReporteAut.Month);

                if (Resultado.HayError)
                    ErrorProceso += Resultado.Error + Environment.NewLine;
            }
        }

        private void wkr04_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ValoresIniciales();

            if (ErrorProceso == string.Empty)
            {
                MessageBox.Show("Se ha generado el reproceso del cierre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ErrorProceso, "Error al autorizar periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;
        }
        #endregion Eventos
    }
}
