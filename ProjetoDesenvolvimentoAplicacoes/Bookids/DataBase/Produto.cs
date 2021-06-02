using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Produto
    {
        RepositorioTipoProdutos repoTipos = new RepositorioTipoProdutos();

        public Produto(string designacao, decimal preco, int idTipoProduto, int stock)
        {
            this.Designacao = designacao;
            this.Preco = preco;
            this.IdTipoProduto = idTipoProduto;
            this.StockExistente = stock;
        }

        public override string ToString()
        {
            var tipo = repoTipos.SearchById(IdTipoProduto);

            return $"{tipo.Tipo}, {Designacao} - {Preco}€ - Stock: {StockExistente}";
        }
    }
}
