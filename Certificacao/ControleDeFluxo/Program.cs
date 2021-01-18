namespace ControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            SaquesValidados();

            Validacao.ValidacaoNumero();
        }

        private static void SaquesValidados()
        {
            ContaBancaria conta = new ContaBancaria(100);
            conta.SacarDinheiro(35);
            conta.SacarDinheiro(65);
            conta.SacarDinheiro(1);
        }
    }
}
