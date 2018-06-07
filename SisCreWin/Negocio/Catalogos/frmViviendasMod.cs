using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SisCreWin.BD;
using SisCreWin.Modelo;

namespace SisCreWin.Negocio.Catalogos
{
    public partial class frmViviendasMod : Form
    {
        #region Variables

        private int PViv_Id = 0;

        #endregion Variables

        #region Metodos

        public frmViviendasMod()
        {
            InitializeComponent();
        }

        private void ValoresIniciales()
        {
            string[] selectedColumns = new[] { "Proy_Id", "Proy_Nombre" };
            DataView dv = clsBD.Catalogos_C_Proyectos(true).Resultado.DefaultView;

            dv.Sort = "Proy_Nombre asc";

            DataTable dt = dv.ToTable(false, selectedColumns);
            DataRow dr;

            dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "Todos los proyectos";
            dt.Rows.InsertAt(dr, 0);

            cboProyectos.DisplayMember = "Proy_Nombre";
            cboProyectos.ValueMember = "Proy_Id";
            cboProyectos.DataSource = dt;

            cboEstadosMod.DisplayMember = "Valor";
            cboEstadosMod.ValueMember = "Id";
            cboEstadosMod.DataSource = clsBD.Catalogos_C_ViviendasEstados().Resultado;

            dt = new DataTable();
            dt = clsBD.Catalogos_C_ViviendasEstados().Resultado;
            dt.Columns[1].MaxLength = 20;
            dr = dt.NewRow();
            dr[0] = "";
            dr[1] = "Todos los estados";
            dt.Rows.InsertAt(dr, 0);

            cboEstados.DisplayMember = "Valor";
            cboEstados.ValueMember = "Id";
            cboEstados.DataSource = dt;

            grdDatos.DataSource = null;

            txtReferenciaMod.Text = string.Empty;
            txtCUVMod.Text = string.Empty;
            txtUbicacionMod.Text = string.Empty;
            numMontoCredMod.Value = 0;
            numMontoMinPenMod.Value = 0;
            numMontoPagoPenMod.Value = 0;
            numMontoSaldoPenMod.Value = 0;
            numSaldoInsolutoMod.Value = 0;
            dtpFechaMod.Value = DateTime.Now;
            dtpFechaMod.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1).AddMilliseconds(-10);
            cboEstados.SelectedIndex = 0;

            PViv_Id = 0;
            gbDatos.Enabled = false;
        }

        #endregion Metodos

        #region Eventos

        private void frmViviendasMod_Load(object sender, EventArgs e)
        {
            cboProyectos.DrawMode = DrawMode.OwnerDrawFixed;
            cboProyectos.DrawItem += cboProyectos_DrawItem;
            cboProyectos.DropDownClosed += cboProyectos_DropDownClosed;
            cboProyectos.LostFocus += cboProyectos_LostFocus;

            ValoresIniciales();
        }

        private void cboProyectos_LostFocus(object sender, EventArgs e)
        {
            tip01.Hide(cboProyectos);
        }

        private void cboProyectos_DropDownClosed(object sender, EventArgs e)
        {
            tip01.Hide(cboProyectos);
        }

