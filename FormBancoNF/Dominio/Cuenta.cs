using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBancoNF
{
    public class Cuenta
    {
        private int codCuenta;
        private string cbu;
        private double saldo;
        private string ultimoMov;
        private TipoCuenta tipo;
        private bool activo;
        public Cuenta()
        {
            codCuenta = -1;
            cbu = "";
            ultimoMov = "";
            saldo = 0;
            tipo = new TipoCuenta();
            activo = true;
        }
        public Cuenta(int codCuenta,string cbu,double saldo,int tipoCuenta,string nombreCuenta,string ultimoMov)
        {
            this.codCuenta = codCuenta;
            this.cbu = cbu;
            this.saldo = saldo;
            this.ultimoMov = ultimoMov;
            this.tipo = new TipoCuenta(tipoCuenta,nombreCuenta);
            this.activo = true;
        }
        public int CodCuenta
        {
            get { return codCuenta; }
            set { codCuenta = value; }
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
