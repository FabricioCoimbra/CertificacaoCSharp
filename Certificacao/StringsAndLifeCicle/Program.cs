using System;
using System.Threading.Tasks;

namespace StringsAndLifeCicle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pilha = new PilhaDeChamadas();
            pilha.Executar();

            var coleta = new ColetaGC();
            await coleta.Executar();
        }
    }
}
