using FormBancoNF.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormBancoNF.Datos.Implementaciones
{
    internal class ClientesDao : IClientesDao
    {
        private SqlConnection cnn;
        private DataTable tabla;
        public ClientesDao()
        {
            cnn = new SqlConnection(FormBancoNF.Properties.Resources.CadenaConexionNB);
        }

        public DataTable ObtenerTodos(string nombreSP)
        {
            //SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = nombreSP;
                cmd.CommandType = CommandType.StoredProcedure;
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error.Intente de nuevo");

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }
            return tabla;
        }
        public DataTable ObtenerDetalles(int id)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CLIENTES_Y_CUENTAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", id);
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool Crear(Cliente cliente)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MAESTRO_CLIENTE", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                //el nombre de los parametros que le asignamos aca deben ser iguales a los 
                //declarados en el store procedure
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
                    SqlCommand cmdCuentaDetalle = new SqlCommand("SP_INSERTAR_DETALLE_CUENTA", cnn, t);
                    cmdCuentaDetalle.CommandType = CommandType.StoredProcedure;
                    cmdCuentaDetalle.Parameters.AddWithValue("@idCLiente", idCliente);
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
                if (t != null) t.Rollback();
                resultado = false;
                MessageBox.Show($"Error {ex.Message}");
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }
            return resultado;
        }
        public int Eliminar(int id, string nombreSP, string param)
        {
            int filas = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(nombreSP, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al borrar.Intente mas tarde");

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return filas;
        }

        public DataTable Filtrar(double numero)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_REPORTE_CLIENTES_SALDOS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@monto", numero);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }


        
    }
}
