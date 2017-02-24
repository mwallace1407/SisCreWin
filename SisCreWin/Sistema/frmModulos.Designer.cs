namespace SisCreWin.Sistema
{
    partial class frmModulos
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
            this.btnCrearModulo = new System.Windows.Forms.Button();
            this.chkCActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtMId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.chkMActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.sfd01 = new System.Windows.Forms.SaveFileDialog();
            this.txtCFormulario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCMultiple = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkMMultiple = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMFormulario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.gbDatos.SuspendLayout();
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
            this.tabCrear.Controls.Add(this.chkCMultiple);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.txtCFormulario);
            this.tabCrear.Controls.Add(this.label10);
            this.tabCrear.Controls.Add(this.btnCrearModulo);
            this.tabCrear.Controls.Add(this.chkCActivo);
            this.tabCrear.Controls.Add(this.label4);
            this.tabCrear.Controls.Add(this.txtCDescripcion);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.txtCNombre);
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
            // btnCrearModulo
            // 
            this.btnCrearModulo.Location = new System.Drawing.Point(182, 180);
            this.btnCrearModulo.Name = "btnCrearModulo";
            this.btnCrearModulo.Size = new System.Drawing.Size(252, 23);
            this.btnCrearModulo.TabIndex = 7;
            this.btnCrearModulo.Text = "Crear módulo";
            this.btnCrearModulo.UseVisualStyleBackColor = true;
            this.btnCrearModulo.Click += new System.EventHandler(this.btnCrearModulo_Click);
            // 
            // chkCActivo
            // 
            this.chkCActivo.AutoSize = true;
            this.chkCActivo.Checked = true;
            this.chkCActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCActivo.Location = new System.Drawing.Point(182, 159);
            this.chkCActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkCActivo.Name = "chkCActivo";
            this.chkCActivo.Size = new System.Drawing.Size(15, 14);
            this.chkCActivo.TabIndex = 6;
            this.chkCActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Módulo activo:";
            // 
            // txtCDescripcion
            // 
            this.txtCDescripcion.Location = new System.Drawing.Point(182, 75);
            this.txtCDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCDescripcion.MaxLength = 150;
            this.txtCDescripcion.Name = "txtCDescripcion";
            this.txtCDescripcion.Size = new System.Drawing.Size(252, 23);
            this.txtCDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción del módulo:";
            // 
            // txtCNombre
            // 
            this.txtCNombre.Location = new System.Drawing.Point(182, 41);
            this.txtCNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNombre.MaxLength = 50;
            this.txtCNombre.Name = "txtCNombre";
            this.txtCNombre.Size = new System.Drawing.Size(252, 23);
            this.txtCNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del módulo:";
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
            this.gbDatos.Controls.Add(this.chkMMultiple);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.txtMFormulario);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.txtMId);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.btnModificarUsuario);
            this.gbDatos.Controls.Add(this.chkMActivo);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtMDescripcion);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtMNombre);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Location = new System.Drawing.Point(581, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(455, 431);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Módulo seleccionado:";
            // 
            // txtMId
            // 
            this.txtMId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMId.Location = new System.Drawing.Point(181, 23);
            this.txtMId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMId.MaxLength = 25;
            this.txtMId.Name = "txtMId";
            this.txtMId.ReadOnly = true;
            this.txtMId.Size = new System.Drawing.Size(267, 23);
            this.txtMId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "No. de módulo:";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(181, 193);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(267, 23);
            this.btnModificarUsuario.TabIndex = 14;
            this.btnModificarUsuario.Text = "Modificar módulo";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarModulo_Click);
            // 
            // chkMActivo
            // 
            this.chkMActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMActivo.AutoSize = true;
            this.chkMActivo.Location = new System.Drawing.Point(181, 172);
            this.chkMActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkMActivo.Name = "chkMActivo";
            this.chkMActivo.Size = new System.Drawing.Size(15, 14);
            this.chkMActivo.TabIndex = 13;
            this.chkMActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Módulo activo:";
            // 
            // txtMDescripcion
            // 
            this.txtMDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMDescripcion.Location = new System.Drawing.Point(181, 88);
            this.txtMDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMDescripcion.MaxLength = 150;
            this.txtMDescripcion.Name = "txtMDescripcion";
            this.txtMDescripcion.Size = new System.Drawing.Size(267, 23);
            this.txtMDescripcion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Descripción del módulo:";
            // 
            // txtMNombre
            // 
            this.txtMNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMNombre.Location = new System.Drawing.Point(181, 54);
            this.txtMNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtMNombre.MaxLength = 50;
            this.txtMNombre.Name = "txtMNombre";
            this.txtMNombre.Size = new System.Drawing.Size(267, 23);
            this.txtMNombre.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre del módulo:";
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
            this.label5.Size = new System.Drawing.Size(227, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Módulos registrados en el sistema:";
            // 
            // sfd01
            // 
            this.sfd01.CheckFileExists = true;
            this.sfd01.DefaultExt = "*.xlsx";
            this.sfd01.Filter = "Archivos de Excel|*.xlsx";
            // 
            // txtCFormulario
            // 
            this.txtCFormulario.Location = new System.Drawing.Point(182, 106);
            this.txtCFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCFormulario.MaxLength = 150;
            this.txtCFormulario.Name = "txtCFormulario";
            this.txtCFormulario.Size = new System.Drawing.Size(252, 23);
            this.txtCFormulario.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Formulario del módulo:";
            // 
            // chkCMultiple
            // 
            this.chkCMultiple.AutoSize = true;
            this.chkCMultiple.Checked = true;
            this.chkCMultiple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCMultiple.Location = new System.Drawing.Point(182, 137);
            this.chkCMultiple.Margin = new System.Windows.Forms.Padding(4);
            this.chkCMultiple.Name = "chkCMultiple";
            this.chkCMultiple.Size = new System.Drawing.Size(15, 14);
            this.chkCMultiple.TabIndex = 11;
            this.chkCMultiple.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Módulo múltiple:";
            // 
            // chkMMultiple
            // 
            this.chkMMultiple.AutoSize = true;
            this.chkMMultiple.Location = new System.Drawing.Point(181, 150);
            this.chkMMultiple.Margin = new System.Windows.Forms.Padding(4);
            this.chkMMultiple.Name = "chkMMultiple";
            this.chkMMultiple.Size = new System.Drawing.Size(15, 14);
            this.chkMMultiple.TabIndex = 20;
            this.chkMMultiple.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Módulo múltiple:";
            // 
            // txtMFormulario
            // 
            this.txtMFormulario.Location = new System.Drawing.Point(181, 119);
            this.txtMFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFormulario.MaxLength = 150;
            this.txtMFormulario.Name = "txtMFormulario";
            this.txtMFormulario.Size = new System.Drawing.Size(267, 23);
            this.txtMFormulario.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Formulario del módulo:";
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 525);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModulos";
            this.Text = "Administración de módulos";
            this.Load += new System.EventHandler(this.frmModulos_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab01;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.CheckBox chkCActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearModulo;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.CheckBox chkMActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.SaveFileDialog sfd01;
        private System.Windows.Forms.CheckBox chkCMultiple;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCFormulario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkMMultiple;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMFormulario;
        private System.Windows.Forms.Label label13;
    }
}