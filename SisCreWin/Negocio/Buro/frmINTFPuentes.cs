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

namespace SisCreWin.Negocio.Buro
{
    public partial class frmINTFPuentes : Form
    {
        #region Variables
        string DirectorioReporte = string.Empty;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
        DateTime FechaDoc = DateTime.Now;
        bool EnProceso = false;
        #endregion Variables
        #region Metodos
        public frmINTFPuentes()
        {
            InitializeComponent();
        }

        protected string ProcesarDatos(DataTable DT)
        {
            string Resultado = string.Empty;

            for (int w = 0; w < DT.Rows.Count; w++)
            {
                Resultado += DT.Rows[w]["Valor"].ToString();
            }

            return Resultado;
        }

        private void CargaValoresIniciales()
        {
            cboFechas.DisplayMember = "Descripcion";
            cboFechas.ValueMember = "Valor";
            cboFechas.DataSource = clsBD.Buro_C_PeriodosDisponiblesPuentes().Resultado;

            if (cboFechas.Items.Count == 0)
            {
                btnCrear.Enabled = false;
                MessageBox.Show("No hay periodos disponibles para generar el INTF", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cboPeriodosCreados.DataSource = clsBD.Buro_C_PeriodosDisponiblesPuentes(true).Resultado;

            if (cboPeriodosCreados.Items.Count == 0)
                btnAutorizar.Enabled = false;
            else
                btnAutorizar.Enabled = true;
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

                Respuesta = clsGeneral.ValidarAccesoUsuario(Sistema.Global.Usr_Id, CatalogoModulos.Buro_Puentes_RegenerarINTF);

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

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.ReportesBuro_C_CreditosPuentes, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @FechaDoc = " + FechaDoc.ToString("ddMMyyyy") + "; @Periodo = " + FechaDoc.ToString("MMyyyy")));
            Resultado = clsBD.ReportesBuro_C_CreditosPuentes(FechaDoc.ToString("ddMMyyyy"), FechaDoc.ToString("MMyyyy"), Convert.ToInt32(FechaDoc.ToString("yyyyMM")));

            if (!Resultado.HayError)
            {
                string CadenaTXT = ProcesarDatos(Resultado.Resultado);
                clsGeneral.BuroHistoricoPuentes Buro = new clsGeneral.BuroHistoricoPuentes(Sistema.Global.Usr_Id, Convert.ToInt32(FechaDoc.ToString("yyyyMM")), vBHP_Documento: clsGeneral.Zip(CadenaTXT));
                clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Sistema.Global.Usr_Id, FechaDoc.Year, FechaDoc.Month, "P", vBDG_Documento: clsGeneral.Zip(CadenaTXT, clsGeneral.Codificaciones.UTF8SinBOM));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Buro_I_HistoricoPuentes(Buro);
                clsBD.Buro_M_Documentos(BuroDoc);

                ArchivoProceso = Path.Combine(DirectorioReporte, clsGeneral.GeneraNombreArchivoRnd("BuroPuentes_", "txt"));
                System.IO.TextWriter tw;
                System.Text.Encoding utf8SinBOM = new UTF8Encoding(false); //Genera UTF-8 sin BOM

                tw = new System.IO.StreamWriter(ArchivoProceso, false, utf8SinBOM);
                tw.Write(CadenaTXT);
                tw.Close();
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
            if(EnProceso)
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
            clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Sistema.Global.Usr_Id, FechaReporteAut.Year, FechaReporteAut.Month, "P");

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
    }
}
