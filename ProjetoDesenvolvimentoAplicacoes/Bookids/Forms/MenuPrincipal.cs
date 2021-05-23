using Bookids.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            labelData.Text = DateTime.Now.ToString("d");
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

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarRecenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verRecenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
