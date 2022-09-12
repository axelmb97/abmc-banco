
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
        private int idCliente;
        public FormBaja(int idCliente)
        {
            InitializeComponent();
            helper = new ConexionDB();
            this.idCliente = idCliente;
        }
        private void FormBaja_Load(object sender, EventArgs e)
        {
            CargarLista(idCliente);

        }
        #region PRIVATE METHODS
        //private void CargarCombo()
        //{
        //    DataTable tabla = helper.ConsultarSql("SP_CLIENTES");
        //    tabla.Columns.Add("nombre_completo", typeof(String), "apellido + ' ' + nombre");
        //    //            foreach (DataRow row in tabla.Rows) {
        //    //;            }
        //    cbCliente.DataSource = tabla;
        //    cbCliente.ValueMember = "id_cliente";
        //    cbCliente.DisplayMember = "nombre_completo";
        //    cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        //}
        private void CargarLista(int idCliente) {
            DataTable tabla = helper.ConsultarCuentas("SP_CLIENTES_Y_CUENTAS", idCliente);
            dgvCuentasCliente.Rows.Clear();
            foreach (DataRow row in tabla.Rows)
            {
                Cuenta c = new Cuenta();
                c.CodCuenta = Convert.ToInt32(row["cod_cuenta"]);
                c.Cbu = row["cbu"].ToString();
                c.Saldo = Convert.ToDouble(row["saldo"]);
                c.UltimoMov = row["ultimo_mov"].ToString();
                c.Tipo.Nombre = row["nombre"].ToString();
                c.Activo = Convert.ToBoolean(row["activo"].ToString());
                dgvCuentasCliente.Rows.Add(c.Cbu, c.Saldo, c.UltimoMov, c.Tipo.Nombre,c.CodCuenta, c.Activo);
            }
        }
        #endregion

        //private void btnBuscar_Click_1(object sender, EventArgs e)
        //{
        //    DataRowView item = (DataRowView)cbCliente.SelectedItem;
        //    //MessageBox.Show($"{item}");
        //    int idCliente = Convert.ToInt32(item.Row.ItemArray[0]);
        //    DataTable tabla = helper.ConsultarCuentas("SP_CLIENTES_Y_CUENTAS", idCliente);
        //    dgvCuentasCliente.Rows.Clear();
        //    foreach (DataRow row in tabla.Rows)
        //    {
        //        Cuenta c = new Cuenta();
        //        c.Cbu = row["cbu"].ToString();
        //        c.Saldo = Convert.ToDouble(row["saldo"]);
        //        c.UltimoMov = row["ultimo_mov"].ToString();
        //        c.Tipo.Nombre = row["nombre"].ToString();
        //        c.Activo = Convert.ToBoolean(row["activo"].ToString());
        //        dgvCuentasCliente.Rows.Add(c.Cbu, c.Saldo, c.UltimoMov, c.Tipo.Nombre, c.Activo);
        //    }
        //}




        private void dgvCuentasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentasCliente.CurrentCell.ColumnIndex == 6)
            {
                DialogResult msg = MessageBox.Show("Esta seguro que desea dar de baja esta cuenta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    
                    int resultado = helper.BajaLogica((int)dgvCuentasCliente.CurrentRow.Cells["colCodCuenta"].Value);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de baja la cuenta correctamente");
                        dgvCuentasCliente.Rows.Remove(dgvCuentasCliente.CurrentRow);
                    }
                    else {
                        MessageBox.Show("Error al dar de baja la cuenta.Intente de nuevo");
                    }

                }
                else return;
            }
           
        }

        
    }
}
