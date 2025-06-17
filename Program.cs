using System;
using System.Runtime.CompilerServices;
using Contas;
using RH;

namespace C____OO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var conta = new Conta("123a2-23", DateTime.Today, 1000);
            var funcionario = new Funcionario("Francisco", "703-789-658-42");

            var contaPoupanca1 = new ContaPoupanca("123-23cs", DateTime.Today, 5000);
            Console.WriteLine(contaPoupanca1.DataAbertura);
            Console.WriteLine(contaPoupanca1.NumeroConta);
            Console.WriteLine(contaPoupanca1.Saldo);

        }
    }

}