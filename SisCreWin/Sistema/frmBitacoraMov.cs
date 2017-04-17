using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Sistema
{
    public partial class frmBitacoraMov : Form
    {
        #region Variables
        private DateTime? Fecha_Ini = null;
        private DateTime? Fecha_Fin = null;
        private string Procedimiento = null;
        private int? Usr_Id = null;
        private int TopSel = 100;
        #endregion Variables
        #region Metodos
        public frmBitacoraMov()
        {
            InitializeComponent();
        }

        private void CargarDatosIniciales()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            txtTopSel.Value = 100;
            dtpFechaFin.MaxDate = clsGeneral.ObtieneFecha(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")).AddMilliseconds(-1);
            dtpFechaFin.Value = dtpFechaFin.MaxDate;
            dtpFechaIni.MaxDate = clsGeneral.ObtieneFecha(DateTime.Now.ToString("dd/MM/yyyy"));
            dtpFechaIni.Value = dtpFechaIni.MaxDate;

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

            Resultado = new ResultadoStored_DT();
            Resultado = clsBD.Catalogos_C_Procedimientos();

            if (!Resultado.HayError)
            {
                cboProcedimientos.DisplayMember = "Valor";
                cboProcedimientos.ValueMember = "Descripcion";
                cboProcedimientos.DataSource = Resultado.Resultado;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de procedimientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarGrid();
        }

        private void AsignarVariables()
        {
            TopSel = (int)txtTopSel.Value;

            if (chkFI.Checked)
            {
                Fecha_Ini = clsGeneral.ObtieneFecha(dtpFechaIni.Value.ToString("dd/MM/yyyy"));
                dtpFechaIni.Enabled = true;
            }
            else
            {
                Fecha_Ini = null;
                dtpFechaIni.Enabled = false;
            }

            if (chkFF.Checked)
            {
                Fecha_Fin = dtpFechaFin.Value;
                dtpFechaFin.Enabled = true;
            }
            else
            {
                Fecha_Fin = null;
                dtpFechaFin.Enabled = false;
            }

            if (chkU.Checked)
            {
                Usr_Id = (int)cboUsuarios.SelectedValue;
                cboUsuarios.Enabled = true;
            }
            else
            {
                Usr_Id = null;
                cboUsuarios.Enabled = false;
            }

            if (chkP.Checked)
            {
                Procedimiento = cboProcedimientos.SelectedValue.ToString();
                cboProcedimientos.Enabled = true;
            }
            else
            {
                Procedimiento = null;
                cboProcedimientos.Enabled = false;
            }
        }

        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Bitacoras_C_MovimientosSistema(Fecha_Ini, Fecha_Fin, Procedimiento, Usr_Id, TopSel);
            grdDatos.DataSource = null;

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado.Rows.Count > 0)
                {
                    if (Resultado.Resultado.Rows.Count <= 100)
                        grdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    grdDatos.DataSource = Resultado.Resultado;
                    grdDatos.Columns[0].HeaderText = "No.";
                    grdDatos.Columns[1].HeaderText = "Usuario";
                    grdDatos.Columns[2].HeaderText = "Fecha";
                    grdDatos.Columns[3].HeaderText = "Procedimiento";
                    grdDatos.Columns[0].ReadOnly = true;
                    grdDatos.Columns[1].ReadOnly = true;
                    grdDatos.Columns[2].ReadOnly = true;
                    grdDatos.Columns[3].ReadOnly = true;

                    grdDatos.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para su búsqueda", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de bitácora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Metodos
        #region Eventos
        private void frmBitacoraMov_Load(object sender, EventArgs e)
        {
            cboProcedimientos.DrawMode = DrawMode.OwnerDrawFixed;
            cboProcedimientos.DrawItem += cboProcedimientos_DrawItem;
            cboProcedimientos.DropDownClosed += cboProcedimientos_DropDownClosed;
            cboProcedimientos.LostFocus += cboProcedimientos_LostFocus;

            cboUsuarios.DrawMode = DrawMode.OwnerDrawFixed;
            cboUsuarios.DrawItem += cboUsuarios_DrawItem;
            cboUsuarios.DropDownClosed += cboUsuarios_DropDownClosed;
            cboUsuarios.LostFocus += cboUsuarios_LostFocus;

            CargarDatosIniciales();
        }

        private void cboProcedimientos_LostFocus(object sender, EventArgs e)
        {
            tip01.Hide(cboProcedimientos);
        }

        private void cboProcedimientos_DropDownClosed(object sender, EventArgs e)
        {
            tip01.Hide(cboProcedimientos);
        }

        private void cboProcedimientos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = cboProcedimientos.GetItemText(cboProcedimientos.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { tip01.Show(text, cboProcedimientos, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void cboUsuarios_LostFocus(object sender, EventArgs e)
        {
            tip01.Hide(cboUsuarios);
        }

        private void cboUsuarios_DropDownClosed(object sender, EventArgs e)
        {
            tip01.Hide(cboUsuarios);
        }

        private void cboUsuarios_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = cboUsuarios.GetItemText(cboUsuarios.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { tip01.Show(text, cboUsuarios, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab01.SelectedIndex == 0)
            {
                CargarDatosIniciales();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new BD.ResultadoExport();
            
            exp = clsBD.Bitacoras_C_MovimientosSistema_Exp(Fecha_Ini, Fecha_Fin, Procedimiento, Usr_Id, TopSel);

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
        }

        private void btnAyudaP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ver el detalle del registro se debe dar doble clic sobre el mismo.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkFI_CheckedChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void chkFF_CheckedChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void chkU_CheckedChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void chkP_CheckedChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void txtTopSel_ValueChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            AsignarVariables();

            if (dtpFechaFin.Value < dtpFechaIni.Value)
                dtpFechaIni.Value = dtpFechaIni.MaxDate;
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void cboProcedimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignarVariables();
        }

        private void grdDatosP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = grdDatos.SelectedRows[0];
                ResultadoStored_Byte Resultado = new ResultadoStored_Byte();

                Resultado = clsBD.Bitacoras_C_MovimientosDatos(Convert.ToInt32(dr.Cells["Bit_Id"].Value));

                if (!Resultado.HayError)
                {
                    try
                    {
                        frmTXTModal frm = new Sistema.frmTXTModal();

                        frm.frmAlto = this.Height - 50;
                        frm.frmAncho = this.Width - 50;
                        frm.frmContenido = clsGeneral.Unzip(Resultado.Resultado);
                        frm.frmTitulo = "Detalle del movimiento " + dr.Cells["Bit_Id"].Value.ToString();
                        frm.ShowDialog(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al abrir ventana de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al obtener datos de detalle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Eventos
    }
}
