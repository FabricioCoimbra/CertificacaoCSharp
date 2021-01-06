using System;

namespace CriarTipos.Tipos
{
    public class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Data Leitura: {dataLeitura}";
        }
    }
}
