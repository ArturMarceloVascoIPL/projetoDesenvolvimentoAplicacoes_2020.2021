using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioTipoProdutos
    {
        Model1Container model = new Model1Container();

        /* Retorna em Lista todos os dados dos Produtos */
        public List<TipoProduto> GetTipos()
        {
            return model.TiposProdutos.ToList<TipoProduto>();
        }

        /* Adiciona um tipo de produto, retorna true(sucesso) ou false(erro) */
        public bool AddTipo(TipoProduto tipoProduto)
        {
            try
            {
                model.TiposProdutos.Add(tipoProduto);
                model.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /* Remove um tipo de produto, retorna true(sucesso) ou false(erro) */
        public bool RemoveTipo(TipoProduto tipoProduto)
        {
            try
            {
                model.TiposProdutos.Remove(tipoProduto);
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
