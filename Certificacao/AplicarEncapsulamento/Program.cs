using System;

namespace AplicarEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1000);
            Console.WriteLine(funcionario.Salario);
            //funcionario.Salario = -1000;
            //Console.WriteLine(funcionario.Salario);

            funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();

            Cliente cliente = new Cliente
            {
                CPF = "789.456.123-99",
                DataNascimento = new DateTime(1980, 1, 1),
                Nome = "Maria de Souza",
                DataUltimaCompra = new DateTime(2018, 1, 1),
                ValorUltimaCompra = 200
            };

            Console.WriteLine(cliente);

            Pessoa pessoa = new Cliente
            {
                CPF = "789.456.123-99",
                DataNascimento = new DateTime(1980, 1, 1),
                Nome = "Maria de Souza"
            };

            Console.WriteLine(pessoa);
        }
    }
}
