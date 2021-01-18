using System;

namespace AplicarEncapsulamento
{
    sealed class Cliente : Pessoa
    {
        public DateTime? DataUltimaCompra { get; set; }
        public decimal? ValorUltimaCompra { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data última compra: {DataUltimaCompra}";
        }
    }
}
