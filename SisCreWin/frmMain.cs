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
using SisCreWin.Modelo;
using SisCreWin.Negocio;
using SisCreWin.Negocio.Catalogos;
using SisCreWin.Negocio.Buro;
using SisCreWin.Negocio.Puentes;

namespace SisCreWin
{
    public partial class frmMain : Form
    {
        #region Variables
        #endregion Variables
        #region Propiedades
        #endregion Propiedades
        #region Metodos
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + Global.Usuario;
            tmrMtto.Enabled = true;
            tmrMtto.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.ProcesosPendientes)
            {
                MessageBox.Show("Existen procesos pendientes por lo que no se puede cerrar la aplicación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Application.Exit();
            }
        }
        #endregion Metodos
        #region Eventos
        #region Menu
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();
            frmUsuarios frm = new Sistema.frmUsuarios();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmUsuarios))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Usuarios_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuModulos_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();
            frmModulos frm = new frmModulos();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmModulos))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Catalogos_Modulos_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuOrigenesPuente_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();
            frmOrigenesPuente frm = new frmOrigenesPuente();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmOrigenesPuente))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Puentes_OCP_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuPromotores_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();
            frmPromotores frm = new frmPromotores();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmPromotores))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Promotores_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuProyectos_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmProyectos frm = new frmProyectos();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmProyectos))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Proyectos_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuTIIE_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmTIIE frm = new frmTIIE();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmTIIE))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Catalogos_TIIE_ABC);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuCSVIndividuales_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmCSVIndividuales frm = new frmCSVIndividuales();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Individuales_GenerarCSV);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuINTFPuentes_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmINTFPuentes frm = new frmINTFPuentes();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Puentes_GenerarINTF);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuCierreDiarioPuentes_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmCierreDiario frm = new frmCierreDiario();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCierreDiario))
                {
                    form.Activate();
                    return;
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Puentes_GenerarCierre);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuRegistrarPagoPuente_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmRegistroPago frm = new frmRegistroPago();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Puentes_RegistrarPago);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuBitacoraMov_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmBitacoraMov frm = new frmBitacoraMov();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Bitacora_Movimientos);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuBuroHistInd_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmHistInd frm = new frmHistInd();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Individuales_Historico);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void mnuBuroHistPuentes_Click(object sender, EventArgs e)
        {
            clsGeneral.RespuestaAcceso Respuesta = new clsGeneral.RespuestaAcceso();
            frmHistPuentes frm = new frmHistPuentes();

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Puentes_Historico);

            if (Respuesta.Permitido)
            {
                frm.MdiParent = this;
                frm.Icon = SisCreWin.Properties.Resources.favicon;
                frm.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }
        #endregion Menu

        private void tmrMtto_Tick(object sender, EventArgs e)
        {
            if (clsGeneral.SistemaEnMantenimiento(Global.Usr_Id))
            {
                this.Enabled = false;
                stMantenimiento.Visible = true;
            }
            else
            {
                //foreach (Form frm in this.MdiChildren)
                //{
                //    frm.Enabled = true;
                //}
                this.Enabled = true;
                stMantenimiento.Visible = false;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Refresh();
        }
        #endregion Eventos
    }
}
