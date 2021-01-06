using System;

namespace CriarTipos.Tipos
{
    public class TiposBooleanos : IAulaItem
    {
        public void Executar()
        {
            bool possuiSaldo = true;
            Console.WriteLine($"possuiSaldo = {possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");
            bool diasPar = (dias % 2 == 0);

            string EhPar = diasPar ? "dias é um número par" : "dias é um número ímpar";
            Console.WriteLine(EhPar);
        }
    }
}
