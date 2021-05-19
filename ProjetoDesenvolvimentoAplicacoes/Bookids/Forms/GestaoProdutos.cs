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
            Size = new Size(1043, 595);
        }

        private void btnAddTipos_Click(object sender, EventArgs e)
        {
            //aumentar janela
            Size = new Size(1592, 595);
            Location = new Point(Location.X - 250, Location.Y);
            panelEditProdutos.Enabled = false;

        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            panelEditProdutos.Enabled = true;
        }
    }
}
