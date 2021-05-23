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
    public partial class GestaoClienteFilhos : Form
    {
        public GestaoClienteFilhos()
        {
            InitializeComponent();
            Size = new Size(886, 573);
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim.Checked == true)
                textBoxNumCartao.Enabled = true;

            else
            {
                textBoxNumCartao.Clear();
                textBoxNumCartao.Enabled = false;
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            panelCliente.Enabled = true;
            panelFilho.Enabled = true;
        }

        bool confirmPanel = false;
        private void buttonConfirmacoes_Click(object sender, EventArgs e)
        {
            if (!confirmPanel)
            {
                Size = new Size(1743, 573);
                Location = new Point(Location.X - 400, Location.Y);
                confirmPanel = true;
            }
            else
            {
                Size = new Size(886, 573);
                Location = new Point(Location.X + 400, Location.Y);
                confirmPanel = false;
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
