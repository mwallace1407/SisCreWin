using System;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

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

                grdDatos.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de orígenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValoresIniciales()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            txtIngAnno.Maximum = DateTime.Now.Year;
            txtIngMes.Maximum = DateTime.Now.AddMonths(-1).Month;
            Resultado = clsBD.Catalogos_C_ObtenerTIIEMaxima();

            if (!Resultado.HayError)
            {
                DateTime dtTM = new DateTime((int)Resultado.Resultado.Rows[0]["Anno"], (int)Resultado.Resultado.Rows[0]["Mes"], 1);
                DateTime Control = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                dtTM = dtTM.AddMonths(1);

                if (Control > dtTM)
                {
                    txtIngAnno.Value = (int)Resultado.Resultado.Rows[0]["Anno"];
                    txtIngMes.Value = ((int)Resultado.Resultado.Rows[0]["Mes"]) + 1;
                    txtIngValor.Select();
                }
                else
                {
                    txtIngAnno.Value = (int)Resultado.Resultado.Rows[0]["Anno"];
                    txtIngMes.Value = (int)Resultado.Resultado.Rows[0]["Mes"];
                    txtIngValor.Select();
                    MessageBox.Show("Se han registrado todos los valores TIIE para los periodos disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener TIIE máxima", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (clsBD.Catalogos_C_TIIEVerificarExistente(TIIE).Resultado > 0)
            {
                MessageBox.Show("Ya existe un valor registrado para el periodo, será dirigido a la pestaña donde puede modificarlo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tab01.SelectedIndex = 1;
                return;
            }

            Resultado = clsBD.Catalogos_I_TIIE(TIIE);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_TIIEBitacora(TIIE);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un registro para TIIE", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIngValor.Value = 0;
                    ValoresIniciales();
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
            if (tab01.SelectedIndex == 0)
            {
                ValoresIniciales();
            }
            else if (tab01.SelectedIndex == 1)
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

            //System.Diagnostics.Process.Start(lblArchivo.Text);
        }

        private void frmTIIE_Load(object sender, EventArgs e)
        {
            ValoresIniciales();
        }

        private void txtIngAnno_ValueChanged(object sender, EventArgs e)
        {
            if (txtIngAnno.Value == txtIngAnno.Maximum)
            {
                txtIngMes.Maximum = DateTime.Now.AddMonths(-1).Month;
            }
            else
            {
                txtIngMes.Maximum = 12;
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            txtIngAnno.Enabled = !chkAuto.Checked;
            txtIngMes.Enabled = !chkAuto.Checked;
        }

        #endregion Eventos
    }
}