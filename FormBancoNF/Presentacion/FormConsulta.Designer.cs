using System.Windows.Forms;

namespace FormBancoNF.Presentacion
{
    partial class FormConsulta
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApellido,
            this.colNombre,
            this.colDni,
            this.colId});
            this.dgvClientes.Location = new System.Drawing.Point(26, 60);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(295, 166);
            this.dgvClientes.TabIndex = 19;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "APELLIDO";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "NOMBRE";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "idCliente";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 20);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Location = new System.Drawing.Point(26, 35);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(202, 21);
            this.cbTipoCuenta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo cuenta:";
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 247);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.label5);
            this.Name = "FormConsulta";
            this.Text = "Clientes Actuales";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnBuscar;
        private ComboBox cbTipoCuenta;
        private Label label5;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colId;
    }
}