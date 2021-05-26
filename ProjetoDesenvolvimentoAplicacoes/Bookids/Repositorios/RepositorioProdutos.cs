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
        public bool AddProduto(Produto produto)
        {
            try
            {
                model.Produtos.Add(produto);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /* Remove um produto, retorna true(sucesso) ou false(erro) */
        public bool RemoveProduto(Produto produto)
        {
            try
            {
                model.Produtos.Remove(produto);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /* Edita um produto, retorna true(sucesso) ou false(erro) */
        public bool EditProduto(int id, Produto produtoEditado)
        {
            try
            {
                Produto produtoEncontrado = (from p in model.Produtos
                                            where p.IdProduto == id
                                            select p).Single();

                produtoEncontrado.Designacao = produtoEditado.Designacao;
                produtoEncontrado.Preco = produtoEditado.Preco;
                produtoEncontrado.TipoProduto = produtoEditado.TipoProduto;
                produtoEncontrado.StockExistente = produtoEditado.StockExistente;

                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /* Faz uma pesquisa pela DESIGNACAO e retorna a lista de produtos encontrados */
        public List<Produto> SearchByDesignacao(string nome)
        {
            return (from p in model.Produtos
                    where p.Designacao == nome
                    select p).ToList<Produto>();
        }
    }
}
