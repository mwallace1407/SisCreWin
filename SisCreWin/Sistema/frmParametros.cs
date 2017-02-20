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
    public partial class frmParametros : Form
    {
        #region Metodos
        private void CargarValoresIniciales()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Usuarios_C_Usuarios();
            cboUsuarios.DisplayMember = "Usr_Nombre";
            cboUsuarios.ValueMember = "Usr_Id";
            cboUsuarios.DataSource = Resultado.Resultado;

            Resultado = new ResultadoStored_DT();
            Resultado = clsBD.Sistema_C_ParametrosMantenimiento();

            for (int w = 0; w < Resultado.Resultado.Rows.Count; w++)
            {
                if(Resultado.Resultado.Rows[w]["Param_Llave"].ToString() == "SisMant")
                {
                    if (Resultado.Resultado.Rows[w]["Param_Valor"].ToString() == "0")
                        chkActivo.Checked = false;
                    else
                        chkActivo.Checked = true;
                }

                if (Resultado.Resultado.Rows[w]["Param_Llave"].ToString() == "UsuMant")
                {
                    cboUsuarios.SelectedValue = Convert.ToInt32(Resultado.Resultado.Rows[w]["Param_Valor"].ToString());
                }
            }

            lblActualizacion.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion Metodos
        #region Eventos
        public frmParametros()
        {
            InitializeComponent();
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new BD.ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Sistema_U_ParametrosMantenimiento, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @SisMant = " + ((chkActivo.Checked) ? "1" : "0") + "; @UsuMant = " + cboUsuarios.SelectedValue.ToString()));

            Resultado = clsBD.Sistema_U_ParametrosMantenimiento((chkActivo.Checked) ? "1" : "0", cboUsuarios.SelectedValue.ToString());

            if(!Resultado.HayError)
            {
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                MessageBox.Show("Proceso satisfacoriamente finalizado", "Mantenimiento del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarValoresIniciales();
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Eventos
    }
}
