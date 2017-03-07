using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCreWin
{
    public partial class frmSplash : Form
    {
        private Image GIFAnim = global::SisCreWin.Properties.Resources.splash_screen_animated_fast_1loop;
        private int frames;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmr01_Tick(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();

            //frm.Show();
            //this.Hide();
        }

        private void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            frames = GIFAnim.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
            TransparetBackground(lblMsj);
        }

        private void pbAni_Paint(object sender, PaintEventArgs e)
        {
            if (frames > 0)
            {
                frames -= 1;
            }
            else
            {
                pbAni.Image = global::SisCreWin.Properties.Resources.splash_screen_animated_frame1;
                this.Close();
            }
        }
    }
}
