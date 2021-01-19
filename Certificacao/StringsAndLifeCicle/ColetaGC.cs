using System;
using System.Threading.Tasks;

namespace StringsAndLifeCicle
{
    class ColetaGC
    {
        public async Task Executar()
        {
            await Espera10Segundos();

            GerarTiposValor();

            await Espera10Segundos();

            GerarTiposReferencia();
        }

        private static async Task Espera10Segundos()
        {
            await Task.Delay(10000);
        }

        private void GerarTiposValor()
        {
            Console.WriteLine("inciando tipos de valor");
            for (long i = 0; i < 100000; i++)
            {
                EstruturaLivro livro = new EstruturaLivro
                {
                    NumeroPaginas = 1200
                };
            }
            Console.WriteLine("tipos de calor finalizados");
        }

        private static void GerarTiposReferencia()
        {
            Console.WriteLine("Inciando tipos de referência");
            for (long i = 0; i < 100000; i++)
            {
                ClasseLivro livro = new ClasseLivro
                {
                    Introducao = new string(' ', 100000),
                    Texto = new string(' ', 100000),
                    Conclusao = new string(' ', 100000)
                };
            }
            Console.WriteLine("Tipos de referência finalizados");
        }
    }
}
