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
    public partial class ExportarFile : Form
    {
        public ExportarFile()
        {
            InitializeComponent();
        }

        public string option { get; set; }

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

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            option = "PDF";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonTXT_Click(object sender, EventArgs e)
        {
            option = "TXT";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
