using System;

namespace AplicarEncapsulamento
{
    abstract class Pessoa
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
