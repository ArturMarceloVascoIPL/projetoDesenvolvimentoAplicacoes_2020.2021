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
        RepositorioClientes repoCliente = new RepositorioClientes();
        RepositorioFilhos repoFilho = new RepositorioFilhos();
        RepositorioEscolas repoEscola = new RepositorioEscolas();

        bool editarCliente;
        bool editarFilho;

        public GestaoClienteFilhos()
        {
            InitializeComponent();

            Size = new Size(886, 573);
        }

        private void GestaoClienteFilhos_Load(object sender, EventArgs e)
        {
            refreshListas();
        }

        #region Manipulacao Janela
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

        bool confirmPanel = false;
        private void buttonConfirmacoes_Click(object sender, EventArgs e)
        {
            if (!confirmPanel)
            {
                Size = new Size(1743, 573);
                Location = new Point(Location.X - 400, Location.Y);
                confirmPanel = true;
            }
            else
            {
                Size = new Size(886, 573);
                Location = new Point(Location.X + 400, Location.Y);
                confirmPanel = false;
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

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

            if (cliente != null)
            {
                buttonEditarCliente.Enabled = true;
                buttonApagarCliente.Enabled = true;
                panelFilhos.Enabled = true;

                if (Size != new Size(1428, 573))
                {
                    Size = new Size(1428, 573);
                    Location = new Point(Location.X - 250, Location.Y);
                }

                if (Size != new Size(1428, 573))
                {
                    Size = new Size(1428, 573);
                    Location = new Point(Location.X - 250, Location.Y);
                }

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
        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            editarCliente = false;

            if (Size != new Size(1428, 573))
            {
                Size = new Size(1428, 573);
                Location = new Point(Location.X - 250, Location.Y);
            }
            panelCliente.Enabled = true;

            labelCliente.Text = "Cliente Novo";

            textBoxNomeCliente.Focus();
            foreach (var control in panelCliente.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            RepositorioClientes repoCliente = new RepositorioClientes();

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
            if (Size != new Size(1428, 573))
            {
                Size = new Size(1428, 573);
                Location = new Point(Location.X - 250, Location.Y);
            }

            panelCliente.Enabled = true;
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

            listBoxClientes.DataSource = repoCliente.GetClientes(); //Atualizar Lista Clientes

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
            //Filho filho = (Filho)listBoxFilhos.SelectedItem;

            //Detalhes do Filho
            // Code...
        }

        private void buttonNovoFilho_Click(object sender, EventArgs e)
        {
            panelFilho.Enabled = true;
            editarFilho = false;
            textBoxNomeFilho.Focus();

            labelFilho.Text = "Filho Novo";
        }

        private void buttonEditarFilho_Click(object sender, EventArgs e)
        {
            if (Size != new Size(1428, 573))
            {
                Size = new Size(1428, 573);
                Location = new Point(Location.X - 250, Location.Y);
            }

            panelFilho.Enabled = true;
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

            //Escola escola = (Escola)comboBoxEscolas.SelectedItem;

            Escola escola = repoEscola.SearchById(filho.IdEscola);
            comboBoxEscolas.Text = escola.Nome;

        }

        private void buttonGuardarFilho_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            if (!editarFilho)
            {

                Filho filho = new Filho();
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
                Filho filho = (Filho)listBoxFilhos.SelectedItem;

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

            }

            //Lista Filhos
            refreshListas();
            listBoxFilhos.DataSource = cliente.Filhos.ToList();

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
    }
    #endregion
}
