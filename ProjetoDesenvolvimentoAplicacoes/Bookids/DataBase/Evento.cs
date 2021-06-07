using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Evento
    {
        public Evento(string descricao, string local, string tipo, int maxParticipantes, int idadeMin, int idadeMax, DateTime dataHora)
        {
            this.Descricao = descricao;
            this.Local = local;
            this.TipoEvento = tipo;
            this.LimiteParticipacao = maxParticipantes;
            this.IdadeInferiror = idadeMin;
            this.IdadeSuperior = idadeMax;
            this.DataHora = dataHora;
        }

        public override string ToString()
        {
            return $"{Descricao}, {Local}, {DataHora}, {Inscricoes.Count}/{LimiteParticipacao}";
        }
    }
}
