using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioEscolas : IDisposable
    {
        Model1Container model = new Model1Container();

        /* Retorna em Lista todos os dados das Escolas */
        public List<Escola> GetEscolas()
        {
            return model.Escolas.ToList<Escola>();
        }

        /* Retorna em Lista todos os eventos que a escola vai participar */
        public List<Evento> GetEventos(int id)
        {
            return (from p in model.Participacoes
                    join e in model.Eventos
                    on p.IdEvento equals e.IdEvento
                    where p.IdEscola == id
                    select e).ToList<Evento>();
        }

        /* Adiciona uma escola */
        public void AddEscola(Escola escola)
        {
            model.Escolas.Add(escola);
            model.SaveChanges();
        }

        /* Remove uma escola */
        public void RemoveEscola(Escola escola)
        {
            model.Escolas.Remove(escola);
            model.SaveChanges();
        }

        /* Edita uma escola */
        public void EditEscola(int id, Escola escolaEditada)
        {
            Escola escolaEncontrada = (from e in model.Escolas
                                        where e.IdEscola == id
                                        select e).Single();

            escolaEncontrada.Nome = escolaEditada.Nome;
            escolaEncontrada.Morada = escolaEditada.Morada;
            escolaEncontrada.Localidade = escolaEditada.Localidade;
            escolaEncontrada.CodPostal = escolaEditada.CodPostal;
            escolaEncontrada.Telefone = escolaEditada.Telefone;
            escolaEncontrada.Email = escolaEditada.Email;

            model.SaveChanges();
        }

        /* Faz uma pesquisa pelo NOME e retorna a lista de escolas encontradas */
        public List<Escola> SearchByName(string nome)
        {
            return (from escola in model.Escolas
                    where escola.Nome.Contains(nome)
                    select escola).ToList<Escola>();
        }

        public Escola SearchById(int id)
        {
            return (from escola in model.Escolas
                    where escola.IdEscola == id
                    select escola).Single<Escola>();
        }

        /* Fecha as ligacoes na base de dados e liberta os recursos do computador */
        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
