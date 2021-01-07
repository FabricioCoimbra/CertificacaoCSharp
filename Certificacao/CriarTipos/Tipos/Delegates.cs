using System;

namespace CriarTipos.Tipos
{
    public class Delegates : IAulaItem
    {
        double Duplicar(double input) => input * 2;
        double Triplicar(double input) => input * 3;

        delegate double MetodoMultiplicacao(double input);
        public void Executar()
        {
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");
            Console.WriteLine();

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine($"metodoMultiplicacao(7.5): {metodoMultiplicacao(7.5)}");
            Console.WriteLine();
            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"metodoMultiplicacao(7.5): {metodoMultiplicacao(7.5)}");
            Console.WriteLine();

            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine("Delegate metodo anonimo: {0}", quadrado);

            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoCubo(4.375);

            Console.WriteLine("Delegate com lambda expression cubo: {0}", cubo);
        }        
    }
 }
