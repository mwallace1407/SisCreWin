using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCreWin.Sistema;
using Microsoft.Win32;

namespace SisCreWin
{
    public partial class frmCnx : Form
    {
        private void LeePreferencias()
        {
            RegistryKey llave = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SisCreWin\\Preferencias");

            try
            {
                string tmpVal = "";

                tmpVal = (string)llave.GetValue("Usuario");
                txtUsuario.Text = tmpVal;
                tmpVal = (string)llave.GetValue("Servidor");
                txtServidor.Text = tmpVal;
                tmpVal = (string)llave.GetValue("BD");
                txtBD.Text = tmpVal;
            }
            catch { }
            finally
            {
                llave.Close();
            }
        }

        private void GuardaPreferencias()
        {
            RegistryKey llave = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SisCreWin\\Preferencias");

            try
            {
                llave.SetValue("Usuario", txtUsuario.Text);
                llave.SetValue("Servidor", txtServidor.Text);
                llave.SetValue("BD", txtBD.Text);
            }
            catch { }
            finally
            {
                llave.Close();
            }
        }
        private string setCnx(string Servidor, string BD, string Usuario, string Pass, bool Trusted)
        {
            if (Trusted)
                return "Data Source=" + Servidor + ";Initial Catalog=" + BD + ";Trusted_Connection=True;";
            else
                return "Data Source=" + Servidor + ";Initial Catalog=" + BD + ";User Id=" + Usuario + ";Password=" + Pass + ";";
        }
        public frmCnx()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.OverrideCnx = string.Empty;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) && !chkTrusted.Checked)
            {
                MessageBox.Show("Debe introducir un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text) && !chkTrusted.Checked)
            {
                MessageBox.Show("Debe introducir una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtServidor.Text) || string.IsNullOrWhiteSpace(txtBD.Text))
            {
                MessageBox.Show("Debe introducir todos los valores: Servidor y Base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.OverrideCnx = setCnx(txtServidor.Text.Trim(), txtBD.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim(), chkTrusted.Checked);
            GuardaPreferencias();
            this.Close();
        }

        private void chkTrusted_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtUsuario.Enabled = !chkTrusted.Checked;
            txtPass.Enabled = !chkTrusted.Checked;
        }

        private void frmCnx_Load(object sender, EventArgs e)
        {
            LeePreferencias();

            if (txtUsuario.Text != string.Empty)
                txtPass.Select();
        }
    }
}
