using System;
using CriarTipos;

namespace Tipos
{
    class TiposFlutuantes : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            Console.WriteLine($"idade: {idade}");
            float massaDaTerra = 5.9736e24f; //System.Single
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            float numeroPI = 3.14159f; // System.Single
            Console.WriteLine($"numeroPI: {numeroPI}");

            //float numeroMuitoMaior = 6e100f
            double numeroMuitoMaior = 6e100;
            Console.WriteLine($"numeroMuitoMaior: {numeroMuitoMaior}");

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y= (0)", resultado1);
            Console.WriteLine($"O resultado é do tipo:  {resultado1.GetType()}");

            float z = 4.5f;
            var resultado2 = (x * y) / z;
            Console.WriteLine("x * y= (0)", resultado2);
            Console.WriteLine($"O resultado2 é do tipo:  {resultado2.GetType()}");
            Console.WriteLine($"O z é do tipo:  {z.GetType()}");

            double a = 4.5;
            var b = 8.2;
            var resultado3 = x / y;
            Console.WriteLine("x / y= (0)", resultado3);
            Console.WriteLine($"O resultado3 é do tipo:  {resultado3.GetType()}");
            Console.WriteLine($"O a é do tipo:  {a.GetType()}");
            Console.WriteLine($"O b é do tipo:  {b.GetType()}");

            var resultado4 = (a / b);
            Console.WriteLine($"O resultado4 é do tipo:  {resultado4.GetType()}");
            var resultado5 = (a * b);
            Console.WriteLine($"O resultado5 é do tipo:  {resultado5.GetType()}");

            var resultado6 = (x * z);
            Console.WriteLine($"O resultado6 é do tipo:  {resultado6.GetType()}");
        }

    }
}