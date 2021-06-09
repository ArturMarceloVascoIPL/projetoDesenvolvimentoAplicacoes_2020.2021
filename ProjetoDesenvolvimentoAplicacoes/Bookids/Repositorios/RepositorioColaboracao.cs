using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioColaboracao : IDisposable
    {
        Model1Container model = new Model1Container();

        public void AddColaboracao(Colaboracao colaboracao)
        {
            model.Colaboracoes.Add(colaboracao);
            model.SaveChanges();
        }

        public void RemoveColaboracao(Colaboracao colaboracao)
        {
            model.Colaboracoes.Remove(colaboracao);
            model.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
