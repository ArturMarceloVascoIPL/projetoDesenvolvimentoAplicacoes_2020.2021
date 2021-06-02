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
    public partial class GestaoClienteFilhos : Form
    {
        //Inicializacaoes dos repositiors
        RepositorioClientes repoCliente = new RepositorioClientes();
        RepositorioFilhos repoFilho = new RepositorioFilhos();
        RepositorioEscolas repoEscola = new RepositorioEscolas();

        //Manipuacalo paneis
        bool editarCliente;
        bool editarFilho;
        bool confirmPanel = false;

        public GestaoClienteFilhos()
        {
            InitializeComponent();
        }


        #region Manipulacao Janela
        private void GestaoClienteFilhos_Load(object sender, EventArgs e)
        {
            refreshListas();
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim.Checked)
                textBoxNumCartao.Enabled = true;

            else
            {
                textBoxNumCartao.Clear();
                textBoxNumCartao.Enabled = false;
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            panelCliente.Enabled = true;
            panelFilho.Enabled = true;
        }

        private void buttonConfirmacoes_Click(object sender, EventArgs e)
        {
            if (!confirmPanel)
                confirmPanel = true;
            else
                confirmPanel = false;

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        public void refreshListas()
        {
            //Lista Clientes
            listBoxClientes.DataSource = repoCliente.GetClientes();

            //Lista Escolas
            comboBoxEscolas.DataSource = repoEscola.GetEscolas();
        }

        #endregion

        #region Gestao Clientes
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            listBoxFilhos.DataSource = cliente.Filhos.ToList();

            if (cliente != null && listBoxFilhos.Items.Count > 0)
            {
                buttonEditarCliente.Enabled = true;
                buttonApagarCliente.Enabled = true;

                buttonEditarFilho.Enabled = true;
                buttonApagarFilho.Enabled = true;

                panelFilhos.Enabled = true;

                panelCliente.Enabled = false;
                panelFilho.Enabled = false;

                labelCliente.Text = "Cliente Detalhes";

                textBoxNomeCliente.Focus();

                textBoxNomeCliente.Text = cliente.Nome;
                textBoxMorada.Text = cliente.Morada;
                textBoxLocalidade.Text = cliente.Localidade;
                textBoxCodPostal.Text = cliente.CodPostal;
                textBoxEmail.Text = cliente.Email;
                textBoxTelemovel.Text = Convert.ToString(cliente.Telemovel);
                textBoxTelefone.Text = Convert.ToString(cliente.Telefone);
            }
            else
            {
                buttonEditarFilho.Enabled = false;
                buttonApagarFilho.Enabled = false;
            }
        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            editarCliente = false;

            panelCliente.Enabled = true;
            panelFilho.Enabled = false;

            labelCliente.Text = "Cliente Novo";

            textBoxNomeCliente.Focus();

            //Apagar as textbox
            foreach (var control in panelCliente.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            //Novo Cliente
            if (!editarCliente)
            {
                Cliente cliente = new Cliente();

                // Confirmacao para guardar
                if (MessageBox.Show("Guardar Cliente ?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Verificacao se Tem os campos todos Preenchidos
                    foreach (Control c in panelCliente.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                cliente.Nome = textBoxNomeCliente.Text;
                                cliente.Morada = textBoxMorada.Text;
                                cliente.Localidade = textBoxLocalidade.Text;
                                cliente.CodPostal = textBoxCodPostal.Text;
                                cliente.Email = textBoxEmail.Text;
                                cliente.Telemovel = int.Parse(textBoxTelemovel.Text);
                                cliente.Telefone = int.Parse(textBoxTelefone.Text);

                                if (radioButtonSim.Checked)
                                {
                                    cliente.NumCartao = int.Parse(textBoxNumCartao.Text);
                                    cliente.ValorOferta = 0;
                                }
                                else //valor 0 (default) para salvar
                                {
                                    cliente.NumCartao = 0;
                                    cliente.ValorOferta = 0;
                                }

                                repoCliente.AddCliente(cliente);
                                MessageBox.Show("Salvo com Sucesso.");

                                //Apagar campos do Form
                                foreach (var control in panelCliente.Controls)
                                {
                                    if (control is TextBox)
                                        (control as TextBox).Clear();
                                }
                                break;
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

            //Editar Cliente
            else
            {
                if (MessageBox.Show("Guardar Cliente Editado?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

                    //Verificacao se Tem os campos todos Preenchidos
                    foreach (Control c in panelCliente.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                cliente.Nome = textBoxNomeCliente.Text;
                                cliente.Morada = textBoxMorada.Text;
                                cliente.Localidade = textBoxLocalidade.Text;
                                cliente.CodPostal = textBoxCodPostal.Text;
                                cliente.Email = textBoxEmail.Text;
                                cliente.Telemovel = int.Parse(textBoxTelemovel.Text);
                                cliente.Telefone = int.Parse(textBoxTelefone.Text);

                                if (radioButtonSim.Checked)
                                {
                                    cliente.NumCartao = int.Parse(textBoxNumCartao.Text);
                                    cliente.ValorOferta = 0;
                                }
                                else //valor 0 (default) para salvar
                                {
                                    cliente.NumCartao = 0;
                                    cliente.ValorOferta = 0;
                                }

                                repoCliente.EditCliente(cliente.IdPessoa, cliente);
                                MessageBox.Show("Editada com Sucesso.");

                                //Apagar campos do Form
                                foreach (var control in panelCliente.Controls)
                                {
                                    if (control is TextBox)
                                        (control as TextBox).Clear();
                                }
                                break;
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

            refreshListas();
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            panelCliente.Enabled = true;
            panelFilho.Enabled = false;
            editarCliente = true;
            labelCliente.Text = "Cliente Editar";

            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            textBoxNomeCliente.Focus();

            textBoxNomeCliente.Text = cliente.Nome;
            textBoxMorada.Text = cliente.Morada;
            textBoxLocalidade.Text = cliente.Localidade;
            textBoxCodPostal.Text = cliente.CodPostal;
            textBoxEmail.Text = cliente.Email;
            textBoxTelemovel.Text = Convert.ToString(cliente.Telemovel);
            textBoxTelefone.Text = Convert.ToString(cliente.Telefone);

        }

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem; // Guarda o cliente selecionado

            if (cliente != null) // Verifica se o cliente nao é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoCliente.RemoveCliente(cliente);
                        MessageBox.Show("Removida com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar remover!" + err.Message);
                    }
                }
            }
            else
                MessageBox.Show("Tem de selecionar um cliente!");

            refreshListas();
        }

        #endregion

        #region Gestao Filhos

        private void listBoxFilhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filho filho = (Filho)listBoxFilhos.SelectedItem;

            if (filho != null && listBoxFilhos.Items.Count > 0)
            {
                buttonEditarFilho.Enabled = true;
                buttonApagarFilho.Enabled = true;

                panelCliente.Enabled = false;
                panelFilho.Enabled = false;

                labelFilho.Text = "Filho Detalhes";

                textBoxNomeCliente.Focus();

                textBoxNomeFilho.Text = filho.Nome;
                dateTimePickerDataNascimento.Text = filho.DtaNascimento;
                if (filho.Sexo == "Masculino")
                    radioButtonMasculino.Checked = true;
                else
                    radioButtonFeminino.Checked = true;

                Escola escola = repoEscola.SearchById(filho.IdEscola);
                comboBoxEscolas.Text = escola.Nome;
            }
            else
            {
                buttonEditarFilho.Enabled = false;
                buttonApagarFilho.Enabled = false;
                panelFilho.Enabled = false;
            }
        }

        private void buttonNovoFilho_Click(object sender, EventArgs e)
        {
            panelFilho.Enabled = true;
            panelCliente.Enabled = false;
            editarFilho = false;

            labelFilho.Text = "Filho Novo";

            textBoxNomeCliente.Focus();

            //Apagar as textbox
            foreach (var control in panelFilho.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
        }

        private void buttonEditarFilho_Click(object sender, EventArgs e)
        {
            panelFilho.Enabled = true;
            panelCliente.Enabled = false;
            editarFilho = true;
            labelFilho.Text = "Filho Editar";

            Filho filho = (Filho)listBoxFilhos.SelectedItem;

            textBoxNomeFilho.Focus();

            textBoxNomeFilho.Text = filho.Nome;

            if (filho.Sexo == "Masculino")
                radioButtonMasculino.Checked = true;
            else
                radioButtonFeminino.Checked = true;

            dateTimePickerDataNascimento.Text = filho.DtaNascimento;

            Escola escola = repoEscola.SearchById(filho.IdEscola);
            comboBoxEscolas.Text = escola.Nome;

        }

        private void buttonGuardarFilho_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            if (!editarFilho)
            {
                Filho filho = new Filho();

                if (MessageBox.Show("Guardar Cliente ?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Verificacao se Tem os campos todos Preenchidos
                    foreach (Control c in panelFilho.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                filho.Nome = textBoxNomeFilho.Text;

                                if (radioButtonMasculino.Checked)
                                    filho.Sexo = "Masculino";
                                else
                                    filho.Sexo = "Feminino";

                                filho.DtaNascimento = dateTimePickerDataNascimento.Text;

                                Escola escola = (Escola)comboBoxEscolas.SelectedItem;
                                filho.IdEscola = escola.IdEscola;

                                filho.CodPostal = cliente.CodPostal;
                                filho.Morada = cliente.Morada;
                                filho.Localidade = cliente.Localidade;
                                filho.Email = cliente.Email;
                                filho.Telefone = cliente.Telefone;
                                filho.Telemovel = cliente.Telemovel;
                                filho.IdCliente = cliente.IdPessoa;

                                try
                                {
                                    repoFilho.AddFilho(filho);
                                    MessageBox.Show("Salvo com Sucesso.");
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show("Erro ao Salvar." + err.Message);
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
                if (MessageBox.Show("Guardar Cliente Editado?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Filho filho = (Filho)listBoxFilhos.SelectedItem;
                    foreach (Control c in panelFilho.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (!string.IsNullOrEmpty(Convert.ToString(textBox.Text)))
                            {
                                filho.Nome = textBoxNomeFilho.Text;

                                if (radioButtonMasculino.Checked)
                                    filho.Sexo = "Masculino";
                                else
                                    filho.Sexo = "Feminino";

                                filho.DtaNascimento = dateTimePickerDataNascimento.Text;

                                Escola escola = (Escola)comboBoxEscolas.SelectedItem;
                                filho.IdEscola = escola.IdEscola;

                                filho.CodPostal = cliente.CodPostal;
                                filho.Morada = cliente.Morada;
                                filho.Localidade = cliente.Localidade;
                                filho.Email = cliente.Email;
                                filho.Telefone = cliente.Telefone;
                                filho.Telemovel = cliente.Telemovel;
                                filho.IdCliente = cliente.IdPessoa;

                                try
                                {
                                    repoFilho.EditFilho(filho.IdPessoa, filho);
                                    MessageBox.Show("Salvo com Sucesso.");
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show("Erro ao Salvar." + err.Message);
                                }

                                //Apagar as textbox
                                foreach (var control in panelCliente.Controls)
                                {
                                    if (control is TextBox)
                                        (control as TextBox).Clear();
                                }
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Erro. Preencher Todos os Campos.");
                                break;
                            }
                        }
                    }
                }

                //Lista Filhos
                refreshListas();
                listBoxFilhos.DataSource = cliente.Filhos.ToList();
            }
        }

        private void buttonApagarFilho_Click(object sender, EventArgs e)
        {
            Filho filho = (Filho)listBoxFilhos.SelectedItem; // Guarda o cliente selecionado

            if (filho != null) // Verifica se o cliente nao é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoFilho.RemoveFilho(filho.IdPessoa);
                        MessageBox.Show("Removida com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar remover!" + err.Message);
                    }
                }
            }
            else
                MessageBox.Show("Tem de selecionar um cliente!");


            refreshListas();
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            listBoxFilhos.DataSource = cliente.Filhos.ToList();

        }

        private void buttonConfirmacoes_Click_1(object sender, EventArgs e)
        {
            if (panelConfirmacoes.Enabled == false)
                panelConfirmacoes.Enabled = true;
            else
                panelConfirmacoes.Enabled = false;

        }
    }
    #endregion
}
