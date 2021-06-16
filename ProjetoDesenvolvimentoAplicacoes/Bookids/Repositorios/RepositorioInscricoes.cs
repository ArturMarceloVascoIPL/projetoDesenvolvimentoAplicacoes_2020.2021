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

        public List<Inscricao> GetInscricoes()
        {
            return model.Inscricoes.ToList();
        }

        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
