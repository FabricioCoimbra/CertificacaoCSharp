using System;

namespace ControleDeFluxo
{
    class ContaBancaria
    {
        private decimal Saldo = 0m;
        public ContaBancaria(decimal saldo)
        {
            Saldo = saldo;
            Console.WriteLine(this);
        }
        public void SacarDinheiro(decimal valorSaque)
        {
            if (!TemSaldoSuficiente(ValorSaque: valorSaque))
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }
            Sacar(valor: valorSaque);
            ImprimirComprovante();
        }
        private bool TemSaldoSuficiente(decimal ValorSaque) => Saldo >= ValorSaque;

        private void ImprimirComprovante() => Console.WriteLine("Comprovante impresso.");
        private void Sacar(decimal valor)
        {
            Console.WriteLine($"Sacando {valor:C}");
            Saldo -= valor;
            Console.WriteLine(this);
        }
        public override string ToString() => $"Saldo: {Saldo:C}";
    }
}
