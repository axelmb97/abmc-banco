using System.Windows.Forms;

namespace FormBancoNF.PilasYColas
{
    partial class FormPilasColas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPilas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColas = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.resultadoPila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoCola = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVacio = new System.Windows.Forms.Button();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.txtAgregarPila = new System.Windows.Forms.TextBox();
            this.txtAgregarCola = new System.Windows.Forms.TextBox();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(360, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cola";
            // 
            // lbPilas
            // 
            this.lbPilas.FormattingEnabled = true;
            this.lbPilas.Location = new System.Drawing.Point(44, 138);
            this.lbPilas.Name = "lbPilas";
            this.lbPilas.Size = new System.Drawing.Size(237, 134);
            this.lbPilas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(35, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar elemento";
            // 
            // lbColas
            // 
            this.lbColas.FormattingEnabled = true;
            this.lbColas.Location = new System.Drawing.Point(360, 138);
            this.lbColas.Name = "lbColas";
            this.lbColas.Size = new System.Drawing.Size(229, 134);
            this.lbColas.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(365, 370);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 20);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // resultadoPila
            // 
            this.resultadoPila.Enabled = false;
            this.resultadoPila.Location = new System.Drawing.Point(44, 317);
            this.resultadoPila.Name = "resultadoPila";
            this.resultadoPila.Size = new System.Drawing.Size(149, 20);
            this.resultadoPila.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(44, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultados";
            // 
            // resultadoCola
            // 
            this.resultadoCola.Enabled = false;
            this.resultadoCola.Location = new System.Drawing.Point(360, 317);
            this.resultadoCola.Name = "resultadoCola";
            this.resultadoCola.Size = new System.Drawing.Size(149, 20);
            this.resultadoCola.TabIndex = 9;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(288, 370);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(64, 20);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Primero";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVacio
            // 
            this.btnVacio.Location = new System.Drawing.Point(211, 370);
            this.btnVacio.Name = "btnVacio";
            this.btnVacio.Size = new System.Drawing.Size(64, 20);
            this.btnVacio.TabIndex = 10;
            this.btnVacio.Text = "Vacio?";
            this.btnVacio.UseVisualStyleBackColor = true;
            this.btnVacio.Click += new System.EventHandler(this.btnVacio_Click);
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.Location = new System.Drawing.Point(207, 52);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(64, 20);
            this.btnAgregarPila.TabIndex = 2;
            this.btnAgregarPila.Text = "Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = true;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // txtAgregarPila
            // 
            this.txtAgregarPila.Location = new System.Drawing.Point(44, 52);
            this.txtAgregarPila.Name = "txtAgregarPila";
            this.txtAgregarPila.Size = new System.Drawing.Size(149, 20);
            this.txtAgregarPila.TabIndex = 1;
            // 
            // txtAgregarCola
            // 
            this.txtAgregarCola.Location = new System.Drawing.Point(360, 52);
            this.txtAgregarCola.Name = "txtAgregarCola";
            this.txtAgregarCola.Size = new System.Drawing.Size(149, 20);
            this.txtAgregarCola.TabIndex = 12;
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.Location = new System.Drawing.Point(524, 51);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(64, 20);
            this.btnAgregarCola.TabIndex = 13;
            this.btnAgregarCola.Text = "Agregar";
            this.btnAgregarCola.UseVisualStyleBackColor = true;
            this.btnAgregarCola.Click += new System.EventHandler(this.btnAgregarCola_Click);
            // 
            // FormPilasColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 423);
            this.Controls.Add(this.btnAgregarCola);
            this.Controls.Add(this.txtAgregarCola);
            this.Controls.Add(this.btnVacio);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbColas);
            this.Controls.Add(this.lbPilas);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarPila);
            this.Controls.Add(this.resultadoCola);
            this.Controls.Add(this.resultadoPila);
            this.Controls.Add(this.txtAgregarPila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormPilasColas";
            this.Text = "Pagina principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbPilas;
        private Label label3;
        private ListBox lbColas;
        private Button btnBorrar;
        private TextBox resultadoPila;
        private Label label4;
        private TextBox resultadoCola;
        private Button btnMostrar;
        private Button btnVacio;
        private Button btnAgregarPila;
        private TextBox txtAgregarPila;
        private TextBox txtAgregarCola;
        private Button btnAgregarCola;
    }
}