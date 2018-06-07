using System;
using System.Data;
using System.Windows.Forms;
using SisCreWin.BD;

namespace SisCreWin
{
    public partial class frmInfo : Form
    {
        private void ParametrosSistema()
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable(), string.Empty, false);
            DataTable Parametros = new DataTable();
            DataRow dr;

            Parametros.Columns.Add("Concepto");
            Parametros.Columns.Add("Valor");
            Resultado = clsBD.Negocio_C_DatosDelSistema();

            BaseConectada baseC = clsBD.ObtenerBaseConectada();
            DatosStatusBar sb = clsBD.Negocio_C_FechasDelSistema(Resultado);

            for (int w = 0; w < Resultado.Resultado.Columns.Count; w++)
            {
                dr = Parametros.NewRow();
                dr[0] = Resultado.Resultado.Columns[w].ColumnName;
                dr[1] = Resultado.Resultado.Rows[0][w].ToString();
                Parametros.Rows.Add(dr);
            }

            Parametros.AcceptChanges();
            grdInfo.DataSource = Parametros;
        }

        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            ParametrosSistema();
            tmrMtto.Start();
        }

        private void tmrMtto_Tick(object sender, EventArgs e)
        {
            ParametrosSistema();
        }

        private void frmInfo_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}