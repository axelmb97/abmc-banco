using FormBancoNF.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.Datos
{
    internal abstract class AbstractDaoFactory
    {
        public abstract IClientesDao CrearClienteDao();
    }
}
