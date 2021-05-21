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

        public void AddCliente() // INCOMPLETO
        {
            model.SaveChanges();
        }

        public void RemoveCliente() // INCOMPLETO
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
