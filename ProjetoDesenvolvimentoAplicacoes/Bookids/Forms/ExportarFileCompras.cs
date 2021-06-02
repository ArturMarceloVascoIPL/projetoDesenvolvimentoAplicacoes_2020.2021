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
    public partial class ExportarFileCompras : Form
    {
        public ExportarFileCompras()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPDF_MouseHover(object sender, EventArgs e)
        {
            buttonPDF.BackColor = Color.Red;
            buttonTXT.BackColor = Color.White;
        }

        private void buttonPDF_MouseLeave(object sender, EventArgs e)
        {
            buttonPDF.BackColor = Color.White;
            buttonTXT.BackColor = Color.Red;
        }

        private void buttonTXT_MouseHover(object sender, EventArgs e)
        {
            buttonPDF.BackColor = Color.White;
            buttonTXT.BackColor = Color.Red;
        }

        private void buttonTXT_MouseLeave(object sender, EventArgs e)
        {
            buttonPDF.BackColor = Color.White;
            buttonTXT.BackColor = Color.White;
        }
    }
}
