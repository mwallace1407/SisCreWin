namespace SisCreWin.Negocio.Catalogos
{
    partial class frmOrigenesPuente
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
            this.txtIngEstado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpIngFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIngFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIngNumViviendas = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIngIdProyecto = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIngId = new System.Windows.Forms.NumericUpDown();
            this.btnCrearModulo = new System.Windows.Forms.Button();
            this.txtIngOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtModEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpModFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpModFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModNumViviendas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModIdProyecto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.NumericUpDown();
            this.txtModOrigen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd01 = new System.Windows.Forms.SaveFileDialog();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNumViviendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngIdProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngId)).BeginInit();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModNumViviendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModIdProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
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
            this.tabCrear.Controls.Add(this.txtIngEstado);
            this.tabCrear.Controls.Add(this.label14);
            this.tabCrear.Controls.Add(this.dtpIngFechaVencimiento);
            this.tabCrear.Controls.Add(this.label13);
            this.tabCrear.Controls.Add(this.dtpIngFechaApertura);
            this.tabCrear.Controls.Add(this.label12);
            this.tabCrear.Controls.Add(this.txtIngNumViviendas);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.txtIngIdProyecto);
            this.tabCrear.Controls.Add(this.label10);
            this.tabCrear.Controls.Add(this.txtIngId);
            this.tabCrear.Controls.Add(this.btnCrearModulo);
            this.tabCrear.Controls.Add(this.txtIngOrigen);
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
            // txtIngEstado
            // 
            this.txtIngEstado.Location = new System.Drawing.Point(182, 219);
            this.txtIngEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngEstado.MaxLength = 20;
            this.txtIngEstado.Name = "txtIngEstado";
            this.txtIngEstado.Size = new System.Drawing.Size(252, 23);
            this.txtIngEstado.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 222);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Estado:";
            // 
            // dtpIngFechaVencimiento
            // 
            this.dtpIngFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpIngFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngFechaVencimiento.Location = new System.Drawing.Point(182, 189);
            this.dtpIngFechaVencimiento.Name = "dtpIngFechaVencimiento";
            this.dtpIngFechaVencimiento.Size = new System.Drawing.Size(252, 23);
            this.dtpIngFechaVencimiento.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 194);
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
            this.dtpIngFechaApertura.Location = new System.Drawing.Point(182, 160);
            this.dtpIngFechaApertura.Name = "dtpIngFechaApertura";
            this.dtpIngFechaApertura.Size = new System.Drawing.Size(252, 23);
            this.dtpIngFechaApertura.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha de apertura:";
            // 
            // txtIngNumViviendas
            // 
            this.txtIngNumViviendas.Location = new System.Drawing.Point(182, 131);
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
            this.label11.Location = new System.Drawing.Point(8, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Número de viviendas:";
            // 
            // txtIngIdProyecto
            // 
            this.txtIngIdProyecto.Location = new System.Drawing.Point(182, 102);
            this.txtIngIdProyecto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtIngIdProyecto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIngIdProyecto.Name = "txtIngIdProyecto";
            this.txtIngIdProyecto.Size = new System.Drawing.Size(252, 23);
            this.txtIngIdProyecto.TabIndex = 2;
            this.txtIngIdProyecto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Id de proyecto:";
            // 
            // txtIngId
            // 
            this.txtIngId.Location = new System.Drawing.Point(182, 42);
            this.txtIngId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtIngId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIngId.Name = "txtIngId";
            this.txtIngId.Size = new System.Drawing.Size(252, 23);
            this.txtIngId.TabIndex = 0;
            this.txtIngId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrearModulo
            // 
            this.btnCrearModulo.Location = new System.Drawing.Point(182, 249);
            this.btnCrearModulo.Name = "btnCrearModulo";
            this.btnCrearModulo.Size = new System.Drawing.Size(252, 24);
            this.btnCrearModulo.TabIndex = 7;
            this.btnCrearModulo.Text = "Crear origen";
            this.btnCrearModulo.UseVisualStyleBackColor = true;
            this.btnCrearModulo.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtIngOrigen
            // 
            this.txtIngOrigen.Location = new System.Drawing.Point(182, 72);
            this.txtIngOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngOrigen.MaxLength = 50;
            this.txtIngOrigen.Name = "txtIngOrigen";
            this.txtIngOrigen.Size = new System.Drawing.Size(252, 23);
            this.txtIngOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de crédito:";
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
            this.gbDatos.Controls.Add(this.txtModEstado);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.dtpModFechaVencimiento);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.dtpModFechaApertura);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtModNumViviendas);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtModIdProyecto);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtModId);
            this.gbDatos.Controls.Add(this.txtModOrigen);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.btnModificar);
            this.gbDatos.Location = new System.Drawing.Point(581, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(455, 431);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Origen seleccionado:";
            // 
            // txtModEstado
            // 
            this.txtModEstado.Location = new System.Drawing.Point(197, 199);
            this.txtModEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtModEstado.MaxLength = 20;
            this.txtModEstado.Name = "txtModEstado";
            this.txtModEstado.Size = new System.Drawing.Size(252, 23);
            this.txtModEstado.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Estado:";
            // 
            // dtpModFechaVencimiento
            // 
            this.dtpModFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpModFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModFechaVencimiento.Location = new System.Drawing.Point(197, 169);
            this.dtpModFechaVencimiento.Name = "dtpModFechaVencimiento";
            this.dtpModFechaVencimiento.Size = new System.Drawing.Size(252, 23);
            this.dtpModFechaVencimiento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha de vencimiento:";
            // 
            // dtpModFechaApertura
            // 
            this.dtpModFechaApertura.CustomFormat = "dd/MM/yyyy";
            this.dtpModFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModFechaApertura.Location = new System.Drawing.Point(197, 140);
            this.dtpModFechaApertura.Name = "dtpModFechaApertura";
            this.dtpModFechaApertura.Size = new System.Drawing.Size(252, 23);
            this.dtpModFechaApertura.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de apertura:";
            // 
            // txtModNumViviendas
            // 
            this.txtModNumViviendas.Location = new System.Drawing.Point(197, 111);
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
            this.txtModNumViviendas.Size = new System.Drawing.Size(252, 23);
            this.txtModNumViviendas.TabIndex = 11;
            this.txtModNumViviendas.ThousandsSeparator = true;
            this.txtModNumViviendas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Número de viviendas:";
            // 
            // txtModIdProyecto
            // 
            this.txtModIdProyecto.Location = new System.Drawing.Point(197, 82);
            this.txtModIdProyecto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtModIdProyecto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtModIdProyecto.Name = "txtModIdProyecto";
            this.txtModIdProyecto.Size = new System.Drawing.Size(252, 23);
            this.txtModIdProyecto.TabIndex = 10;
            this.txtModIdProyecto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Id de proyecto:";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(197, 22);
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
            this.txtModId.Size = new System.Drawing.Size(252, 23);
            this.txtModId.TabIndex = 8;
            this.txtModId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtModOrigen
            // 
            this.txtModOrigen.Location = new System.Drawing.Point(197, 52);
            this.txtModOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtModOrigen.MaxLength = 50;
            this.txtModOrigen.Name = "txtModOrigen";
            this.txtModOrigen.Size = new System.Drawing.Size(252, 23);
            this.txtModOrigen.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Origen:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Número de crédito:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(197, 229);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(252, 24);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar origen";
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
            this.label5.Size = new System.Drawing.Size(229, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Orígenes registrados en el sistema:";
            // 
            // sfd01
            // 
            this.sfd01.CheckFileExists = true;
            this.sfd01.DefaultExt = "*.xlsx";
            this.sfd01.Filter = "Archivos de Excel|*.xlsx";
            // 
            // frmOrigenesPuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 525);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrigenesPuente";
            this.Text = "Administración de orígenes para créditos puente";
            this.Load += new System.EventHandler(this.frmOrigenesPuente_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNumViviendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngIdProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngId)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModNumViviendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModIdProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TextBox txtIngOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearModulo;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.SaveFileDialog sfd01;
        private System.Windows.Forms.NumericUpDown txtIngIdProyecto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtIngId;
        private System.Windows.Forms.DateTimePicker dtpIngFechaApertura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtIngNumViviendas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpIngFechaVencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpModFechaVencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpModFechaApertura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtModNumViviendas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtModIdProyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtModId;
        private System.Windows.Forms.TextBox txtModOrigen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}