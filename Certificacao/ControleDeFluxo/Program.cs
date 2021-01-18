using System;

namespace ControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            SaquesValidados();           

            Validacao.ValidacaoNumero();

            Emprestimos();
        }

        private static void Emprestimos()
        {
            var emprestimo = new Emprestimo("123");
            emprestimo.Prazo = 3;
            emprestimo = new Emprestimo("123A");
            emprestimo.Prazo = 7; // não deu erro nem valdiou o prazo pois não foi assinado o evento de validação;
            try
            {
                emprestimo = new Emprestimo("123a");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            emprestimo.OnPrazoMaximoEstourado += (object source, EventArgs e) => Console.WriteLine("Prazo máximo excedido");
            emprestimo.Prazo = 11;
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
