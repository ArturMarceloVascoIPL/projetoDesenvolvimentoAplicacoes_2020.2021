using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioFilhos : IDisposable
    {
        Model1Container model = new Model1Container();

        public void AddFilho(Filho filho)
        {
            model.Pessoas.Add(filho);
            model.SaveChanges();
        }

        public void EditFilho(int id, Filho filho)
        {
            Filho filhoEncontrado = (from p in model.Pessoas.Where(c => c is Filho)
                                             .Select(p => p).ToList().Select(p => (Filho)p).ToList()
                                     where p.IdPessoa == id
                                     select p).Single();

            filhoEncontrado.Nome = filho.Nome;
            filhoEncontrado.DtaNascimento = filho.DtaNascimento;
            filhoEncontrado.Sexo = filho.Sexo;

            model.SaveChanges();
        }

        public void RemoveFilho(int idFilho)
        {
            //model.Pessoas.Attach(filho);
            var filho = model.Pessoas.Single(o => o.IdPessoa == idFilho);
            model.Pessoas.Remove(filho);
            model.SaveChanges();
        }

        /* Fecha as ligacoes na base de dados e liberta os recursos do computador */
        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }

        public void GetInscricoes(int idFilho)
        {
            Filho filho = (Filho)model.Pessoas.Single(o => o.IdPessoa == idFilho);

            if (filho != null)
            {
                Escola escola = (from e in model.Escolas
                                 where e.IdEscola == filho.IdEscola
                                 select e).Single();

                if (escola != null)
                {
                    List<Participacao> participacoes = (from e in model.Participacoes
                                                        where e.IdEscola == escola.IdEscola
                                                        select e).ToList();

                    foreach (var participacao in participacoes)
                    {
                        Inscricao inscricao = new Inscricao(filho.IdPessoa, participacao.IdEvento);
                    }
                }
            }
        }
    }
}
