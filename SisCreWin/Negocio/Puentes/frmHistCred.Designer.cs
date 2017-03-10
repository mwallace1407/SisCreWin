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
            this.tabSaldos = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportarDet = new System.Windows.Forms.Button();
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
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.grdPDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPUsarFechaFinal = new System.Windows.Forms.CheckBox();
            this.dtpPFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPUsarFechaInicial = new System.Windows.Forms.CheckBox();
            this.chkPUsarCredito = new System.Windows.Forms.CheckBox();
            this.btnPExportar = new System.Windows.Forms.Button();
            this.btnPVisualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPNumeroPrestamo = new System.Windows.Forms.ComboBox();
            this.wkr02 = new System.ComponentModel.BackgroundWorker();
            this.tab01.SuspendLayout();
            this.tabSaldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabSaldos);
            this.tab01.Controls.Add(this.tabPagos);
            this.tab01.Location = new System.Drawing.Point(16, 16);
            this.tab01.Margin = new System.Windows.Forms.Padding(4);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(1010, 537);
            this.tab01.TabIndex = 0;
            // 
            // tabSaldos
            // 
            this.tabSaldos.Controls.Add(this.label19);
            this.tabSaldos.Controls.Add(this.label18);
            this.tabSaldos.Controls.Add(this.grdDetalle);
            this.tabSaldos.Controls.Add(this.grdDatos);
            this.tabSaldos.Controls.Add(this.groupBox1);
            this.tabSaldos.Location = new System.Drawing.Point(4, 26);
            this.tabSaldos.Margin = new System.Windows.Forms.Padding(4);
            this.tabSaldos.Name = "tabSaldos";
            this.tabSaldos.Padding = new System.Windows.Forms.Padding(4);
            this.tabSaldos.Size = new System.Drawing.Size(1002, 507);
            this.tabSaldos.TabIndex = 0;
            this.tabSaldos.Text = "Saldos";
            this.tabSaldos.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(245, 302);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Detalle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(245, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Saldos:";
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
            this.grdDetalle.Location = new System.Drawing.Point(248, 322);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(747, 178);
            this.grdDetalle.TabIndex = 26;
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
            this.grdDatos.Location = new System.Drawing.Point(248, 27);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(747, 272);
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
            this.groupBox1.Size = new System.Drawing.Size(235, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // btnExportarDet
            // 
            this.btnExportarDet.Location = new System.Drawing.Point(11, 248);
            this.btnExportarDet.Name = "btnExportarDet";
            this.btnExportarDet.Size = new System.Drawing.Size(218, 23);
            this.btnExportarDet.TabIndex = 9;
            this.btnExportarDet.Text = "Exportar detalle a Excel";
            this.btnExportarDet.UseVisualStyleBackColor = true;
            this.btnExportarDet.Click += new System.EventHandler(this.btnExportarDet_Click);
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
            this.pnlProgreso.Size = new System.Drawing.Size(205, 263);
            this.pnlProgreso.TabIndex = 3;
            this.pnlProgreso.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SisCreWin.Properties.Resources.gears_animated_t;
            this.pictureBox1.Location = new System.Drawing.Point(32, 61);
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
            this.label2.Location = new System.Drawing.Point(54, 206);
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
            // tabPagos
            // 
            this.tabPagos.Controls.Add(this.grdPDatos);
            this.tabPagos.Controls.Add(this.groupBox2);
            this.tabPagos.Location = new System.Drawing.Point(4, 26);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Size = new System.Drawing.Size(1002, 507);
            this.tabPagos.TabIndex = 1;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
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
            this.grdPDatos.Location = new System.Drawing.Point(248, 15);
            this.grdPDatos.MultiSelect = false;
            this.grdPDatos.Name = "grdPDatos";
            this.grdPDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPDatos.Size = new System.Drawing.Size(747, 485);
            this.grdPDatos.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chkPUsarFechaFinal);
            this.groupBox2.Controls.Add(this.dtpPFechaFinal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkPUsarFechaInicial);
            this.groupBox2.Controls.Add(this.chkPUsarCredito);
            this.groupBox2.Controls.Add(this.btnPExportar);
            this.groupBox2.Controls.Add(this.btnPVisualizar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpPFechaInicial);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboPNumeroPrestamo);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 493);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            // 
            // chkPUsarFechaFinal
            // 
            this.chkPUsarFechaFinal.AutoSize = true;
            this.chkPUsarFechaFinal.Checked = true;
            this.chkPUsarFechaFinal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPUsarFechaFinal.Location = new System.Drawing.Point(11, 134);
            this.chkPUsarFechaFinal.Name = "chkPUsarFechaFinal";
            this.chkPUsarFechaFinal.Size = new System.Drawing.Size(15, 14);
            this.chkPUsarFechaFinal.TabIndex = 5;
            this.tip01.SetToolTip(this.chkPUsarFechaFinal, "Usar fecha de movimiento");
            this.chkPUsarFechaFinal.UseVisualStyleBackColor = true;
            this.chkPUsarFechaFinal.CheckedChanged += new System.EventHandler(this.chkPUsarFechaFinal_CheckedChanged);
            // 
            // dtpPFechaFinal
            // 
            this.dtpPFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPFechaFinal.Location = new System.Drawing.Point(11, 151);
            this.dtpPFechaFinal.Name = "dtpPFechaFinal";
            this.dtpPFechaFinal.Size = new System.Drawing.Size(218, 23);
            this.dtpPFechaFinal.TabIndex = 6;
            this.dtpPFechaFinal.ValueChanged += new System.EventHandler(this.dtpPFechaFinal_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha final:";
            // 
            // chkPUsarFechaInicial
            // 
            this.chkPUsarFechaInicial.AutoSize = true;
            this.chkPUsarFechaInicial.Checked = true;
            this.chkPUsarFechaInicial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPUsarFechaInicial.Location = new System.Drawing.Point(11, 77);
            this.chkPUsarFechaInicial.Name = "chkPUsarFechaInicial";
            this.chkPUsarFechaInicial.Size = new System.Drawing.Size(15, 14);
            this.chkPUsarFechaInicial.TabIndex = 3;
            this.tip01.SetToolTip(this.chkPUsarFechaInicial, "Usar fecha de movimiento");
            this.chkPUsarFechaInicial.UseVisualStyleBackColor = true;
            this.chkPUsarFechaInicial.CheckedChanged += new System.EventHandler(this.chkPUsarFechaInicial_CheckedChanged);
            // 
            // chkPUsarCredito
            // 
            this.chkPUsarCredito.AutoSize = true;
            this.chkPUsarCredito.Checked = true;
            this.chkPUsarCredito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPUsarCredito.Location = new System.Drawing.Point(11, 22);
            this.chkPUsarCredito.Name = "chkPUsarCredito";
            this.chkPUsarCredito.Size = new System.Drawing.Size(15, 14);
            this.chkPUsarCredito.TabIndex = 1;
            this.tip01.SetToolTip(this.chkPUsarCredito, "Usar número de crédito");
            this.chkPUsarCredito.UseVisualStyleBackColor = true;
            this.chkPUsarCredito.CheckedChanged += new System.EventHandler(this.chkPUsarCredito_CheckedChanged);
            // 
            // btnPExportar
            // 
            this.btnPExportar.Location = new System.Drawing.Point(11, 225);
            this.btnPExportar.Name = "btnPExportar";
            this.btnPExportar.Size = new System.Drawing.Size(218, 29);
            this.btnPExportar.TabIndex = 8;
            this.btnPExportar.Text = "Exportar pagos a Excel";
            this.btnPExportar.UseVisualStyleBackColor = true;
            this.btnPExportar.Click += new System.EventHandler(this.btnPExportar_Click);
            // 
            // btnPVisualizar
            // 
            this.btnPVisualizar.Location = new System.Drawing.Point(11, 190);
            this.btnPVisualizar.Name = "btnPVisualizar";
            this.btnPVisualizar.Size = new System.Drawing.Size(218, 29);
            this.btnPVisualizar.TabIndex = 7;
            this.btnPVisualizar.Text = "Visualizar";
            this.btnPVisualizar.UseVisualStyleBackColor = true;
            this.btnPVisualizar.Click += new System.EventHandler(this.btnPVisualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número de crédito:";
            // 
            // dtpPFechaInicial
            // 
            this.dtpPFechaInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpPFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPFechaInicial.Location = new System.Drawing.Point(11, 94);
            this.dtpPFechaInicial.Name = "dtpPFechaInicial";
            this.dtpPFechaInicial.Size = new System.Drawing.Size(218, 23);
            this.dtpPFechaInicial.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha inicial:";
            // 
            // cboPNumeroPrestamo
            // 
            this.cboPNumeroPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPNumeroPrestamo.FormattingEnabled = true;
            this.cboPNumeroPrestamo.Location = new System.Drawing.Point(11, 39);
            this.cboPNumeroPrestamo.Name = "cboPNumeroPrestamo";
            this.cboPNumeroPrestamo.Size = new System.Drawing.Size(218, 25);
            this.cboPNumeroPrestamo.TabIndex = 2;
            // 
            // wkr02
            // 
            this.wkr02.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr02_DoWork);
            this.wkr02.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr02_RunWorkerCompleted);
            // 
            // frmHistCred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 568);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHistCred";
            this.Text = "Consultar historial de créditos puente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHistCred_FormClosing);
            this.Load += new System.EventHandler(this.frmHistCred_Load);
            this.tab01.ResumeLayout(false);
            this.tabSaldos.ResumeLayout(false);
            this.tabSaldos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabSaldos;
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.DataGridView grdPDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPUsarFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpPFechaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPUsarFechaInicial;
        private System.Windows.Forms.CheckBox chkPUsarCredito;
        private System.Windows.Forms.Button btnPExportar;
        private System.Windows.Forms.Button btnPVisualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPFechaInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPNumeroPrestamo;
        private System.ComponentModel.BackgroundWorker wkr02;
    }
}