using FormBancoNF.Datos.Implementaciones;
using FormBancoNF.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.Datos
{
    internal class DaoFactory : AbstractDaoFactory
    {
        public override IClientesDao CrearClienteDao()
        {
            return new ClientesDao();
        }
    }
}
