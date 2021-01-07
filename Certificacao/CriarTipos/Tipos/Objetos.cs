using System;

namespace CriarTipos.Tipos
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto: {meuObjeto}");
            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto; //conversão explícita "cast"
            
            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
            classRef.Pontuacao = 5;
            meuObjeto = classRef;

            Console.WriteLine($"conversao implicita classRef.Pontuacao: {(meuObjeto as Jogador).Pontuacao}");
        }   
    }

    class Jogador
    {
        public object Pontuacao { get; internal set; } = 15;
    }
}
