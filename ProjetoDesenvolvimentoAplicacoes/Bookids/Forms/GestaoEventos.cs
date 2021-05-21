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
    public partial class GestaoEventos : Form
    {
        public GestaoEventos()
        {
            InitializeComponent();
        }

        private void btnNovoEvento_Click(object sender, EventArgs e)
        {
            panelEditEvento.Enabled = true;
            panelEditEventoExtend.Enabled = true;
        }
        private void btnCancelarEvento_Click(object sender, EventArgs e)
        {

            panelEditEvento.Enabled = true;
            panelEditEventoExtend.Enabled = true;
        }
    }
}
