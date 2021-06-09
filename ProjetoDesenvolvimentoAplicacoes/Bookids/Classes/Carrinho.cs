using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    public class Carrinho
    {
        public int IdProduto { get; set; }
        public string Designacao { get; set; }
        public decimal Preco { get; set; }
        public int IdTipoProduto { get; set; }
        public int Quantidade { get; set; }

        public Carrinho(int IdProduto, string Designacao, decimal Preco, int IdTipoProduto, int Quantidade)
        {
            this.IdProduto = IdProduto;
            this.Designacao = Designacao;
            this.Preco = Preco;
            this.IdTipoProduto = IdTipoProduto;
            this.Quantidade = Quantidade;
            
        }

        public override string ToString()
        {
            return $"{Designacao}, Quantidade: {Quantidade}";
        }

    }
}
