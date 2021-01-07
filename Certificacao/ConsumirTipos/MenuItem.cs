using System;

namespace ConsumirTipos
{
    internal class MenuItem
    {
        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; internal set; }
        public Type TipoClasse { get; internal set; }
    }
}