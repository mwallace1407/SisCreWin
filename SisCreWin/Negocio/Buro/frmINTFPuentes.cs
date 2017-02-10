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
        string FechaReporte = string.Empty;
        string Periodo = string.Empty;
        int PeriodoInt = 0;
        string DirectorioReporte = string.Empty;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
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
        #endregion Metodos
        #region Eventos
        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCSVIndividuales_Load(object sender, EventArgs e)
        {
            dtpFechaDocumento.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1);
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
            FechaReporte = dtpFechaDocumento.Value.ToString("ddMMyyyy");
            Periodo = dtpPeriodo.Value.ToString("MMyyyy");
            PeriodoInt = Convert.ToInt32(dtpPeriodo.Value.ToString("yyyyMM"));
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

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.ReportesBuro_C_CreditosPuentes, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @FechaDoc = " + FechaReporte + "; @Periodo = " + Periodo));
            Resultado = clsBD.ReportesBuro_C_CreditosPuentes(FechaReporte, Periodo, PeriodoInt);

            if (!Resultado.HayError)
            {
                string CadenaTXT = ProcesarDatos(Resultado.Resultado);
                clsGeneral.BuroHistoricoPuentes Buro = new clsGeneral.BuroHistoricoPuentes(Sistema.Global.Usr_Id, PeriodoInt, vBHP_Documento: clsGeneral.Zip(CadenaTXT));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Buro_I_HistoricoPuentes(Buro);

                ArchivoProceso = Path.Combine(DirectorioReporte, clsGeneral.GeneraNombreArchivoRnd("BuroPuentes_", "txt"));
                System.IO.TextWriter tw;

                tw = new System.IO.StreamWriter(ArchivoProceso, false, System.Text.Encoding.UTF8);
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

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion Eventos

        private void frmCSVIndividuales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(EnProceso)
            {
                e.Cancel = true;
            }
        }
    }
}
