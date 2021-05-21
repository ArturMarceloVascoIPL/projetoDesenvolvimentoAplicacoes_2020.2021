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
    public partial class GestaoEscolas : Form
    {
        RepositorioEscolas RepoEscolas = new RepositorioEscolas(); // Instancia o repositorio das escolas

        bool editar = true; // Variavel para verificar se vai editar(true) ou criar(false) a escola

        public GestaoEscolas()
        {
            InitializeComponent();
        }

        private void GestaoEscolas_Load(object sender, EventArgs e)
        {
            listBoxEscolas.DataSource = RepoEscolas.GetEscolas();

            toolTipPesquisa.SetToolTip(buttonPesquisarEscolas, "Case Sensitive");
            toolTipRefresh.SetToolTip(buttonRefresh, "Atualizar Lista");
        }

        /* Desbloqueia e Limpa o painel para inserir os dados da nova escola */
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false; // Mete 'editar' a falso pois nao vai editar

            panelEscola.Enabled = true; // Ativa o painel

            // Limpa o painel
            textBoxNome.Clear();
            textBoxMorada.Clear();
            textBoxLocalidade.Clear();
            textBoxCodPostal.Clear();
            textBoxTelefone.Clear();
            textBoxEmail.Clear();

            textBoxNome.Focus(); // Coloca o cursor no painel

        }

        /* Desbloqueia e Permite editar a escola selecionada */
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            panelEscola.Enabled = true; // Ativa o painel

            textBoxNome.Focus(); // Coloca o cursor no painel
        }

        /* Apaga a escola selecionada */
        private void buttonApagarEscola_Click(object sender, EventArgs e)
        {
            Escola escola = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

            if (escola != null) // Verifica se a escola nao e' null
            {
                if (RepoEscolas.RemoveEscola(escola)) // Remove a escola
                {
                    MessageBox.Show("Removida com Sucesso.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar remover!");
                }

                listBoxEscolas.DataSource = RepoEscolas.GetEscolas(); // Atualiza a lista de escolas
            }
            else
            {
                MessageBox.Show("Tem de selecionar uma escola!");
            }
        }

        /* Edita ou Cria a escola */
        private void buttonGuardarEscola_Click(object sender, EventArgs e)
        {
            int telefone = Convert.ToInt32(textBoxTelefone.Text); // Converte o telefone para inteiro
            Escola escola = new Escola(textBoxNome.Text, textBoxMorada.Text, textBoxLocalidade.Text, textBoxCodPostal.Text, telefone, textBoxEmail.Text); // Guarda a nova escola

            if (editar == true) /* EDICAO NAO FUNCIONAL AINDA */
            {
                Escola escolaEditada = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

                RepoEscolas.EditEscola(escolaEditada.IdEscola, escola); // Edita a escola
                MessageBox.Show("Editada com Sucesso.");
            }
            else
            {
                if (RepoEscolas.AddEscola(escola)) // Cria a escola
                {
                    MessageBox.Show("Criada com Sucesso.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar criar a escola!");
                }
            }

            listBoxEscolas.DataSource = RepoEscolas.GetEscolas(); // Atualiza a lista de escolas
        }

        /* Bloqueia o painel e Apresenta os dados da escola */
        private void listBoxEscolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEscola.Enabled = false; // Bloqueia o painel

            Escola escola = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

            // Apresenta os dados
            textBoxNome.Text = escola.Nome;
            textBoxMorada.Text = escola.Morada;
            textBoxLocalidade.Text = escola.Localidade;
            textBoxCodPostal.Text = escola.CodPostal;
            textBoxTelefone.Text = escola.Telefone.ToString();
            textBoxEmail.Text = escola.Email;
        }

        /* Pesquisar as escolas por nome */
        private void buttonPesquisarEscolas_Click(object sender, EventArgs e)
        {
            listBoxEscolas.DataSource = RepoEscolas.SearchByName(textBoxPesquisaEscolas.Text);
        }

        /* Atualizar lista ou Limpar a pesquisa */
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBoxEscolas.DataSource = RepoEscolas.GetEscolas();
        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
