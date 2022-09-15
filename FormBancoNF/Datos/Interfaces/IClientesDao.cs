using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.Datos.Interfaces
{
    public interface IClientesDao
    {
        DataTable ObtenerTodos(string nombreSP);
        DataTable ObtenerDetalles(int idMaestro);
        bool Crear(Cliente cliente);
        int Eliminar(int id,string nombreSP,string param);
        DataTable Filtrar(double numero);
    }
}
