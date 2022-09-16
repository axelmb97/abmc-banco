using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.PilasYColas
{
    internal interface IColeccion
    {
        bool Agregar(object elemento);

        bool EstaVacia();
        object Extraer();

        object Primero();
    }
}
