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

namespace SisCreWin.Sistema
{
    public partial class frmModulos : Form
    {
        #region Metodos
        private void CargarModulosGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_Modulos();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "No.";
                grdDatos.Columns[1].HeaderText = "Nombre";
                grdDatos.Columns[2].HeaderText = "Descripción";
                grdDatos.Columns[3].HeaderText = "Activo";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de módulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmModulos()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos
        private void btnCrearModulo_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Global.Usr_Id, CatalogoStoreds.Catalogos_I_Modulos, vBit_DatosPrevios: null);
            clsGeneral.CatModulos Modulos = new clsGeneral.CatModulos(0, txtCNombre.Text.Trim(), txtCDescripcion.Text.Trim(), chkCActivo.Checked);

            Resultado = clsBD.Catalogos_I_Modulos(Modulos);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_ModulosBitacora(Resultado.Resultado);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un módulo.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNombre.Text = string.Empty;
                    txtCDescripcion.Text = string.Empty;
                    chkCActivo.Checked = false;
                    txtCNombre.Focus();
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
                CargarModulosGrid();
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                gbDatos.Visible = true;
                DataGridViewRow dr = grdDatos.SelectedRows[0];
                txtMId.Text = dr.Cells["Mod_Id"].Value.ToString();
                txtMNombre.Text = dr.Cells["Mod_Nombre"].Value.ToString();
                txtMDescripcion.Text = dr.Cells["Mod_Descripcion"].Value.ToString();

                if (dr.Cells["Mod_Activo"].Value.ToString() == "S")
                    chkMActivo.Checked = true;
                else
                    chkMActivo.Checked = false;
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificarModulo_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Global.Usr_Id, CatalogoStoreds.Catalogos_U_Modulos, vBit_DatosPrevios: null);
            clsGeneral.CatModulos Modulos = new clsGeneral.CatModulos(Convert.ToInt32(txtMId.Text), txtMNombre.Text.Trim(), txtMDescripcion.Text.Trim(), chkMActivo.Checked);

            Resultado = clsBD.Catalogos_C_ModulosBitacora(Convert.ToInt32(txtMId.Text));

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Catalogos_U_Modulos(Modulos);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en el módulo", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarModulosGrid();
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

        private void btnAyudaP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PAra cambiar el permiso de un usuario sobre un módulo se debe dar doble clic sobre el módulo deseado.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new BD.ResultadoExport();

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_Modulos, null);

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

        private void frmModulos_Load(object sender, EventArgs e)
        {

        }
        #endregion Eventos
    }
}
