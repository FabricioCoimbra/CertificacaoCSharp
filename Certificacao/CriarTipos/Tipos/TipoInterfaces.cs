using System;

namespace CriarTipos.Tipos
{
    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    public class TipoInterfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();
            eletro1.Desligar();

            eletro1 = new Abajur();
            eletro1.Ligar();
            eletro1.Desligar();

            eletro1 = new Lanterna();
            eletro1.Ligar();
            eletro1.Desligar();
        }
    }   

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine("Televisão desligada");
        }

        public void Ligar()
        {
            Console.WriteLine("Televisão Ligada");
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            Console.WriteLine("Abajur desligado");
        }

        public void Ligar()
        {
            Console.WriteLine("Abajur ligado");
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            Console.WriteLine("Lanterna desligada");
        }

        public void Ligar()
        {
            Console.WriteLine("Lanterna ligada");
        }
    }
}
