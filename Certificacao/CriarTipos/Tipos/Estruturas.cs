using System;

namespace CriarTipos.Tipos
{
    public class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine();

            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");
            Console.WriteLine();

            PosicaoGPS posicao1;
            posicao1.Latitude = 17.12;
            posicao1.Longitude = 22.15;
            Console.WriteLine($"posicao1.Latitude = {posicao1.Latitude}");
            Console.WriteLine($"posicao1.Longitude = {posicao1.Longitude}");
            Console.WriteLine();

            var posicao2 = new PosicaoGPS() { Latitude = 13.78, Longitude = 36.51 };
            Console.WriteLine($"posicao2.Latitude = {posicao2.Latitude}");
            Console.WriteLine($"posicao2.Longitude = {posicao2.Longitude}");
            Console.WriteLine();

            var posicao3 = new PosicaoGPS(39.87, 16.12);

            Console.WriteLine($"posicao3.Latitude = {posicao3.Latitude}");
            Console.WriteLine($"posicao3.Longitude = {posicao3.Longitude}");
            Console.WriteLine();

            Console.WriteLine(posicao1);

        }
    }
}
