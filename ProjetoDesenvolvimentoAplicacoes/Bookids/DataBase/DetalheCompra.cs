using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class DetalheCompra
    {
        public DetalheCompra(int IdCompra, int IdProduto, int Quantidade)
        {
            this.IdCompra = IdCompra;
            this.IdProduto = IdProduto;
            this.Quantidade = Quantidade; 
        }

        public override string ToString()
        {
            return $"{Produto.Designacao} - {Quantidade} Preço: {Produto.Preco}";
        }
    }
}
