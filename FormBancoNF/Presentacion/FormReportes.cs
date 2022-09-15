
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBancoNF.Negocios;
using FormBancoNF.Reportes.DatosR;
namespace FormBancoNF.Presentacion
{
    public partial class FormReportes : Form
    {

        private GestorClientes gestor;
        public FormReportes()
        {
            InitializeComponent();
            gestor = new GestorClientes();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            txtMonto.Text = "0";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "") {
                MessageBox.Show("Debe ingresar un monto.");
                return;
            }
            if (!int.TryParse(txtMonto.Text, out _)) { 
                
                MessageBox.Show("Solo puede ingresar datos numericos");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = gestor.ClientesConMontosMayores(Convert.ToDouble(txtMonto.Text));

            this.rvClientes.LocalReport.DataSources.Clear();
            //Se pone el nombre de la tabla creada en el archivo Report1.rdlc
            //Propiedades -> DataSetName
            this.rvClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("TReporte", tabla));
            this.rvClientes.RefreshReport();
        }
    }
}
