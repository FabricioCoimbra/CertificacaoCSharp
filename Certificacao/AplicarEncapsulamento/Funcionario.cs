using System;

namespace AplicarEncapsulamento
{
    class Funcionario
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

    }
}
