using System;
using System.Collections.Generic;

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
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));

            Aluno aluno4 = new Aluno
            {
                Nome = "ANDRÉ DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };

            alunos.Sort();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
