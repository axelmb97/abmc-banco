
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
    public partial class FormBaja : Form
    {
        private ConexionDB helper;
        public FormBaja()
        {
            InitializeComponent();
            helper = new ConexionDB();
        }
        private void FormBaja_Load(object sender, EventArgs e)
        {
            CargarCombo();

        }
        #region PRIVATE METHODS
        private void CargarCombo()
        {
            DataTable tabla = helper.ConsultarSql("SP_CLIENTES");
            tabla.Columns.Add("nombre_completo", typeof(String), "apellido + ' ' + nombre");
            //            foreach (DataRow row in tabla.Rows) {
            //;            }
            cbCliente.DataSource = tabla;
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "nombre_completo";
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cbCliente.SelectedItem;
            //MessageBox.Show($"{item}");
            int idCliente = Convert.ToInt32(item.Row.ItemArray[0]);
            DataTable tabla = helper.ConsultarCuentas("SP_CLIENTES_Y_CUENTAS", idCliente);
            dgvCuentasCliente.Rows.Clear();
            foreach (DataRow row in tabla.Rows)
            {
                Cuenta c = new Cuenta();
                c.Cbu = row["cbu"].ToString();
                c.Saldo = Convert.ToDouble(row["saldo"]);
                c.UltimoMov = row["ultimo_mov"].ToString();
                c.Tipo.Nombre = row["nombre"].ToString();
                c.Activo = Convert.ToBoolean(row["activo"].ToString());
                dgvCuentasCliente.Rows.Add(c.Cbu, c.Saldo, c.UltimoMov, c.Tipo.Nombre, c.Activo);
            }
        }




        private void dgvCuentasCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentasCliente.CurrentCell.ColumnIndex == 4)
            {
                DialogResult msg = MessageBox.Show("Esta seguro que desea dar de baja esta cuenta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    DataRowView item = (DataRowView)cbCliente.SelectedItem;
                    helper.BajaLogica(Convert.ToInt32(item.Row.ItemArray[0]), dgvCuentasCliente.CurrentRow.Cells["colCbu"].Value.ToString());
                    dgvCuentasCliente.Rows.Remove(dgvCuentasCliente.CurrentRow);

                }
                else return;
            }
        }

        
    }
}
