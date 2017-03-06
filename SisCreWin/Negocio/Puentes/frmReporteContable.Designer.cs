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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFechasGen = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.btnExportarDetalle = new System.Windows.Forms.Button();
            this.grdDatosDet = new System.Windows.Forms.DataGridView();
            this.btnCerrarPanel = new System.Windows.Forms.Button();
            this.btnExportarRExcel = new System.Windows.Forms.Button();
            this.btnAyudaP = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.chkP = new System.Windows.Forms.CheckBox();
            this.cboFechas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkU = new System.Windows.Forms.CheckBox();
            this.chkFF = new System.Windows.Forms.CheckBox();
            this.chkFI = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTopSel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grdDatosR = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboCierresGenerados = new System.Windows.Forms.ComboBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wkr02 = new System.ComponentModel.BackgroundWorker();
            this.wkr03 = new System.ComponentModel.BackgroundWorker();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.tab01.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDet)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosR)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabPage2);
            this.tab01.Controls.Add(this.tabPage1);
            this.tab01.Controls.Add(this.tabPage3);
            this.tab01.Location = new System.Drawing.Point(17, 17);
            this.tab01.Margin = new System.Windows.Forms.Padding(5);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(1001, 479);
            this.tab01.TabIndex = 1;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdDatos);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(993, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generar cierre mensual";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.grdDatos.Location = new System.Drawing.Point(242, 17);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.ShowEditingIcon = false;
            this.grdDatos.Size = new System.Drawing.Size(742, 423);
            this.grdDatos.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnExportarExcel);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboFechasGen);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(225, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(14, 79);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(201, 30);
            this.btnExportarExcel.TabIndex = 2;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 117);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(200, 30);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar cierre";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha:";
            // 
            // cboFechasGen
            // 
            this.cboFechasGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFechasGen.FormattingEnabled = true;
            this.cboFechasGen.Location = new System.Drawing.Point(15, 46);
            this.cboFechasGen.Margin = new System.Windows.Forms.Padding(4);
            this.cboFechasGen.Name = "cboFechasGen";
            this.cboFechasGen.Size = new System.Drawing.Size(200, 25);
            this.cboFechasGen.TabIndex = 1;
            this.cboFechasGen.SelectedIndexChanged += new System.EventHandler(this.cboFechasGen_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlDetalle);
            this.tabPage1.Controls.Add(this.btnExportarRExcel);
            this.tabPage1.Controls.Add(this.btnAyudaP);
            this.tabPage1.Controls.Add(this.gbFiltros);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.grdDatosR);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(993, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultar cierres generados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.Controls.Add(this.btnExportarDetalle);
            this.pnlDetalle.Controls.Add(this.grdDatosDet);
            this.pnlDetalle.Controls.Add(this.btnCerrarPanel);
            this.pnlDetalle.Location = new System.Drawing.Point(728, 8);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(28, 36);
            this.pnlDetalle.TabIndex = 13;
            this.pnlDetalle.Visible = false;
            // 
            // btnExportarDetalle
            // 
            this.btnExportarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarDetalle.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarDetalle.Location = new System.Drawing.Point(-78, 2);
            this.btnExportarDetalle.Name = "btnExportarDetalle";
            this.btnExportarDetalle.Size = new System.Drawing.Size(32, 32);
            this.btnExportarDetalle.TabIndex = 13;
            this.tip01.SetToolTip(this.btnExportarDetalle, "Exportar a Excel");
            this.btnExportarDetalle.UseVisualStyleBackColor = true;
            this.btnExportarDetalle.Click += new System.EventHandler(this.btnExportarDetalle_Click);
            // 
            // grdDatosDet
            // 
            this.grdDatosDet.AllowUserToAddRows = false;
            this.grdDatosDet.AllowUserToDeleteRows = false;
            this.grdDatosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatosDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDatosDet.Location = new System.Drawing.Point(12, 40);
            this.grdDatosDet.Name = "grdDatosDet";
            this.grdDatosDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosDet.Size = new System.Drawing.Size(7, 0);
            this.grdDatosDet.TabIndex = 9;
            // 
            // btnCerrarPanel
            // 
            this.btnCerrarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanel.Location = new System.Drawing.Point(-40, 3);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(59, 31);
            this.btnCerrarPanel.TabIndex = 0;
            this.btnCerrarPanel.Text = "Cerrar";
            this.btnCerrarPanel.UseVisualStyleBackColor = true;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // btnExportarRExcel
            // 
            this.btnExportarRExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarRExcel.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarRExcel.Location = new System.Drawing.Point(606, 8);
            this.btnExportarRExcel.Name = "btnExportarRExcel";
            this.btnExportarRExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportarRExcel.TabIndex = 12;
            this.tip01.SetToolTip(this.btnExportarRExcel, "Exportar a Excel");
            this.btnExportarRExcel.UseVisualStyleBackColor = true;
            this.btnExportarRExcel.Click += new System.EventHandler(this.btnExportarRExcel_Click);
            // 
            // btnAyudaP
            // 
            this.btnAyudaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyudaP.BackgroundImage = global::SisCreWin.Properties.Resources.help1600_s;
            this.btnAyudaP.Location = new System.Drawing.Point(574, 8);
            this.btnAyudaP.Name = "btnAyudaP";
            this.btnAyudaP.Size = new System.Drawing.Size(32, 32);
            this.btnAyudaP.TabIndex = 11;
            this.btnAyudaP.UseVisualStyleBackColor = true;
            this.btnAyudaP.Click += new System.EventHandler(this.btnAyudaP_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.chkP);
            this.gbFiltros.Controls.Add(this.cboFechas);
            this.gbFiltros.Controls.Add(this.label10);
            this.gbFiltros.Controls.Add(this.chkU);
            this.gbFiltros.Controls.Add(this.chkFF);
            this.gbFiltros.Controls.Add(this.chkFI);
            this.gbFiltros.Controls.Add(this.btnProcesar);
            this.gbFiltros.Controls.Add(this.cboUsuarios);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.dtpFechaFin);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.dtpFechaIni);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.txtTopSel);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Location = new System.Drawing.Point(644, 33);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(340, 408);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // chkP
            // 
            this.chkP.AutoSize = true;
            this.chkP.Location = new System.Drawing.Point(317, 115);
            this.chkP.Name = "chkP";
            this.chkP.Size = new System.Drawing.Size(15, 14);
            this.chkP.TabIndex = 7;
            this.chkP.UseVisualStyleBackColor = true;
            this.chkP.CheckedChanged += new System.EventHandler(this.chkP_CheckedChanged);
            // 
            // cboFechas
            // 
            this.cboFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFechas.Enabled = false;
            this.cboFechas.FormattingEnabled = true;
            this.cboFechas.Location = new System.Drawing.Point(129, 109);
            this.cboFechas.Name = "cboFechas";
            this.cboFechas.Size = new System.Drawing.Size(182, 25);
            this.cboFechas.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Periodo:";
            // 
            // chkU
            // 
            this.chkU.AutoSize = true;
            this.chkU.Location = new System.Drawing.Point(317, 146);
            this.chkU.Name = "chkU";
            this.chkU.Size = new System.Drawing.Size(15, 14);
            this.chkU.TabIndex = 9;
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
            this.btnProcesar.Location = new System.Drawing.Point(129, 171);
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
            this.cboUsuarios.Location = new System.Drawing.Point(129, 140);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(182, 25);
            this.cboUsuarios.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha final:";
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha inicial:";
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
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Resultados máx.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cierres mensuales generados en el sistema:";
            // 
            // grdDatosR
            // 
            this.grdDatosR.AllowUserToAddRows = false;
            this.grdDatosR.AllowUserToDeleteRows = false;
            this.grdDatosR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatosR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDatosR.Location = new System.Drawing.Point(11, 41);
            this.grdDatosR.Name = "grdDatosR";
            this.grdDatosR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosR.Size = new System.Drawing.Size(627, 400);
            this.grdDatosR.TabIndex = 8;
            this.grdDatosR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosR_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboCierresGenerados);
            this.tabPage3.Controls.Add(this.btnAutorizar);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(993, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Regenerar cierre";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboCierresGenerados
            // 
            this.cboCierresGenerados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCierresGenerados.FormattingEnabled = true;
            this.cboCierresGenerados.Location = new System.Drawing.Point(173, 32);
            this.cboCierresGenerados.Name = "cboCierresGenerados";
            this.cboCierresGenerados.Size = new System.Drawing.Size(150, 25);
            this.cboCierresGenerados.TabIndex = 1;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(173, 64);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(150, 25);
            this.btnAutorizar.TabIndex = 2;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha del documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccione el periodo que desea autorizar para volverse a generar:";
            // 
            // wkr01
            // 
            this.wkr01.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr01_DoWork);
            this.wkr01.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr01_RunWorkerCompleted);
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
            // wkr02
            // 
            this.wkr02.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr02_DoWork);
            this.wkr02.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr02_RunWorkerCompleted);
            // 
            // wkr03
            // 
            this.wkr03.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr03_DoWork);
            this.wkr03.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr03_RunWorkerCompleted);
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
            this.Text = "Generar / consultar cierre contable mensual de créditos puente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporteContable_FormClosing);
            this.Load += new System.EventHandler(this.frmReporteContable_Load);
            this.tab01.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDet)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosR)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFechasGen;
        private System.ComponentModel.BackgroundWorker wkr02;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboCierresGenerados;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker wkr03;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarRExcel;
        private System.Windows.Forms.Button btnAyudaP;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckBox chkU;
        private System.Windows.Forms.CheckBox chkFF;
        private System.Windows.Forms.CheckBox chkFI;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtTopSel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdDatosR;
        private System.Windows.Forms.CheckBox chkP;
        private System.Windows.Forms.ComboBox cboFechas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView grdDatosDet;
        private System.Windows.Forms.Button btnCerrarPanel;
        private System.Windows.Forms.Button btnExportarDetalle;
    }
}