using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioProdutos
    {
        Model1Container model = new Model1Container();

        /* Retorna em Lista todos os dados dos Produtos */
        public List<Produto> GetProdutos()
        {
            return model.Produtos.ToList<Produto>();
        }

        /* Adiciona um produto, retorna true(sucesso) ou false(erro) */
        public void AddProduto(Produto produto)
        {
            model.Produtos.Add(produto);
            model.SaveChanges();
        }

        /* Remove um produto, retorna true(sucesso) ou false(erro) */
        public void RemoveProduto(Produto produto)
        {
            model.Produtos.Remove(produto);
            model.SaveChanges();
        }

        /* Edita um produto, retorna true(sucesso) ou false(erro) */
        public void EditProduto(int id, Produto produtoEditado)
        {
            Produto produtoEncontrado = (from p in model.Produtos
                                        where p.IdProduto == id
                                        select p).Single();

            produtoEncontrado.Designacao = produtoEditado.Designacao;
            produtoEncontrado.Preco = produtoEditado.Preco;
            produtoEncontrado.IdTipoProduto = produtoEditado.IdTipoProduto;
            produtoEncontrado.StockExistente = produtoEditado.StockExistente;

            model.SaveChanges();
        }

        /* Faz uma pesquisa pela DESIGNACAO e retorna a lista de produtos encontrados */
        public List<Produto> SearchByDesignacao(string nome)
        {
            return (from p in model.Produtos
                    where p.Designacao.Contains(nome)
                    select p).ToList<Produto>();
        }
    }
}
