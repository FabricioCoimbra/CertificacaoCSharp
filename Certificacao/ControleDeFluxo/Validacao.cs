using System;
using System.Text;

namespace ControleDeFluxo
{
    class Validacao
    {
        public static void ValidacaoNumero()
        {
            ValidaNumero(2);
            ValidaNumero(1);
            ValidaNumero(0);
            ValidaNumero(-1);
            ValidaNumero(-2);

            ValidaNumeroSimplificado(52);
            ValidaNumeroSimplificado(21);
            ValidaNumeroSimplificado(0);
            ValidaNumeroSimplificado(-12);
            ValidaNumeroSimplificado(-13);
        }

        static void ValidaNumero(int numero)
        {   //uso complexo de IFs aninhados sem chaves
            if (numero >= 0)
                if (numero % 2 == 0)
                    Console.WriteLine($"O numero {numero} eh par e positivo\n");
                else
                    Console.WriteLine($"O numero {numero} eh impar e positivo\n");
            else
            if (numero % 2 == 0)
                Console.WriteLine($"O numero {numero} eh par e negativo\n");
            else
                Console.WriteLine($"O numero {numero} eh impar e negativo\n");
        }

        static void ValidaNumeroSimplificado(int numero)
        {   //uso de IF ternário para simplificar a manipulação da string de mensagem
            var sb = new StringBuilder($"O numero {numero} eh ");
            sb.Append(numero % 2 == 0 ? "par" : "impar");
            sb.Append(numero >= 0 ? " e positivo" : " e negativo");
            Console.WriteLine(sb);
            Console.WriteLine();
        }
    }
}
