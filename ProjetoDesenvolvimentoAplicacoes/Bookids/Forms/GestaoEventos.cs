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
        RepositorioColaboracao repoColaboracao = new RepositorioColaboracao();
        RepositorioParticipacao repoParticipacao = new RepositorioParticipacao();

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
            repoColaboracao.Dispose();
            repoParticipacao.Dispose();
        }

        private void btnExportFichaInsc_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;

            var exportarFichaInscricao = new ExportarFile(evento);
            exportarFichaInscricao.ShowDialog();
        }

        private void btnExportInscritos_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;

            var exportarInscritos = new ExportarFile(repoEventos.GetParticipantes(evento.IdEvento));
            exportarInscritos.ShowDialog();
        }

        #region GestaoEventos

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false;

            labelEvento.Text = "Novo Evento";
            buttonGuardarEvento.Text = "Criar";

            panelEvento.Enabled = true;

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

        private void buttonApagarEvento_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem; // Guarda o evento selecionado

            if (evento == null) // Verifica se não é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoEventos.RemoveEvento(evento); // Remove
                        MessageBox.Show("Removido com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Ocorreu um erro ao tentar remover!\n{err.Message}");
                    }
                }

                refreshListas();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um Evento!");
            }
        }

        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;

            listBoxAnimadores.DataSource = repoEventos.GetAnimadores(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolas(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);

            textBoxDescricao.Text = evento.Descricao;
            textBoxLocal.Text = evento.Local;
            textBoxTipoEvento.Text = evento.TipoEvento;
            textBoxMaxParticipantes.Text = evento.LimiteParticipacao.ToString();
            textBoxIdadeMin.Text = evento.IdadeInferiror.ToString();
            textBoxIdadeMax.Text = evento.IdadeSuperior.ToString();
            dateTimePickerData.Value = evento.DataHora;
        }

        /* Edita ou Cria o Evento */
        private void buttonGuardarEvento_Click(object sender, EventArgs e)
        {
            // Convert os valores das TextBox
            int maxParticipantes = Convert.ToInt32(textBoxMaxParticipantes.Text);
            int idadeMin = Convert.ToInt32(textBoxIdadeMin.Text);
            int idadeMax = Convert.ToInt32(textBoxIdadeMax.Text);

            Evento evento = new Evento(textBoxDescricao.Text, textBoxLocal.Text, textBoxTipoEvento.Text, maxParticipantes, idadeMin, idadeMax, dateTimePickerData.Value); // Guarda o novo Evento

            if (editar == true)
            {
                Evento eventoEditado = (Evento)listBoxEventos.SelectedItem; // Guarda o Evento selecionado

                repoEventos.EditEvento(eventoEditado.IdEvento, evento); // Edita o Evento
                MessageBox.Show("Editado com Sucesso.");
            }
            else
            {
                try
                {
                    repoEventos.AddEvento(evento); // Cria o Evento                
                    MessageBox.Show("Criado com Sucesso.");

                    panelAnimadores.Enabled = true;
                    panelEscolas.Enabled = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar criar!\n{err.Message}");
                }
            }

            refreshListas();
        }

        #endregion

        #region GestaoColaboracao

        private void buttonAdicionarAnimador_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Animador animador = (Animador)comboBoxAnimadores.SelectedItem;

            Colaboracao colaboracao = new Colaboracao(animador.IdPessoa, evento.IdEvento);

            repoColaboracao.AddColaboracao(colaboracao);
        }

        private void buttonRemoverAnimador_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Animador animador = (Animador)listBoxAnimadores.SelectedItem;

            Colaboracao colaboracao = new Colaboracao(animador.IdPessoa, evento.IdEvento);

            repoColaboracao.RemoveColaboracao(colaboracao);
        }

        #endregion

        #region GestaoParticipacao
        private void buttonAdicionarEscola_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Escola escola = (Escola)comboBoxEscolas.SelectedItem;

            Participacao participacao = new Participacao(escola.IdEscola, evento.IdEvento);

            repoParticipacao.AddParticipacao(participacao);
        }

        private void buttonRemoverEscola_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Escola escola = (Escola)listBoxEscolas.SelectedItem;

            Participacao participacao = new Participacao(escola.IdEscola, evento.IdEvento);

            repoParticipacao.RemoveParticipacao(participacao);
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

        #region MiscFuncoes

        void refreshListas()
        {
            RepositorioEventos repoEventos = new RepositorioEventos();
            RepositorioAnimadores repoAnimadores = new RepositorioAnimadores();
            RepositorioEscolas repoEscolas = new RepositorioEscolas();

            listBoxEventos.DataSource = repoEventos.GetEventos();
            comboBoxAnimadores.DataSource = repoAnimadores.GetAnimadores();
            comboBoxEscolas.DataSource = repoEscolas.GetEscolas();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshListas();
        }

        private void GestaoEventos_Load(object sender, EventArgs e)
        {
            refreshListas();
        }

        #endregion
    }
}
