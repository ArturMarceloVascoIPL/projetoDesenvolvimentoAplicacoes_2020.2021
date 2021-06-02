using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioAnimadores
    {
        Model1Container model = new Model1Container();

        public RepositorioAnimadores()
        {
            
        }

        public List<Animador> GetAnimadores()
        {
            return model.Pessoas.Where(a => a is Animador).Select(a => a).ToList().Select(a => (Animador)a).ToList();
        }

        /* Adiciona um animador, retorna true(sucesso) ou false(erro) */
        public bool AddAnimador(Animador animador)
        {
            try
            {
                model.Pessoas.Add(animador);
                model.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }


        /* Remove um Animador, retorna true(sucesso) ou false(erro) */
        public bool RemoveAnimador(Animador animador)
        {
            try
            {
                model.Pessoas.Remove(animador);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool EditAnimador(int id,Animador animadorEditado)
        {
            try
            {
                Animador animadorEncontrado = (from a in model.Pessoas.Where(a => a is Animador).Select(a => a).ToList().Select(a => (Animador)a).ToList()
                                             where a.IdPessoa == id
                                             select a).Single();

                animadorEncontrado.Nome = animadorEditado.Nome;
                animadorEncontrado.Morada = animadorEditado.Morada;
                animadorEncontrado.Localidade = animadorEditado.Localidade;
                animadorEncontrado.CodPostal = animadorEditado.CodPostal;
                animadorEncontrado.Telefone = animadorEditado.Telefone;
                animadorEncontrado.Telemovel = animadorEditado.Telemovel;
                animadorEncontrado.Email = animadorEditado.Email;
                animadorEncontrado.Especialidade = animadorEditado.Especialidade;

                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Animador> SearchByName(string nome)
        {
            return (from animador in model.Pessoas.Where(a => a is Animador).Select(a => a).ToList().Select(a => (Animador)a).ToList()
            where animador.Nome.ToLower().Contains(nome.ToLower()) select animador).ToList<Animador>();
        }

    }
}
