using System;

namespace StringsAndLifeCicle
{
    class ClasseLivro
    {
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        ~ClasseLivro()
        {
            Console.WriteLine("Objeto ClasseLivro finalizado");
        }
    }
   
}
