using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.Negocios
{
    internal interface IServicios
    {
        DataTable ObtenerElementos(string nombreSP);
        bool InsertarCliente();
    }
}
