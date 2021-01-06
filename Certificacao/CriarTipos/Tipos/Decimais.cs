using System;

namespace CriarTipos.Tipos
{
    class Decimais : IAulaItem
    {   
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subtotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);
            Console.WriteLine();

            subtotal = valorProduto1 + valorProduto2;
            Console.WriteLine("Descobrindo se atribuir a variável muda alguma coisa");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);
            Console.WriteLine();


            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subtotal = 30.30;

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);
            Console.WriteLine();

            Console.WriteLine(valorProduto1 + valorProduto2);
            Console.WriteLine();

            subtotal = valorProduto1 + valorProduto2;
            Console.WriteLine("Descobrindo se atribuir a variável muda alguma coisa");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);
            Console.WriteLine();

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);
            Console.WriteLine();

            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);
            Console.WriteLine();

            var tipoInferido = 10.5;
            Console.WriteLine($"tipoInferido = {tipoInferido.GetType()}");
            Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");

        }
    }
}
