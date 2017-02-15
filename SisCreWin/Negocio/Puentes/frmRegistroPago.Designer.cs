namespace SisCreWin.Negocio.Puentes
{
    partial class frmRegistroPago
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
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPagoIntMoratorios = new System.Windows.Forms.NumericUpDown();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComiAplicacion = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInteresCapVenc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInteresCubierto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPagoCapital = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNumeroPrestamo = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoIntMoratorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComiAplicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCapVenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCubierto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal)).BeginInit();
            this.pnlProgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab01
            // 
            this.tab01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab01.Controls.Add(this.tabCrear);
            this.tab01.Controls.Add(this.tabEstadisticas);
            this.tab01.Location = new System.Drawing.Point(14, 14);
            this.tab01.Margin = new System.Windows.Forms.Padding(5);
            this.tab01.Name = "tab01";
            this.tab01.SelectedIndex = 0;
            this.tab01.Size = new System.Drawing.Size(996, 449);
            this.tab01.TabIndex = 1;
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.btnExportarExcel);
            this.tabCrear.Controls.Add(this.grdDatos);
            this.tabCrear.Controls.Add(this.groupBox1);
            this.tabCrear.Controls.Add(this.label5);
            this.tabCrear.Controls.Add(this.txtMontoTotal);
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
            this.tabCrear.Size = new System.Drawing.Size(988, 419);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarExcel.Location = new System.Drawing.Point(948, 18);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportarExcel.TabIndex = 13;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
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
            this.grdDatos.Location = new System.Drawing.Point(372, 52);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(608, 319);
            this.grdDatos.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPagoIntMoratorios);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtComiAplicacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtInteresCapVenc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInteresCubierto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPagoCapital);
            this.groupBox1.Location = new System.Drawing.Point(13, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 229);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dispersión";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Intereses moratorios:";
            // 
            // txtPagoIntMoratorios
            // 
            this.txtPagoIntMoratorios.DecimalPlaces = 6;
            this.txtPagoIntMoratorios.Location = new System.Drawing.Point(188, 151);
            this.txtPagoIntMoratorios.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPagoIntMoratorios.Name = "txtPagoIntMoratorios";
            this.txtPagoIntMoratorios.Size = new System.Drawing.Size(150, 23);
            this.txtPagoIntMoratorios.TabIndex = 8;
            this.txtPagoIntMoratorios.ValueChanged += new System.EventHandler(this.txtPagoIntMoratorios_ValueChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Image = global::SisCreWin.Properties.Resources.DivBackA_big;
            this.lblMensaje.Location = new System.Drawing.Point(11, 177);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(327, 37);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Comisión por aplicación:";
            // 
            // txtComiAplicacion
            // 
            this.txtComiAplicacion.DecimalPlaces = 6;
            this.txtComiAplicacion.Location = new System.Drawing.Point(188, 122);
            this.txtComiAplicacion.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtComiAplicacion.Name = "txtComiAplicacion";
            this.txtComiAplicacion.Size = new System.Drawing.Size(150, 23);
            this.txtComiAplicacion.TabIndex = 7;
            this.txtComiAplicacion.ValueChanged += new System.EventHandler(this.txtComiAplicacion_ValueChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "Interés sobre capital vencido cubierto:";
            // 
            // txtInteresCapVenc
            // 
            this.txtInteresCapVenc.DecimalPlaces = 6;
            this.txtInteresCapVenc.Location = new System.Drawing.Point(188, 80);
            this.txtInteresCapVenc.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtInteresCapVenc.Name = "txtInteresCapVenc";
            this.txtInteresCapVenc.Size = new System.Drawing.Size(150, 23);
            this.txtInteresCapVenc.TabIndex = 6;
            this.txtInteresCapVenc.ValueChanged += new System.EventHandler(this.txtInteresCapVenc_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Interés cubierto:";
            // 
            // txtInteresCubierto
            // 
            this.txtInteresCubierto.DecimalPlaces = 6;
            this.txtInteresCubierto.Location = new System.Drawing.Point(188, 51);
            this.txtInteresCubierto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtInteresCubierto.Name = "txtInteresCubierto";
            this.txtInteresCubierto.Size = new System.Drawing.Size(150, 23);
            this.txtInteresCubierto.TabIndex = 5;
            this.txtInteresCubierto.ValueChanged += new System.EventHandler(this.txtInteresCubierto_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pago a capital:";
            // 
            // txtPagoCapital
            // 
            this.txtPagoCapital.DecimalPlaces = 6;
            this.txtPagoCapital.Location = new System.Drawing.Point(188, 22);
            this.txtPagoCapital.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPagoCapital.Name = "txtPagoCapital";
            this.txtPagoCapital.Size = new System.Drawing.Size(150, 23);
            this.txtPagoCapital.TabIndex = 4;
            this.txtPagoCapital.ValueChanged += new System.EventHandler(this.txtPagoCapital_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto total a pagar:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.DecimalPlaces = 6;
            this.txtMontoTotal.Location = new System.Drawing.Point(165, 113);
            this.txtMontoTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(201, 23);
            this.txtMontoTotal.TabIndex = 3;
            this.txtMontoTotal.ValueChanged += new System.EventHandler(this.txtMontoTotal_ValueChanged);
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
            this.cboNumeroPrestamo.TabIndex = 2;
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
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(201, 378);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 25);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Registrar pago";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de pago:";
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
            // tabEstadisticas
            // 
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 26);
            this.tabEstadisticas.Margin = new System.Windows.Forms.Padding(5);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(5);
            this.tabEstadisticas.Size = new System.Drawing.Size(988, 419);
            this.tabEstadisticas.TabIndex = 1;
            this.tabEstadisticas.Text = "Estadísticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
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
            this.pnlProgreso.Size = new System.Drawing.Size(604, 120);
            this.pnlProgreso.TabIndex = 2;
            this.pnlProgreso.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 135);
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
            // frmRegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 477);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistroPago";
            this.Text = "Registrar pago para créditos puente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroPago_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroPago_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoIntMoratorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComiAplicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCapVenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresCubierto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagoCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal)).EndInit();
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
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnExportarExcel;
    }
}