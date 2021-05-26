using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Evento
    {
        public override string ToString()
        {
            return $"{Descricao}, {Local}, {DataHora}, {Inscricoes.Count}/{LimiteParticipacao}";
        }
    }
}
