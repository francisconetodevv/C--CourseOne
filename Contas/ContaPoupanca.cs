namespace Contas
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string numero, DateTime dataAbertura, double saldo) : base(numero, dataAbertura, saldo)
        {

        }

        public override void Depositar(double valor)
        {
            base.Depositar(valor);
        }
    }
}