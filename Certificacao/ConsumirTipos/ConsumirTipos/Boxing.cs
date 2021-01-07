using System;

namespace ConsumirTipos.ConsumirTipos
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;
            //netsa linha o número está sofrendo Boxing ao ser armazenado em um objeto
            object caixa = numero;

            Console.WriteLine(string.Concat("Resposta ", numero, " ", true));
            try
            {
                int unboxed = (int)caixa;
                Console.WriteLine("primeiro Unboxing Ok.");
                unboxed = (short)caixa;
                Console.WriteLine("segundo Unboxing Ok."); // erro.
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("\nErro: unboxing incorreto. \nErro original \n{0} ", e);
            }

            ImprimirSaldo(50m);
        }

        public void ImprimirSaldo(decimal quantia)
        {
            object quantiaRef = quantia;
            // faz o unboxing para decima e após isso um CAST para int
            int saldo = (int)(decimal)quantiaRef;

            Console.WriteLine(saldo);
        }
    }
}
