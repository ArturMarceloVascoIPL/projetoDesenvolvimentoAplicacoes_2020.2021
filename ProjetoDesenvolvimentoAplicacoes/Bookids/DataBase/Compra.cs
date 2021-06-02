using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Compra
    {
        public Compra(string Data, bool UtilizouCartao, int IdCliente)
        {
            this.Data = Data;
            this.UtilizouCartao = UtilizouCartao;
            this.IdCliente = IdCliente;
        }
    }
}
