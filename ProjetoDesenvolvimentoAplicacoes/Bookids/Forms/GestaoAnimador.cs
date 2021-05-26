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
    public partial class GestaoAnimador : Form
    {
        private bool disposedValue;

        public GestaoAnimador()
        {
            InitializeComponent();
            Animador animador = new Animador("Nome","Dentista");
            listBoxAnimadores.Items.Add(animador);

            Model1Container _db = new Model1Container();
        }
        


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            panelEditar.Enabled = true;
        }

        private void GestaoAnimador_Load(object sender, EventArgs e)
        {
            Model1Container _db = new Model1Container();
            var results = from emp in _db.Pessoas
                          where emp is Animador
                          select emp;


            foreach (Animador Emp in results)
            {
                listBoxAnimadores.Items.Add(Emp.Morada);
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
