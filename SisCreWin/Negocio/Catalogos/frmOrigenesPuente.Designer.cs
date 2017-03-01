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
            this.cboIngProyectos = new System.Windows.Forms.ComboBox();
            this.txtIngEstado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpIngFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
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
            this.cboModEstado = new System.Windows.Forms.ComboBox();
            this.cboModProyectos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.cboIngDacionAdju = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIngNoLiquidado = new System.Windows.Forms.CheckBox();
            this.chkModNoLiquidado = new System.Windows.Forms.CheckBox();
            this.cboModDacionAdju = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpModFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngId)).BeginInit();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
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
            this.tabCrear.Controls.Add(this.chkIngNoLiquidado);
            this.tabCrear.Controls.Add(this.cboIngDacionAdju);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.cboIngProyectos);
            this.tabCrear.Controls.Add(this.txtIngEstado);
            this.tabCrear.Controls.Add(this.label14);
            this.tabCrear.Controls.Add(this.dtpIngFechaLiquidacion);
            this.tabCrear.Controls.Add(this.label13);
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
            // cboIngProyectos
            // 
            this.cboIngProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngProyectos.FormattingEnabled = true;
            this.cboIngProyectos.Location = new System.Drawing.Point(182, 102);
            this.cboIngProyectos.Name = "cboIngProyectos";
            this.cboIngProyectos.Size = new System.Drawing.Size(252, 25);
            this.cboIngProyectos.TabIndex = 2;
            // 
            // txtIngEstado
            // 
            this.txtIngEstado.Enabled = false;
            this.txtIngEstado.Location = new System.Drawing.Point(182, 225);
            this.txtIngEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngEstado.MaxLength = 20;
            this.txtIngEstado.Name = "txtIngEstado";
            this.txtIngEstado.Size = new System.Drawing.Size(252, 23);
            this.txtIngEstado.TabIndex = 5;
            this.txtIngEstado.Text = "ACTIVO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 228);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Estado:";
            // 
            // dtpIngFechaLiquidacion
            // 
            this.dtpIngFechaLiquidacion.CustomFormat = "dd/MM/yyyy";
            this.dtpIngFechaLiquidacion.Enabled = false;
            this.dtpIngFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngFechaLiquidacion.Location = new System.Drawing.Point(182, 195);
            this.dtpIngFechaLiquidacion.Name = "dtpIngFechaLiquidacion";
            this.dtpIngFechaLiquidacion.Size = new System.Drawing.Size(252, 23);
            this.dtpIngFechaLiquidacion.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fecha de liquidación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Proyecto:";
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
            this.btnCrearModulo.Location = new System.Drawing.Point(182, 255);
            this.btnCrearModulo.Name = "btnCrearModulo";
            this.btnCrearModulo.Size = new System.Drawing.Size(252, 24);
            this.btnCrearModulo.TabIndex = 6;
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
            this.tabModificar.Click += new System.EventHandler(this.tabModificar_Click);
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
            this.gbDatos.Controls.Add(this.chkModNoLiquidado);
            this.gbDatos.Controls.Add(this.cboModDacionAdju);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.dtpModFechaLiquidacion);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.cboModEstado);
            this.gbDatos.Controls.Add(this.cboModProyectos);
            this.gbDatos.Controls.Add(this.label4);
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
            // cboModEstado
            // 
            this.cboModEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModEstado.FormattingEnabled = true;
            this.cboModEstado.Location = new System.Drawing.Point(197, 203);
            this.cboModEstado.Name = "cboModEstado";
            this.cboModEstado.Size = new System.Drawing.Size(252, 25);
            this.cboModEstado.TabIndex = 33;
            // 
            // cboModProyectos
            // 
            this.cboModProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModProyectos.FormattingEnabled = true;
            this.cboModProyectos.Location = new System.Drawing.Point(197, 82);
            this.cboModProyectos.Name = "cboModProyectos";
            this.cboModProyectos.Size = new System.Drawing.Size(252, 25);
            this.cboModProyectos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Proyecto:";
            // 
            // txtModId
            // 
            this.txtModId.Enabled = false;
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
            this.btnModificar.Location = new System.Drawing.Point(197, 234);
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
            // cboIngDacionAdju
            // 
            this.cboIngDacionAdju.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngDacionAdju.FormattingEnabled = true;
            this.cboIngDacionAdju.Location = new System.Drawing.Point(182, 134);
            this.cboIngDacionAdju.Name = "cboIngDacionAdju";
            this.cboIngDacionAdju.Size = new System.Drawing.Size(252, 25);
            this.cboIngDacionAdju.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dación o adjudicación:";
            // 
            // chkIngNoLiquidado
            // 
            this.chkIngNoLiquidado.AutoSize = true;
            this.chkIngNoLiquidado.Checked = true;
            this.chkIngNoLiquidado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIngNoLiquidado.Location = new System.Drawing.Point(182, 168);
            this.chkIngNoLiquidado.Name = "chkIngNoLiquidado";
            this.chkIngNoLiquidado.Size = new System.Drawing.Size(163, 21);
            this.chkIngNoLiquidado.TabIndex = 20;
            this.chkIngNoLiquidado.Text = "Crédito no liquidado";
            this.chkIngNoLiquidado.UseVisualStyleBackColor = true;
            this.chkIngNoLiquidado.CheckedChanged += new System.EventHandler(this.chkIngNoLiquidado_CheckedChanged);
            // 
            // chkModNoLiquidado
            // 
            this.chkModNoLiquidado.AutoSize = true;
            this.chkModNoLiquidado.Checked = true;
            this.chkModNoLiquidado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModNoLiquidado.Location = new System.Drawing.Point(197, 147);
            this.chkModNoLiquidado.Name = "chkModNoLiquidado";
            this.chkModNoLiquidado.Size = new System.Drawing.Size(163, 21);
            this.chkModNoLiquidado.TabIndex = 38;
            this.chkModNoLiquidado.Text = "Crédito no liquidado";
            this.chkModNoLiquidado.UseVisualStyleBackColor = true;
            this.chkModNoLiquidado.CheckedChanged += new System.EventHandler(this.chkModNoLiquidado_CheckedChanged);
            // 
            // cboModDacionAdju
            // 
            this.cboModDacionAdju.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModDacionAdju.FormattingEnabled = true;
            this.cboModDacionAdju.Location = new System.Drawing.Point(197, 113);
            this.cboModDacionAdju.Name = "cboModDacionAdju";
            this.cboModDacionAdju.Size = new System.Drawing.Size(252, 25);
            this.cboModDacionAdju.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Dación o adjudicación:";
            // 
            // dtpModFechaLiquidacion
            // 
            this.dtpModFechaLiquidacion.CustomFormat = "dd/MM/yyyy";
            this.dtpModFechaLiquidacion.Enabled = false;
            this.dtpModFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModFechaLiquidacion.Location = new System.Drawing.Point(197, 174);
            this.dtpModFechaLiquidacion.Name = "dtpModFechaLiquidacion";
            this.dtpModFechaLiquidacion.Size = new System.Drawing.Size(252, 23);
            this.dtpModFechaLiquidacion.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fecha de liquidación:";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtIngId)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtIngId;
        private System.Windows.Forms.DateTimePicker dtpIngFechaLiquidacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtModId;
        private System.Windows.Forms.TextBox txtModOrigen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboModProyectos;
        private System.Windows.Forms.ComboBox cboIngProyectos;
        private System.Windows.Forms.ComboBox cboModEstado;
        private System.Windows.Forms.ComboBox cboIngDacionAdju;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkIngNoLiquidado;
        private System.Windows.Forms.CheckBox chkModNoLiquidado;
        private System.Windows.Forms.ComboBox cboModDacionAdju;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpModFechaLiquidacion;
        private System.Windows.Forms.Label label7;
    }
}