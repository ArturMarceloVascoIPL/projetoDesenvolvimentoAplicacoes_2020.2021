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
        RepositorioEventos repoEventos = new RepositorioEventos();
        RepositorioAnimadores repoAnimadores = new RepositorioAnimadores();
        RepositorioEscolas repoEscolas = new RepositorioEscolas();

        bool editar = false;

        public GestaoEventos()
        {
            InitializeComponent();
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestaoEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoEventos.Dispose();
            repoAnimadores.Dispose();
            repoEscolas.Dispose();
        }

        private void btnExportFichaInsc_Click(object sender, EventArgs e)
        {
            var exportarFichaInscricao = new ExportarFile(true, textBoxDescricao.Text, textBoxLocal.Text);
            exportarFichaInscricao.ShowDialog();
        }

        private void btnExportInscritos_Click(object sender, EventArgs e)
        {
            var exportarInscritos = new ExportarFile();
            exportarInscritos.ShowDialog();
        }

        #region GestaoEventos
        
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false;

            labelEvento.Text = "Novo Evento";
            buttonGuardarEvento.Text = "Criar";

            panelEvento.Enabled = true;
            panelAnimadores.Enabled = true;
            panelEscolas.Enabled = true;

            textBoxDescricao.Clear();
            textBoxLocal.Clear();
            textBoxTipoEvento.Clear();
            textBoxMaxParticipantes.Clear();
            textBoxIdadeMin.Clear();
            textBoxIdadeMax.Clear();
            dateTimePickerData.Value = DateTime.Now;

            textBoxDescricao.Focus();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar = true;

            labelEvento.Text = "Editar Evento";
            buttonGuardarEvento.Text = "Guardar";

            panelEvento.Enabled = true;
            panelAnimadores.Enabled = true;
            panelEscolas.Enabled = true;

            textBoxDescricao.Focus();
        }

        #endregion


        #region TextBoxValidation

        private void textBoxMaxParticipantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdadeMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdadeMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        void refreshListas()
        {
            RepositorioEventos repoEventos = new RepositorioEventos();
            RepositorioAnimadores repoAnimadores = new RepositorioAnimadores();
            RepositorioEscolas repoEscolas = new RepositorioEscolas();

            listBoxEventos.DataSource = repoEventos.GetEventos();
            comboBoxAnimadores.DataSource = repoAnimadores.GetAnimadores();
            comboBoxEscolas.DataSource = repoEscolas.GetEscolas();
        }

        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;

            listBoxAnimadores.DataSource = repoEventos.GetAnimadores(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolas(evento.IdEvento);
                // TODO - Adicionar os participantes

            textBoxDescricao.Text = evento.Descricao;
            textBoxLocal.Text = evento.Local;
            textBoxTipoEvento.Text = evento.TipoEvento;
            textBoxMaxParticipantes.Text = evento.LimiteParticipacao.ToString();
            textBoxIdadeMin.Text = evento.IdadeInferiror.ToString();
            textBoxIdadeMax.Text = evento.IdadeSuperior.ToString();
            dateTimePickerData.Value = evento.DataHora;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshListas();
        }
    }
}
