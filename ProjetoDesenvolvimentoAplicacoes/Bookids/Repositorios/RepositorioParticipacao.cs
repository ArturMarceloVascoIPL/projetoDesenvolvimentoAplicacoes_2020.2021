using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioParticipacao : IDisposable
    {
        Model1Container model = new Model1Container();

        public void AddParticipacao(Participacao participacao)
        {
            model.Participacoes.Add(participacao);
            model.SaveChanges();
        }

        public void RemoveParticipacao(Participacao participacao)
        {
            model.Participacoes.Remove(participacao);
            model.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
