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
using SisCreWin.BD;

namespace SisCreWin
{
    public partial class frmMain : Form
    {
        #region Variables
        DataTable ModulosFecuentes = new DataTable();
        #endregion Variables
        #region Propiedades
        #endregion Propiedades
        #region Metodos
        public frmMain()
        {
            InitializeComponent();
        }

        private void AbrirVentana(int Mod_Id)
        {
            //frmModulos frm2 = new frmModulos();

            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(frmModulos))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            
            //Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Catalogos_Modulos_ABC);

            //if (Respuesta.Permitido)
            //{
            //    frm2.MdiParent = this;
            //    frm2.Icon = SisCreWin.Properties.Resources.favicon;
            //    frm2.Show();
            //}
            //else
            //{
            //    MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            //}

            Form frmGen = null;
            bool Mod_Multiple = false;
            clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();
            ResultadoStored_DT Resultado = new BD.ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_DatosModulo(Mod_Id);

            if(Resultado.Resultado.Rows.Count > 0)
            {
                bool.TryParse(Resultado.Resultado.Rows[0]["Mod_Multiple"].ToString(), out Mod_Multiple);
            }

            switch (Mod_Id)
            {
                case 1:
                    frmGen = new frmModulos();
                    break;
                case 2:
                    frmGen = new frmUsuarios();
                    break;
                case 3:
                    frmGen = new frmPromotores();
                    break;
                case 4:
                    frmGen = new frmProyectos();
                    break;
                case 5:
                    frmGen = new frmINTFPuentes();
                    break;
                case 6:
                    frmGen = new frmTIIE();
                    break;
                case 7:
                    frmGen = new frmOrigenesPuente();
                    break;
                case 8:
                    frmGen = new frmCSVIndividuales();
                    break;
                case 9:
                    frmGen = new frmCierreDiario();
                    break;
                case 10:
                    frmGen = new frmRegistroPago();
                    break;
                case 11:
                    frmGen = new frmUsuarios();
                    break;
                case 12:
                    frmGen = new frmBitacoraMov();
                    break;
                case 13:
                    frmGen = new frmHistInd();
                    break;
                case 14:
                    frmGen = new frmHistPuentes();
                    break;
                case 15:
                    frmGen = new frmHistCred();
                    break;
                case 16:
                    frmGen = new frmCSVIndividuales();
                    break;
                case 17:
                    frmGen = new frmINTFPuentes();
                    break;
                case 18:
                    frmGen = new frmParametros();
                    break;
                case 19:
                    frmGen = new frmReporteContable();
                    break;
                case 20:
                    frmGen = new frmReporteContable();
                    break;
                case 21:
                    frmGen = new frmTiposPagoPuentes();
                    break;
                default:
                    break;
            }

            if (!Mod_Multiple)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == frmGen.GetType())
                    {
                        form.Activate();
                        return;
                    }
                }
            }

            Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, Mod_Id);

            if (Respuesta.Permitido)
            {
                frmGen.MdiParent = this;
                frmGen.Icon = SisCreWin.Properties.Resources.favicon;
                frmGen.Show();
            }
            else
            {
                MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
            }
        }

        private void ProcesarFecuentes()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Sistema_C_Top10PaginasUsuario(Global.Usr_Id);

            if(!Resultado.HayError)
            {
                for (int w = 0; w < Resultado.Resultado.Rows.Count; w++)
                {
                    try
                    {
                        ToolStripItem[] itm = mnuMain.Items.Find("mnuFreq" + (w + 1).ToString(), true);

                        if(itm.Count() > 0)
                        {
                            if(itm[0].Name == "mnuFreq" + (w + 1).ToString())
                            {
                                itm[0].Text = Resultado.Resultado.Rows[w]["Nombre"].ToString();
                                itm[0].ToolTipText = Resultado.Resultado.Rows[w]["Descripcion"].ToString();
                                itm[0].Visible = true;
                            }
                        }
                    }
                    catch { }
                }

                mnuModulosFreq.Visible = true;
            }
            else
            {
                mnuModulosFreq.Visible = false;
                MessageBox.Show("No se pudo obtener la lista para su usuario", "Módulos frecuentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion Metodos
        #region Eventos
        private void frmMain_Load(object sender, EventArgs e)
        {
            BaseConectada baseC = clsBD.ObtenerBaseConectada();
            DatosStatusBar sb = clsBD.Negocio_C_FechasDelSistema();

            this.Text = this.Text + " - " + Global.Usuario;
            tmrMtto.Enabled = true;
            tmrMtto.Start();
            ProcesarFecuentes();
            stBaseConectada.Text = baseC.BaseDatos;
            stBaseConectada.ToolTipText = baseC.Detalle;
            stFechasSistema.Text = sb.Titulo;
            stFechasSistema.ToolTipText = sb.Detalle;
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
            AbrirVentana(CatalogoModulos.Usuarios_ABC);
        }

        private void mnuModulos_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Catalogos_Modulos_ABC);
        }

        private void mnuOrigenesPuente_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Puentes_OCP_ABC);
        }

        private void mnuPromotores_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Promotores_ABC);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuProyectos_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Proyectos_ABC);
        }

        private void mnuTIIE_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Catalogos_TIIE_ABC);
        }

        private void mnuCSVIndividuales_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Buro_Individuales_GenerarCSV);
        }

        private void mnuINTFPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Buro_Puentes_GenerarINTF);
        }

        private void mnuCierreDiarioPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Puentes_GenerarCierre);
        }

        private void mnuRegistrarPagoPuente_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Puentes_RegistrarPago);
        }

        private void mnuBitacoraMov_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Bitacora_Movimientos);
        }

        private void mnuBuroHistInd_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Buro_Individuales_Historico);
        }

        private void mnuBuroHistPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Buro_Puentes_Historico);
        }

        private void mnuHistoricoPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Puentes_Historico);
        }

        private void mnuMttoSist_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Sistema_Mantenimiento);
        }

        private void mnuRptContaPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Puentes_ReporteContable);
        }

        private void mnuTiposPagoPuentes_Click(object sender, EventArgs e)
        {
            AbrirVentana(CatalogoModulos.Catalogos_TiposPagoPuentes_ABC);
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion Eventos
    }
}
