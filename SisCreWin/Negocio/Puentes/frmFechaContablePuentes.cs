using System;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Puentes
{
    public partial class frmFechaContablePuentes : Form
    {
        #region Metodos

        private void ValoresIniciales()
        {
            ResultadoStored_Str Resultado = new BD.ResultadoStored_Str();
            DateTime FechaConta;
            DateTime FechaCierre;

            btnProcesar.Enabled = false;
            Resultado = clsBD.Puentes_C_ObtenerFechaContable();
            FechaConta = clsGeneral.ObtieneFecha(Resultado.Resultado);

            if (!Resultado.HayError && FechaConta.Year > 1900)
            {
                Resultado = new BD.ResultadoStored_Str();
                Resultado = clsBD.Puentes_C_ObtenerFechaUltimoCierre();
                FechaCierre = clsGeneral.ObtieneFecha(Resultado.Resultado);

                if (!Resultado.HayError && FechaCierre.Year > 1900)
                {
                    try
                    {
                        if (FechaConta.AddMonths(1) <= FechaCierre)
                        {
                            lblFechaActual.Text = "Fecha actual: " + FechaConta.ToString("dd/MM/yyyy");
                            dtpFecha.MinDate = FechaConta.AddMonths(1);
                            dtpFecha.Value = FechaConta.AddMonths(1);
                            dtpFecha.MaxDate = FechaCierre;
                            btnProcesar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("La fecha contable próxima es mayor a la fecha de cierre actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al asignar límites de fecha: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener fecha de cierre: " + Resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al obtener fecha contable actual: " + Resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Procesar(DateTime Fecha)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Puentes_U_EstablecerFechaContable, vBit_DatosPrevios: clsGeneral.Zip("Fecha establecida: " + Fecha.ToString("dd/MM/yyyy")));

            clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
            Resultado = clsBD.Puentes_U_EstablecerFechaContable(Fecha.ToString("yyyyMMdd"));

            if (!Resultado.HayError)
            {
                MessageBox.Show("Ha sido actualizada la fecha contable satisfactoriamente", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValoresIniciales();
            }
            else
            {
                MessageBox.Show("Error al actualizar fecha contable: " + Resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Metodos

        #region Eventos

        public frmFechaContablePuentes()
        {
            InitializeComponent();
        }

        private void frmFechaContablePuentes_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de realizar este proceso?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Procesar(clsGeneral.ObtenerUltimoDiaMes(dtpFecha.Value.Year, dtpFecha.Value.Month, false));
            }
        }

        #endregion Eventos
    }
}