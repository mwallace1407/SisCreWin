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
    public partial class frmReporteContable : Form
    {
        #region Variables
        ResultadoStored_DT ResultadoGrid = new ResultadoStored_DT();
        DateTime? Fecha = null;
        TipoProceso tipoProceso;
        string Archivo;
        bool EnProceso = false;
        string ErrorProceso = string.Empty;

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
        private void CargaValoresIniciales()
        {
            txtTopSel.Value = 100;
            dtpFechaFin.MaxDate = clsGeneral.ObtieneFecha(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")).AddMilliseconds(-1);
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
                    MessageBox.Show("No hay periodos disponibles para realizar el cierre mensual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnGenerar.Enabled = true;
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
        }
        public frmReporteContable()
        {
            InitializeComponent();
        }

        private void Procesar()
        {
            Fecha = (DateTime?)cboFechasGen.SelectedValue;

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
            
            param = new SqlParameter("@SCP_Fecha", SqlDbType.DateTime);
            param.Value = Fecha;
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

                grdDatosR.ClearSelection();
            }
            else
            {
                MessageBox.Show(ResultadoGrid.Error, "Error al obtener datos de cierres generados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Metodos
        #region Eventos
        private void frmReporteContable_Load(object sender, EventArgs e)
        {
            CargaValoresIniciales();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteContableMensual(Fecha);

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

        private void frmReporteContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ErrorProceso = string.Empty;
            ProcesarGen();
        }
        
        private void wkr02_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_M_CierreMensual, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: Periodo = " + Fecha.Value.ToString("MMyyyy")));
            ResultadoGrid = new BD.ResultadoStored_DT();
            ResultadoGrid = clsBD.Puentes_C_ReporteContableMensual(Fecha);

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
            CargaValoresIniciales();

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Se ha generado el cierre", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaValoresIniciales();

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
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            DateTime FechaReporteAut = clsGeneral.ObtieneFecha(cboCierresGenerados.Text);
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(
                Sistema.Global.Usr_Id,
                CatalogoStoreds.Puentes_U_AutorizarRegeneracionCierreMensual,
                vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @PCM_Anno = " + FechaReporteAut.Year.ToString() +
                    " PCM_Mes = " + FechaReporteAut.Month.ToString()));
            
            ResultadoStored_Str Resultado2 = new ResultadoStored_Str();
            
            if (MessageBox.Show("¿Está seguro de autorizar el reproceso del cierre?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                Resultado2 = clsBD.Puentes_U_AutorizarRegeneracionCierreMensual(FechaReporteAut.Year, FechaReporteAut.Month);

                if (!Resultado.HayError)
                {
                    CargaValoresIniciales();
                    MessageBox.Show("Se ha autorizado el reproceso del cierre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al autorizar periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Eventos
    }
}
