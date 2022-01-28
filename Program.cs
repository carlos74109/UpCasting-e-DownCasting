using ContaBancaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Alex", 0.0);
            ContaNegocio contaNeg = new ContaNegocio(1002, "Maria", 0.0, 600);

            //UPCASTING, converção da subClasse para superClass
            Conta acc1 = contaNeg;
            Conta acc2 = new ContaNegocio(1005, "henrique", 300, 1200);
            Conta acc3 = new ContaPoupanca(1009, "joana", 900, 300);

            //DOWNCASTING, converção da superClasse para subClasse
            ContaNegocio acc4 = acc2 as ContaNegocio;
            acc4.Emprestimo(200);
            

            if(acc3 is ContaNegocio)
            {
                ContaNegocio acc5 = (ContaNegocio)acc3;

            }
            else
            {
                Console.WriteLine("Instancia errada");
            }

            if(acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.depostio(400);
                Console.WriteLine("Deposito realizado com sucesso!!!");

            }
        }
    }
}
