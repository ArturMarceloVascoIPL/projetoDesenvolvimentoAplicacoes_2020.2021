using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class TipoProduto
    {
        public TipoProduto(string nome)
        {
            this.Tipo = nome;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
