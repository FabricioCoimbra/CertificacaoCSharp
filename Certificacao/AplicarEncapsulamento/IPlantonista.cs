namespace AplicarEncapsulamento
{
    interface IPlantonista
    {
        int CargaHorariaMensal { get; set; }
        void GerarCracha();
    }
}
