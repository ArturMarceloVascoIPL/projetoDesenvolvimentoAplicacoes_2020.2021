using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Inscricao
    {
        public Inscricao()
        {

        }

        public Inscricao(int idFilho, int idEvento, bool confirmada = false)
        {
            this.IdFilho = idFilho;
            this.IdEvento = idEvento;
            this.Confirmada = confirmada;
        }

        public override string ToString()
        {
            return $"Filho: {Filho}, Evento: {Evento}";
        }
    }
}
