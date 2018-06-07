using System;
using System.Drawing;
using System.Windows.Forms;

namespace SisCreWin.Sistema
{
    public partial class frmTXTModal : Form
    {
        #region Variables

        private int frmHeight = 100;
        private int frmWidth = 100;
        private string frmTitle = string.Empty;
        private string frmContent = string.Empty;

        #endregion Variables

        #region Propiedades

        public int frmAlto
        {
            get { return frmHeight; }
            set { frmHeight = value; }
        }

        public int frmAncho
        {
            get { return frmWidth; }
            set { frmWidth = value; }
        }

        public string frmTitulo
        {
            get { return frmTitle; }
            set { frmTitle = value; }
        }

        public string frmContenido
        {
            get { return frmContent; }
            set { frmContent = value; }
        }

        #endregion Propiedades

        #region Modulos

        public frmTXTModal()
        {
            InitializeComponent();
        }

        #endregion Modulos

        #region Eventos

        private void frmTXTModal_Load(object sender, EventArgs e)
        {
            this.Size = new Size(frmWidth, frmHeight);
            this.Text = frmTitle;
            txtContenido.Text = frmContent;
        }

        #endregion Eventos
    }
}