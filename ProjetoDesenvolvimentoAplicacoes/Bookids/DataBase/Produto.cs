using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Produto
    {
        public Produto(string designacao, decimal preco, TipoProduto tipoProduto, int stock)
        {
            this.Designacao = designacao;
            this.Preco = preco;
            this.TipoProduto = tipoProduto;
            this.StockExistente = stock;
        }

        public override string ToString()
        {
            return $"{TipoProduto}, {Designacao} - {Preco}€ - Stock: {StockExistente}";
        }
    }
}
