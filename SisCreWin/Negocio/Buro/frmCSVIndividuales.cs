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
    public partial class frmCSVIndividuales : Form
    {
        #region Variables
        string FechaReporte = string.Empty;
        string DirectorioReporte = string.Empty;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
        bool EnProceso = false;
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
                clsGeneral.BuroHistoricoIndividuales Buro = new clsGeneral.BuroHistoricoIndividuales(Sistema.Global.Usr_Id, vBHI_Documento: clsGeneral.Zip(System.IO.File.ReadAllText(ArchivoProceso)));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Buro_I_HistoricoIndividuales(Buro);
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
