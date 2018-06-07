using System;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Catalogos
{
    public partial class frmOrigenesPuente : Form
    {
        private DateTime? FechaLiq = null;

        #region Metodos

        private void CargarGrid()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_OrigenCreditosPuente();

            if (!Resultado.HayError)
            {
                grdDatos.DataSource = Resultado.Resultado;
                grdDatos.Columns[0].HeaderText = "Crédito";
                grdDatos.Columns[1].HeaderText = "Origen";
                grdDatos.Columns[2].HeaderText = "Proyecto";
                grdDatos.Columns[3].HeaderText = "Dación o Adjudicación";
                grdDatos.Columns[4].HeaderText = "Fecha de liquidación";
                grdDatos.Columns[5].HeaderText = "Estado";
                grdDatos.Columns[6].HeaderText = "Id de proyecto";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
                grdDatos.Columns[4].ReadOnly = true;
                grdDatos.Columns[5].ReadOnly = true;
                grdDatos.Columns[6].ReadOnly = true;
                grdDatos.Columns[6].Visible = false;

                grdDatos.AlternatingRowsDefaultCellStyle.BackColor = Sistema.Global.ColorAltGrid;
                clsGeneral.FormatoResaltadoGrid(ref grdDatos, "OCP_Estado", "LIQUIDADO");
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de orígenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            ResultadoStored_DT Resultado = new BD.ResultadoStored_DT();

            Resultado = clsBD.Catalogos_C_Proyectos();

            if (!Resultado.HayError)
            {
                cboIngProyectos.DisplayMember = "Prom_Nombre";
                cboIngProyectos.ValueMember = "Prom_Id";
                cboIngProyectos.DataSource = Resultado.Resultado;

                Resultado = new BD.ResultadoStored_DT();
                Resultado = clsBD.Catalogos_C_Proyectos(true);
                cboModProyectos.DisplayMember = "Prom_Nombre";
                cboModProyectos.ValueMember = "Prom_Id";
                cboModProyectos.DataSource = Resultado.Resultado;

                cboModEstado.DisplayMember = "Descripcion";
                cboModEstado.ValueMember = "Valor";
                cboModEstado.DataSource = clsGeneral.ddlActLiq;

                cboIngDacionAdju.DisplayMember = "Descripcion";
                cboIngDacionAdju.ValueMember = "Valor";
                cboIngDacionAdju.DataSource = clsGeneral.ddlSiNo2;

                cboModDacionAdju.DisplayMember = "Descripcion";
                cboModDacionAdju.ValueMember = "Valor";
                cboModDacionAdju.DataSource = clsGeneral.ddlSiNo2;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmOrigenesPuente()
        {
            InitializeComponent();
        }

        #endregion Metodos

        #region Eventos

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ResultadoStored_Int Resultado = new ResultadoStored_Int();

            if (!chkIngNoLiquidado.Checked)
                FechaLiq = dtpIngFechaLiquidacion.Value;
            else
                FechaLiq = null;

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_I_OrigenCreditosPuente, vBit_DatosPrevios: null);
            clsGeneral.OrigenCreditosPuente OCP = new clsGeneral.OrigenCreditosPuente((int)txtIngId.Value, txtIngOrigen.Text.Trim(), (int)cboIngProyectos.SelectedValue, txtIngEstado.Text.Trim(),
                    cboIngDacionAdju.SelectedValue.ToString(), FechaLiq);

            Resultado = clsBD.Catalogos_I_OrigenCreditosPuente(OCP);

            if (!Resultado.HayError)
            {
                if (Resultado.Resultado > 0)
                {
                    ResultadoStored_Str ResultadoS = new ResultadoStored_Str();

                    ResultadoS = clsBD.Catalogos_C_OrigenCreditosPuenteBitacora(Resultado.Resultado);
                    Bitacora.Bit_DatosPrevios = clsGeneral.Zip(ResultadoS.Resultado);
                    clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                    MessageBox.Show("Se ha agregado un origen.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIngId.Value = 1;
                    txtIngOrigen.Text = string.Empty;
                    if (cboIngProyectos.Items.Count > 0) { cboIngProyectos.SelectedIndex = 0; }
                    if (cboIngDacionAdju.Items.Count > 0) { cboIngDacionAdju.SelectedIndex = 0; }
                    dtpIngFechaLiquidacion.Value = DateTime.Now;
                    txtIngEstado.Text = string.Empty;
                    txtIngId.Focus();
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
                CargarGrid();
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                gbDatos.Visible = true;
                DataGridViewRow dr = grdDatos.SelectedRows[0];

                txtModId.Value = (int)dr.Cells["OCP_Prestamo"].Value;
                txtModOrigen.Text = dr.Cells["OCP_Origen_Prestamo"].Value.ToString();
                if (cboModProyectos.Items.Count > 0) { cboIngProyectos.SelectedValue = (int)dr.Cells["OCP_Id_Proyecto"].Value; }
                if (cboModDacionAdju.Items.Count > 0) { cboModDacionAdju.SelectedValue = dr.Cells["OCP_Dacion_o_Adjudicacion"].Value; }
                if (cboModEstado.Items.Count > 0) { cboModEstado.SelectedValue = dr.Cells["OCP_Estado"].Value; }

                if (clsGeneral.ObtieneFecha(dr.Cells["OCP_Fecha_Liquidacion"].Value.ToString()).ToString("dd/MM/yyyy") == "01/01/1900")
                {
                    dtpModFechaLiquidacion.Value = clsGeneral.ObtieneFecha(DateTime.Now.ToString("dd/MM/yyyy"));
                    dtpModFechaLiquidacion.Enabled = false;
                    chkModNoLiquidado.Checked = true;
                }
                else
                {
                    dtpModFechaLiquidacion.Value = clsGeneral.ObtieneFecha(dr.Cells["OCP_Fecha_Liquidacion"].Value.ToString());
                    dtpModFechaLiquidacion.Enabled = true;
                    chkModNoLiquidado.Checked = false;
                }
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            if (!chkModNoLiquidado.Checked)
                FechaLiq = dtpModFechaLiquidacion.Value;
            else
                FechaLiq = null;

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_OrigenCreditosPuente, vBit_DatosPrevios: null);
            clsGeneral.OrigenCreditosPuente OCP = new clsGeneral.OrigenCreditosPuente((int)txtModId.Value, txtModOrigen.Text.Trim(), (int)cboModProyectos.SelectedValue, cboModEstado.SelectedValue.ToString(),
                cboModDacionAdju.SelectedValue.ToString(), FechaLiq);

            Resultado = clsBD.Catalogos_C_OrigenCreditosPuenteBitacora(OCP.OCP_Prestamo);

            if (!Resultado.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Resultado.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Resultado = new ResultadoStored_Str();
                Resultado = clsBD.Catalogos_U_OrigenCreditosPuente(OCP);

                if (!Resultado.HayError)
                {
                    MessageBox.Show("Se han realizado los cambios en el origen", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_OrigenCreditosPuente, null);

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

            //System.Diagnostics.Process.Start(lblArchivo.Text);
        }

        private void frmOrigenesPuente_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void chkIngNoLiquidado_CheckedChanged(object sender, EventArgs e)
        {
            dtpIngFechaLiquidacion.Enabled = !chkIngNoLiquidado.Checked;
        }

        private void chkModNoLiquidado_CheckedChanged(object sender, EventArgs e)
        {
            dtpModFechaLiquidacion.Enabled = !chkModNoLiquidado.Checked;
        }

        private void tabModificar_Click(object sender, EventArgs e)
        {
        }

        #endregion Eventos
    }
}