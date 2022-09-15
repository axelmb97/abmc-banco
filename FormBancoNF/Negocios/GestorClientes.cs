using FormBancoNF.Datos;
using FormBancoNF.Datos.Implementaciones;
using FormBancoNF.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.Negocios
{
    internal class GestorClientes 
    {
        //Diremos que sea de tipo IClienteDao para que en el caso de querer cambiar la fuente de datos
        //a otro tipo, nuestra unico trabajo sera, crear una nueva clase por ejemplo ConexionMemoria
        //que IMPLEMENTE la interfaz IClienteDao.Haciendo esto no tendremos que modificar nada de la capa
        //de negocios ni de la capa de presentaciones.La capa de presentacion, no le importara a que 
        //tipo de fuente de datos le estamos pegando, ya que solo dependera de BusinessLayer.
        //Lo mismo podriamos hacer con esta capa de negocios.Hacer que implemente una INegocios y en la
        //capa de presentacion relacionarla con esa interfaz.De este modo la capa de presentacion no quedaria
        //pegada a ningun Objeto en especifico, sino a cualquiera que utilice la interfaz INegocios
        private IClientesDao dao;
        //Poner como parametro AbstractDaoFactory
        public GestorClientes()
        {
            dao = new ClientesDao();
        }
        public DataTable ConsultarClientes(bool incluirBajas)
        {
            DataTable tabla = new DataTable();
            if (incluirBajas) tabla = dao.ObtenerTodos("DATOS_CLIENTES_Y_BAJAS");
            else tabla = dao.ObtenerTodos("DATOS_CLIENTES");

            return tabla;
        }
        public DataTable CuentasDeCliente(int idCLiente)
        {
            return dao.ObtenerDetalles(idCLiente);
        }
        public DataTable ClientesConME() {
            return dao.ObtenerTodos("SP_CLIENTES_CON_ME");
        }
        public DataTable ClientesConMontosMayores(double monto) {
            return dao.Filtrar(monto);
        }
        public bool InsertarCliente(Cliente cliente)
        {
            return dao.Crear(cliente);
        }
        public DataTable ObtenerTiposCuenta()
        {
            return dao.ObtenerTodos("TIPOS_CUENTAS");
        }
        public DataTable ObtenerTiposMovimientos()
        {
            return dao.ObtenerTodos("SP_TIPOS_MOVIMIENTOS");
        }
        public int BajaLogicaCuenta(int id) {
            return dao.Eliminar(id, "SP_BAJA_LOGICA_CUENTA", "@codCuenta");
        }
        public int BajaLogicaCliente(int id)
        {
            return dao.Eliminar(id, "SP_BAJA_LOGICA_Cliente", "@idCliente");
        }
    }
}
