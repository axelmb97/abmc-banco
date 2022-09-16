using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBancoNF.PilasYColas
{
    public partial class FormPilasColas : Form
    {
        private Pila pila;
        private Cola cola;
        public FormPilasColas()
        {
            InitializeComponent();
            pila = new Pila();
            cola = new Cola();
        }

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            if (txtAgregarPila.Text == "")
            {
                MessageBox.Show("Debe ingresar un elemento a pila");
                return;
            }
            if (pila.Agregar(txtAgregarPila.Text))
            {

                lbPilas.Items.Add(txtAgregarPila.Text);

            }
            else
            {
                MessageBox.Show("No se pudo ingrear el elemento a pilas");
            }
            txtAgregarPila.Text = "";
            txtAgregarPila.Focus();
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            if (txtAgregarCola.Text == "")
            {
                MessageBox.Show("Debe ingresar un elemento");
                return;
            }
            if (cola.Agregar(txtAgregarCola.Text))
            {

                lbColas.Items.Add(txtAgregarCola.Text);
            }
            else
            {
                MessageBox.Show("No se pudo ingrear el elemento");
            }
            txtAgregarCola.Text = "";
            txtAgregarCola.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!pila.EstaVacia())
            {
                resultadoPila.Text = pila.Extraer().ToString();
                lbPilas.Items.RemoveAt(lbPilas.Items.Count - 1);

            }
            else MessageBox.Show("No se puede extrar nada de la pila porque esta vacia");
            if (!cola.EstaVacia())
            {
                resultadoCola.Text = cola.Extraer().ToString();
                lbColas.Items.RemoveAt(0);
            }
            else MessageBox.Show("No se puede extrar nada de la cola porque esta vacia");
        }

        private void btnVacio_Click(object sender, EventArgs e)
        {
            string vacio = "Esta vacio";
            if (pila.EstaVacia()) resultadoPila.Text = vacio;
            else resultadoPila.Text = "No " + vacio;
            if (cola.EstaVacia()) resultadoCola.Text = vacio;
            else resultadoCola.Text = "No " + vacio;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!pila.EstaVacia()) resultadoPila.Text = pila.Primero().ToString();
            else MessageBox.Show("No se puede mostrar nada de la pila porque esta vacia");

            if (!cola.EstaVacia()) resultadoCola.Text = cola.Primero().ToString();
            else MessageBox.Show("No se puede mostrar nada de la pila porque esta vacia");
        }
    }
}
