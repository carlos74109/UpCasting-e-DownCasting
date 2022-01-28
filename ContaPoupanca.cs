using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidades
{
    internal class ContaPoupanca : Conta
    {
        public double taxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string Titular, double saldo, double taxaJuros) : base(numero, Titular, saldo)
        {
            this.taxaJuros = taxaJuros;
        }

        public void atualizarSaldo()
        {
            saldo += saldo * taxaJuros;
        }
    }
}
