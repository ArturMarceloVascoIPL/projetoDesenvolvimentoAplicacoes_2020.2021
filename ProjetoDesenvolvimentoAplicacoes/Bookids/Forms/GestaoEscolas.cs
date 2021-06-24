using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids.Forms
{
    public partial class GestaoEscolas : Form
    {
        RepositorioEscolas repoEscolas = new RepositorioEscolas(); // Instancia o repositorio das escolas

        bool editar = true; // Variavel para verificar se vai editar(true) ou criar(false) a escola

        public GestaoEscolas()
        {
            InitializeComponent();
        }

        private void GestaoEscolas_Load(object sender, EventArgs e)
        {
            listBoxEscolas.DataSource = repoEscolas.GetEscolas();

            toolTipRefresh.SetToolTip(buttonRefresh, "Atualizar Lista");
        }

        #region MiscFunctions

        // Cria um gradiente como fundo do Form 
        private void GestaoEscolas_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.WhiteSmoke, Color.FromArgb(157, 131, 235), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        #endregion

        #region GestaoEscola

        /* Desbloqueia e Limpa o painel para inserir os dados da nova escola */
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false; // Mete 'editar' a falso pois nao vai editar

            labelEscola.Text = "Nova Escola";
            buttonGuardarEscola.Text = "Criar";
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
            editar = true; // Mete 'editar' a verdadeiro pois vai editar

            labelEscola.Text = "Editar Escola";
            buttonGuardarEscola.Text = "Guardar";
            panelEscola.Enabled = true; // Ativa o painel

            textBoxNome.Focus(); // Coloca o cursor no painel
        }

        /* Apaga a escola selecionada */
        private void buttonApagarEscola_Click(object sender, EventArgs e)
        {
            Escola escola = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

            if (escola != null) // Verifica se a escola não é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoEscolas.RemoveEscola(escola); // Remove a escola
                        MessageBox.Show("Removida com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Ocorreu um erro ao tentar remover!\n{err.Message}");
                    }
                }

                listBoxEscolas.DataSource = repoEscolas.GetEscolas(); // Atualiza a lista de escolas
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

            if (editar == true)
            {
                Escola escolaEditada = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

                repoEscolas.EditEscola(escolaEditada.IdEscola, escola); // Edita a escola
                MessageBox.Show("Editada com Sucesso.");
            }
            else
            {
                try
                {
                    repoEscolas.AddEscola(escola); // Cria a escola                
                    MessageBox.Show("Criada com Sucesso.");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar criar a escola!\n{err.Message}");
                }
            }

            listBoxEscolas.DataSource = repoEscolas.GetEscolas(); // Atualiza a lista de escolas
        }

        /* Bloqueia o painel e Apresenta os dados da escola */
        private void listBoxEscolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEscola.Enabled = false; // Bloqueia o painel

            Escola escola = (Escola)listBoxEscolas.SelectedItem; // Guarda a escola selecionada

            // Apresenta os dados da escola
            textBoxNome.Text = escola.Nome;
            textBoxMorada.Text = escola.Morada;
            textBoxLocalidade.Text = escola.Localidade;
            textBoxCodPostal.Text = escola.CodPostal;
            textBoxTelefone.Text = escola.Telefone.ToString();
            textBoxEmail.Text = escola.Email;

            // Apresenta os alunos
            try
            {
                listBoxAlunos.DataSource = escola.Filhos.ToList<Filho>();
            }
            catch (Exception)
            {

            }

            // Apresenta os eventos planeados
            listBoxEventos.DataSource = repoEscolas.GetEventos(escola.IdEscola);
        }


        /* Atualizar lista ou Limpar a pesquisa */
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBoxEscolas.DataSource = repoEscolas.GetEscolas();
        }

        /* Apenas permitir inserir numeros no campo do numero de telefone */
        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* Pesquisa escolas pelo NOME */
        private void textBoxPesquisaEscolas_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBoxEscolas.DataSource = repoEscolas.SearchByName(textBoxPesquisaEscolas.Text);
        }

        #endregion

        private void GestaoEscolas_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoEscolas.Dispose();
        }

        #region Menu Tool Strip
        //HomePage
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Eventos
        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoEventos"];
        }

        //Compras
        private void verCompraRecenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioClientes repoClientes = new RepositorioClientes();
            RepositorioCompras repoCompras = new RepositorioCompras();
            RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();
        }

        // Produtos
        private void novoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoProdutos"];

            if (fc != null)
                fc.Focus();
            else
            {
                GestaoProdutos produtoForm = new GestaoProdutos(false);
                produtoForm.Show();
            }
        }

        private void editarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["GestaoProdutos"];

            if (fc != null)
                fc.Focus();
            else
            {
                GestaoProdutos produtoForm = new GestaoProdutos(true);
                produtoForm.Show();
            }
        }
        #endregion 
    }
}
