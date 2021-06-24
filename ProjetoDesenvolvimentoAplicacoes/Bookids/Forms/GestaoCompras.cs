using Bookids.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class GestaoCompras : Form
    {
        RepositorioClientes repoClientes = new RepositorioClientes();
        RepositorioCompras repoCompras = new RepositorioCompras();
        RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();

        public GestaoCompras()
        {
            InitializeComponent();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            var formNovaCompra = new FormNovaCompra((Cliente)listaClientes.SelectedItem);
            formNovaCompra.ShowDialog();
        }

        public void refreshClientes()
        {
            listaClientes.DataSource = repoClientes.GetClientes();
        }

        private void GestaoCompras_Load(object sender, EventArgs e)
        {
            refreshClientes();
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaClientes.SelectedItem;
            if (cliente != null)
            {
                listaCompras.DataSource = repoCompras.GetCompras(cliente.IdPessoa);
                if (listaCompras.Items.Count == 0)
                {
                    labelPrecoTotalCompra.Text = "-,-- €";
                }
                panelCompras.Enabled = true;

                labelNomeCliente.Text = cliente.Nome;
            }
        }

        private void listaCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Compra compra = (Compra)listaCompras.SelectedItem;

            var compras = repoCompras.GetCompras(compra.IdCompra);

            decimal total = repositorioDetalhesCompras.GetDinheiroTotal(compra);

            labelPrecoTotalCompra.Text = $"{total}€";
        }

        private void btnApagarCompra_Click(object sender, EventArgs e)
        {
            Compra compra = (Compra)listaCompras.SelectedItem;
            Cliente cliente = (Cliente)listaClientes.SelectedItem;

            repoCompras.DeleteCompras(compra);

            listaCompras.DataSource = repoCompras.GetCompras(cliente.IdPessoa);
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            Compra compra = (Compra)listaCompras.SelectedItem;

            var formMostraDetlahesCompra = new Forms.MostraDetalhesCompra(compra);
            formMostraDetlahesCompra.ShowDialog();

        }

        private void textBoxSearchClientes_TextChanged(object sender, EventArgs e)
        {
            listaClientes.DataSource = repoClientes.SearchByName(textBoxSearchClientes.Text);
        }

        #region Menu Tool Strip

        //HomePage
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Eventos
        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoEventos"];
        }

        // Produtos
        private void novoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoProdutos"];

            if (fc != null)
                fc.Focus();
            else
            {
                GestaoProdutos produtoForm = new GestaoProdutos(false);
                produtoForm.Show();
            }
        }

        private void editarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoProdutos"];

            if (fc != null)
                fc.Focus();
            else
            {
                GestaoProdutos produtoForm = new GestaoProdutos(true);
                produtoForm.Show();
            }
        }
        #endregion
    }
}
