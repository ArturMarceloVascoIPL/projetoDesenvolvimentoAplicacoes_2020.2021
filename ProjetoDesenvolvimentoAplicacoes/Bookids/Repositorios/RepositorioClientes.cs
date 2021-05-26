using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioClientes
    {
        Model1Container model = new Model1Container();

        public List<Cliente> GetClientes()
        {
            return model.Pessoas.Where(p => p is Cliente).Select(p => p).ToList().Select(p => (Cliente)p).ToList();
        }


        public void AddCliente(Cliente cliente)
        {
            model.Pessoas.Add(cliente);
            model.SaveChanges();
        }

        internal bool EditCliente(int id, Cliente cliente)
        {
            try
            {
                //Cliente clienteDB = (from p in model.Pessoas
                //                     where p.IdPessoa == (Cliente)id
                //                     select p).Single();

                Cliente clienteEncontrado = (from p in model.Pessoas.Where(c => c is Cliente)
                                            .Select(p => p).ToList().Select(p => (Cliente)p).ToList()
                                             where p.IdPessoa == id
                                             select p).Single();

                clienteEncontrado.Nome = cliente.Nome;
                clienteEncontrado.Morada = cliente.Morada;
                clienteEncontrado.Localidade = cliente.Localidade;
                clienteEncontrado.CodPostal = cliente.CodPostal;
                clienteEncontrado.Email = cliente.Email;
                clienteEncontrado.Telemovel = cliente.Telemovel;
                clienteEncontrado.Telefone = cliente.Telefone;

                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool RemoveCliente(Cliente cliente)
        {
            try
            {
                model.Pessoas.Remove(cliente);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        //public List<Cliente> SearchByName(string nome) // INCOMPLETO
        //{
        //    // Where Clientes.Nome == nome
        //    return;
        //}

        //public List<Cliente> SearchById(int id)
        //{
        //    // Where Clientes.Id == id
        //    return;
        //}
    }
}
