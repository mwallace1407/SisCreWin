namespace SisCreWin
{
    partial class frmInfo
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
            this.pnlDatosSistema = new System.Windows.Forms.Panel();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.grdInfo = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrMtto = new System.Windows.Forms.Timer(this.components);
            this.pnlDatosSistema.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosSistema
            // 
            this.pnlDatosSistema.Controls.Add(this.gbParametros);
            this.pnlDatosSistema.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosSistema.Name = "pnlDatosSistema";
            this.pnlDatosSistema.Size = new System.Drawing.Size(400, 250);
            this.pnlDatosSistema.TabIndex = 6;
            // 
            // gbParametros
            // 
            this.gbParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParametros.Controls.Add(this.grdInfo);
            this.gbParametros.Location = new System.Drawing.Point(3, 3);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(394, 244);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros del sistema";
            // 
            // grdInfo
            // 
            this.grdInfo.AllowUserToAddRows = false;
            this.grdInfo.AllowUserToResizeColumns = false;
            this.grdInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.Valor});
            this.grdInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdInfo.Location = new System.Drawing.Point(6, 22);
            this.grdInfo.Name = "grdInfo";
            this.grdInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdInfo.ShowCellErrors = false;
            this.grdInfo.ShowEditingIcon = false;
            this.grdInfo.ShowRowErrors = false;
            this.grdInfo.Size = new System.Drawing.Size(382, 216);
            this.grdInfo.TabIndex = 0;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 165;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 165;
            // 
            // tmrMtto
            // 
            this.tmrMtto.Enabled = true;
            this.tmrMtto.Interval = 30000;
            this.tmrMtto.Tick += new System.EventHandler(this.tmrMtto_Tick);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.pnlDatosSistema);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimizeBox = false;
            this.Name = "frmInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmInfo";
            this.Activated += new System.EventHandler(this.frmInfo_Activated);
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.pnlDatosSistema.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosSistema;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.DataGridView grdInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Timer tmrMtto;
    }
}