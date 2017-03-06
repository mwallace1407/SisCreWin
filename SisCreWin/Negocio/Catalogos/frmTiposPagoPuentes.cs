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
    public partial class frmTiposPagoPuentes : Form
    {
        #region Metodos
        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_TiposPagoPuentes();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "No.";
                grdDatos.Columns[1].HeaderText = "Descripción";
                grdDatos.Columns[2].HeaderText = "Orden";
                grdDatos.Columns[3].HeaderText = "Activo";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de tipos de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmTiposPagoPuentes()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_I_TiposPagoPuentes, vBit_DatosPrevios: null);
            clsGeneral.TiposPagoPuentes Tipo = new clsGeneral.TiposPagoPuentes(txtIngNombre.Text.Trim(), (int)txtIngOrden.Value, chkIngActivo.Checked);

            Resultado = clsBD.Catalogos_I_TiposPagoPuentes(Tipo);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_TiposPagoPuentesBitacora(Resultado.Resultado);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un tipo de pago", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIngNombre.Text = string.Empty;
                    chkIngActivo.Checked = false;
                    txtIngNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Al parecer se generó el registro pero hubo un problema con la bitácora. Revise por favor", "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                txtModId.Text = dr.Cells["PTP_Id"].Value.ToString();
                txtModNombre.Text = dr.Cells["PTP_Descripcion"].Value.ToString();
                txtModOrden.Value = (int)dr.Cells["PTP_Orden"].Value;

                if (dr.Cells["PTP_Activo"].Value.ToString() == "S")
                    chkModActivo.Checked = true;
                else
                    chkModActivo.Checked = false;
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_TiposPagoPuentes, vBit_DatosPrevios: null);
            clsGeneral.TiposPagoPuentes Tipo = new clsGeneral.TiposPagoPuentes(txtModNombre.Text.Trim(), (int)txtModOrden.Value, chkModActivo.Checked, vPTP_Id: Convert.ToInt32(txtModId.Text));

            Resultado = clsBD.Catalogos_C_TiposPagoPuentesBitacora(Convert.ToInt32(txtModId.Text));

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Catalogos_U_TiposPagoPuentes(Tipo);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en el tipo de pago", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_TiposPagoPuentes, null);

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
        #endregion Eventos
    }
}
