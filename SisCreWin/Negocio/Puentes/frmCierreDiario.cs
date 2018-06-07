using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmCierreDiario : Form
    {
        #region Variables

        private string FechaReporte = string.Empty;
        private string ErrorProceso = string.Empty;
        private string ArchivoProceso = string.Empty;
        private bool EnProceso = false;

        #endregion Variables

        #region Metodos

        public frmCierreDiario()
        {
            InitializeComponent();
        }

        private void UltimaFecha()
        {
            ResultadoStored_Str Resultado = new BD.ResultadoStored_Str();

            Resultado = clsBD.Puentes_C_ObtenerFechaUltimoCierre();
            dtpFechaSistema.Value = clsGeneral.ObtieneFecha(Resultado.Resultado);

            //if (Resultado.Resultado.Rows[0]["Validacion"].ToString() == string.Empty)
            //{
            //    btnCrear.Enabled = true;
            //}
            //else
            //{
            //    btnCrear.Enabled = false;
            //    lblMensaje.Text = Resultado.Resultado.Rows[0]["Validacion"].ToString();
            //}

            if (dtpFechaSistema.Value > DateTime.Now)
            {
                btnCrear.Enabled = false;
                MessageBox.Show("No existen periodos pendientes por cerrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Metodos

        #region Eventos

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmCierreDiario_Load(object sender, EventArgs e)
        {
            UltimaFecha();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de realizar el cierre diario para los créditos puente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

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
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_I_CierreDiario, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: Ninguno"));
            clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
            Resultado = clsBD.Puentes_I_CierreDiario();

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
                MessageBox.Show("Ha finalizado satisfactoriamente el cierre diario.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UltimaFecha();
        }

        #endregion Eventos

        private void frmCierreDiario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnProceso)
            {
                e.Cancel = true;
            }
        }
    }
}