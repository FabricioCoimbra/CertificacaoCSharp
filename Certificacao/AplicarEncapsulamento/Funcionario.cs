using System;

namespace AplicarEncapsulamento
{
    class Funcionario : Pessoa, IFuncionario, IPlantonista
    {
        private decimal salario;
        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("O salário não pode ser negativo");
                }
                salario = value;
            }
        }
        public int CargaHorariaMensal { get; set; }

        public event EventHandler CrachaGerado;

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }

        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }
        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }
        public Funcionario(decimal salario)
        {
            Salario = salario;
        }
    }
}
