namespace SisCreWin.Negocio.Catalogos
{
    partial class frmTIIE
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
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtModAnno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd01 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.txtIngAnno = new System.Windows.Forms.NumericUpDown();
            this.txtIngMes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngValor = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModMes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModValor = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tab01.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.tabCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModValor)).BeginInit();
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
            this.tab01.Size = new System.Drawing.Size(843, 489);
            this.tab01.TabIndex = 0;
            this.tab01.SelectedIndexChanged += new System.EventHandler(this.tab01_SelectedIndexChanged);
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
            this.tabModificar.Size = new System.Drawing.Size(835, 459);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = global::SisCreWin.Properties.Resources.xlsIcon_32;
            this.btnExportarExcel.Location = new System.Drawing.Point(453, 5);
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
            this.gbDatos.Controls.Add(this.txtModValor);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtModMes);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtModAnno);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.btnModificar);
            this.gbDatos.Location = new System.Drawing.Point(491, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(337, 420);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "TIIE seleccionada:";
            // 
            // txtModAnno
            // 
            this.txtModAnno.Location = new System.Drawing.Point(78, 23);
            this.txtModAnno.Margin = new System.Windows.Forms.Padding(4);
            this.txtModAnno.MaxLength = 100;
            this.txtModAnno.Name = "txtModAnno";
            this.txtModAnno.ReadOnly = true;
            this.txtModAnno.Size = new System.Drawing.Size(252, 23);
            this.txtModAnno.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Año:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(78, 113);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(252, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar TIIE";
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
            this.grdDatos.Size = new System.Drawing.Size(474, 412);
            this.grdDatos.TabIndex = 2;
            this.grdDatos.SelectionChanged += new System.EventHandler(this.grdDatos_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "TIIE registradas en el sistema:";
            // 
            // sfd01
            // 
            this.sfd01.CheckFileExists = true;
            this.sfd01.DefaultExt = "*.xlsx";
            this.sfd01.Filter = "Archivos de Excel|*.xlsx";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(61, 129);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(252, 24);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear TIIE";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.txtIngValor);
            this.tabCrear.Controls.Add(this.label7);
            this.tabCrear.Controls.Add(this.txtIngMes);
            this.tabCrear.Controls.Add(this.label6);
            this.tabCrear.Controls.Add(this.txtIngAnno);
            this.tabCrear.Controls.Add(this.btnCrear);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.label1);
            this.tabCrear.Location = new System.Drawing.Point(4, 26);
            this.tabCrear.Margin = new System.Windows.Forms.Padding(4);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(4);
            this.tabCrear.Size = new System.Drawing.Size(835, 459);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // txtIngAnno
            // 
            this.txtIngAnno.Location = new System.Drawing.Point(61, 42);
            this.txtIngAnno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txtIngAnno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtIngAnno.Name = "txtIngAnno";
            this.txtIngAnno.Size = new System.Drawing.Size(252, 23);
            this.txtIngAnno.TabIndex = 1;
            this.txtIngAnno.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.txtIngAnno.ValueChanged += new System.EventHandler(this.txtIngAnno_ValueChanged);
            // 
            // txtIngMes
            // 
            this.txtIngMes.Location = new System.Drawing.Point(61, 71);
            this.txtIngMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtIngMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIngMes.Name = "txtIngMes";
            this.txtIngMes.Size = new System.Drawing.Size(252, 23);
            this.txtIngMes.TabIndex = 2;
            this.txtIngMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mes:";
            // 
            // txtIngValor
            // 
            this.txtIngValor.DecimalPlaces = 4;
            this.txtIngValor.Location = new System.Drawing.Point(61, 100);
            this.txtIngValor.Name = "txtIngValor";
            this.txtIngValor.Size = new System.Drawing.Size(252, 23);
            this.txtIngValor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Valor:";
            // 
            // txtModMes
            // 
            this.txtModMes.Location = new System.Drawing.Point(78, 54);
            this.txtModMes.Margin = new System.Windows.Forms.Padding(4);
            this.txtModMes.MaxLength = 100;
            this.txtModMes.Name = "txtModMes";
            this.txtModMes.ReadOnly = true;
            this.txtModMes.Size = new System.Drawing.Size(252, 23);
            this.txtModMes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mes:";
            // 
            // txtModValor
            // 
            this.txtModValor.Location = new System.Drawing.Point(78, 84);
            this.txtModValor.Name = "txtModValor";
            this.txtModValor.Size = new System.Drawing.Size(252, 23);
            this.txtModValor.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor:";
            // 
            // frmTIIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 514);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTIIE";
            this.Text = "Administración de TIIE";
            this.Load += new System.EventHandler(this.frmTIIE_Load);
            this.tab01.ResumeLayout(false);
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.SaveFileDialog sfd01;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtModAnno;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.NumericUpDown txtIngValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtIngMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtIngAnno;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtModValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModMes;
        private System.Windows.Forms.Label label4;
    }
}