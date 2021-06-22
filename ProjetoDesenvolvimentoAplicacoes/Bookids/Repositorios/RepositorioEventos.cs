using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioEventos : IDisposable
    {
        Model1Container model = new Model1Container();

        #region GetFunctions

        /* Retorna em Lista todos os dados dos Eventos */
        public List<Evento> GetEventos()
        {
            return model.Eventos.ToList();
        }

        /* Retorna em Lista todos as Animadores que participam no Evento */
        public List<Pessoa> GetColaboradoresEvento(int id)
        {
            return (from c in model.Colaboracoes
                    join a in model.Pessoas.Where(a => a is Animador).Select(a => a)
                    on c.IdAnimador equals a.IdPessoa
                    where c.IdEvento == id
                    select a).ToList<Pessoa>();
        }

        /* Retorna em Lista todas as Escolas que participam no Evento */
        public List<Escola> GetEscolasEvento(int id)
        {
            return (from p in model.Participacoes
                    join e in model.Escolas
                    on p.IdEscola equals e.IdEscola
                    where p.IdEvento == id
                    select e).ToList<Escola>();
        }

        /* Retorna em Lista todos os Filhos confirmados que participam no Evento */
        public List<Pessoa> GetParticipantes(int id)
        {
            return (from i in model.Inscricoes
                    join a in model.Pessoas.Where(a => a is Filho).Select(a => a)
                    on i.IdFilho equals a.IdPessoa
                    where i.IdEvento == id && i.Confirmada == true
                    select a).ToList<Pessoa>();
        }

        #endregion

        #region Eventos

        public void AddEvento(Evento evento)
        {
            model.Eventos.Add(evento);
            model.SaveChanges();
        }

        public void RemoveEvento(Evento evento)
        {
            model.Eventos.Remove(evento);
            model.SaveChanges();
        }

        public void EditEvento(int id, Evento eventoEditado)
        {
            Evento eventoEncontrado = (from e in model.Eventos
                                       where e.IdEvento == id
                                       select e).Single();

            eventoEncontrado.Descricao = eventoEditado.Descricao;
            eventoEncontrado.Local = eventoEditado.Local;
            eventoEncontrado.TipoEvento = eventoEditado.TipoEvento;
            eventoEncontrado.LimiteParticipacao = eventoEditado.LimiteParticipacao;
            eventoEncontrado.IdadeInferiror = eventoEditado.IdadeInferiror;
            eventoEncontrado.IdadeSuperior = eventoEditado.IdadeSuperior;
            eventoEncontrado.DataHora = eventoEditado.DataHora;

            model.SaveChanges();
        }

        #endregion

        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
