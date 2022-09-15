using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBancoNF.Datos
{
    internal class HelperDB
    {
        private static HelperDB instancia;
        private string connectionString;
        private HelperDB()
        {
            connectionString = FormBancoNF.Properties.Resources.CadenaConexionNB;
        }
        public static HelperDB ObtenerInstancia() 
        {
            if (instancia == null) { 
                instancia = new HelperDB();
            }
            return instancia;
        }
        public DataTable ConsultarSql(string nombreSP) {
            SqlConnection cnn = new SqlConnection(connectionString);
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
            finally { 
                if(cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }
            return tabla;
        }
        
    }
}
