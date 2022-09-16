
using FormBancoNF.PilasYColas;
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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }
        private void FormIndex_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        #region PRIVATE METHODS


        //private void Limpiar() {
        //    txtNombre.Text = "";
        //    txtApellido.Text = "";
        //    txtDni.Text = "";
        //    txtCbu.Text = "";
        //    txtSaldo.Text = "";
        //    txtUltimoMov.Text = "";
        //}
        //private void HabilitarBotones(bool v) {
        //    btnNuevo.Enabled = v;
        //    btnEditar.Enabled = v;
        //    btnEliminar.Enabled = v;
        //    btnGuardar.Enabled = !v;
        //    btnCancelar.Enabled = !v;
        //    btnSalir.Enabled = v;
        //}
        //private void HabilitarCampos(bool v) {
        //    txtNombre.Enabled = v;
        //    txtApellido.Enabled = v;
        //    txtDni.Enabled = v;
        //    txtCbu.Enabled = v;
        //    txtSaldo.Enabled = v;
        //    cbTipoCuenta.Enabled = v;
        //    txtUltimoMov.Enabled = v;
        //}

        #endregion

        #region EVENTS


        //private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvClientes.CurrentRow.Index > -1)
        //    {
        //        Cliente c = (Cliente)dgvClientes.CurrentRow.Ite;
        //        txtNombre.Text = dgvClientes.CurrentRow.Cells["colNombre"].Value.ToString();
        //        txtApellido.Text = dgvClientes.CurrentRow.Cells["colApellido"].Value.ToString();
        //        txtDni.Text = dgvClientes.CurrentRow.Cells["colDni"].Value.ToString();
        //        txtCbu.Text = dgvClientes.CurrentRow.Cells["colCbu"].Value.ToString();
        //        txtSaldo.Text = dgvClientes.CurrentRow.Cells["colSaldo"].Value.ToString();
        //        cbTipoCuenta.SelectedValue = (int)dgvClientes.CurrentRow.Cells["colTipoCUenta"].Value;
        //        txtUltimoMov.Text = dgvClientes.CurrentRow.Cells["colUltMov"].Value.ToString();
        //    }
        //}
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Desea salir del formulario?", "Saliendo formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) this.Close();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlta nuevoCliente = new FormAlta();
            nuevoCliente.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta clientesActuales = new FormConsulta();
            clientesActuales.ShowDialog();
        }

        

       
        private void clientesConMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteDolar reporteME = new FormReporteDolar();
            reporteME.ShowDialog();
        }
        private void totalActivosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportes reporte = new FormReportes();
            reporte.ShowDialog();
        }









        #endregion

        private void pilasColasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPilasColas nuevo = new FormPilasColas();
            nuevo.ShowDialog();
        }
    }
}
