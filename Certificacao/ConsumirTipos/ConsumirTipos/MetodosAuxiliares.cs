using System;

namespace ConsumirTipos.ConsumirTipos
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado;

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("texto não é um numero");
            }

            textoDigitado = "123,45";

            decimal.TryParse(textoDigitado, out decimal valorConvertido);
            Console.WriteLine(valorConvertido);

            textoDigitado = "R$ 123,45";
            decimal.TryParse(textoDigitado,
                        System.Globalization.NumberStyles.Currency, //moeda
                        System.Globalization.CultureInfo.CurrentCulture, //pt-BR
                        out valorConvertido);

            Console.WriteLine(valorConvertido);
        }
    }
}
