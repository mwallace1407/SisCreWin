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
using System.IO;
using SisCreWin.Sistema;

namespace SisCreWin.Negocio.Buro
{
    public partial class frmCSVIndividuales : Form
    {
        #region Variables
        string FechaReporte = string.Empty;
        string DirectorioReporte = string.Empty;
        string ErrorProceso = string.Empty;
        string ArchivoProceso = string.Empty;
        DateTime FechaDoc = DateTime.Now;
        bool EnProceso = false;
        #endregion Variables
        #region Metodos
        public frmCSVIndividuales()
        {
            InitializeComponent();
        }

        protected void ProcesarDatos(DataTable DT, string Archivo)
        {
            string Linea = string.Empty;

            using (StreamWriter outfile = new StreamWriter(Archivo, true, Encoding.Default))
            {
                outfile.AutoFlush = true;
                outfile.NewLine = Environment.NewLine;

                for (int w = 0; w < DT.Columns.Count; w++)
                {
                    Linea += DT.Columns[w].ColumnName + ",";
                }

                outfile.WriteLine(Linea);

                for (int w = 0; w < DT.Rows.Count; w++)
                {
                    Linea = string.Empty;

                    for (int w2 = 0; w2 < DT.Columns.Count; w2++)
                    {
                        Linea += DT.Rows[w][w2].ToString() + ",";
                    }

                    outfile.WriteLine(Linea);
                }
            }
        }

        private void CargaValoresIniciales()
        {
            cboFechas.DisplayMember = "Descripcion";
            cboFechas.ValueMember = "Valor";
            cboFechas.DataSource = clsBD.Buro_C_PeriodosDisponiblesIndividuales().Resultado;

            if (cboFechas.Items.Count == 0)
            {
                btnCrear.Enabled = false;
                MessageBox.Show("No hay periodos disponibles para generar el CSV", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnCrear.Enabled = true;
            }
        }

        private void CargarPeriodosCreados()
        {
            cboPeriodosCreados.DisplayMember = "Descripcion";
            cboPeriodosCreados.ValueMember = "Valor";
            cboPeriodosCreados.DataSource = clsBD.Buro_C_PeriodosDisponiblesIndividuales(true).Resultado;

            if (cboPeriodosCreados.Items.Count == 0)
                btnAutorizar.Enabled = false;
            else
                btnAutorizar.Enabled = true;
        }
        #endregion Metodos
        #region Eventos
        private void tab01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab01.SelectedIndex == 0)
            {
                CargaValoresIniciales();
            }
            else if (tab01.SelectedIndex == 1)
            {
                clsGeneral.RespuestaAcceso Respuesta = new Modelo.clsGeneral.RespuestaAcceso();

                Respuesta = clsGeneral.ValidarAccesoUsuario(Global.Usr_Id, CatalogoModulos.Buro_Individuales_RegenerarCSV);

                if (!Respuesta.Permitido)
                {
                    MessageBox.Show(Respuesta.Mensaje, Respuesta.Titulo, MessageBoxButtons.OK, Respuesta.MsgIcon);
                    tab01.SelectedIndex = 0;
                }
                else
                {
                    CargarPeriodosCreados();
                }
            }
        }

        private void frmCSVIndividuales_Load(object sender, EventArgs e)
        {
            CargaValoresIniciales();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            fbd01.ShowDialog(this);

            if (!Directory.Exists(fbd01.SelectedPath))
            {
                MessageBox.Show("El directorio seleccionado no existe.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DirectorioReporte = fbd01.SelectedPath;
            FechaReporte = cboFechas.SelectedValue.ToString();
            FechaDoc = clsGeneral.ObtieneFecha(cboFechas.Text);
            pnlProgreso.Size = new Size(this.Width - 6, this.Height - 6);
            pnlProgreso.Location = new Point(3, 3);
            pnlProgreso.Visible = true;
            ErrorProceso = string.Empty;
            EnProceso = true;
            Sistema.Global.ProcesosPendientes = true;
            wkr01.RunWorkerAsync();
        }

        private void wkr01_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();
            
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(Sistema.Global.Usr_Id, CatalogoStoreds.ReportesBuro_C_CreditosIndividuales, vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @FECHA_DEL_REPORTE = " + FechaReporte));
            Resultado = clsBD.ReportesBuro_C_CreditosIndividuales(FechaReporte);

            if (!Resultado.HayError)
            {
                ArchivoProceso = Path.Combine(DirectorioReporte, clsGeneral.GeneraNombreArchivoRnd("BuroInd_", "csv"));
                ProcesarDatos(Resultado.Resultado, ArchivoProceso);


                clsGeneral.BuroHistoricoIndividuales Buro = new clsGeneral.BuroHistoricoIndividuales(Sistema.Global.Usr_Id, vBHI_Documento: clsGeneral.Zip(System.IO.File.ReadAllText(ArchivoProceso, Encoding.Default), clsGeneral.Codificaciones.ANSI));
                clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Global.Usr_Id, FechaDoc.Year, FechaDoc.Month, "I", vBDG_Documento: clsGeneral.Zip(System.IO.File.ReadAllText(ArchivoProceso, Encoding.Default), clsGeneral.Codificaciones.ANSI));

                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                clsBD.Buro_I_HistoricoIndividuales(Buro);
                clsBD.Buro_M_Documentos(BuroDoc);
            }
            else
            {
                ErrorProceso = Resultado.Error;
            }
        }

        private void wkr01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ArchivoProceso);
            }
            catch { }

            pnlProgreso.Visible = false;
            EnProceso = false;
            Sistema.Global.ProcesosPendientes = false;
            CargaValoresIniciales();

            if (ErrorProceso != string.Empty)
                MessageBox.Show(ErrorProceso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmCSVIndividuales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(EnProceso)
            {
                e.Cancel = true;
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT();

            DateTime FechaReporteAut = clsGeneral.ObtieneFecha(cboPeriodosCreados.Text);
            clsGeneral.BitacoraMovimientosSistema Bitacora = new clsGeneral.BitacoraMovimientosSistema(
                Sistema.Global.Usr_Id,
                CatalogoStoreds.Buro_U_AutorizarRecreacion,
                vBit_DatosPrevios: clsGeneral.Zip("Parámetros: @BDG_Anno = " + FechaReporteAut.Year.ToString() +
                    " BDG_Mes = " + FechaReporteAut.Month.ToString() +
                    " BDG_Tipo = I"));


            ResultadoStored_Str Resultado2 = new ResultadoStored_Str();
            clsGeneral.BuroDocumentos BuroDoc = new clsGeneral.BuroDocumentos(Global.Usr_Id, FechaReporteAut.Year, FechaReporteAut.Month, "I");
            
            if (MessageBox.Show("¿Está seguro de autorizar el reproceso de el documento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clsBD.Bitacoras_I_MovimientosSistema(Bitacora);
                Resultado2 = clsBD.Buro_U_AutorizarRecreacion(BuroDoc);

                if (!Resultado.HayError)
                {
                    CargarPeriodosCreados();
                    MessageBox.Show("Se ha autorizado el reproceso del documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Resultado.Error, "Error al autorizar periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Eventos
    }
}
