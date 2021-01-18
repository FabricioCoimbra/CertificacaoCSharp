using System;

namespace ControleDeFluxo
{
    class Emprestimo
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        public Emprestimo(string codigoContrato)
        {
            if (!ValidarCodigo(codigoContrato))
            {
                throw new ArgumentException($"Código de contrato inválido: {codigoContrato}");
            }
            else
            {
                this.CodigoContrato = codigoContrato;
                Console.WriteLine($"Novo empréstimo criado para o {codigoContrato}");
            }
        }
        public string CodigoContrato { get; set; }
        private bool ValidarCodigo(string codigoContrato)
        {
            bool codigoContratoValido = true;
            foreach (var caractere in codigoContrato)
            {
                //só deve ser válido se for numérico ou maiúscula
                bool numerico = Char.IsDigit(caractere);
                bool maiuscula = Char.IsUpper(caractere);
                bool valido = numerico || maiuscula;
                if (!valido)
                {
                    codigoContratoValido = false;
                    break;
                }
            }
            return codigoContratoValido;
        }
        public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;
        public int Prazo
        {
            get
            {
                return prazo;
            }
            set
            {
                //se o novo prazo for maior que o prazo máximo,
                //lançar um evento de "prazo estourado"
                //senão, definir o novo prazo.

                if (value > PRAZO_MAXIMO_PAGAMENTO_ANOS)
                {
                    OnPrazoMaximoEstourado?.Invoke(this, new EventArgs());
                    return;
                }
                prazo = value;
                Console.WriteLine($"novo prazo: {prazo}");
            }
        }        
    }

}
