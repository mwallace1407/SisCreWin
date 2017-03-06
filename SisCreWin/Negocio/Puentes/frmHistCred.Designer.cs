namespace SisCreWin.Negocio.Puentes
{
    partial class frmHistCred
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUsarFechaFinal = new System.Windows.Forms.CheckBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUsarFechaInicial = new System.Windows.Forms.CheckBox();
            this.chkUsarCredito = new System.Windows.Forms.CheckBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNumeroPrestamo = new System.Windows.Forms.ComboBox();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.btnExportarDet = new System.Windows.Forms.Button();
            this.tab01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabPage1);
            this.tab01.Location = new System.Drawing.Point(16, 16);
            this.tab01.Margin = new System.Windows.Forms.Padding(4);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(1010, 471);
            this.tab01.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdDetalle);
            this.tabPage1.Controls.Add(this.grdDatos);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1002, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDatos.Location = new System.Drawing.Point(248, 16);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(747, 234);
            this.grdDatos.TabIndex = 13;
            this.grdDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnExportarDet);
            this.groupBox1.Controls.Add(this.chkUsarFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkUsarFechaInicial);
            this.groupBox1.Controls.Add(this.chkUsarCredito);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNumeroPrestamo);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // chkUsarFechaFinal
            // 
            this.chkUsarFechaFinal.AutoSize = true;
            this.chkUsarFechaFinal.Checked = true;
            this.chkUsarFechaFinal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsarFechaFinal.Location = new System.Drawing.Point(11, 134);
            this.chkUsarFechaFinal.Name = "chkUsarFechaFinal";
            this.chkUsarFechaFinal.Size = new System.Drawing.Size(15, 14);
            this.chkUsarFechaFinal.TabIndex = 5;
            this.tip01.SetToolTip(this.chkUsarFechaFinal, "Usar fecha de movimiento");
            this.chkUsarFechaFinal.UseVisualStyleBackColor = true;
            this.chkUsarFechaFinal.CheckedChanged += new System.EventHandler(this.chkUsarFechaFinal_CheckedChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(11, 151);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(218, 23);
            this.dtpFechaFinal.TabIndex = 6;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha final:";
            // 
            // chkUsarFechaInicial
            // 
            this.chkUsarFechaInicial.AutoSize = true;
            this.chkUsarFechaInicial.Checked = true;
            this.chkUsarFechaInicial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsarFechaInicial.Location = new System.Drawing.Point(11, 77);
            this.chkUsarFechaInicial.Name = "chkUsarFechaInicial";
            this.chkUsarFechaInicial.Size = new System.Drawing.Size(15, 14);
            this.chkUsarFechaInicial.TabIndex = 3;
            this.tip01.SetToolTip(this.chkUsarFechaInicial, "Usar fecha de movimiento");
            this.chkUsarFechaInicial.UseVisualStyleBackColor = true;
            this.chkUsarFechaInicial.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkUsarCredito
            // 
            this.chkUsarCredito.AutoSize = true;
            this.chkUsarCredito.Checked = true;
            this.chkUsarCredito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsarCredito.Location = new System.Drawing.Point(11, 22);
            this.chkUsarCredito.Name = "chkUsarCredito";
            this.chkUsarCredito.Size = new System.Drawing.Size(15, 14);
            this.chkUsarCredito.TabIndex = 1;
            this.tip01.SetToolTip(this.chkUsarCredito, "Usar número de crédito");
            this.chkUsarCredito.UseVisualStyleBackColor = true;
            this.chkUsarCredito.CheckedChanged += new System.EventHandler(this.chkUsarCredito_CheckedChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(11, 219);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(218, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar saldos a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(11, 190);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(218, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número de crédito:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(11, 94);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(218, 23);
            this.dtpFechaInicial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha inicial:";
            // 
            // cboNumeroPrestamo
            // 
            this.cboNumeroPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumeroPrestamo.FormattingEnabled = true;
            this.cboNumeroPrestamo.Location = new System.Drawing.Point(11, 39);
            this.cboNumeroPrestamo.Name = "cboNumeroPrestamo";
            this.cboNumeroPrestamo.Size = new System.Drawing.Size(218, 25);
            this.cboNumeroPrestamo.TabIndex = 2;
            // 
            // pnlProgreso
            // 
            this.pnlProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlProgreso.Controls.Add(this.pictureBox1);
            this.pnlProgreso.Controls.Add(this.label2);
            this.pnlProgreso.Location = new System.Drawing.Point(1022, 494);
            this.pnlProgreso.Name = "pnlProgreso";
            this.pnlProgreso.Size = new System.Drawing.Size(205, 197);
            this.pnlProgreso.TabIndex = 3;
            this.pnlProgreso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SisCreWin.Properties.Resources.gears_animated_t;
            this.pictureBox1.Location = new System.Drawing.Point(32, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 173);
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
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDetalle.Location = new System.Drawing.Point(248, 256);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(747, 178);
            this.grdDetalle.TabIndex = 26;
            // 
            // btnExportarDet
            // 
            this.btnExportarDet.Location = new System.Drawing.Point(11, 248);
            this.btnExportarDet.Name = "btnExportarDet";
            this.btnExportarDet.Size = new System.Drawing.Size(218, 23);
            this.btnExportarDet.TabIndex = 16;
            this.btnExportarDet.Text = "Exportar detalle a Excel";
            this.btnExportarDet.UseVisualStyleBackColor = true;
            this.btnExportarDet.Click += new System.EventHandler(this.btnExportarDet_Click);
            // 
            // frmHistCred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 502);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHistCred";
            this.Text = "Consultar historial de créditos puente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHistCred_FormClosing);
            this.Load += new System.EventHandler(this.frmHistCred_Load);
            this.tab01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNumeroPrestamo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.CheckBox chkUsarFechaInicial;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.CheckBox chkUsarCredito;
        private System.Windows.Forms.CheckBox chkUsarFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Button btnExportarDet;
    }
}