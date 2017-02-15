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
    public partial class frmProyectos : Form
    {
        #region Metodos
        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_Proyectos();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "No.";
                grdDatos.Columns[1].HeaderText = "No. Promotor";
                grdDatos.Columns[2].HeaderText = "Promotor";
                grdDatos.Columns[3].HeaderText = "Nombre";
                grdDatos.Columns[4].HeaderText = "Número de viviendas";
                grdDatos.Columns[5].HeaderText = "Fecha de apertura";
                grdDatos.Columns[6].HeaderText = "Fecha de vencimiento";
                grdDatos.Columns[7].HeaderText = "Monto de crédito en pesos";
                grdDatos.Columns[8].HeaderText = "Monto desembolsado en pesos";
                grdDatos.Columns[9].HeaderText = "Tipo de amortización";
                grdDatos.Columns[10].HeaderText = "Administración";
                grdDatos.Columns[11].HeaderText = "Spread";
                grdDatos.Columns[12].HeaderText = "Activo";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
                grdDatos.Columns[4].ReadOnly = true;
                grdDatos.Columns[5].ReadOnly = true;
                grdDatos.Columns[6].ReadOnly = true;
                grdDatos.Columns[7].ReadOnly = true;
                grdDatos.Columns[8].ReadOnly = true;
                grdDatos.Columns[9].ReadOnly = true;
                grdDatos.Columns[10].ReadOnly = true;
                grdDatos.Columns[11].ReadOnly = true;
                grdDatos.Columns[12].ReadOnly = true;
                grdDatos.Columns[1].Visible = false;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de orígenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_Promotores();

            cboIngPromotor.ValueMember = "Prom_Id";
            cboIngPromotor.DisplayMember = "Prom_Nombre";
            cboIngPromotor.DataSource = Resultado.Resultado;

            cboModPromotor.ValueMember = "Prom_Id";
            cboModPromotor.DisplayMember = "Prom_Nombre";
            cboModPromotor.DataSource = Resultado.Resultado;

            cboIngAdministracion.ValueMember = "Valor";
            cboIngAdministracion.DisplayMember = "Descripcion";
            cboIngAdministracion.DataSource = clsGeneral.ddlAdminCred;

            cboModAdministracion.ValueMember = "Valor";
            cboModAdministracion.DisplayMember = "Descripcion";
            cboModAdministracion.DataSource = clsGeneral.ddlAdminCred;
        }

        public frmProyectos()
        {
            InitializeComponent();
        }
        #endregion Metodos
        #region Eventos
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_I_Proyectos, vBit_DatosPrevios: null);
            clsGeneral.Proyecto Proyecto = new clsGeneral.Proyecto((int)cboIngPromotor.SelectedValue, txtIngNombre.Text, (int)txtIngNumViviendas.Value,
                    dtpIngFechaApertura.Value, dtpIngFechaVencimiento.Value, txtIngMontoCredPesos.Value, txtIngMontoDesembolsadoPesos.Value,
                    txtIngTipoAmortizacion.Text, cboIngAdministracion.SelectedValue.ToString(), txtIngSpread.Value, chkIngActivo.Checked);

            Resultado = clsBD.Catalogos_I_Proyectos(Proyecto);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_PromotoresBitacora(Resultado.Resultado);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un proyecto.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboIngPromotor.SelectedIndex = 0;
                    txtIngNombre.Text = string.Empty;
                    txtIngNumViviendas.Value = 1;
                    dtpIngFechaApertura.Value = DateTime.Now;
                    dtpIngFechaVencimiento.Value = DateTime.Now;
                    txtIngMontoCredPesos.Value = 0;
                    txtIngMontoDesembolsadoPesos.Value = 0;
                    txtIngTipoAmortizacion.Text = string.Empty;
                    if (cboIngAdministracion.Items.Count > 0) { cboIngAdministracion.SelectedIndex = 0; }
                    txtIngSpread.Value = 0;
                    chkIngActivo.Checked = false;
                    cboIngPromotor.Focus();
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
            CargarCombos();

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

                txtModId.Value = (int)dr.Cells["Proy_Id"].Value;
                cboModPromotor.SelectedValue = (int)dr.Cells["Prom_Id"].Value;
                txtModNombre.Text = dr.Cells["Proy_Nombre"].Value.ToString();
                txtModNumViviendas.Value = (int)dr.Cells["Proy_Numero_Viviendas"].Value;
                dtpModFechaApertura.Value = clsGeneral.ObtieneFecha(dr.Cells["Proy_Fecha_Apertura"].Value.ToString());
                dtpModFechaVencimiento.Value = clsGeneral.ObtieneFecha(dr.Cells["Proy_Fecha_Vencimiento"].Value.ToString());
                txtModMontoCredPesos.Value = (decimal)dr.Cells["Proy_Monto_Credito_Pesos"].Value;
                txtModMontoDesembolsadoPesos.Value = (decimal)dr.Cells["Proy_Monto_Desembolsado_Pesos"].Value;
                txtModTipoAmortizacion.Text = dr.Cells["Proy_Tipo_Amortizacion"].Value.ToString();
                if (cboModAdministracion.Items.Count > 0) { cboModAdministracion.SelectedValue = dr.Cells["Proy_Administracion"].Value.ToString(); }
                txtModSpread.Value = (decimal)dr.Cells["Proy_Spread"].Value;

                if (dr.Cells["Proy_Activo"].Value.ToString() == "S")
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

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_Proyectos, vBit_DatosPrevios: null);
            clsGeneral.Proyecto Proyecto = new clsGeneral.Proyecto((int)cboModPromotor.SelectedValue, txtModNombre.Text, (int)txtModNumViviendas.Value,
                dtpModFechaApertura.Value, dtpModFechaVencimiento.Value, (decimal)txtModMontoCredPesos.Value, (decimal)txtModMontoDesembolsadoPesos.Value,
                txtModTipoAmortizacion.Text, cboModAdministracion.SelectedValue.ToString(), (decimal)txtModSpread.Value, chkModActivo.Checked, vProy_Id: (int)txtModId.Value);

            Resultado = clsBD.Catalogos_C_ProyectosBitacora((int)txtModId.Value);

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Catalogos_U_Proyectos(Proyecto);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en el proyecto.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_Proyectos, null);

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

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            cboIngPromotor.DrawMode = DrawMode.OwnerDrawFixed;
            cboIngPromotor.DrawItem += cboIngPromotor_DrawItem;
            cboIngPromotor.DropDownClosed += cboIngPromotor_DropDownClosed;
            cboIngPromotor.LostFocus += cboIngPromotor_LostFocus;

            cboModPromotor.DrawMode = DrawMode.OwnerDrawFixed;
            cboModPromotor.DrawItem += cboModPromotor_DrawItem;
            cboModPromotor.DropDownClosed += cboModPromotor_DropDownClosed;
            cboModPromotor.LostFocus += cboModPromotor_LostFocus;

            CargarCombos();
        }

        private void cboIngPromotor_LostFocus(object sender, EventArgs e)
        {
            tip01.Hide(cboIngPromotor);
        }

        private void cboIngPromotor_DropDownClosed(object sender, EventArgs e)
        {
            tip01.Hide(cboIngPromotor);
        }

        private void cboIngPromotor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = cboIngPromotor.GetItemText(cboIngPromotor.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { tip01.Show(text, cboIngPromotor, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void cboModPromotor_LostFocus(object sender, EventArgs e)
        {
            tip01.Hide(cboModPromotor);
        }

        private void cboModPromotor_DropDownClosed(object sender, EventArgs e)
        {
            tip01.Hide(cboModPromotor);
        }

        private void cboModPromotor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = cboModPromotor.GetItemText(cboModPromotor.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { tip01.Show(text, cboModPromotor, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }
        #endregion Eventos
    }
}
