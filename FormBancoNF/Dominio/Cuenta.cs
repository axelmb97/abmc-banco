using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF
{
    internal class Cuenta
    {
        private string cbu;
        private double saldo;
        private string ultimoMov;
        private TipoCuenta tipo;
        private bool activo;
        public Cuenta()
        {
            cbu = "";
            ultimoMov = "";
            saldo = 0;
            tipo = new TipoCuenta();
            activo = true;
        }
        public Cuenta(string cbu,double saldo,int tipoCuenta,string nombreCuenta,string ultimoMov)
        {
            this.cbu = cbu;
            this.saldo = saldo;
            this.ultimoMov = ultimoMov;
            this.tipo = new TipoCuenta(tipoCuenta,nombreCuenta);
            this.activo = true;
        }
        public string Cbu
        {
            set { cbu = value; }
            get { return cbu; }
        }
        public double Saldo {
            set { saldo = value; }
            get { return saldo; }
        }
        public TipoCuenta Tipo
        {
            get { return tipo; }
        }
        public string UltimoMov
        {
            set { ultimoMov = value; }
            get { return ultimoMov; }
        }
        public bool Activo
        {
            set { activo = value; }
            get { return activo; }
        }
    }
}
