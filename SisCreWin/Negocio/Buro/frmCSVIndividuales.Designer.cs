namespace SisCreWin.Negocio.Buro
{
    partial class frmCSVIndividuales
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
            this.tab01 = new System.Windows.Forms.TabControl();
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.cboFechas = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRecrear = new System.Windows.Forms.TabPage();
            this.cboPeriodosCreados = new System.Windows.Forms.ComboBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.fbd01 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabCargar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.wkr02 = new System.ComponentModel.BackgroundWorker();
            this.ofd01 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.wkr03 = new System.ComponentModel.BackgroundWorker();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.tabRecrear.SuspendLayout();
            this.pnlProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCargar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabCrear);
            this.tab01.Controls.Add(this.tabRecrear);
            this.tab01.Controls.Add(this.tabCargar);
            this.tab01.Location = new System.Drawing.Point(14, 14);
            this.tab01.Margin = new System.Windows.Forms.Padding(5);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(751, 341);
            this.tab01.TabIndex = 1;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.cboFechas);
            this.tabCrear.Controls.Add(this.btnCrear);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.label1);
            this.tabCrear.Location = new System.Drawing.Point(4, 26);
            this.tabCrear.Margin = new System.Windows.Forms.Padding(5);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(5);
            this.tabCrear.Size = new System.Drawing.Size(743, 311);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // cboFechas
            // 
            this.cboFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFechas.FormattingEnabled = true;
            this.cboFechas.Location = new System.Drawing.Point(176, 46);
            this.cboFechas.Name = "cboFechas";
            this.cboFechas.Size = new System.Drawing.Size(150, 25);
            this.cboFechas.TabIndex = 6;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(176, 78);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 25);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Generar CSV";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha del documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca los valores requeridos:";
            // 
            // tabRecrear
            // 
            this.tabRecrear.Controls.Add(this.cboPeriodosCreados);
            this.tabRecrear.Controls.Add(this.btnAutorizar);
            this.tabRecrear.Controls.Add(this.label4);
            this.tabRecrear.Controls.Add(this.label5);
            this.tabRecrear.Location = new System.Drawing.Point(4, 26);
            this.tabRecrear.Name = "tabRecrear";
            this.tabRecrear.Size = new System.Drawing.Size(743, 311);
            this.tabRecrear.TabIndex = 1;
            this.tabRecrear.Text = "Recrear CSV";
            this.tabRecrear.UseVisualStyleBackColor = true;
            // 
            // cboPeriodosCreados
            // 
            this.cboPeriodosCreados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodosCreados.FormattingEnabled = true;
            this.cboPeriodosCreados.Location = new System.Drawing.Point(176, 46);
            this.cboPeriodosCreados.Name = "cboPeriodosCreados";
            this.cboPeriodosCreados.Size = new System.Drawing.Size(150, 25);
            this.cboPeriodosCreados.TabIndex = 10;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(176, 78);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(150, 25);
            this.btnAutorizar.TabIndex = 9;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha del documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione el periodo que desea autorizar para volverse a generar:";
            // 
            // pnlProgreso
            // 
            this.pnlProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlProgreso.Controls.Add(this.pictureBox1);
            this.pnlProgreso.Controls.Add(this.label2);
            this.pnlProgreso.Location = new System.Drawing.Point(3000, 3000);
            this.pnlProgreso.Name = "pnlProgreso";
            this.pnlProgreso.Size = new System.Drawing.Size(214, 203);
            this.pnlProgreso.TabIndex = 2;
            this.pnlProgreso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SisCreWin.Properties.Resources.gears_animated_t;
            this.pictureBox1.Location = new System.Drawing.Point(35, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procesando...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // wkr01
            // 
            this.wkr01.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr01_DoWork);
            this.wkr01.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr01_RunWorkerCompleted);
            // 
            // fbd01
            // 
            this.fbd01.Description = "Seleccione una carpeta para depositar el archivo";
            // 
            // tabCargar
            // 
            this.tabCargar.Controls.Add(this.btnCargarDatos);
            this.tabCargar.Controls.Add(this.groupBox1);
            this.tabCargar.Controls.Add(this.btnExaminar);
            this.tabCargar.Controls.Add(this.label6);
            this.tabCargar.Location = new System.Drawing.Point(4, 26);
            this.tabCargar.Name = "tabCargar";
            this.tabCargar.Size = new System.Drawing.Size(743, 311);
            this.tabCargar.TabIndex = 2;
            this.tabCargar.Text = "Cargar CSV";
            this.tabCargar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione el archivo que desea importar:";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(300, 22);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(92, 25);
            this.btnExaminar.TabIndex = 9;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // wkr02
            // 
            this.wkr02.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr02_DoWork);
            this.wkr02.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr02_RunWorkerCompleted);
            // 
            // ofd01
            // 
            this.ofd01.DefaultExt = "*.cvs";
            this.ofd01.Filter = "Archivos CSV|*.csv";
            this.ofd01.Title = "Seleccione el archivo a cargar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalReg);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 83);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen del archivo CSV seleccionado:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(6, 22);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 17);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave: N/A";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: N/A";
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.Location = new System.Drawing.Point(6, 56);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(149, 17);
            this.lblTotalReg.TabIndex = 2;
            this.lblTotalReg.Text = "Total de registros: N/A";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Enabled = false;
            this.btnCargarDatos.Location = new System.Drawing.Point(280, 142);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(112, 25);
            this.btnCargarDatos.TabIndex = 11;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // wkr03
            // 
            this.wkr03.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr03_DoWork);
            this.wkr03.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr03_RunWorkerCompleted);
            // 
            // frmCSVIndividuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 369);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCSVIndividuales";
            this.Text = "Generar CSV para individuales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCSVIndividuales_FormClosing);
            this.Load += new System.EventHandler(this.frmCSVIndividuales_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.tabRecrear.ResumeLayout(false);
            this.tabRecrear.PerformLayout();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCargar.ResumeLayout(false);
            this.tabCargar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbd01;
        private System.Windows.Forms.ComboBox cboFechas;
        private System.Windows.Forms.TabPage tabRecrear;
        private System.Windows.Forms.ComboBox cboPeriodosCreados;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabCargar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker wkr02;
        private System.Windows.Forms.OpenFileDialog ofd01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.ComponentModel.BackgroundWorker wkr03;
    }
}