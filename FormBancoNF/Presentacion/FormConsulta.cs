
using FormBancoNF.Dominio;
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
            CargarLista();
        }

       
        #region PRIVATE METHODS
        private void CargarLista()
        {
            DataTable tabla = ckbCuentasBajas.Checked ? helper.ConsultarSql("DATOS_CLIENTES_Y_BAJAS") : helper.ConsultarSql("DATOS_CLIENTES");

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
                if (row["fecha_baja"] == DBNull.Value) c.FechaBaja = "";
                else  c.FechaBaja = row["fecha_baja"].ToString();
                // Con DataGridViewRow
                //c.IdCliente = (int)row.Cells["id_CLiente"].Value;
                //c.Nombre = row.Cells["nombre"].Value.ToString();
                //c.Apellido = row.Cells["apellido"].Value.ToString();
                //c.Dni = (int)row.Cells["dni"].Value;
                dgvClientes.Rows.Add(new object[] { c.Apellido, c.Nombre, c.Dni,c.FechaBaja, c.IdCliente });
            }
            dgvClientes.ClearSelection();
        }

        #endregion

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentCell.ColumnIndex == 5) {
                FormBaja baja = new FormBaja((int)dgvClientes.CurrentRow.Cells["colId"].Value);
                baja.ShowDialog();
            }
            if (dgvClientes.CurrentCell.ColumnIndex == 6)
            {
                string cliente = dgvClientes.CurrentRow.Cells["colApellido"].Value.ToString();
                DialogResult msg = MessageBox.Show($"Esta seguro que desea dar de baja a {cliente}","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (msg == DialogResult.Yes) {

                    int resultado = helper.EliminarCuenta((int)dgvClientes.CurrentRow.Cells["colId"].Value);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente correctamente dado de baja");
                    }
                    else {
                        MessageBox.Show("Hubo incovenientes al dar de baja este usuario.Intente de nuevo");
                    }
                    CargarLista();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ckbCuentasBajas_CheckedChanged(object sender, EventArgs e)
        {
            CargarLista();
        }
    }
}
