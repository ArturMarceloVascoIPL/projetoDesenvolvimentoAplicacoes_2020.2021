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
        bool card;

        public FormNovaCompra()
        {
            InitializeComponent();
            timer1.Start();
            panelCardNo.BackColor = Color.Red;
            panelCardYes.BackColor = Color.White;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            labelData.Text = DateTime.Now.ToString("d");
        }

        private void panelCardYes_Click(object sender, EventArgs e)
        {
            card = true;
            panelCardYes.BackColor = Color.Green;
            panelCardNo.BackColor = Color.White;
        }

        private void panelCardNo_Click(object sender, EventArgs e)
        {
            card = false;
            panelCardNo.BackColor = Color.Red;
            panelCardYes.BackColor = Color.White;
        }
    }
}
