using System;

namespace Contas {
    public abstract class Conta 
    {
        public static double TaxaRendimento = 0.5f;
        public string NumeroConta;
        public DateTime DataAbertura;
        public double Saldo;
        protected double taxaConta { get; set; }

        // Construct
        public Conta(string numero, DateTime dataAbertura, double saldo)
        {
            NumeroConta = numero;
            DataAbertura = dataAbertura;
            Saldo = saldo;
        }

        public string ExibirExtrato()
        {
            return $"Conta Numero:     {NumeroConta}{Environment.NewLine}" +
                   $"Data de Abertura: {DataAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
                   $"Saldo:            {Saldo.ToString("C")}{Environment.NewLine}" +
                   "-----------------------------------------------------------";
        }

        public virtual void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        // Sobrecarga de métodos funcionando
        public void RealizarEmprestimo(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"O valor {valor} foi creditado e será debitado dentro de 30 dias");
        }

        public void RealizarEmprestimo(double valor, int parcelas)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"O valor {valor} foi creditado e será debitado dentro de {parcelas} parcelas");
        }

        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses);
        }
    }
}