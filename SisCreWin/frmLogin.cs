using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCreWin.Seguridad;
using SisCreWin.BD;
using SisCreWin.Modelo;
using SisCreWin.Sistema;

namespace SisCreWin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsSeguridad.Credencial Cred = new clsSeguridad.Credencial();

            Cred = clsSeguridad.ObtenerUsuarioActual();
            txtUsuario.Text = Cred.Usuario;
            txtDominio.Text = Cred.Dominio;
            txtContrasenna.Focus();

            if (Environment.MachineName.ToLower() == "oenriquez" && txtUsuario.Text.Trim() == "oenriquez")
                txtContrasenna.Text = new De_CryptDLL.De_Crypt().Desencriptar("7GRodt3g62JucX8dSj6KdA==", Environment.MachineName.ToLower(), true);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if(clsSeguridad.IsValidateCredentials(txtUsuario.Text, txtContrasenna.Text, txtDominio.Text))
            {
                ResultadoStored_Int Resultado;

                if (clsGeneral.Produccion != "N")
                    Resultado = clsBD.Usuarios_C_ValidarLogin(clsGeneral.Codificar(txtUsuario.Text.Trim()));
                else
                    Resultado = clsBD.Usuarios_C_ValidarLogin(clsGeneral.Codificar("oenriquez"));
                
                //string ss = clsGeneral.Codificar("");

                if (!Resultado.HayError)
                {
                    if (Resultado.Resultado > 0)
                    {
                        frmMain frm = new frmMain();

                        Global.Usr_Id = Resultado.Resultado;
                        Global.Usuario = txtUsuario.Text.Trim();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró su usuario en la base de datos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Eror al verificar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique su usuario y contraseña", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
