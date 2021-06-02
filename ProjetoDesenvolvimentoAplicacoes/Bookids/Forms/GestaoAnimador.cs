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
        RepositorioAnimadores RepoAnimadores = new RepositorioAnimadores();
        bool editar = true;

        public GestaoAnimador()
        {
            InitializeComponent();
        }
        private void GestaoAnimador_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false;
            panelEditar.Enabled = true;

            textBoxNome.Clear();
            textBoxMorada.Clear();
            textBoxLocalidade.Clear();
            textBoxCodPostal.Clear();
            textBoxTelefone.Clear();
            textBoxTelemovel.Clear();
            textBoxEmail.Clear();
            textBoxLocalidade.Clear();
            textBoxEspecialidade.Clear();

            textBoxNome.Focus(); 
        }
        


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int telefone = Convert.ToInt32(textBoxTelefone.Text);
            int telemovel = Convert.ToInt32(textBoxTelemovel.Text);

            Animador animador = new Animador(textBoxNome.Text,textBoxMorada.Text,textBoxLocalidade.Text,textBoxCodPostal.Text,telefone,telemovel,textBoxEmail.Text,textBoxEspecialidade.Text);

            if(editar == true)
            {
                Animador animadorEditado = (Animador)listBoxAnimadores.SelectedItem;

                RepoAnimadores.EditAnimador(animadorEditado.IdPessoa,animador);
                MessageBox.Show("Editada com Sucesso");

                refresh();
            }
            else
            {
                if (RepoAnimadores.AddAnimador(animador))
                {
                    MessageBox.Show("Animador criado com sucesso");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar criar o Animador!");
                }
            }
        }



        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxAnimadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEditar.Enabled = false;

            Animador animador = (Animador)listBoxAnimadores.SelectedItem;

            textBoxNome.Text = animador.Nome;
            textBoxMorada.Text = animador.Morada;
            textBoxLocalidade.Text = animador.Localidade;
            textBoxCodPostal.Text = animador.CodPostal;
            textBoxTelefone.Text = animador.Telefone.ToString();
            textBoxTelemovel.Text = animador.Telemovel.ToString();
            textBoxEmail.Text = animador.Email;
            textBoxEspecialidade.Text = animador.Especialidade;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            listBoxAnimadores.DataSource = RepoAnimadores.GetAnimadores();
        }

        private void panelBotaoPesquisa_Click(object sender, EventArgs e)
        {
            listBoxAnimadores.DataSource = RepoAnimadores.SearchByName(textBoxPesquisa.Text);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Enabled = true; // Ativa o painel
            editar = true;

            textBoxNome.Focus(); // Coloca o cursor no painel
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Animador animador = (Animador)listBoxAnimadores.SelectedItem; // Guarda a escola selecionada

            if (animador != null) // Verifica se a escola nao e' null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    if (RepoAnimadores.RemoveAnimador(animador)) // Remove a escola
                    {
                        MessageBox.Show("Removida com Sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar remover!");
                    }
                }

                listBoxAnimadores.DataSource = RepoAnimadores.GetAnimadores(); // Atualiza a lista de escolas
            }
            else
            {
                MessageBox.Show("Tem de selecionar uma escola!");
            }
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            listBoxAnimadores.DataSource = RepoAnimadores.SearchByName(textBoxPesquisa.Text);
        }
    }
}
