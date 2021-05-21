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
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim.Checked == true)
            {
                textBoxNumCartao.Enabled = true;
            }
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

        private void buttonConfirmacoes_Click(object sender, EventArgs e)
        {
            Size = new Size(1310, 466);
        }

        private void GestaoClienteFilhos_Load(object sender, EventArgs e)
        {
            Size = new Size(1085, 466);
        }
    }
}
