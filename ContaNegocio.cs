using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidades
{
    internal class ContaNegocio : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaNegocio()
        {
        }

       public ContaNegocio(int numero, string titular, double saldo, double LimiteEmprestimo) : base(numero, titular, saldo)
        {
            this.LimiteEmprestimo = LimiteEmprestimo;
        }

        public void Emprestimo(double emprestimo)
        {
            if(emprestimo <= LimiteEmprestimo)
            {
                saldo += emprestimo;

            }

        }
    }
}
