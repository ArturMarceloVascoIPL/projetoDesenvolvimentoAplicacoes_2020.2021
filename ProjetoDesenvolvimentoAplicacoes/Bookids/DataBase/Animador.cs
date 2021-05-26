using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Animador
    { 

        public Animador(string Nome,string Especialidade)
        {
            this.Nome = Nome;
            this.Especialidade = Especialidade;
        }
        public override string ToString()
        {
            return $"{Nome} - {Especialidade}";
        }

    }
}
