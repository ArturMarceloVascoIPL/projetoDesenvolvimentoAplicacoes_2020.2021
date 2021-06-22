using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids.Forms
{
    public partial class MostraDetalhesCompra : Form
    {
        RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();
        Compra compra;
        public MostraDetalhesCompra(Compra compra)
        {
            InitializeComponent();

            labeNome.Text = compra.Cliente.Nome;
            labelPrecoTotal.Text = $"{repositorioDetalhesCompras.GetDinheiroTotal(compra)} €";
            foreach (var item in compra.DetalhesCompras)
            {
                listBoxDetalhesCompras.Items.Add(item);
            }

            this.compra = compra;
        }

        private void listBoxDetalhesCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalheCompra detalheCompra = (DetalheCompra)listBoxDetalhesCompras.SelectedItem;

            if (detalheCompra != null)
            {
                labelPrecoDetalhe.Text = $"{detalheCompra.Produto.Preco * detalheCompra.Quantidade} €";
            }
            
        }
    }
}
