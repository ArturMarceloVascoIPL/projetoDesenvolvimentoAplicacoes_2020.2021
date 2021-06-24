using Bookids.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            eventosTableAdapter.FillBy(bookidsDBDataSet.Eventos);
        }

        #region Butoes

        private void btnAnimadores_Click(object sender, EventArgs e)
        {
            var formAnimador = new GestaoAnimador();
            formAnimador.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var formProdutos = new GestaoProdutos(false);
            formProdutos.ShowDialog();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            var formEscolas = new GestaoEscolas();
            formEscolas.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

            var formCompras = new GestaoCompras();
            formCompras.ShowDialog();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            var formEventos = new GestaoEventos();
            formEventos.ShowDialog();
        }

        private void btnCLientesFilhos_Click(object sender, EventArgs e)
        {
            var formClientesFilhos = new GestaoClienteFilhos();
            formClientesFilhos.ShowDialog();
        } 

        #endregion

        #region Menu Tool Strip

        //Eventos
        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarRecenteEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Compras
        private void verCompraRecenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioClientes repoClientes = new RepositorioClientes();
            RepositorioCompras repoCompras = new RepositorioCompras();
            RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();
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

        #region MiscFunctions

        // Apresenta a hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            labelData.Text = DateTime.Now.ToString("d");
        }

        #endregion
    }
}
