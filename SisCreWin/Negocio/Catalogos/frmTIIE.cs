using SisCreWin.BD;
using SisCreWin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCreWin.Negocio.Catalogos
{
    public partial class frmTIIE : Form
    {
        #region Metodos
        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_TIIE();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "Año";
                grdDatos.Columns[1].HeaderText = "Mes";
                grdDatos.Columns[2].HeaderText = "Valor";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de orígenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmTIIE()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_I_TIIE, vBit_DatosPrevios: null);
            clsGeneral.TIIE TIIE = new clsGeneral.TIIE((int)txtIngMes.Value, (int)txtIngAnno.Value, txtIngValor.Value);

            Resultado = clsBD.Catalogos_I_TIIE(TIIE);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_TIIEBitacora(TIIE);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un registro para TIIE.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIngAnno.Maximum = DateTime.Now.Year;
                    txtIngAnno.Value = DateTime.Now.Year;
                    txtIngMes.Value = DateTime.Now.Month;
                    txtIngValor.Value = 0;
                    txtIngAnno.Focus();
                }
                else
                {
                    MessageBox.Show("Al parecer se generó el registro pero hubo un problema con la bitácora. Revise por favor.", "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab01.SelectedIndex == 1)
            {
                CargarGrid();
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                gbDatos.Visible = true;
                DataGridViewRow dr = grdDatos.SelectedRows[0];

                txtModAnno.Text = dr.Cells["TIIE_Anno"].Value.ToString();
                txtModMes.Text = dr.Cells["TIIE_Mes"].Value.ToString();
                txtModValor.Value = (decimal)dr.Cells["TIIE_Valor"].Value;
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_TIIE, vBit_DatosPrevios: null);
            clsGeneral.TIIE TIIE = new clsGeneral.TIIE(Convert.ToInt32(txtModMes.Text), Convert.ToInt32(txtModAnno.Text), txtModValor.Value);

            Resultado = clsBD.Catalogos_C_TIIEBitacora(TIIE);

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Catalogos_U_TIIE(TIIE);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en la TIIE", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new BD.ResultadoExport();

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_TIIE, null);

            if(!exp.HayError)
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

            //System.Diagnostics.Process.Start(lblArchivo.Text);
        }

        private void frmTIIE_Load(object sender, EventArgs e)
        {
            txtIngAnno.Maximum = DateTime.Now.Year;
            txtIngAnno.Value = DateTime.Now.Year;
            txtIngMes.Value = DateTime.Now.Month;
        }

        private void txtIngAnno_ValueChanged(object sender, EventArgs e)
        {
            if(txtIngAnno.Value == txtIngAnno.Maximum)
            {
                txtIngMes.Maximum = DateTime.Now.Month;
            }
            else
            {
                txtIngMes.Maximum = 12;
            }
        }
        #endregion Eventos
    }
}
