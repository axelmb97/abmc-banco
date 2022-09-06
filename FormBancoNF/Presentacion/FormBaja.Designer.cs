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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCuentasCliente = new System.Windows.Forms.DataGridView();
            this.colCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(10, 34);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(260, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 20);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
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
            this.colAccion,
            this.colActivo});
            this.dgvCuentasCliente.Location = new System.Drawing.Point(10, 83);
            this.dgvCuentasCliente.Name = "dgvCuentasCliente";
            this.dgvCuentasCliente.ReadOnly = true;
            this.dgvCuentasCliente.RowTemplate.Height = 25;
            this.dgvCuentasCliente.Size = new System.Drawing.Size(550, 150);
            this.dgvCuentasCliente.TabIndex = 31;
            this.dgvCuentasCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasCliente_CellContentClick_1);
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
            // colActivo
            // 
            this.colActivo.HeaderText = "activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Visible = false;
            // 
            // FormBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.dgvCuentasCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbCliente);
            this.Name = "FormBaja";
            this.Text = "FormBajaCuenta";
            this.Load += new System.EventHandler(this.FormBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbCliente;
        private Button btnBuscar;
        private DataGridView dgvCuentasCliente;
        private DataGridViewTextBoxColumn colCbu;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridViewTextBoxColumn colUltMov;
        private DataGridViewTextBoxColumn colTipoCuenta;
        private DataGridViewButtonColumn colAccion;
        private DataGridViewTextBoxColumn colActivo;
    }
}