        private void cboProyectos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = cboProyectos.GetItemText(cboProyectos.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { tip01.Show(text, cboProyectos, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCUV.Text = txtCUV.Text.Trim();
            txtUbicacion.Text = txtUbicacion.Text.Trim();

            try
            {
                grdDatos.DataSource = clsBD.Catalogos_C_BuscarVivienda((int)cboProyectos.SelectedValue, Convert.ToInt32(numCredito.Value), txtCUV.Text, txtUbicacion.Text, cboEstados.SelectedValue.ToString()).Resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar vivienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gbDatos.Enabled = (grdDatos.Rows.Count > 0);
            gbResultados.Text = "Resultado de búsqueda (" + grdDatos.Rows.Count.ToString() + ")";
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDatos.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = grdDatos.SelectedRows[0];
                PViv_Id = 0;

                int.TryParse(dr.Cells["Id"].Value.ToString(), out PViv_Id);

                gbDatos.Enabled = (PViv_Id > 0);

                if (PViv_Id > 0)
                {
                    ResultadoStored_DT Res = clsBD.Catalogos_C_ViviendasInformacionIndividual(PViv_Id);

                    if (!Res.HayError)
                    {
                        if (Res.Resultado.Rows.Count > 0)
                        {
                            txtReferenciaMod.Text = Res.Resultado.Rows[0]["PViv_Referencia"].ToString();
                            txtCUVMod.Text = Res.Resultado.Rows[0]["PViv_CUV"].ToString();
                            txtUbicacionMod.Text = Res.Resultado.Rows[0]["PViv_Ubicacion"].ToString();
                            numMontoCredMod.Value = Convert.ToDecimal(Res.Resultado.Rows[0]["PViv_MontoCredito"]);
                            numMontoMinPenMod.Value = Convert.ToDecimal(Res.Resultado.Rows[0]["PViv_MontoMinPendiente"]);
                            numMontoPagoPenMod.Value = Convert.ToDecimal(Res.Resultado.Rows[0]["PViv_MontoPagoPendiente"]);
                            numMontoSaldoPenMod.Value = Convert.ToDecimal(Res.Resultado.Rows[0]["PViv_MontoSaldoPendiente"]);
                            numSaldoInsolutoMod.Value = Convert.ToDecimal(Res.Resultado.Rows[0]["PViv_SaldoInsoluto"]);
                            dtpFechaMod.Value = Convert.ToDateTime(Res.Resultado.Rows[0]["PViv_FechaUltimoPago"] != DBNull.Value ? Res.Resultado.Rows[0]["PViv_FechaUltimoPago"] : new DateTime(1900, 1, 1));
                            cboEstadosMod.SelectedValue = Res.Resultado.Rows[0]["PViv_Estatus"];
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron valores para la vivienda seleccionada", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Res.Error, "Error al cargar datos de vivienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            DateTime? Fecha = dtpFechaMod.Value;

            if (new DateTime(dtpFechaMod.Value.Year, dtpFechaMod.Value.Month, dtpFechaMod.Value.Day) == new DateTime(1900, 1, 1))
                Fecha = null;

            ResultadoStored_Str Res = new ResultadoStored_Str();
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_Viviendas, vBit_DatosPrevios: null);
            clsGeneral.Vivienda vivienda = new clsGeneral.Vivienda(PViv_Id, 0, 0, 0,
                txtReferenciaMod.Text.Trim(),
                txtCUVMod.Text.Trim(),
                txtUbicacionMod.Text.Trim(),
                numMontoCredMod.Value,
                numMontoMinPenMod.Value,
                numMontoPagoPenMod.Value,
                numMontoSaldoPenMod.Value,
                numSaldoInsolutoMod.Value,
                Fecha,
                cboEstadosMod.SelectedValue.ToString());

            Res = clsBD.Catalogos_C_ViviendasBitacora(vivienda.PViv_Id);

            if (!Res.HayError)
            {
                Bitacora.Bit_DatosPrevios = clsGeneral.Zip(Res.Resultado);
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);

                Res = new ResultadoStored_Str();
                Res = clsBD.Catalogos_U_Viviendas(vivienda);

                if (!Res.HayError)
                {
                    MessageBox.Show("Se ha actualizado la vivienda seleccionada", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValoresIniciales();
                }
                else
                {
                    MessageBox.Show(Res.Error, "Error al actualizar datos de vivienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Res.Error, "Errores en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ResultadoExport exp = new BD.ResultadoExport();

            exp = clsBD.ExportarExcel(CatalogoStoreds.Catalogos_C_BuscarVivienda, null);

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

        #endregion Eventos
    }
}