namespace FormBancoNF.Presentacion
{
    partial class FormReporteDolar
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
            this.rvClientesME = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvClientesME
            // 
            this.rvClientesME.LocalReport.ReportEmbeddedResource = "FormBancoNF.Reportes.DiseniosR.ReporteME.rdlc";
            this.rvClientesME.Location = new System.Drawing.Point(26, 30);
            this.rvClientesME.Name = "rvClientesME";
            this.rvClientesME.ServerReport.BearerToken = null;
            this.rvClientesME.Size = new System.Drawing.Size(634, 305);
            this.rvClientesME.TabIndex = 0;
            // 
            // FormReporteDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.rvClientesME);
            this.Name = "FormReporteDolar";
            this.Text = "Usuarios con ME";
            this.Load += new System.EventHandler(this.FormReporteDolar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClientesME;
    }
}