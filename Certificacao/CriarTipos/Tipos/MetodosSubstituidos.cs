using System;
using System.Collections.Generic;
using System.Text;

namespace CriarTipos.Tipos
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gato2 = new Gato() { Nome = "Bichano 2" };
            gato2.Beber();
            gato2.Comer();
            gato2.Andar();

            //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/new-modifier
            Console.WriteLine("Campos sobrescritos e classes aninhadas");
            // Criação de um objeto da classe sobrescrita:
            DerivedC.NestedC c1 = new DerivedC.NestedC(); 
            // Criar um objeto da classe base:
            BaseC.NestedC c2 = new BaseC.NestedC();

            Console.WriteLine(c1.x);
            Console.WriteLine(c2.x);
        }
    }
    class Animal
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

    class Gato : Animal
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
