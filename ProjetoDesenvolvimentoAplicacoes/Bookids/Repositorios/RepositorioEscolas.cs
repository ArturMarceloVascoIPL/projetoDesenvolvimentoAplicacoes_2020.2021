using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioEscolas
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

        /* Adiciona uma escola, retorna true(sucesso) ou false(erro) */
        public bool AddEscola(Escola escola)
        {
            try
            {
                model.Escolas.Add(escola);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /* Remove uma escola, retorna true(sucesso) ou false(erro) */
        public bool RemoveEscola(Escola escola)
        {
            try
            {
                model.Escolas.Remove(escola);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;
        }

        /* NAO FUNCIONA POR ALGUMA RAZAO */
        /* Edita uma escola, retorna true(sucesso) ou false(erro) */
        public bool EditEscola(int id, Escola escolaEditada)
        {
            try
            {
                Escola escolaEncontrada = (from e in model.Escolas
                                           where e.IdEscola == id
                                           select e).Single();

                escolaEncontrada = escolaEditada;
                
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
                
            return true;
        }

        /* Faz uma pesquisa pelo NOME e retorna a lista de escolas encontradas */
        public List<Escola> SearchByName(string nome)
        {
            return (from escola in model.Escolas
                    where escola.Nome == nome
                    select escola).ToList<Escola>();
        }

        /* Faz uma pesquisa pela LOCALIDADE e retorna a lista de escolas encontradas */
        public List<Escola> SearchByLocalidade(string local)
        {
            return (from escola in model.Escolas
                    where escola.Localidade == local
                    select escola).ToList<Escola>();
        }
    }
}
