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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnimadores_Click(object sender, EventArgs e)
        {
            var formAnimador = new GestaoAnimador();
            formAnimador.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var formProdutos = new GestaoProdutos();
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
    }
}
