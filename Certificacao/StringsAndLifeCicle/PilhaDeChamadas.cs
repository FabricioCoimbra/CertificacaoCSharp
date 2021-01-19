using System;

namespace StringsAndLifeCicle
{
    class PilhaDeChamadas
    {
        public void Executar()
        {            
            Metodo1();
        }
        public void Metodo1()
        {
            Console.WriteLine("Enqueue Metodo1();");
            Metodo2(12);
            Console.WriteLine("Dequeue Metodo1()");
        }
        public void Metodo2(int dados)
        {
            Console.WriteLine("Enqueue Metodo2(12);");
            int multiplicador = 2;
            Console.WriteLine($"O valor é: {dados}");
            Metodo3(dados * multiplicador);
            Console.WriteLine("Dequeue Metodo2(12);");
        }
        public void Metodo3(int dados)
        {
            Console.WriteLine("Enqueue Metodo3(dados * multiplicador);");
            Console.WriteLine($"O dobro é: {dados}");
            Console.WriteLine("Dequeue Metodo3(dados * multiplicador);");
        }
    }
}
