using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioDetalhesCompras
    {
        Model1Container model = new Model1Container();
        RepositorioProdutos repoProdutos = new RepositorioProdutos();

        public RepositorioDetalhesCompras()
        {

        }
        public void AddDetalheCompra(DetalheCompra detalheCompra)
        {
            model.DetalhesCompras.Add(detalheCompra);
            model.SaveChanges();
        }


        public decimal GetDinheiroTotal(Compra compra)
        {
            decimal total = 0;

            var listaDetalhesCompra = model.DetalhesCompras.Where(c => c.IdCompra == compra.IdCompra).ToList();

            foreach (var detalhes in listaDetalhesCompra)
            {
                var preco = detalhes.Produto.Preco;
                var quantidade = detalhes.Quantidade;
                total = total + preco * quantidade;
            }

            return total;
        }
    }
}
