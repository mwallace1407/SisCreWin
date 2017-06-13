namespace SisCreWin.Negocio.Catalogos
{
    partial class frmViviendasMod
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
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCUV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCredito = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProyectos = new System.Windows.Forms.ComboBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cboEstadosMod = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaMod = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.numSaldoInsolutoMod = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numMontoSaldoPenMod = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numMontoPagoPenMod = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numMontoMinPenMod = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numMontoCredMod = new System.Windows.Forms.NumericUpDown();
            this.txtUbicacionMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCUVMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferenciaMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredito)).BeginInit();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoInsolutoMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoSaldoPenMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoPagoPenMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoMinPenMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoCredMod)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.label5);
            this.gbBusqueda.Controls.Add(this.cboEstados);
            this.gbBusqueda.Controls.Add(this.label4);
            this.gbBusqueda.Controls.Add(this.txtUbicacion);
            this.gbBusqueda.Controls.Add(this.label3);
            this.gbBusqueda.Controls.Add(this.txtCUV);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Controls.Add(this.numCredito);
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.cboProyectos);
            this.gbBusqueda.Location = new System.Drawing.Point(16, 16);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Size = new System.Drawing.Size(369, 213);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(281, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado";
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(86, 144);
            this.cboEstados.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(270, 25);
            this.cboEstados.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ubicación";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(86, 114);
            this.txtUbicacion.MaxLength = 150;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(270, 23);
            this.txtUbicacion.TabIndex = 3;
            this.txtUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUV";
            // 
            // txtCUV
            // 
            this.txtCUV.Location = new System.Drawing.Point(86, 85);
            this.txtCUV.MaxLength = 16;
            this.txtCUV.Name = "txtCUV";
            this.txtCUV.Size = new System.Drawing.Size(270, 23);
            this.txtCUV.TabIndex = 2;
            this.txtCUV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crédito";
            // 
            // numCredito
            // 
            this.numCredito.Location = new System.Drawing.Point(86, 56);
            this.numCredito.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCredito.Name = "numCredito";
            this.numCredito.Size = new System.Drawing.Size(270, 23);
            this.numCredito.TabIndex = 1;
            this.numCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto";
            // 
            // cboProyectos
            // 
            this.cboProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyectos.FormattingEnabled = true;
            this.cboProyectos.Location = new System.Drawing.Point(86, 24);
            this.cboProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.cboProyectos.Name = "cboProyectos";
            this.cboProyectos.Size = new System.Drawing.Size(270, 25);
            this.cboProyectos.TabIndex = 0;
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultados.Controls.Add(this.grdDatos);
            this.gbResultados.Location = new System.Drawing.Point(392, 16);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(607, 213);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultado de búsqueda";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDatos.Location = new System.Drawing.Point(6, 22);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(595, 185);
            this.grdDatos.TabIndex = 27;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.btnProcesar);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.cboEstadosMod);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.dtpFechaMod);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.numSaldoInsolutoMod);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.numMontoSaldoPenMod);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.numMontoPagoPenMod);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.numMontoMinPenMod);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.numMontoCredMod);
            this.gbDatos.Controls.Add(this.txtUbicacionMod);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtCUVMod);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtReferenciaMod);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(16, 236);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(983, 353);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de vivienda";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(222, 316);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 25);
            this.btnProcesar.TabIndex = 24;
            this.btnProcesar.Text = "Modificar vivienda";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 292);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Estado";
            // 
            // cboEstadosMod
            // 
            this.cboEstadosMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadosMod.FormattingEnabled = true;
            this.cboEstadosMod.Location = new System.Drawing.Point(172, 284);
            this.cboEstadosMod.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstadosMod.Name = "cboEstadosMod";
            this.cboEstadosMod.Size = new System.Drawing.Size(200, 25);
            this.cboEstadosMod.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Fecha de último pago";
            // 
            // dtpFechaMod
            // 
            this.dtpFechaMod.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaMod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMod.Location = new System.Drawing.Point(172, 254);
            this.dtpFechaMod.Name = "dtpFechaMod";
            this.dtpFechaMod.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaMod.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Saldo insoluto";
            // 
            // numSaldoInsolutoMod
            // 
            this.numSaldoInsolutoMod.DecimalPlaces = 4;
            this.numSaldoInsolutoMod.Location = new System.Drawing.Point(172, 225);
            this.numSaldoInsolutoMod.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSaldoInsolutoMod.Name = "numSaldoInsolutoMod";
            this.numSaldoInsolutoMod.Size = new System.Drawing.Size(200, 23);
            this.numSaldoInsolutoMod.TabIndex = 18;
            this.numSaldoInsolutoMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSaldoInsolutoMod.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Monto saldo pendiente";
            // 
            // numMontoSaldoPenMod
            // 
            this.numMontoSaldoPenMod.DecimalPlaces = 4;
            this.numMontoSaldoPenMod.Location = new System.Drawing.Point(172, 196);
            this.numMontoSaldoPenMod.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMontoSaldoPenMod.Name = "numMontoSaldoPenMod";
            this.numMontoSaldoPenMod.Size = new System.Drawing.Size(200, 23);
            this.numMontoSaldoPenMod.TabIndex = 16;
            this.numMontoSaldoPenMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMontoSaldoPenMod.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Monto pago pendiente";
            // 
            // numMontoPagoPenMod
            // 
            this.numMontoPagoPenMod.DecimalPlaces = 4;
            this.numMontoPagoPenMod.Location = new System.Drawing.Point(172, 167);
            this.numMontoPagoPenMod.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMontoPagoPenMod.Name = "numMontoPagoPenMod";
            this.numMontoPagoPenMod.Size = new System.Drawing.Size(200, 23);
            this.numMontoPagoPenMod.TabIndex = 14;
            this.numMontoPagoPenMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMontoPagoPenMod.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Monto min. pendiente";
            // 
            // numMontoMinPenMod
            // 
            this.numMontoMinPenMod.DecimalPlaces = 4;
            this.numMontoMinPenMod.Location = new System.Drawing.Point(172, 138);
            this.numMontoMinPenMod.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMontoMinPenMod.Name = "numMontoMinPenMod";
            this.numMontoMinPenMod.Size = new System.Drawing.Size(200, 23);
            this.numMontoMinPenMod.TabIndex = 12;
            this.numMontoMinPenMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMontoMinPenMod.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Monto de crédito";
            // 
            // numMontoCredMod
            // 
            this.numMontoCredMod.DecimalPlaces = 4;
            this.numMontoCredMod.Location = new System.Drawing.Point(172, 109);
            this.numMontoCredMod.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMontoCredMod.Name = "numMontoCredMod";
            this.numMontoCredMod.Size = new System.Drawing.Size(200, 23);
            this.numMontoCredMod.TabIndex = 10;
            this.numMontoCredMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMontoCredMod.ThousandsSeparator = true;
            // 
            // txtUbicacionMod
            // 
            this.txtUbicacionMod.Location = new System.Drawing.Point(172, 80);
            this.txtUbicacionMod.MaxLength = 150;
            this.txtUbicacionMod.Name = "txtUbicacionMod";
            this.txtUbicacionMod.Size = new System.Drawing.Size(200, 23);
            this.txtUbicacionMod.TabIndex = 9;
            this.txtUbicacionMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ubicación";
            // 
            // txtCUVMod
            // 
            this.txtCUVMod.Location = new System.Drawing.Point(172, 51);
            this.txtCUVMod.MaxLength = 16;
            this.txtCUVMod.Name = "txtCUVMod";
            this.txtCUVMod.Size = new System.Drawing.Size(200, 23);
            this.txtCUVMod.TabIndex = 7;
            this.txtCUVMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "CUV";
            // 
            // txtReferenciaMod
            // 
            this.txtReferenciaMod.Location = new System.Drawing.Point(172, 22);
            this.txtReferenciaMod.MaxLength = 17;
            this.txtReferenciaMod.Name = "txtReferenciaMod";
            this.txtReferenciaMod.Size = new System.Drawing.Size(200, 23);
            this.txtReferenciaMod.TabIndex = 6;
            this.txtReferenciaMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Referencia";
            // 
            // frmViviendasMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 601);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbBusqueda);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1027, 640);
            this.Name = "frmViviendasMod";
            this.Text = "Modificar viviendas";
            this.Load += new System.EventHandler(this.frmViviendasMod_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredito)).EndInit();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoInsolutoMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoSaldoPenMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoPagoPenMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoMinPenMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoCredMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProyectos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCUV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCredito;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboEstadosMod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaMod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numSaldoInsolutoMod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numMontoSaldoPenMod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMontoPagoPenMod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMontoMinPenMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMontoCredMod;
        private System.Windows.Forms.TextBox txtUbicacionMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCUVMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReferenciaMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip tip01;
    }
}