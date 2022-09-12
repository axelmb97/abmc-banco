using System.Windows.Forms;

namespace FormBancoNF.Presentacion
{
    partial class FormBaja
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
            this.dgvCuentasCliente = new System.Windows.Forms.DataGridView();
            this.colCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuentasCliente
            // 
            this.dgvCuentasCliente.AllowUserToAddRows = false;
            this.dgvCuentasCliente.AllowUserToDeleteRows = false;
            this.dgvCuentasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCbu,
            this.colSaldo,
            this.colUltMov,
            this.colTipoCuenta,
            this.colCodCuenta,
            this.colActivo,
            this.colAccion});
            this.dgvCuentasCliente.Location = new System.Drawing.Point(10, 34);
            this.dgvCuentasCliente.Name = "dgvCuentasCliente";
            this.dgvCuentasCliente.ReadOnly = true;
            this.dgvCuentasCliente.RowTemplate.Height = 25;
            this.dgvCuentasCliente.Size = new System.Drawing.Size(550, 199);
            this.dgvCuentasCliente.TabIndex = 31;
            this.dgvCuentasCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasCliente_CellContentClick);
            // 
            // colCbu
            // 
            this.colCbu.HeaderText = "CBU";
            this.colCbu.Name = "colCbu";
            this.colCbu.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "SALDO";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // colUltMov
            // 
            this.colUltMov.HeaderText = "ULT. MOV.";
            this.colUltMov.Name = "colUltMov";
            this.colUltMov.ReadOnly = true;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoCuenta.HeaderText = "TIPO CUENTA";
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.ReadOnly = true;
            // 
            // colCodCuenta
            // 
            this.colCodCuenta.HeaderText = "codigoCuenta";
            this.colCodCuenta.Name = "colCodCuenta";
            this.colCodCuenta.ReadOnly = true;
            this.colCodCuenta.Visible = false;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Visible = false;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Acciones";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccion.Text = "Dar de baja";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // FormBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.dgvCuentasCliente);
            this.Name = "FormBaja";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FormBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvCuentasCliente;
        private DataGridViewTextBoxColumn colCbu;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridViewTextBoxColumn colUltMov;
        private DataGridViewTextBoxColumn colTipoCuenta;
        private DataGridViewTextBoxColumn colCodCuenta;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewButtonColumn colAccion;
    }
}