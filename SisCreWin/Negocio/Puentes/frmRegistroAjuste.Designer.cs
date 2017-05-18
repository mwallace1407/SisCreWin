namespace SisCreWin.Negocio.Puentes
{
    partial class frmRegistroAjuste
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
            this.tabPagos = new System.Windows.Forms.TabControl();
            this.tabP01 = new System.Windows.Forms.TabPage();
            this.pnlN03 = new System.Windows.Forms.Panel();
            this.txtPagoIntMoratorios = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlN02 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInteresCapVenc = new System.Windows.Forms.NumericUpDown();
            this.pnlN01 = new System.Windows.Forms.Panel();
            this.txtPagoCapital = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInteresCubierto = new System.Windows.Forms.NumericUpDown();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComiAplicacion = new System.Windows.Forms.NumericUpDown();
            this.tabP02 = new System.Windows.Forms.TabPage();
            this.grdArchivos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.grdPropiedades = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNumeroPrestamo = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.ofd01 = new System.Windows.Forms.OpenFileDialog();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.tabPagos.SuspendLayout();
            this.tabP01.SuspendLayout();
            this.pnlN03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoIntMoratorios)).BeginInit();
            this.pnlN02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCapVenc)).BeginInit();
            this.pnlN01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCubierto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComiAplicacion)).BeginInit();
            this.tabP02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPropiedades)).BeginInit();
            this.pnlProgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabCrear);
            this.tab01.Location = new System.Drawing.Point(14, 14);
            this.tab01.Margin = new System.Windows.Forms.Padding(5);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(546, 613);
            this.tab01.TabIndex = 1;
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.tabPagos);
            this.tabCrear.Controls.Add(this.label4);
            this.tabCrear.Controls.Add(this.cboNumeroPrestamo);
            this.tabCrear.Controls.Add(this.dtpFechaPago);
            this.tabCrear.Controls.Add(this.btnCrear);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.label1);
            this.tabCrear.Location = new System.Drawing.Point(4, 26);
            this.tabCrear.Margin = new System.Windows.Forms.Padding(5);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(5);
            this.tabCrear.Size = new System.Drawing.Size(538, 583);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Registrar ajuste";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            this.tabPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPagos.Controls.Add(this.tabP01);
            this.tabPagos.Controls.Add(this.tabP02);
            this.tabPagos.Location = new System.Drawing.Point(14, 113);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.SelectedIndex = 0;
            this.tabPagos.Size = new System.Drawing.Size(513, 431);
            this.tabPagos.TabIndex = 3;
            // 
            // tabP01
            // 
            this.tabP01.Controls.Add(this.pnlN03);
            this.tabP01.Controls.Add(this.pnlN02);
            this.tabP01.Controls.Add(this.pnlN01);
            this.tabP01.Controls.Add(this.txtObservaciones);
            this.tabP01.Controls.Add(this.label23);
            this.tabP01.Controls.Add(this.txtMontoTotal);
            this.tabP01.Controls.Add(this.label5);
            this.tabP01.Controls.Add(this.txtInteresCubierto);
            this.tabP01.Controls.Add(this.lblMensaje);
            this.tabP01.Controls.Add(this.label7);
            this.tabP01.Controls.Add(this.label9);
            this.tabP01.Controls.Add(this.txtComiAplicacion);
            this.tabP01.Location = new System.Drawing.Point(4, 26);
            this.tabP01.Name = "tabP01";
            this.tabP01.Padding = new System.Windows.Forms.Padding(3);
            this.tabP01.Size = new System.Drawing.Size(505, 356);
            this.tabP01.TabIndex = 0;
            this.tabP01.Text = "Montos";
            this.tabP01.UseVisualStyleBackColor = true;
            // 
            // pnlN03
            // 
            this.pnlN03.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlN03.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlN03.Controls.Add(this.txtPagoIntMoratorios);
            this.pnlN03.Controls.Add(this.label10);
            this.pnlN03.Location = new System.Drawing.Point(3, 171);
            this.pnlN03.Name = "pnlN03";
            this.pnlN03.Size = new System.Drawing.Size(499, 32);
            this.pnlN03.TabIndex = 8;
            // 
            // txtPagoIntMoratorios
            // 
            this.txtPagoIntMoratorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagoIntMoratorios.DecimalPlaces = 6;
            this.txtPagoIntMoratorios.Location = new System.Drawing.Point(346, 5);
            this.txtPagoIntMoratorios.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPagoIntMoratorios.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtPagoIntMoratorios.Name = "txtPagoIntMoratorios";
            this.txtPagoIntMoratorios.Size = new System.Drawing.Size(150, 23);
            this.txtPagoIntMoratorios.TabIndex = 8;
            this.txtPagoIntMoratorios.ThousandsSeparator = true;
            this.txtPagoIntMoratorios.ValueChanged += new System.EventHandler(this.txtPagoIntMoratorios_ValueChanged);
            this.txtPagoIntMoratorios.Enter += new System.EventHandler(this.txtPagoIntMoratorios_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Intereses moratorios:";
            // 
            // pnlN02
            // 
            this.pnlN02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlN02.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlN02.Controls.Add(this.label8);
            this.pnlN02.Controls.Add(this.txtInteresCapVenc);
            this.pnlN02.Location = new System.Drawing.Point(3, 104);
            this.pnlN02.Name = "pnlN02";
            this.pnlN02.Size = new System.Drawing.Size(499, 32);
            this.pnlN02.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Intereses ordinarios sobre capital vencido cubierto:";
            // 
            // txtInteresCapVenc
            // 
            this.txtInteresCapVenc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteresCapVenc.DecimalPlaces = 6;
            this.txtInteresCapVenc.Location = new System.Drawing.Point(346, 3);
            this.txtInteresCapVenc.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtInteresCapVenc.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtInteresCapVenc.Name = "txtInteresCapVenc";
            this.txtInteresCapVenc.Size = new System.Drawing.Size(150, 23);
            this.txtInteresCapVenc.TabIndex = 6;
            this.txtInteresCapVenc.ThousandsSeparator = true;
            this.txtInteresCapVenc.ValueChanged += new System.EventHandler(this.txtInteresCapVenc_ValueChanged);
            this.txtInteresCapVenc.Enter += new System.EventHandler(this.txtInteresCapVenc_Enter);
            // 
            // pnlN01
            // 
            this.pnlN01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlN01.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlN01.Controls.Add(this.txtPagoCapital);
            this.pnlN01.Controls.Add(this.label6);
            this.pnlN01.Location = new System.Drawing.Point(3, 37);
            this.pnlN01.Name = "pnlN01";
            this.pnlN01.Size = new System.Drawing.Size(499, 32);
            this.pnlN01.TabIndex = 4;
            // 
            // txtPagoCapital
            // 
            this.txtPagoCapital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagoCapital.DecimalPlaces = 6;
            this.txtPagoCapital.Location = new System.Drawing.Point(346, 5);
            this.txtPagoCapital.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPagoCapital.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtPagoCapital.Name = "txtPagoCapital";
            this.txtPagoCapital.Size = new System.Drawing.Size(150, 23);
            this.txtPagoCapital.TabIndex = 4;
            this.txtPagoCapital.ThousandsSeparator = true;
            this.txtPagoCapital.ValueChanged += new System.EventHandler(this.txtPagoCapital_ValueChanged);
            this.txtPagoCapital.Enter += new System.EventHandler(this.txtPagoCapital_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pago a capital:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(8, 226);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(491, 82);
            this.txtObservaciones.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 206);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Observaciones:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoTotal.DecimalPlaces = 6;
            this.txtMontoTotal.Location = new System.Drawing.Point(349, 8);
            this.txtMontoTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtMontoTotal.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(150, 23);
            this.txtMontoTotal.TabIndex = 3;
            this.txtMontoTotal.ThousandsSeparator = true;
            this.txtMontoTotal.ValueChanged += new System.EventHandler(this.txtMontoTotal_ValueChanged);
            this.txtMontoTotal.Enter += new System.EventHandler(this.txtMontoTotal_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto total a pagar:";
            // 
            // txtInteresCubierto
            // 
            this.txtInteresCubierto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteresCubierto.DecimalPlaces = 6;
            this.txtInteresCubierto.Location = new System.Drawing.Point(349, 75);
            this.txtInteresCubierto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtInteresCubierto.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtInteresCubierto.Name = "txtInteresCubierto";
            this.txtInteresCubierto.Size = new System.Drawing.Size(150, 23);
            this.txtInteresCubierto.TabIndex = 5;
            this.txtInteresCubierto.ThousandsSeparator = true;
            this.txtInteresCubierto.ValueChanged += new System.EventHandler(this.txtInteresCubierto_ValueChanged);
            this.txtInteresCubierto.Enter += new System.EventHandler(this.txtInteresCubierto_Enter);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Image = global::SisCreWin.Properties.Resources.DivBackA_big;
            this.lblMensaje.Location = new System.Drawing.Point(5, 311);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(494, 37);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Interés sobre capital vencido cubierto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Comisión por aplicación:";
            // 
            // txtComiAplicacion
            // 
            this.txtComiAplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComiAplicacion.DecimalPlaces = 6;
            this.txtComiAplicacion.Location = new System.Drawing.Point(349, 142);
            this.txtComiAplicacion.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtComiAplicacion.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.txtComiAplicacion.Name = "txtComiAplicacion";
            this.txtComiAplicacion.Size = new System.Drawing.Size(150, 23);
            this.txtComiAplicacion.TabIndex = 7;
            this.txtComiAplicacion.ThousandsSeparator = true;
            this.txtComiAplicacion.ValueChanged += new System.EventHandler(this.txtComiAplicacion_ValueChanged);
            this.txtComiAplicacion.Enter += new System.EventHandler(this.txtComiAplicacion_Enter);
            // 
            // tabP02
            // 
            this.tabP02.Controls.Add(this.grdArchivos);
            this.tabP02.Controls.Add(this.btnAgregar);
            this.tabP02.Controls.Add(this.label13);
            this.tabP02.Controls.Add(this.label12);
            this.tabP02.Controls.Add(this.btnExaminar);
            this.tabP02.Controls.Add(this.label11);
            this.tabP02.Controls.Add(this.grdPropiedades);
            this.tabP02.Location = new System.Drawing.Point(4, 26);
            this.tabP02.Name = "tabP02";
            this.tabP02.Padding = new System.Windows.Forms.Padding(3);
            this.tabP02.Size = new System.Drawing.Size(505, 401);
            this.tabP02.TabIndex = 1;
            this.tabP02.Text = "Adjuntar archivos";
            this.tabP02.UseVisualStyleBackColor = true;
            // 
            // grdArchivos
            // 
            this.grdArchivos.AllowUserToAddRows = false;
            this.grdArchivos.AllowUserToDeleteRows = false;
            this.grdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArchivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdArchivos.Location = new System.Drawing.Point(6, 244);
            this.grdArchivos.MultiSelect = false;
            this.grdArchivos.Name = "grdArchivos";
            this.grdArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArchivos.Size = new System.Drawing.Size(493, 155);
            this.grdArchivos.TabIndex = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(256, 213);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Paso 3.- Agregue el archivo a la lista:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Paso 2.- Revise la información del archivo seleccionado:";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(217, 6);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 16;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Paso 1.- Seleccione un archivo:";
            // 
            // grdPropiedades
            // 
            this.grdPropiedades.AllowUserToAddRows = false;
            this.grdPropiedades.AllowUserToDeleteRows = false;
            this.grdPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPropiedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdPropiedades.Location = new System.Drawing.Point(6, 52);
            this.grdPropiedades.MultiSelect = false;
            this.grdPropiedades.Name = "grdPropiedades";
            this.grdPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPropiedades.Size = new System.Drawing.Size(493, 155);
            this.grdPropiedades.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de crédito:";
            // 
            // cboNumeroPrestamo
            // 
            this.cboNumeroPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumeroPrestamo.FormattingEnabled = true;
            this.cboNumeroPrestamo.Location = new System.Drawing.Point(165, 52);
            this.cboNumeroPrestamo.Name = "cboNumeroPrestamo";
            this.cboNumeroPrestamo.Size = new System.Drawing.Size(201, 25);
            this.cboNumeroPrestamo.TabIndex = 0;
            this.cboNumeroPrestamo.SelectedIndexChanged += new System.EventHandler(this.cboNumeroPrestamo_SelectedIndexChanged);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(165, 84);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(201, 23);
            this.dtpFechaPago.TabIndex = 1;
            this.dtpFechaPago.ValueChanged += new System.EventHandler(this.dtpFechaPago_ValueChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(316, 551);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(201, 25);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Registrar ajuste";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de ajuste:";
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
            // pnlProgreso
            // 
            this.pnlProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgreso.BackgroundImage = global::SisCreWin.Properties.Resources.gears_animated_t;
            this.pnlProgreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlProgreso.Controls.Add(this.label2);
            this.pnlProgreso.Location = new System.Drawing.Point(3000, 3000);
            this.pnlProgreso.Name = "pnlProgreso";
            this.pnlProgreso.Size = new System.Drawing.Size(155, 284);
            this.pnlProgreso.TabIndex = 2;
            this.pnlProgreso.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-73, 239);
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
            // frmRegistroAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 641);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(590, 680);
            this.Name = "frmRegistroAjuste";
            this.Text = "Registrar ajuste para créditos puente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroPago_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroPago_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.tabPagos.ResumeLayout(false);
            this.tabP01.ResumeLayout(false);
            this.tabP01.PerformLayout();
            this.pnlN03.ResumeLayout(false);
            this.pnlN03.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoIntMoratorios)).EndInit();
            this.pnlN02.ResumeLayout(false);
            this.pnlN02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCapVenc)).EndInit();
            this.pnlN01.ResumeLayout(false);
            this.pnlN01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCubierto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComiAplicacion)).EndInit();
            this.tabP02.ResumeLayout(false);
            this.tabP02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPropiedades)).EndInit();
            this.pnlProgreso.ResumeLayout(false);
            this.pnlProgreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtComiAplicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtInteresCapVenc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtInteresCubierto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtPagoCapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtMontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNumeroPrestamo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtPagoIntMoratorios;
        private System.Windows.Forms.TabControl tabPagos;
        private System.Windows.Forms.TabPage tabP01;
        private System.Windows.Forms.TabPage tabP02;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlN03;
        private System.Windows.Forms.Panel pnlN02;
        private System.Windows.Forms.Panel pnlN01;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grdPropiedades;
        private System.Windows.Forms.OpenFileDialog ofd01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.DataGridView grdArchivos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label13;
    }
}