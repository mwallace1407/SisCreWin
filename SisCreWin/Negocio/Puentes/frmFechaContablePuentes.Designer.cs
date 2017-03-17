namespace SisCreWin.Negocio.Puentes
{
    partial class frmFechaContablePuentes
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tip01 = new System.Windows.Forms.ToolTip(this.components);
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(92, 46);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(196, 23);
            this.dtpFecha.TabIndex = 3;
            this.tip01.SetToolTip(this.dtpFecha, "Al seleccionar cualquier fecha de un mes el sistema automáticamente asignará el ú" +
        "ltimo día de ese mes");
            this.dtpFecha.Value = new System.DateTime(2017, 3, 17, 0, 0, 0, 0);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(92, 76);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(196, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Establecer fecha contable";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Location = new System.Drawing.Point(92, 20);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(196, 22);
            this.lblFechaActual.TabIndex = 5;
            this.lblFechaActual.Text = "label1";
            this.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFechaContablePuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 119);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dtpFecha);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFechaContablePuentes";
            this.Text = "Establecer fecha contable para créditos puente";
            this.Load += new System.EventHandler(this.frmFechaContablePuentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ToolTip tip01;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblFechaActual;
    }
}