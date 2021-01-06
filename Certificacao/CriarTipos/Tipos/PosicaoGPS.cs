using System;

namespace CriarTipos.Tipos
{
    public struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        bool IGPS.EstaNoHemisferioNorte => Latitude > 0;
    }
}
