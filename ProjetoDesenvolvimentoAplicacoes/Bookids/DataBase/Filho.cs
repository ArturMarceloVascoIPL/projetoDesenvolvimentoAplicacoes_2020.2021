using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Filho
    {
        public int Idade { get; set; }

        public Filho(string nome, string sexo, DateTime dtaNascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DtaNascimento = dtaNascimento;

            var hoje = DateTime.Today;
            this.Idade = hoje.Year - DtaNascimento.Year;
            if (DtaNascimento.Date > hoje.AddYears(-Idade))
            {
                Idade--;
            }
        }

        public override string ToString()
        {
            return $"{Nome}, {Idade} Anos";
        }
    }
}
