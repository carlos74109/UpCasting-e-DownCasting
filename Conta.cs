using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidades
{
    internal class Conta
    {
        public int numero {  get; private set; }
        public string Titular {  get; private set; }
        public double saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string Titular, double saldo)

        {
            this.numero = numero;
            this.Titular = Titular;
            this.saldo = saldo;
        }

        public void saque(double quantia)
        {
            saldo -= quantia;
        }

        public void depostio(double quantia)
        {
            saldo += quantia;
        }
    }
}
