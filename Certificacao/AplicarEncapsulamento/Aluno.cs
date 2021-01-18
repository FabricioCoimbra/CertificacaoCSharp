using System;
using System.Collections.Generic;
using System.Text;

namespace AplicarEncapsulamento
{
    class Aluno : Pessoa, IComparable
    {
        public int CompareTo(object obj)
        {
            //retorna 0 => objetos são iguais
            //retornar > 0 => objeto atual vem depois
            //retornar < 0 => objeto atual vem antes

            if (obj == null)
            {
                return 1;
            }

            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                throw new ArgumentException("Objeto não é um Aluno");
            }

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if (resultado == 0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }
            return resultado;
        }
        public override int GetHashCode()
        {
            var hashCode = -1523756618;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
            return hashCode;
        }
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase)
                && this.DataNascimento.Equals(outro.DataNascimento);
        }
    }
}
