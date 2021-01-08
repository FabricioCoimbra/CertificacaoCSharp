using System;
using System.Collections.Generic;

namespace ConsumirTipos.ConsumirTipos
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "essa é uma string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 923, 456, 789 };
            Imprimir(d1, d2, d3, d4);

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lista = d4;

            Imprimir(i, str, dt, lista);
        }

        private static void Imprimir(dynamic d1, dynamic d2, dynamic d3, dynamic d4)
        {
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
}
