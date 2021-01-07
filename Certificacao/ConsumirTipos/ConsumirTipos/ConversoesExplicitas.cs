using System;

namespace ConsumirTipos.ConsumirTipos
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            Console.WriteLine("long.MaxValue : {0}", long.MaxValue);
            Console.WriteLine("double.MaxValue : {0}", double.MaxValue);
            double divida = (double)long.MaxValue * 5;
            try
            {
                long copia = (long)divida;
                Console.WriteLine("Copia ficou com o maior valor possivel de long sem dar erro: {0}", copia);
            }
            catch (Exception)
            {
                Console.WriteLine("Double muito grande não cabe no long");
            }           

            Console.WriteLine(divida);

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato)animal; //cast
            Console.WriteLine(gato.GetType());
        }
    }
}
