﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioCompras
    {
        Model1Container model = new Model1Container();

        public RepositorioCompras()
        {

        }
        public List<Compra> GetCompras(int id)
        {
            return model.Compras.Where(c => c.IdCliente == id).ToList<Compra>();
        }
    }
}