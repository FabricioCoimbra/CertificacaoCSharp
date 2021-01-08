using System;

namespace AplicarEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Salario = 1000;

            Console.WriteLine(funcionario.Salario);

            funcionario.Salario = -1000;
            Console.WriteLine(funcionario.Salario);

        }
    }
}
