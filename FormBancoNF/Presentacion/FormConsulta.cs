
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
    public partial class FormConsulta : Form
    {
        private ConexionDB helper;
        public FormConsulta()
        {
            InitializeComponent();
            helper = new ConexionDB();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            CargarLista(1);
            CargarCombo();

        }

       
        #region PRIVATE METHODS
        private void CargarLista(int tipoCuenta)
        {
            DataTable tabla = helper.ConsultaPorCuenta("DATOS_CLIENTES", tipoCuenta);

            dgvClientes.Rows.Clear();
            foreach (DataRow row in tabla.Rows)
            {
                Cliente c = new Cliente();

                //En este caso si o si edbremos usar DataRow porque estamos sacado las filas de la tabla.
                //Y un objeto DataRow es una representacion de una fila de un DataTable
                //En el caso de querer verificar fila por fila de un DataGridView, alguna condicion,deberiamos
                //usar DataGridViewRow,ya que no estamos sacando las filsa de un DataTable, estamos sacando
                //las filas de un DataGridView y el objeto que representa una fila de ese componente es
                //DataGridVewRow
                //Con DataRow
                c.IdCliente = (int)row["id_CLiente"];
                c.Nombre = row["nombre"].ToString();
                c.Apellido = row["apellido"].ToString();
                c.Dni = (int)row["dni"];

                // Con DataGridViewRow
                //c.IdCliente = (int)row.Cells["id_CLiente"].Value;
                //c.Nombre = row.Cells["nombre"].Value.ToString();
                //c.Apellido = row.Cells["apellido"].Value.ToString();
                //c.Dni = (int)row.Cells["dni"].Value;
                dgvClientes.Rows.Add(new object[] { c.Apellido, c.Nombre, c.Dni, c.IdCliente });
            }
            dgvClientes.ClearSelection();
        }
        public void CargarCombo()
        {
            DataTable tabla = helper.ConsultarSql("TIPOS_CUENTAS");
            cbTipoCuenta.DataSource = tabla;
            cbTipoCuenta.ValueMember = "id_tipo_cuenta";
            cbTipoCuenta.DisplayMember = "nombre";
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarLista((int)cbTipoCuenta.SelectedValue);
        }

    }
}
