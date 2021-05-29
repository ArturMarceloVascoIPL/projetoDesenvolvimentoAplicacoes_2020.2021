using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Filho
    {
        public Filho(string nome, string sexo, string dtaNascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DtaNascimento = dtaNascimento;
        }

        public override string ToString() => $"{Nome}, {Sexo}";
    }
}
