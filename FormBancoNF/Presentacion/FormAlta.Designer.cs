using System.Windows.Forms;

namespace FormBancoNF.Presentacion
{
    partial class FormAlta
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
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpDatosCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpDatosCuenta = new System.Windows.Forms.GroupBox();
            this.txtUltimoMov = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).BeginInit();
            this.gpDatosCliente.SuspendLayout();
            this.gpDatosCuenta.SuspendLayout();
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
            this.colAccion,
            this.colActivo});
            this.dgvCuentasCliente.Location = new System.Drawing.Point(26, 256);
            this.dgvCuentasCliente.Name = "dgvCuentasCliente";
            this.dgvCuentasCliente.ReadOnly = true;
            this.dgvCuentasCliente.RowTemplate.Height = 25;
            this.dgvCuentasCliente.Size = new System.Drawing.Size(550, 150);
            this.dgvCuentasCliente.TabIndex = 30;
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
            // colAccion
            // 
            this.colAccion.HeaderText = "Acciones";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccion.Text = "Eliminar";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Visible = false;
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Location = new System.Drawing.Point(26, 214);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(279, 21);
            this.cbTipoCuenta.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(24, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo cuenta:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(297, 426);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(7);
            this.btnCancelar.Size = new System.Drawing.Size(73, 37);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(216, 426);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(7);
            this.btnGuardar.Size = new System.Drawing.Size(69, 37);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(327, 205);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(7);
            this.btnAgregar.Size = new System.Drawing.Size(104, 37);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpDatosCliente
            // 
            this.gpDatosCliente.Controls.Add(this.label3);
            this.gpDatosCliente.Controls.Add(this.txtDni);
            this.gpDatosCliente.Controls.Add(this.txtApellido);
            this.gpDatosCliente.Controls.Add(this.txtNombre);
            this.gpDatosCliente.Controls.Add(this.label2);
            this.gpDatosCliente.Controls.Add(this.label1);
            this.gpDatosCliente.Location = new System.Drawing.Point(24, 13);
            this.gpDatosCliente.Name = "gpDatosCliente";
            this.gpDatosCliente.Size = new System.Drawing.Size(279, 171);
            this.gpDatosCliente.TabIndex = 34;
            this.gpDatosCliente.TabStop = false;
            this.gpDatosCliente.Text = "Datos Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(17, 136);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(176, 20);
            this.txtDni.TabIndex = 36;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(17, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // gpDatosCuenta
            // 
            this.gpDatosCuenta.Controls.Add(this.txtUltimoMov);
            this.gpDatosCuenta.Controls.Add(this.txtSaldo);
            this.gpDatosCuenta.Controls.Add(this.txtCbu);
            this.gpDatosCuenta.Controls.Add(this.label6);
            this.gpDatosCuenta.Controls.Add(this.label7);
            this.gpDatosCuenta.Controls.Add(this.label4);
            this.gpDatosCuenta.Location = new System.Drawing.Point(308, 13);
            this.gpDatosCuenta.Name = "gpDatosCuenta";
            this.gpDatosCuenta.Size = new System.Drawing.Size(268, 171);
            this.gpDatosCuenta.TabIndex = 35;
            this.gpDatosCuenta.TabStop = false;
            this.gpDatosCuenta.Text = "Datos por cuenta";
            // 
            // txtUltimoMov
            // 
            this.txtUltimoMov.Location = new System.Drawing.Point(7, 137);
            this.txtUltimoMov.Name = "txtUltimoMov";
            this.txtUltimoMov.Size = new System.Drawing.Size(254, 20);
            this.txtUltimoMov.TabIndex = 32;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(7, 90);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(176, 20);
            this.txtSaldo.TabIndex = 30;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(7, 41);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(254, 20);
            this.txtCbu.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ultimo movimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "CBU:";
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 477);
            this.Controls.Add(this.gpDatosCuenta);
            this.Controls.Add(this.gpDatosCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvCuentasCliente);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.label5);
            this.Name = "FormAlta";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).EndInit();
            this.gpDatosCliente.ResumeLayout(false);
            this.gpDatosCliente.PerformLayout();
            this.gpDatosCuenta.ResumeLayout(false);
            this.gpDatosCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCuentasCliente;
        private ComboBox cbTipoCuenta;
        private Label label5;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnAgregar;
        private GroupBox gpDatosCliente;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private GroupBox gpDatosCuenta;
        private TextBox txtUltimoMov;
        private TextBox txtSaldo;
        private TextBox txtCbu;
        private Label label6;
        private Label label7;
        private Label label4;
        private DataGridViewTextBoxColumn colCbu;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridViewTextBoxColumn colUltMov;
        private DataGridViewTextBoxColumn colTipoCuenta;
        private DataGridViewButtonColumn colAccion;
        private DataGridViewTextBoxColumn colActivo;
    }
}