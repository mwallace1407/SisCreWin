namespace SisCreWin.Negocio.Catalogos
{
    partial class frmTiposPagoPuentes
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
            this.chkIngActivo = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearModulo = new System.Windows.Forms.Button();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.chkModActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd01 = new System.Windows.Forms.SaveFileDialog();
            this.txtIngOrden = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModOrden = new System.Windows.Forms.NumericUpDown();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModOrden)).BeginInit();
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
            this.tabCrear.Controls.Add(this.label6);
            this.tabCrear.Controls.Add(this.txtIngOrden);
            this.tabCrear.Controls.Add(this.chkIngActivo);
            this.tabCrear.Controls.Add(this.label14);
            this.tabCrear.Controls.Add(this.btnCrearModulo);
            this.tabCrear.Controls.Add(this.txtIngNombre);
            this.tabCrear.Controls.Add(this.label3);
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
            // chkIngActivo
            // 
            this.chkIngActivo.AutoSize = true;
            this.chkIngActivo.Checked = true;
            this.chkIngActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIngActivo.Enabled = false;
            this.chkIngActivo.Location = new System.Drawing.Point(154, 100);
            this.chkIngActivo.Name = "chkIngActivo";
            this.chkIngActivo.Size = new System.Drawing.Size(15, 14);
            this.chkIngActivo.TabIndex = 2;
            this.chkIngActivo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Activo:";
            // 
            // btnCrearModulo
            // 
            this.btnCrearModulo.Location = new System.Drawing.Point(154, 120);
            this.btnCrearModulo.Name = "btnCrearModulo";
            this.btnCrearModulo.Size = new System.Drawing.Size(252, 24);
            this.btnCrearModulo.TabIndex = 3;
            this.btnCrearModulo.Text = "Crear tipo de pago";
            this.btnCrearModulo.UseVisualStyleBackColor = true;
            this.btnCrearModulo.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Location = new System.Drawing.Point(154, 41);
            this.txtIngNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngNombre.MaxLength = 20;
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(252, 23);
            this.txtIngNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción de tipo:";
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
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtModOrden);
            this.gbDatos.Controls.Add(this.txtModId);
            this.gbDatos.Controls.Add(this.chkModActivo);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtModNombre);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.btnModificar);
            this.gbDatos.Location = new System.Drawing.Point(581, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(455, 431);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Promotor seleccionado:";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(168, 23);
            this.txtModId.Margin = new System.Windows.Forms.Padding(4);
            this.txtModId.MaxLength = 100;
            this.txtModId.Name = "txtModId";
            this.txtModId.ReadOnly = true;
            this.txtModId.Size = new System.Drawing.Size(252, 23);
            this.txtModId.TabIndex = 4;
            // 
            // chkModActivo
            // 
            this.chkModActivo.AutoSize = true;
            this.chkModActivo.Location = new System.Drawing.Point(168, 113);
            this.chkModActivo.Name = "chkModActivo";
            this.chkModActivo.Size = new System.Drawing.Size(15, 14);
            this.chkModActivo.TabIndex = 6;
            this.chkModActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Activo:";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(168, 57);
            this.txtModNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtModNombre.MaxLength = 100;
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(252, 23);
            this.txtModNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción de tipo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "No. de promotor:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(168, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(252, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar promotor";
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
            this.label5.Size = new System.Drawing.Size(247, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Promotores registrados en el sistema:";
            // 
            // sfd01
            // 
            this.sfd01.CheckFileExists = true;
            this.sfd01.DefaultExt = "*.xlsx";
            this.sfd01.Filter = "Archivos de Excel|*.xlsx";
            // 
            // txtIngOrden
            // 
            this.txtIngOrden.Location = new System.Drawing.Point(154, 71);
            this.txtIngOrden.Name = "txtIngOrden";
            this.txtIngOrden.Size = new System.Drawing.Size(252, 23);
            this.txtIngOrden.TabIndex = 18;
            this.txtIngOrden.Value = new decimal(new int[] {
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
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Orden para mostrar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Orden para mostrar:";
            // 
            // txtModOrden
            // 
            this.txtModOrden.Location = new System.Drawing.Point(168, 84);
            this.txtModOrden.Name = "txtModOrden";
            this.txtModOrden.Size = new System.Drawing.Size(252, 23);
            this.txtModOrden.TabIndex = 23;
            this.txtModOrden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmTiposPagoPuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 525);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTiposPagoPuentes";
            this.Text = "Administración de tipos de pago para puentes";
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearModulo;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.SaveFileDialog sfd01;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkIngActivo;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.CheckBox chkModActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtIngOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtModOrden;
    }
}