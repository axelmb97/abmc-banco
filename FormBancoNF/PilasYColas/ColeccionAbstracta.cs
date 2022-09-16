using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF.PilasYColas
{
    internal abstract class ColeccionAbstracta : IColeccion
    {
        protected List<Object> elementos;
        protected int contadorElementos;
        public ColeccionAbstracta()
        {
            elementos = new List<Object>();
            contadorElementos = 0;
        }
        public bool Agregar(object elemento)
        {
            bool bandera = true;

            try
            {
                elementos.Add(elemento);
                contadorElementos++;
            }
            catch (Exception)
            {
                bandera = false;
            }

            return bandera;
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public abstract object Extraer();


        public abstract object Primero();
        

        //public abstract object Extraer();

        //public abstract object Primero();
    }
}
