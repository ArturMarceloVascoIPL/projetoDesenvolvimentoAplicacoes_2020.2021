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
    public partial class GestaoProdutos : Form
    {
        public GestaoProdutos()
        {
            InitializeComponent();
        }

        private void btnAddTipos_Click(object sender, EventArgs e)
        {
            //aumentar janela 
            panelEditProdutos.Enabled = false;

        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            panelEditProdutos.Enabled = true;
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
