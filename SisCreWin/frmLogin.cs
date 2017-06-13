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
        private void TareasVersiones()
        {
            Version VersionBD;
            Version VersionApp = null;

            Version.TryParse(clsBD.Sistema_C_ParametroVersion().Resultado, out VersionBD);

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                VersionApp = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

                if (VersionBD == null && VersionApp != null)
                    clsBD.Sistema_U_ParametroVersion(VersionApp.ToString());

                int Compara = VersionBD.CompareTo(VersionApp);

                if (Compara > 0)
                {
                    btnProcesar.Enabled = false;
                    MessageBox.Show("Debe actualizar la aplicación para poder ingresar", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (Compara < 0)
                {
                    clsBD.Sistema_U_ParametroVersion(VersionApp.ToString());
                }
            }
        }
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
            txtContrasenna.Select();
            clsBD.ObtenerBaseConectada();

            if (Environment.MachineName.ToLower() == "oenriquez" && txtUsuario.Text.Trim() == "oenriquez")
            {
                frmCnx frm = new SisCreWin.frmCnx();

                if (System.IO.File.Exists(@"C:\Users\oenriquez\Downloads\siscre.txt"))
                    txtContrasenna.Text = System.IO.File.ReadAllText(@"C:\Users\oenriquez\Downloads\siscre.txt");

                frm.ShowDialog(this);
            }

            if (Environment.MachineName.ToLower() == "ibecerra2" && txtUsuario.Text.Trim() == "ibecerra")
            {
                frmCnx frm = new SisCreWin.frmCnx();

                frm.ShowDialog(this);
            }

            TareasVersiones();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if(clsSeguridad.IsValidateCredentials(txtUsuario.Text, txtContrasenna.Text, txtDominio.Text))
            {
                ResultadoStored_Int Resultado;

                if (chkPruebas.Checked)
                    Global.OverrideCnx = clsGeneral.BDCnxQA;

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

                        if ((Environment.MachineName.ToLower() == "oenriquez" && txtUsuario.Text.Trim() == "oenriquez") || (Environment.MachineName.ToLower() == "ibecerra2" && txtUsuario.Text.Trim() == "ibecerra"))
                        {
                            if (clsBD.ObtenerBaseConectada().BaseDatos == "BD_ADMIN_CREDIT_BIM")
                            {
                                if (MessageBox.Show("Estás a pundo de entrar en ambiente PRODUCTIVO. ¿Deseas continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.No)
                                    return;
                            }
                        }

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

        private void btnCnxAlt_Click(object sender, EventArgs e)
        {
            frmCnx frm = new SisCreWin.frmCnx();

            frm.ShowDialog(this);
        }

        private void btnCnxAlt_MouseHover(object sender, EventArgs e)
        {
            btnCnxAlt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnCnxAlt_MouseLeave(object sender, EventArgs e)
        {
            btnCnxAlt.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
