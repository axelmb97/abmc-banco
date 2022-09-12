using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormBancoNF
{
    internal class ConexionDB
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private DataTable tabla;
        public ConexionDB()
        {
            this.cnn = new SqlConnection(FormBancoNF.Properties.Resources.CadenaConexionNB);
        }
        public DataTable ConsultarSql(string nombreSP)
        {
            cnn.Open();
            cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultaPorCuenta(string nombreSP,int tipoCuenta) {
            cnn.Open();
            cmd = new SqlCommand(nombreSP,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tipoCuenta",tipoCuenta);
            tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool InsertarCliente(Cliente cliente) {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
               
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd = new SqlCommand("SP_INSERTAR_MAESTRO_CLIENTE", cnn,t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);
                SqlParameter param = new SqlParameter("@NewID", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int idCliente = Convert.ToInt32(param.Value);

                foreach (Cuenta c in cliente.Cuentas)
                {
                    SqlCommand cmdCuentaDetalle = new SqlCommand("SP_INSERTAR_DETALLE_CUENTA", cnn,t);
                    cmdCuentaDetalle.CommandType = CommandType.StoredProcedure;
                    cmdCuentaDetalle.Parameters.AddWithValue("@idCLiente",idCliente);
                    cmdCuentaDetalle.Parameters.AddWithValue("@cbu", c.Cbu);
                    cmdCuentaDetalle.Parameters.AddWithValue("@saldo", c.Saldo);
                    cmdCuentaDetalle.Parameters.AddWithValue("@idTipoCuenta", c.Tipo.Id);
                    cmdCuentaDetalle.Parameters.AddWithValue("@ultimoMov", c.UltimoMov);
                    cmdCuentaDetalle.Parameters.AddWithValue("@activo", c.Activo);
                    cmdCuentaDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception ex)
            {
                if(t != null) t.Rollback();
                resultado = false;
                MessageBox.Show($"Error {ex.Message}");
            }
            finally {
                if(cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }
            return resultado;
        }
        public DataTable ConsultarCuentas(string nombreSp,int idCliente) {
            cnn.Open();
            cmd = new SqlCommand(nombreSp,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente",idCliente);
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public int BajaLogica(int codCuenta){
            int filas = 0;
            cnn.Open();
            cmd = new SqlCommand("SP_BAJA_LOGICA_CUENTA",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codCuenta",codCuenta);
            filas = cmd.ExecuteNonQuery();
            cnn.Close();
            return filas;
        }
        public int EliminarCuenta(int idCliente) {
            int filas = 0;

            try
            {
                cnn.Open();
                cmd = new SqlCommand("SP_BAJA_LOGICA_Cliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                filas= cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al borrar cliente.Intente mas tarde");
                
            }
            finally {
                if (cnn != null && cnn.State == ConnectionState.Open) {
                    cnn.Close();
                }
            }

            return filas;
        }
        public DataTable ReporteAgrupado(string nombreSP,double monto) {
            DataTable tabla = new DataTable();
            cnn.Open();
            cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@monto",monto);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
