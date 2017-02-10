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
    public partial class frmUsuarios : Form
    {
        #region Metodos
        private void CargarUsuariosGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Usuarios_C_Usuarios();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "No.";
                grdDatos.Columns[1].HeaderText = "Login";
                grdDatos.Columns[2].HeaderText = "Nombre";
                grdDatos.Columns[3].HeaderText = "Activo";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosCBO()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Usuarios_C_Usuarios();

            if (!Resultado.HayError)
            {
                cboUsuarios.DisplayMember = "Usr_Nombre";
                cboUsuarios.ValueMember = "Usr_Id";
                cboUsuarios.DataSource = Resultado.Resultado;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPermisos(int Usr_Id)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Usuarios_C_Permisos(Usr_Id);

            if (!Resultado.HayError)
            {
                grdDatosP.DataSource = Resultado.Resultado;
                grdDatosP.Columns[0].HeaderText = "No.";
                grdDatosP.Columns[1].HeaderText = "Nombre";
                grdDatosP.Columns[2].HeaderText = "Descripción";
                grdDatosP.Columns[3].HeaderText = "Autorizado";
                grdDatosP.Columns[0].ReadOnly = true;
                grdDatosP.Columns[1].ReadOnly = true;
                grdDatosP.Columns[2].ReadOnly = true;
                grdDatosP.Columns[3].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos
        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Global.Usr_Id, CatalogoStoreds.Usuarios_I_Usuarios, vBit_DatosPrevios: null);
            clsGeneral.Usuario Usuario = new clsGeneral.Usuario(txtCLogin.Text.Trim(), txtCNombre.Text.Trim(), chkCActivo.Checked);

            Resultado = clsBD.Usuarios_I_Usuarios(Usuario);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Usuarios_C_UsuariosBitacora(Resultado.Resultado);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un usuario.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCLogin.Text = string.Empty;
                    txtCNombre.Text = string.Empty;
                    chkCActivo.Checked = false;
                    txtCLogin.Focus();
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

        private void tabModificar_Click(object sender, EventArgs e)
        {

        }

        private void tab01_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab01.SelectedIndex == 1)
            {
                CargarUsuariosGrid();
            }
            else if (tab01.SelectedIndex == 2)
            {
                clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();

                Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Usuarios_Permisos);

                if (!Respuesta.Permitido)
                {
                    MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
                    tab01.SelectedIndex = 0;
                }
                else
                {
                    CargarUsuariosCBO();
                }
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                gbDatos.Visible = true;
                DataGridViewRow dr = grdDatos.SelectedRows[0];
                txtMId.Text = dr.Cells["Usr_Id"].Value.ToString();
                txtMLogin.Text = dr.Cells["Usr_Login"].Value.ToString();
                txtMNombre.Text = dr.Cells["Usr_Nombre"].Value.ToString();

                if (dr.Cells["Usr_Activo"].Value.ToString() == "S")
                    chkMActivo.Checked = true;
                else
                    chkMActivo.Checked = false;
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Global.Usr_Id, CatalogoStoreds.Usuarios_U_Usuarios, vBit_DatosPrevios: null);
            clsGeneral.Usuario Usuario = new clsGeneral.Usuario(txtMLogin.Text.Trim(), txtMNombre.Text.Trim(), chkMActivo.Checked, vUsr_Id: Convert.ToInt32(txtMId.Text));

            Resultado = clsBD.Usuarios_C_UsuariosBitacora(Convert.ToInt32(txtMId.Text));

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Usuarios_U_Usuarios(Usuario);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en el usuario", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuariosGrid();
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

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboUsuarios.SelectedValue > 0)
            {
                CargarPermisos((int)cboUsuarios.SelectedValue);
            }
        }

        private void btnAyudaP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para cambiar el permiso de un usuario sobre un módulo se debe dar doble clic sobre el módulo deseado.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grdDatosP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Enabled = false;

            if (grdDatosP.SelectedRows.Count > 0)
            {
                ResultadoStored_Str Resultado = new ResultadoStored_Str();
                DataGridViewRow dr = grdDatosP.SelectedRows[0];
                bool Autorizado = false;

                if (dr.Cells["Mod_Autorizado"].Value.ToString() == "N")
                    Autorizado = true;

                clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Global.Usr_Id, CatalogoStoreds.Usuarios_M_Permisos, vBit_DatosPrevios: null);
                clsGeneral.UsuarioPermiso Permiso = new clsGeneral.UsuarioPermiso((int)cboUsuarios.SelectedValue, (int)dr.Cells["Mod_Id"].Value, Autorizado);

                Resultado = clsBD.Usuarios_C_PermisosBitacora(Permiso);
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Usuarios_M_Permisos(Permiso);

                if (!Resultado.HayError)
                {
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    CargarPermisos((int)cboUsuarios.SelectedValue);
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al modificar el permiso al módulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Enabled = true;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new BD.ResultadoExport();

            exp = clsBD.ExportarExcel(CatalogoStoreds.Usuarios_C_Usuarios, null);

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
        }
        #endregion Eventos
    }
}
