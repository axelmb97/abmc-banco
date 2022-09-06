namespace FormBancoNF.Presentacion
{
    partial class FormReportes
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(672, 26);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Reporte";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rvClientes
            // 
            this.rvClientes.LocalReport.ReportEmbeddedResource = "FormBancoNF.Reportes.DiseniosR.Report1.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(12, 55);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.ServerReport.BearerToken = null;
            this.rvClientes.Size = new System.Drawing.Size(760, 378);
            this.rvClientes.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(178, 28);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(276, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Montos mayores a:";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.rvClientes);
            this.Controls.Add(this.btnCargar);
            this.Name = "FormReportes";
            this.Text = "Reporte totales";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
    }
}