namespace SisCreWin.Negocio.Buro
{
    partial class frmHistInd
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
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnAyudaP = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.chkU = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.chkFI = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopSel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.tab01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabPage1);
            this.tab01.Controls.Add(this.tabPage2);
            this.tab01.Location = new System.Drawing.Point(16, 16);
            this.tab01.Margin = new System.Windows.Forms.Padding(4);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(999, 460);
            this.tab01.TabIndex = 0;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExportarExcel);
            this.tabPage1.Controls.Add(this.btnAyudaP);
            this.tabPage1.Controls.Add(this.gbFiltros);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grdDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(991, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarExcel.Location = new System.Drawing.Point(606, 7);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportarExcel.TabIndex = 7;
            this.tip01.SetToolTip(this.btnExportarExcel, "Exportar a Excel");
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnAyudaP
            // 
            this.btnAyudaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyudaP.BackgroundImage = global::SisCreWin.Properties.Resources.help1600_s;
            this.btnAyudaP.Location = new System.Drawing.Point(574, 7);
            this.btnAyudaP.Name = "btnAyudaP";
            this.btnAyudaP.Size = new System.Drawing.Size(32, 32);
            this.btnAyudaP.TabIndex = 6;
            this.btnAyudaP.UseVisualStyleBackColor = true;
            this.btnAyudaP.Click += new System.EventHandler(this.btnAyudaP_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.chkU);
            this.gbFiltros.Controls.Add(this.chkFF);
            this.gbFiltros.Controls.Add(this.chkFI);
            this.gbFiltros.Controls.Add(this.btnProcesar);
            this.gbFiltros.Controls.Add(this.cboUsuarios);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.dtpFechaFin);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.dtpFechaIni);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.txtTopSel);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Location = new System.Drawing.Point(644, 32);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(340, 391);
            this.gbFiltros.TabIndex = 2;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // chkU
            // 
            this.chkU.AutoSize = true;
            this.chkU.Location = new System.Drawing.Point(318, 115);
            this.chkU.Name = "chkU";
            this.chkU.Size = new System.Drawing.Size(15, 14);
            this.chkU.TabIndex = 7;
            this.chkU.UseVisualStyleBackColor = true;
            this.chkU.CheckedChanged += new System.EventHandler(this.chkU_CheckedChanged);
            // 
            // chkFF
            // 
            this.chkFF.AutoSize = true;
            this.chkFF.Location = new System.Drawing.Point(317, 85);
            this.chkFF.Name = "chkFF";
            this.chkFF.Size = new System.Drawing.Size(15, 14);
            this.chkFF.TabIndex = 5;
            this.chkFF.UseVisualStyleBackColor = true;
            this.chkFF.CheckedChanged += new System.EventHandler(this.chkFF_CheckedChanged);
            // 
            // chkFI
            // 
            this.chkFI.AutoSize = true;
            this.chkFI.Location = new System.Drawing.Point(317, 56);
            this.chkFI.Name = "chkFI";
            this.chkFI.Size = new System.Drawing.Size(15, 14);
            this.chkFI.TabIndex = 3;
            this.chkFI.UseVisualStyleBackColor = true;
            this.chkFI.CheckedChanged += new System.EventHandler(this.chkFI_CheckedChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(130, 140);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(182, 23);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Filtrar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.Enabled = false;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(130, 109);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(182, 25);
            this.cboUsuarios.TabIndex = 6;
            this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(129, 80);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(182, 23);
            this.dtpFechaFin.TabIndex = 4;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha final:";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIni.Enabled = false;
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(129, 51);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(182, 23);
            this.dtpFechaIni.TabIndex = 2;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechaIni_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha inicial:";
            // 
            // txtTopSel
            // 
            this.txtTopSel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTopSel.Location = new System.Drawing.Point(129, 22);
            this.txtTopSel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtTopSel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTopSel.Name = "txtTopSel";
            this.txtTopSel.Size = new System.Drawing.Size(182, 23);
            this.txtTopSel.TabIndex = 1;
            this.txtTopSel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtTopSel.ValueChanged += new System.EventHandler(this.txtTopSel_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultados máx.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimientos realizados en el sistema:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(11, 40);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(627, 383);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosP_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(991, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadisticas usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmHistInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 489);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmHistInd";
            this.Text = "Consultar archivos CSV generados para individuales";
            this.Load += new System.EventHandler(this.frmBitacoraMov_Load);
            this.tab01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTopSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.Button btnAyudaP;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.CheckBox chkU;
        private System.Windows.Forms.CheckBox chkFF;
        private System.Windows.Forms.CheckBox chkFI;
    }
}