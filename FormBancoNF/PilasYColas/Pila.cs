using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.PilasYColas
{
    internal class Pila : ColeccionAbstracta
    {
        public Pila() : base()
        {
            
        }
        public override Object Extraer()
        {

            Object elementoExtraido = elementos[contadorElementos - 1];
            elementos.RemoveAt(contadorElementos - 1);
            contadorElementos--;
            return elementoExtraido;
        }
        public override Object Primero()
        {
            return contadorElementos == 0 ? -1 : elementos[contadorElementos - 1];
        }
    }
}
