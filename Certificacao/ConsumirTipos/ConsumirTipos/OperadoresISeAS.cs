using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumirTipos.ConsumirTipos
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente();

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);

            AlimentarIS(animal);
            AlimentarIS(gato);
            AlimentarIS(cliente);
        }
        public void Alimentar(object obj)
        {
            Animal animal = obj as Animal;

            if (animal == null)
            {
                Console.WriteLine("obj não é um animal");
                return;
            }
            animal.Beber();
            animal.Comer();
        }

        public void AlimentarIS(object obj)
        {
            if (obj is IAnimal animal)
            {
                animal.Comer();
                animal.Beber();
            }
        }
    }

    internal class Cliente
    {
    }
}
