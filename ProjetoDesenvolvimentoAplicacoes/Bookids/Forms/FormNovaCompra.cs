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
    public partial class FormNovaCompra : Form
    {
        public FormNovaCompra()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Exportar?", "Exportar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var exportForm = new ExportarFileCompras();
                exportForm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
