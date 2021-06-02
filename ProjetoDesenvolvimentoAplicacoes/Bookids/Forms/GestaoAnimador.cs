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

        public void refresh()
        {
            listBoxAnimadores.DataSource = RepoAnimadores.GetAnimadores();
        }

        private void GestaoAnimador_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxAnimadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAnimador.Enabled = false;
            labelAnimador.Text = "Animador Detalhes";

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

        private void panelBotaoPesquisa_Click(object sender, EventArgs e)
        {
            listBoxAnimadores.DataSource = RepoAnimadores.SearchByName(textBoxPesquisa.Text);
        }

        //Para Permitir apenas numeros quando a digitar nas Textbox
        private void textBoxNumApena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false;
            panelAnimador.Enabled = true;
            labelAnimador.Text = "Animador Novo";

            //Apagar campos do Form
            foreach (var control in panelAnimador.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }

            textBoxNome.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {

                //Apagar campos do Form
                foreach (var control in panelAnimador.Controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                }
            }

            panelAnimador.Enabled = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int telefone = 0;
            int telemovel = 0;

            if (!string.IsNullOrEmpty(Convert.ToString(textBoxTelefone.Text)))
                telefone = Convert.ToInt32(textBoxTelefone.Text);

            if (!string.IsNullOrEmpty(Convert.ToString(textBoxTelemovel.Text)))
                telemovel = Convert.ToInt32(textBoxTelemovel.Text);

            if (!editar)
            {
                // Confirmacao para guardar
                if (MessageBox.Show("Guardar Cliente ?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Verificacao se Tem os campos todos Preenchidos
                    foreach (Control c in panelAnimador.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                Animador animador = new Animador(textBoxNome.Text, textBoxMorada.Text, textBoxLocalidade.Text, textBoxCodPostal.Text, telefone, telemovel, textBoxEmail.Text, textBoxEspecialidade.Text);
                                if (RepoAnimadores.AddAnimador(animador))
                                {
                                    MessageBox.Show("Animador criado com sucesso");

                                    //Apagar campos do Form
                                    foreach (var control in panelAnimador.Controls)
                                    {
                                        if (control is TextBox)
                                            (control as TextBox).Clear();
                                    }
                                    refresh();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Ocorreu um erro ao tentar criar o Animador!");
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro. Preencher Todos os Campos.");
                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                // Confirmacao para guardar
                if (MessageBox.Show("Guardar Cliente ?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Verificacao se Tem os campos todos Preenchidos
                    foreach (Control c in panelAnimador.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                Animador animadorEditado = (Animador)listBoxAnimadores.SelectedItem;
                                Animador animador = new Animador(textBoxNome.Text, textBoxMorada.Text, textBoxLocalidade.Text, textBoxCodPostal.Text, telefone, telemovel, textBoxEmail.Text, textBoxEspecialidade.Text);
                                if (RepoAnimadores.EditAnimador(animadorEditado.IdPessoa, animador))
                                {
                                    MessageBox.Show("Editada com Sucesso");
                                    //Apagar campos do Form
                                    foreach (var control in panelAnimador.Controls)
                                    {
                                        if (control is TextBox)
                                            (control as TextBox).Clear();
                                    }
                                    refresh();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Ocorreu um erro ao tentar criar o Animador!");
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro. Preencher Todos os Campos.");
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            labelAnimador.Text = "Animador Editar";

            panelAnimador.Enabled = true; // Ativa o painel
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
