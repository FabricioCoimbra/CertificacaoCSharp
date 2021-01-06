using System;

namespace CriarTipos.Tipos
{
    public class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int MinValue = int.MinValue;
            var MaxValue = int.MaxValue;
            Console.WriteLine("MinValue =  " + MinValue);
            Console.WriteLine($"MaxValue = {MaxValue} ");

            var copia = MinValue;
            Console.WriteLine($"Copia = {copia} ");
            Console.WriteLine();

            MinValue = 0;
            Console.WriteLine($"Copia = {copia} ");
            Console.WriteLine($"MinValue = {MinValue} ");
            Console.WriteLine();
            
            int? nulo = null;
            System.Nullable<int> otronulo = null;

            Console.WriteLine($"nulo = {nulo} ");
            Console.WriteLine($"otronulo = {otronulo} ");
        }
    }
}