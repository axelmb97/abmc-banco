
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
    public partial class FormAlta : Form
    {
        private Cliente cliente;
        private ConexionDB helper;
        public FormAlta()
        {
            InitializeComponent();
            cliente = new Cliente();
            helper = new ConexionDB();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            CargarCombo("TIPOS_CUENTAS", cbTipoCuenta, "nombre", "id_tipo_cuenta");
            CargarCombo("SP_TIPOS_MOVIMIENTOS",cbUltimoMov,"tipo_mov","id_tipo_mov");

        }

        #region PRIVATE METHODS
        public void CargarCombo(string nombreSP,ComboBox cb,string dMember,string vMember)
        {
            DataTable tabla = helper.ConsultarSql(nombreSP);
            cb.DataSource = tabla;
            cb.ValueMember = vMember;
            cb.DisplayMember = dMember;
        }

        private void LimpiarCuenta()
        {
            txtCbu.Text = "";
            txtSaldo.Text = "";
            cbUltimoMov.SelectedValue = 1;
            cbTipoCuenta.SelectedValue = 1;
        }
        private bool Confirmar() => helper.InsertarCliente(cliente);


        private void GuardarCliente()
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = Convert.ToInt32(txtDni.Text);
            if (Confirmar())
            {
                //Si se agrega el cliente, se cierra el formulario para que la proxima vez que lo
                //abramos, se vuelva a crear un objeto vacio cliente en su constructor, y llenarlo
                //con datos
                MessageBox.Show("Cliente registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR.No se pudo registrar al cliente.Intente de nuevo");
            }
        }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Desea salir del formulario?", "Saliendo formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un dni", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    int.Parse(txtDni.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un dni valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (txtCbu.Text == "")
            {
                MessageBox.Show("Debe ingresar un CBU", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    foreach (char letra in txtCbu.Text)
                    {
                        if (!char.IsDigit(letra)) throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Debe ingresar un CBU valido,{ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtSaldo.Text == "" || !double.TryParse(txtSaldo.Text, out _))
            {
                MessageBox.Show("Debe ingresar un saldo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbUltimoMov.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un movimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTipoCuenta.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvCuentasCliente.Rows.Count == 0) gpDatosCliente.Enabled = false;
            foreach (DataGridViewRow row in dgvCuentasCliente.Rows)
            {

                if (row.Cells["colTipoCuenta"].Value.ToString().Equals(cbTipoCuenta.Text))
                {
                    MessageBox.Show("Ya ingreso una cuenta de este tipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Vamos agregando los datos que no se repiten.Los detalles.
            Cuenta cuenta = new Cuenta();
            cuenta.Cbu = txtCbu.Text;
            cuenta.Saldo = Convert.ToDouble(txtSaldo.Text);
            cuenta.UltimoMov = cbUltimoMov.Text;
            cuenta.Tipo.Id = Convert.ToInt32(cbTipoCuenta.SelectedValue);
            cuenta.Tipo.Nombre = cbTipoCuenta.Text;
            cuenta.Activo = true;
            cliente.Cuentas.Add(cuenta);
            dgvCuentasCliente.Rows.Add(new object[] { cuenta.Cbu, cuenta.Saldo, cuenta.UltimoMov, cuenta.Tipo.Nombre, cuenta.Activo });
            LimpiarCuenta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }


        private void dgvCuentasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentasCliente.CurrentCell.ColumnIndex == 4)
            {
                DialogResult msg = MessageBox.Show("Esta seguro que desea eliminar esta cuenta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes) dgvCuentasCliente.Rows.Remove(dgvCuentasCliente.CurrentRow);
                else return;
            }
        }

        
    }
}
