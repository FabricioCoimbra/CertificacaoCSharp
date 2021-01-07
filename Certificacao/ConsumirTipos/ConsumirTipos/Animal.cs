using System;

namespace ConsumirTipos.ConsumirTipos
{
    public interface IAnimal
    {
        string Nome { get; set; }

        void Andar();
        void Beber();
        void Comer();
    }

    public class Animal : IAnimal
    {
        public String Nome { get; set; }
        public virtual void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }
        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }
        public virtual void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    public class Gato : Animal, IAnimal
    {
        public override void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }
        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }
        public new void Andar() // não sobrescreve e apenas executa da classe base;
        {
            Console.WriteLine("Gato.Andar");
        }
    }

    public class BaseC
    {
        public class NestedC
        {
            public int x = 200;
            public int y;
        }
    }
    public class DerivedC : BaseC
    {
        // Nested type ocultando o valor do campo na classe base.
        new public class NestedC
        {
            public int x = 100;
            public int y;
            public int z;
        }
    }
}
