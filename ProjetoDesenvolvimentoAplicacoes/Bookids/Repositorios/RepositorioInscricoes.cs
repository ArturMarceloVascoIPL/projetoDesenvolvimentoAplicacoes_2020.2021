using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioInscricoes : IDisposable
    {
        Model1Container model = new Model1Container();

        public void AddIncricao(Inscricao inscricao)
        {
            model.Inscricoes.Add(inscricao);
            model.SaveChanges();
        }

        public void RemoveIncricao(Inscricao inscricao)
        {
            model.Inscricoes.Remove(inscricao);
            model.SaveChanges();
        }

        public void EditConfirmacao(Inscricao inscricaoEditada)
        {
            Inscricao inscricao = (from i in model.Inscricoes
                                   where i.IdFilho == inscricaoEditada.IdFilho
                                   && i.IdEvento == inscricaoEditada.IdEvento
                                   select i).Single();

            inscricao.Confirmada = inscricaoEditada.Confirmada;

            model.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
