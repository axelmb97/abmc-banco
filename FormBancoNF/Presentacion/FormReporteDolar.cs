using FormBancoNF.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBancoNF.Presentacion
{
    public partial class FormReporteDolar : Form
    {
        
        private GestorClientes gestor;
        public FormReporteDolar()
        {
            InitializeComponent();
            gestor = new GestorClientes();
        }

        private void FormReporteDolar_Load(object sender, EventArgs e)
        {
            DataTable tabla = gestor.ClientesConME();

            this.rvClientesME.LocalReport.DataSources.Clear();
            this.rvClientesME.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("T_CLIENTES_ME",tabla));
            this.rvClientesME.RefreshReport();
        }
    }
}
