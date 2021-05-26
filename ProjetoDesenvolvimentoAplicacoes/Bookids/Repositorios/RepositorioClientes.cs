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

        {
            model.SaveChanges();
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
