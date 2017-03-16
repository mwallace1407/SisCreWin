namespace SisCreWin.Negocio.Puentes
{
    partial class frmReporteContable
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
            this.tab01 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grdPDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPUsarFechaFinal = new System.Windows.Forms.CheckBox();
            this.dtpPFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.chkPUsarFechaInicial = new System.Windows.Forms.CheckBox();
            this.btnPExportar = new System.Windows.Forms.Button();
            this.btnPVisualizar = new System.Windows.Forms.Button();
            this.dtpPFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.wkr04 = new System.ComponentModel.BackgroundWorker();
            this.tab01.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabPage4);
            this.tab01.Location = new System.Drawing.Point(17, 17);
            this.tab01.Margin = new System.Windows.Forms.Padding(5);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(1001, 479);
            this.tab01.TabIndex = 1;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grdPDatos);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(993, 449);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporte de saldos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grdPDatos
            // 
            this.grdPDatos.AllowUserToAddRows = false;
            this.grdPDatos.AllowUserToDeleteRows = false;
            this.grdPDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdPDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdPDatos.Location = new System.Drawing.Point(244, 11);
            this.grdPDatos.MultiSelect = false;
            this.grdPDatos.Name = "grdPDatos";
            this.grdPDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPDatos.Size = new System.Drawing.Size(746, 435);
            this.grdPDatos.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkPUsarFechaFinal);
            this.groupBox1.Controls.Add(this.dtpPFechaFinal);
            this.groupBox1.Controls.Add(this.chkPUsarFechaInicial);
            this.groupBox1.Controls.Add(this.btnPExportar);
            this.groupBox1.Controls.Add(this.btnPVisualizar);
            this.groupBox1.Controls.Add(this.dtpPFechaInicial);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 443);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // chkPUsarFechaFinal
            // 
            this.chkPUsarFechaFinal.AutoSize = true;
            this.chkPUsarFechaFinal.Checked = true;
            this.chkPUsarFechaFinal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPUsarFechaFinal.Location = new System.Drawing.Point(6, 175);
            this.chkPUsarFechaFinal.Name = "chkPUsarFechaFinal";
            this.chkPUsarFechaFinal.Size = new System.Drawing.Size(97, 21);
            this.chkPUsarFechaFinal.TabIndex = 3;
            this.chkPUsarFechaFinal.Text = "Fecha final";
            this.tip01.SetToolTip(this.chkPUsarFechaFinal, "Usar fecha de movimiento");
            this.chkPUsarFechaFinal.UseVisualStyleBackColor = true;
            this.chkPUsarFechaFinal.Visible = false;
            this.chkPUsarFechaFinal.CheckedChanged += new System.EventHandler(this.chkPUsarFechaFinal_CheckedChanged);
            // 
            // dtpPFechaFinal
            // 
            this.dtpPFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPFechaFinal.Location = new System.Drawing.Point(6, 202);
            this.dtpPFechaFinal.Name = "dtpPFechaFinal";
            this.dtpPFechaFinal.Size = new System.Drawing.Size(223, 23);
            this.dtpPFechaFinal.TabIndex = 4;
            this.dtpPFechaFinal.Visible = false;
            this.dtpPFechaFinal.ValueChanged += new System.EventHandler(this.dtpPFechaFinal_ValueChanged);
            // 
            // chkPUsarFechaInicial
            // 
            this.chkPUsarFechaInicial.AutoSize = true;
            this.chkPUsarFechaInicial.Checked = true;
            this.chkPUsarFechaInicial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPUsarFechaInicial.Location = new System.Drawing.Point(6, 148);
            this.chkPUsarFechaInicial.Name = "chkPUsarFechaInicial";
            this.chkPUsarFechaInicial.Size = new System.Drawing.Size(107, 21);
            this.chkPUsarFechaInicial.TabIndex = 1;
            this.chkPUsarFechaInicial.Text = "Fecha inicial";
            this.tip01.SetToolTip(this.chkPUsarFechaInicial, "Usar fecha de movimiento");
            this.chkPUsarFechaInicial.UseVisualStyleBackColor = true;
            this.chkPUsarFechaInicial.Visible = false;
            this.chkPUsarFechaInicial.CheckedChanged += new System.EventHandler(this.chkPUsarFechaInicial_CheckedChanged);
            // 
            // btnPExportar
            // 
            this.btnPExportar.Location = new System.Drawing.Point(6, 113);
            this.btnPExportar.Name = "btnPExportar";
            this.btnPExportar.Size = new System.Drawing.Size(223, 29);
            this.btnPExportar.TabIndex = 6;
            this.btnPExportar.Text = "Exportar reporte a Excel";
            this.btnPExportar.UseVisualStyleBackColor = true;
            this.btnPExportar.Click += new System.EventHandler(this.btnPExportar_Click);
            // 
            // btnPVisualizar
            // 
            this.btnPVisualizar.Location = new System.Drawing.Point(6, 78);
            this.btnPVisualizar.Name = "btnPVisualizar";
            this.btnPVisualizar.Size = new System.Drawing.Size(223, 29);
            this.btnPVisualizar.TabIndex = 5;
            this.btnPVisualizar.Text = "Visualizar";
            this.btnPVisualizar.UseVisualStyleBackColor = true;
            this.btnPVisualizar.Click += new System.EventHandler(this.btnPVisualizar_Click);
            // 
            // dtpPFechaInicial
            // 
            this.dtpPFechaInicial.CustomFormat = "MMMM yyyy";
            this.dtpPFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPFechaInicial.Location = new System.Drawing.Point(6, 49);
            this.dtpPFechaInicial.Name = "dtpPFechaInicial";
            this.dtpPFechaInicial.Size = new System.Drawing.Size(223, 23);
            this.dtpPFechaInicial.TabIndex = 2;
            this.tip01.SetToolTip(this.dtpPFechaInicial, "Al seleccionar cualquier fecha de un mes el sistema automáticamente asignará el ú" +
        "ltimo día de ese mes");
            this.dtpPFechaInicial.ValueChanged += new System.EventHandler(this.dtpPFechaInicial_ValueChanged);
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
            this.pnlProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgreso.Name = "pnlProgreso";
            this.pnlProgreso.Size = new System.Drawing.Size(249, 239);
            this.pnlProgreso.TabIndex = 4;
            this.pnlProgreso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SisCreWin.Properties.Resources.gears_animated_t;
            this.pictureBox1.Location = new System.Drawing.Point(52, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procesando...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // wkr04
            // 
            this.wkr04.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr04_DoWork);
            this.wkr04.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr04_RunWorkerCompleted);
            // 
            // frmReporteContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 513);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(835, 459);
            this.Name = "frmReporteContable";
            this.Text = "Consultar cartera a fecha determinada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporteContable_FormClosing);
            this.Load += new System.EventHandler(this.frmReporteContable_Load);
            this.tab01.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grdPDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPUsarFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpPFechaFinal;
        private System.Windows.Forms.CheckBox chkPUsarFechaInicial;
        private System.Windows.Forms.Button btnPExportar;
        private System.Windows.Forms.Button btnPVisualizar;
        private System.Windows.Forms.DateTimePicker dtpPFechaInicial;
        private System.ComponentModel.BackgroundWorker wkr04;
        private System.Windows.Forms.Label label1;
    }
}