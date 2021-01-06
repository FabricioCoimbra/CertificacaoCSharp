using System;

namespace CriarTipos.Tipos
{
    public class ClassePosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;
        public ClassePosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public ClassePosicaoGPS()
        {
        }
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";
        bool IGPS.EstaNoHemisferioNorte => Latitude > 0;
    }
}
