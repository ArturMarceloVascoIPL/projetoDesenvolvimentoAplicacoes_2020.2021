using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Participacao
    {
        public Participacao()
        {

        }

        public Participacao(int idEscola, int idEvento)
        {
            this.IdEscola = idEscola;
            this.IdEvento = idEvento;
        }
    }
}
