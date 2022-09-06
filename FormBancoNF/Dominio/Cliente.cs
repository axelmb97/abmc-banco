using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF
{
    internal class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private int dni;
        private List<Cuenta> cuentas;
        public Cliente()
        {
            idCliente = -1;
            nombre = apellido = "";
            dni = 0;
            cuentas = new List<Cuenta>();
        }
        public Cliente(int idCliente,string nombre,string apellido,int dni,List<Cuenta> cuentas)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cuentas = cuentas;
        }
        public int IdCliente {
            get { return idCliente; }
            set { idCliente = value; } 
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido {
            set { apellido = value; }
            get { return apellido; }
        }
        public int Dni {
            set { dni = value; }
            get { return dni; }
        }
        public List<Cuenta> Cuentas {
            
            get { return cuentas; }
        }
        public override string ToString() {
            return $"{apellido}, {nombre}";
        }
    }
}
