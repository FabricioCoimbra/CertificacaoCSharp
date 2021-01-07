using System;

namespace ConsumirTipos.ConsumirTipos
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine(inteiroLongo);

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());

            IAnimal Ianimal = gato;
            Console.WriteLine(Ianimal.GetType());
        }
    }
}
