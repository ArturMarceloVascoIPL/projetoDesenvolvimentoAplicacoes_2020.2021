using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    class RepositorioTipoProdutos : IDisposable
    {
        Model1Container model = new Model1Container();

        /* Retorna em Lista todos os dados dos Produtos */
        public List<TipoProduto> GetTipos()
        {
            return model.TiposProdutos.ToList<TipoProduto>();
        }

        /* Adiciona um tipo de produto, retorna true(sucesso) ou false(erro) */
        public void AddTipo(TipoProduto tipoProduto)
        {
            model.TiposProdutos.Add(tipoProduto);
            model.SaveChanges();
        }

        /* Remove um tipo de produto, retorna true(sucesso) ou false(erro) */
        public void RemoveTipo(TipoProduto tipoProduto)
        {
            model.TiposProdutos.Remove(tipoProduto);
            model.SaveChanges();
        }

        /* Faz uma pesquisa pelo ID e retorna o produto encontrado */
        public TipoProduto SearchById(int id)
        {
            return (from p in model.TiposProdutos
                    where p.IdTipoProduto == id
                    select p).Single();
        }

        /* Fecha as ligacoes na base de dados e liberta os recursos do computador */
        public void Dispose()
        {
            ((IDisposable)model).Dispose();
        }
    }
}
