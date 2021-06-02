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
        RepositorioClientes RepoClientes = new RepositorioClientes();

        public GestaoCompras()
        {
            InitializeComponent();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            var formNovaCompra = new FormNovaCompra();
            formNovaCompra.ShowDialog();
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void refreshClientes()
        {
            listaClientes.DataSource = RepoClientes.GetClientes();
        }

        private void GestaoCompras_Load(object sender, EventArgs e)
        {
            refreshClientes();
        }
    }
}
