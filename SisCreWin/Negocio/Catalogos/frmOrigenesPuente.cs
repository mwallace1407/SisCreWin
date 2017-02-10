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
    public partial class frmOrigenesPuente : Form
    {
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
                grdDatos.Columns[2].HeaderText = "Id de proyecto";
                grdDatos.Columns[3].HeaderText = "Número de viviendas";
                grdDatos.Columns[4].HeaderText = "Fecha de apertura";
                grdDatos.Columns[5].HeaderText = "Fecha de vencimiento";
                grdDatos.Columns[6].HeaderText = "Estado";
                grdDatos.Columns[0].ReadOnly = true;
                grdDatos.Columns[1].ReadOnly = true;
                grdDatos.Columns[2].ReadOnly = true;
                grdDatos.Columns[3].ReadOnly = true;
                grdDatos.Columns[4].ReadOnly = true;
                grdDatos.Columns[5].ReadOnly = true;
                grdDatos.Columns[6].ReadOnly = true;
            }
            else
            {
                MessageBox.Show(Resultado.Error, "Error al obtener datos de orígenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_I_OrigenCreditosPuente, vBit_DatosPrevios: null);
            clsGeneral.OrigenCreditosPuente OCP = new clsGeneral.OrigenCreditosPuente((int)txtIngId.Value, txtIngOrigen.Text.Trim(), (int)txtIngIdProyecto.Value,
                    (int)txtIngNumViviendas.Value, dtpIngFechaApertura.Value, dtpIngFechaVencimiento.Value, txtIngEstado.Text.Trim());

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
                    txtIngIdProyecto.Value = 1;
                    txtIngNumViviendas.Value = 1;
                    dtpIngFechaApertura.Value = DateTime.Now;
                    dtpIngFechaVencimiento.Value = DateTime.Now;
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
                txtModIdProyecto.Value = (int)dr.Cells["OCP_Id_Proyecto"].Value;
                txtModNumViviendas.Value = (int)dr.Cells["OCP_Numero_Viviendas"].Value;
                dtpModFechaApertura.Value = clsGeneral.ObtieneFecha(dr.Cells["OCP_Fecha_Apertura"].Value.ToString());
                dtpModFechaVencimiento.Value = clsGeneral.ObtieneFecha(dr.Cells["OCP_Fecha_Vencimiento"].Value.ToString());
                txtModEstado.Text = dr.Cells["OCP_Estado"].Value.ToString();
            }
            else
            {
                gbDatos.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str();

            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.Catalogos_U_OrigenCreditosPuente, vBit_DatosPrevios: null);
            clsGeneral.OrigenCreditosPuente OCP = new clsGeneral.OrigenCreditosPuente((int)txtModId.Value, txtModOrigen.Text.Trim(), (int)txtModIdProyecto.Value,
                (int)txtModNumViviendas.Value, dtpModFechaApertura.Value, dtpModFechaVencimiento.Value, txtModEstado.Text.Trim());

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

        private void frmOrigenesPuente_Load(object sender, EventArgs e)
        {

        }
        #endregion Eventos
    }
}
