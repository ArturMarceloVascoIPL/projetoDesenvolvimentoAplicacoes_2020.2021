using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioClientes : IDisposable
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

        public void EditCliente(int id, Cliente cliente)
        {
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

        public void RemoveCliente(Cliente cliente)
        {
            model.Pessoas.Attach(cliente);
            model.Pessoas.Remove(cliente);
            model.SaveChanges();

        }

        /* Fecha as ligacoes na base de dados e liberta os recursos do computador */
        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}