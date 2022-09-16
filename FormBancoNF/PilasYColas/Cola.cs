using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.PilasYColas
{
    internal class Cola : ColeccionAbstracta
    {
        public Cola() : base()
        {
           
        }

        public override object Primero()
        {
            return contadorElementos == 0 ? -1 : elementos[0];
        }
        public override object Extraer()
        {
            Object elementoExtraido = elementos[0];
            elementos.RemoveAt(0);
            contadorElementos--;
            return elementoExtraido;
        }

        
    }
}
