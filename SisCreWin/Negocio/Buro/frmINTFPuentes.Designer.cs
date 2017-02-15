﻿namespace SisCreWin.Negocio.Buro
{
    partial class frmINTFPuentes
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
            this.dtpFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.pnlProgreso = new System.Windows.Forms.Panel();
            this.wkr01 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fbd01 = new System.Windows.Forms.FolderBrowserDialog();
            this.tab01.SuspendLayout();
            this.tabCrear.SuspendLayout();
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
            this.tab01.Size = new System.Drawing.Size(751, 341);
            this.tab01.TabIndex = 1;
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.dtpPeriodo);
            this.tabCrear.Controls.Add(this.label4);
            this.tabCrear.Controls.Add(this.dtpFechaDocumento);
            this.tabCrear.Controls.Add(this.btnCrear);
            this.tabCrear.Controls.Add(this.label3);
            this.tabCrear.Controls.Add(this.label1);
            this.tabCrear.Location = new System.Drawing.Point(4, 26);
            this.tabCrear.Margin = new System.Windows.Forms.Padding(5);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(5);
            this.tabCrear.Size = new System.Drawing.Size(743, 311);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDocumento
            // 
            this.dtpFechaDocumento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDocumento.Location = new System.Drawing.Point(175, 46);
            this.dtpFechaDocumento.Name = "dtpFechaDocumento";
            this.dtpFechaDocumento.Size = new System.Drawing.Size(150, 23);
            this.dtpFechaDocumento.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(175, 105);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 25);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Generar INTF";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha del documento:";
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
            this.tabEstadisticas.Size = new System.Drawing.Size(743, 311);
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
            this.pnlProgreso.Size = new System.Drawing.Size(10, 10);
            this.pnlProgreso.TabIndex = 2;
            this.pnlProgreso.Visible = false;
            // 
            // wkr01
            // 
            this.wkr01.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkr01_DoWork);
            this.wkr01.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wkr01_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procesando...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.CustomFormat = "MM/yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Location = new System.Drawing.Point(175, 75);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(150, 23);
            this.dtpPeriodo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periodo a obtener:";
            // 
            // frmINTFPuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 369);
            this.Controls.Add(this.pnlProgreso);
            this.Controls.Add(this.tab01);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmINTFPuentes";
            this.Text = "Generar INTF para puentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCSVIndividuales_FormClosing);
            this.Load += new System.EventHandler(this.frmCSVIndividuales_Load);
            this.tab01.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpFechaDocumento;
        private System.Windows.Forms.Panel pnlProgreso;
        private System.ComponentModel.BackgroundWorker wkr01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog fbd01;
    }
}