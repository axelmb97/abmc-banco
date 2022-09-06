
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBancoNF.Reportes.DatosR;
namespace FormBancoNF.Presentacion
{
    public partial class FormReportes : Form
    {
        private ConexionDB helper;
        public FormReportes()
        {
            InitializeComponent();
            helper = new ConexionDB();
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
            tabla = helper.ReporteAgrupado("SP_REPORTE_CLIENTES_SALDOS",Convert.ToDouble(txtMonto.Text));

            this.rvClientes.LocalReport.DataSources.Clear();
            //Se pone el nombre de la tabla creada en el archivo Report1.rdlc
            //Propiedades -> DataSetName
            this.rvClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("TReporte", tabla));
            this.rvClientes.RefreshReport();
        }
    }
}
