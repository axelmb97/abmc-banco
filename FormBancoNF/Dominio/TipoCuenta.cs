using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF
{
    internal class TipoCuenta
    {
        private int id;
        private string nombre;
        public TipoCuenta()
        {
            id = 2;
            nombre = "";
        }
        public TipoCuenta(int tipo,string nombre)
        {
            this.id = tipo;
            this.nombre = nombre;
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; } 
        }
    }
}
