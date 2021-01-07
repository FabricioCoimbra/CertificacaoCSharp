using System;

namespace CriarTipos.Tipos
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);
            Console.ReadKey();
            dinamico.teste();//erro somente em tempo de execução
        }
    }
}
