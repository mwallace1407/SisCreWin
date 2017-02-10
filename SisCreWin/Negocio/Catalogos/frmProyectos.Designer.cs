namespace SisCreWin.Negocio.Catalogos
{
    partial class frmProyectos
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
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.txtIngTipoAmortizacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpIngFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIngFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIngNumViviendas = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtModId = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd01 = new System.Windows.Forms.SaveFileDialog();
            this.cboIngPromotor = new System.Windows.Forms.ComboBox();
            this.txtIngMontoCredPesos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIngMontoDesembolsadoPesos = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIngAdministracion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIngSpread = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.chkIngActivo = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkModActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModSpread = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModAdministracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModMontoDesembolsadoPesos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModMontoCredPesos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cboModPromotor = new System.Windows.Forms.ComboBox();
            this.txtModTipoAmortizacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpModFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpModFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txtModNumViviendas = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNumViviendas)).BeginInit();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMontoCredPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMontoDesembolsadoPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModMontoDesembolsadoPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModMontoCredPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModNumViviendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabCrear);
            this.tab01.Controls.Add(this.tabModificar);
            this.tab01.Location = new System.Drawing.Point(13, 12);
            this.tab01.Margin = new System.Windows.Forms.Padding(4);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(1051, 500);
            this.tab01.TabIndex = 0;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.chkIngActivo);
            this.tabCrear.Controls.Add(this.label20);
            this.tabCrear.Controls.Add(this.txtIngSpread);
            this.tabCrear.Controls.Add(this.label19);
            this.tabCrear.Controls.Add(this.txtIngAdministracion);
            this.tabCrear.Controls.Add(this.label18);
            this.tabCrear.Controls.Add(this.txtIngMontoDesembolsadoPesos);
            this.tabCrear.Controls.Add(this.label17);
            this.tabCrear.Controls.Add(this.txtIngMontoCredPesos);
            this.tabCrear.Controls.Add(this.label10);
            this.tabCrear.Controls.Add(this.cboIngPromotor);
            this.tabCrear.Controls.Add(this.txtIngTipoAmortizacion);
            this.tabCrear.Controls.Add(this.label14);
            this.tabCrear.Controls.Add(this.dtpIngFechaVencimiento);
            this.tabCrear.Controls.Add(this.label13);
            this.tabCrear.Controls.Add(this.dtpIngFechaApertura);
            this.tabCrear.Controls.Add(this.label12);
            this.tabCrear.Controls.Add(this.txtIngNumViviendas);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.btnCrear);
            this.tabCrear.Controls.Add(this.txtIngNombre);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.label2);
            this.tabCrear.Controls.Add(this.label1);
            this.tabCrear.Location = new System.Drawing.Point(4, 26);
            this.tabCrear.Margin = new System.Windows.Forms.Padding(4);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(4);
            this.tabCrear.Size = new System.Drawing.Size(1043, 470);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // txtIngTipoAmortizacion
            // 
            this.txtIngTipoAmortizacion.Location = new System.Drawing.Point(229, 249);
            this.txtIngTipoAmortizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngTipoAmortizacion.MaxLength = 50;
            this.txtIngTipoAmortizacion.Name = "txtIngTipoAmortizacion";
            this.txtIngTipoAmortizacion.Size = new System.Drawing.Size(252, 23);
            this.txtIngTipoAmortizacion.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 252);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tipo de amortización:";
            // 
            // dtpIngFechaVencimiento
            // 
            this.dtpIngFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpIngFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngFechaVencimiento.Location = new System.Drawing.Point(229, 161);
            this.dtpIngFechaVencimiento.Name = "dtpIngFechaVencimiento";
            this.dtpIngFechaVencimiento.Size = new System.Drawing.Size(252, 23);
            this.dtpIngFechaVencimiento.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fecha de vencimiento:";
            // 
            // dtpIngFechaApertura
            // 
            this.dtpIngFechaApertura.CustomFormat = "dd/MM/yyyy";
            this.dtpIngFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngFechaApertura.Location = new System.Drawing.Point(229, 132);
            this.dtpIngFechaApertura.Name = "dtpIngFechaApertura";
            this.dtpIngFechaApertura.Size = new System.Drawing.Size(252, 23);
            this.dtpIngFechaApertura.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha de apertura:";
            // 
            // txtIngNumViviendas
            // 
            this.txtIngNumViviendas.Location = new System.Drawing.Point(229, 103);
            this.txtIngNumViviendas.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtIngNumViviendas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIngNumViviendas.Name = "txtIngNumViviendas";
            this.txtIngNumViviendas.Size = new System.Drawing.Size(252, 23);
            this.txtIngNumViviendas.TabIndex = 3;
            this.txtIngNumViviendas.ThousandsSeparator = true;
            this.txtIngNumViviendas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Número de viviendas:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(229, 359);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(252, 24);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear proyecto";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Location = new System.Drawing.Point(229, 73);
            this.txtIngNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngNombre.MaxLength = 50;
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(252, 23);
            this.txtIngNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del promotor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca los valores requeridos:";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.btnExportarExcel);
            this.tabModificar.Controls.Add(this.gbDatos);
            this.tabModificar.Controls.Add(this.grdDatos);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Location = new System.Drawing.Point(4, 26);
            this.tabModificar.Margin = new System.Windows.Forms.Padding(4);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(4);
            this.tabModificar.Size = new System.Drawing.Size(1043, 470);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarExcel.Location = new System.Drawing.Point(543, 7);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportarExcel.TabIndex = 6;
            this.tip01.SetToolTip(this.btnExportarExcel, "Exportar a Excel");
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.chkModActivo);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtModSpread);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtModAdministracion);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtModMontoDesembolsadoPesos);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtModMontoCredPesos);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.cboModPromotor);
            this.gbDatos.Controls.Add(this.txtModTipoAmortizacion);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.dtpModFechaVencimiento);
            this.gbDatos.Controls.Add(this.label21);
            this.gbDatos.Controls.Add(this.dtpModFechaApertura);
            this.gbDatos.Controls.Add(this.label22);
            this.gbDatos.Controls.Add(this.txtModNumViviendas);
            this.gbDatos.Controls.Add(this.label23);
            this.gbDatos.Controls.Add(this.txtModNombre);
            this.gbDatos.Controls.Add(this.label24);
            this.gbDatos.Controls.Add(this.label25);
            this.gbDatos.Controls.Add(this.txtModId);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.btnModificar);
            this.gbDatos.Location = new System.Drawing.Point(581, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(455, 431);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Proyecto seleccionado:";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(228, 22);
            this.txtModId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtModId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtModId.Name = "txtModId";
            this.txtModId.ReadOnly = true;
            this.txtModId.Size = new System.Drawing.Size(221, 23);
            this.txtModId.TabIndex = 8;
            this.txtModId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Número de proyecto:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(228, 368);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(221, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar proyecto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.grdDatos.Location = new System.Drawing.Point(11, 40);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(564, 423);
            this.grdDatos.TabIndex = 2;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Proyectos registrados en el sistema:";
            // 
            // sfd01
            // 
            this.sfd01.CheckFileExists = true;
            this.sfd01.DefaultExt = "*.xlsx";
            this.sfd01.Filter = "Archivos de Excel|*.xlsx";
            // 
            // cboIngPromotor
            // 
            this.cboIngPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngPromotor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIngPromotor.FormattingEnabled = true;
            this.cboIngPromotor.Location = new System.Drawing.Point(229, 41);
            this.cboIngPromotor.Name = "cboIngPromotor";
            this.cboIngPromotor.Size = new System.Drawing.Size(252, 24);
            this.cboIngPromotor.TabIndex = 1;
            // 
            // txtIngMontoCredPesos
            // 
            this.txtIngMontoCredPesos.DecimalPlaces = 2;
            this.txtIngMontoCredPesos.Location = new System.Drawing.Point(229, 190);
            this.txtIngMontoCredPesos.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtIngMontoCredPesos.Name = "txtIngMontoCredPesos";
            this.txtIngMontoCredPesos.Size = new System.Drawing.Size(252, 23);
            this.txtIngMontoCredPesos.TabIndex = 6;
            this.txtIngMontoCredPesos.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Monto de crédito en pesos:";
            // 
            // txtIngMontoDesembolsadoPesos
            // 
            this.txtIngMontoDesembolsadoPesos.DecimalPlaces = 2;
            this.txtIngMontoDesembolsadoPesos.Location = new System.Drawing.Point(229, 219);
            this.txtIngMontoDesembolsadoPesos.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtIngMontoDesembolsadoPesos.Name = "txtIngMontoDesembolsadoPesos";
            this.txtIngMontoDesembolsadoPesos.Size = new System.Drawing.Size(252, 23);
            this.txtIngMontoDesembolsadoPesos.TabIndex = 7;
            this.txtIngMontoDesembolsadoPesos.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 221);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Monto desembolsado en pesos:";
            // 
            // txtIngAdministracion
            // 
            this.txtIngAdministracion.Location = new System.Drawing.Point(229, 280);
            this.txtIngAdministracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngAdministracion.MaxLength = 25;
            this.txtIngAdministracion.Name = "txtIngAdministracion";
            this.txtIngAdministracion.Size = new System.Drawing.Size(252, 23);
            this.txtIngAdministracion.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 283);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Administración:";
            // 
            // txtIngSpread
            // 
            this.txtIngSpread.DecimalPlaces = 2;
            this.txtIngSpread.Location = new System.Drawing.Point(229, 310);
            this.txtIngSpread.Name = "txtIngSpread";
            this.txtIngSpread.Size = new System.Drawing.Size(252, 23);
            this.txtIngSpread.TabIndex = 10;
            this.txtIngSpread.ThousandsSeparator = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 312);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 25;
            this.label19.Text = "Spread:";
            // 
            // chkIngActivo
            // 
            this.chkIngActivo.AutoSize = true;
            this.chkIngActivo.Location = new System.Drawing.Point(229, 339);
            this.chkIngActivo.Name = "chkIngActivo";
            this.chkIngActivo.Size = new System.Drawing.Size(15, 14);
            this.chkIngActivo.TabIndex = 11;
            this.chkIngActivo.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 336);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "Activo:";
            // 
            // chkModActivo
            // 
            this.chkModActivo.AutoSize = true;
            this.chkModActivo.Location = new System.Drawing.Point(228, 348);
            this.chkModActivo.Name = "chkModActivo";
            this.chkModActivo.Size = new System.Drawing.Size(15, 14);
            this.chkModActivo.TabIndex = 23;
            this.chkModActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Activo:";
            // 
            // txtModSpread
            // 
            this.txtModSpread.DecimalPlaces = 2;
            this.txtModSpread.Location = new System.Drawing.Point(228, 320);
            this.txtModSpread.Name = "txtModSpread";
            this.txtModSpread.Size = new System.Drawing.Size(221, 23);
            this.txtModSpread.TabIndex = 22;
            this.txtModSpread.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Spread:";
            // 
            // txtModAdministracion
            // 
            this.txtModAdministracion.Location = new System.Drawing.Point(228, 290);
            this.txtModAdministracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtModAdministracion.MaxLength = 25;
            this.txtModAdministracion.Name = "txtModAdministracion";
            this.txtModAdministracion.Size = new System.Drawing.Size(221, 23);
            this.txtModAdministracion.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Administración:";
            // 
            // txtModMontoDesembolsadoPesos
            // 
            this.txtModMontoDesembolsadoPesos.DecimalPlaces = 2;
            this.txtModMontoDesembolsadoPesos.Location = new System.Drawing.Point(228, 229);
            this.txtModMontoDesembolsadoPesos.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtModMontoDesembolsadoPesos.Name = "txtModMontoDesembolsadoPesos";
            this.txtModMontoDesembolsadoPesos.Size = new System.Drawing.Size(221, 23);
            this.txtModMontoDesembolsadoPesos.TabIndex = 19;
            this.txtModMontoDesembolsadoPesos.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Monto desembolsado en pesos:";
            // 
            // txtModMontoCredPesos
            // 
            this.txtModMontoCredPesos.DecimalPlaces = 2;
            this.txtModMontoCredPesos.Location = new System.Drawing.Point(228, 200);
            this.txtModMontoCredPesos.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtModMontoCredPesos.Name = "txtModMontoCredPesos";
            this.txtModMontoCredPesos.Size = new System.Drawing.Size(221, 23);
            this.txtModMontoCredPesos.TabIndex = 18;
            this.txtModMontoCredPesos.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Monto de crédito en pesos:";
            // 
            // cboModPromotor
            // 
            this.cboModPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModPromotor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModPromotor.FormattingEnabled = true;
            this.cboModPromotor.Location = new System.Drawing.Point(228, 51);
            this.cboModPromotor.Name = "cboModPromotor";
            this.cboModPromotor.Size = new System.Drawing.Size(221, 24);
            this.cboModPromotor.TabIndex = 13;
            // 
            // txtModTipoAmortizacion
            // 
            this.txtModTipoAmortizacion.Location = new System.Drawing.Point(228, 259);
            this.txtModTipoAmortizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtModTipoAmortizacion.MaxLength = 50;
            this.txtModTipoAmortizacion.Name = "txtModTipoAmortizacion";
            this.txtModTipoAmortizacion.Size = new System.Drawing.Size(221, 23);
            this.txtModTipoAmortizacion.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 262);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Tipo de amortización:";
            // 
            // dtpModFechaVencimiento
            // 
            this.dtpModFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpModFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModFechaVencimiento.Location = new System.Drawing.Point(228, 171);
            this.dtpModFechaVencimiento.Name = "dtpModFechaVencimiento";
            this.dtpModFechaVencimiento.Size = new System.Drawing.Size(221, 23);
            this.dtpModFechaVencimiento.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 176);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "Fecha de vencimiento:";
            // 
            // dtpModFechaApertura
            // 
            this.dtpModFechaApertura.CustomFormat = "dd/MM/yyyy";
            this.dtpModFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModFechaApertura.Location = new System.Drawing.Point(228, 142);
            this.dtpModFechaApertura.Name = "dtpModFechaApertura";
            this.dtpModFechaApertura.Size = new System.Drawing.Size(221, 23);
            this.dtpModFechaApertura.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 147);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 17);
            this.label22.TabIndex = 42;
            this.label22.Text = "Fecha de apertura:";
            // 
            // txtModNumViviendas
            // 
            this.txtModNumViviendas.Location = new System.Drawing.Point(228, 113);
            this.txtModNumViviendas.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtModNumViviendas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtModNumViviendas.Name = "txtModNumViviendas";
            this.txtModNumViviendas.Size = new System.Drawing.Size(221, 23);
            this.txtModNumViviendas.TabIndex = 15;
            this.txtModNumViviendas.ThousandsSeparator = true;
            this.txtModNumViviendas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 115);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 17);
            this.label23.TabIndex = 40;
            this.label23.Text = "Número de viviendas:";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(228, 83);
            this.txtModNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtModNombre.MaxLength = 50;
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(221, 23);
            this.txtModNombre.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 86);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 17);
            this.label24.TabIndex = 32;
            this.label24.Text = "Nombre del proyecto:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 54);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(159, 17);
            this.label25.TabIndex = 29;
            this.label25.Text = "Nombre del promotor::";
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 525);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProyectos";
            this.Text = "Administración de proyectos";
            this.Load += new System.EventHandler(this.frmProyectos_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNumViviendas)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMontoCredPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMontoDesembolsadoPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModMontoDesembolsadoPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModMontoCredPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModNumViviendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.SaveFileDialog sfd01;
        private System.Windows.Forms.DateTimePicker dtpIngFechaApertura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtIngNumViviendas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpIngFechaVencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngTipoAmortizacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtModId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboIngPromotor;
        private System.Windows.Forms.NumericUpDown txtIngMontoCredPesos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtIngMontoDesembolsadoPesos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown txtIngSpread;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIngAdministracion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkIngActivo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkModActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtModSpread;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModAdministracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtModMontoDesembolsadoPesos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtModMontoCredPesos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboModPromotor;
        private System.Windows.Forms.TextBox txtModTipoAmortizacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpModFechaVencimiento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpModFechaApertura;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown txtModNumViviendas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}