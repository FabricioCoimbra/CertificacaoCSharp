using System;
using System.Collections.Generic;
using System.Text;

namespace CriarTipos.Tipos
{
    class TiposClasses : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS()
            {
                Latitude = 13.78,
                Longitude = 29.51
            };
            posicao1 = new ClassePosicaoGPS() { Latitude = 13.78, Longitude = 29.51 };
            Console.WriteLine(posicao1);

            posicao1 = new PosicaoGPSComLeitura(12.36, 13.2, DateTime.Now);

            Console.WriteLine(posicao1);
        }
    }
}
