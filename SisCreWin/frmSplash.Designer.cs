namespace SisCreWin
{
    partial class frmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.tmr01 = new System.Windows.Forms.Timer(this.components);
            this.pbAni = new System.Windows.Forms.PictureBox();
            this.lblMsj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAni)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr01
            // 
            this.tmr01.Interval = 1000;
            this.tmr01.Tick += new System.EventHandler(this.tmr01_Tick);
            // 
            // pbAni
            // 
            this.pbAni.Image = global::SisCreWin.Properties.Resources.splash_screen_animated_fast_1loop;
            this.pbAni.Location = new System.Drawing.Point(0, 0);
            this.pbAni.Name = "pbAni";
            this.pbAni.Size = new System.Drawing.Size(500, 500);
            this.pbAni.TabIndex = 0;
            this.pbAni.TabStop = false;
            this.pbAni.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAni_Paint);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMsj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.White;
            this.lblMsj.Location = new System.Drawing.Point(85, 467);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(331, 24);
            this.lblMsj.TabIndex = 1;
            this.lblMsj.Text = "Cargando módulos del sistema";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.pbAni);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr01;
        private System.Windows.Forms.PictureBox pbAni;
        private System.Windows.Forms.Label lblMsj;
    }
}