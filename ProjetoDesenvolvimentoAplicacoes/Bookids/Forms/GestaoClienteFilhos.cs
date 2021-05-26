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
        bool editarCliente;

        public GestaoClienteFilhos()
        {
            InitializeComponent();

            Size = new Size(886, 573);
        }

        private void GestaoClienteFilhos_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = repoCliente.GetClientes();
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

        #endregion

        #region Gestao Clientes
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditarCliente.Enabled = true;
            buttonApagarCliente.Enabled = true;
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
                    foreach (Control c in panelCliente.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (textBox.Text != string.Empty)
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
                                    cliente.ValorOferta = 0;
                                    cliente.NumCartao = 0;
                                }

                                repoCliente.AddCliente(cliente);

                                //Apagar campos do Form
                                foreach (var control in panelCliente.Controls)
                                {
                                    if (control is TextBox)
                                        (control as TextBox).Clear();
                                }
                            }
                        }
                    }
                    MessageBox.Show("Salvo com Sucesso.");
                }
            }

            //Editar Cliente
            else
            {
                if (MessageBox.Show("Guardar Cliente Editado?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

                    cliente.Nome = textBoxNomeCliente.Text;
                    cliente.Morada = textBoxMorada.Text;
                    cliente.Localidade = textBoxLocalidade.Text;
                    cliente.CodPostal = textBoxCodPostal.Text;
                    cliente.Email = textBoxEmail.Text;
                    cliente.Telemovel = int.Parse(textBoxTelemovel.Text);
                    cliente.Telefone = int.Parse(textBoxTelefone.Text);

                    repoCliente.EditCliente(cliente.IdPessoa, cliente);
                    MessageBox.Show("Editada com Sucesso.");
                }
            }
            listBoxClientes.DataSource = repoCliente.GetClientes(); //Atualizar Lista Clientes
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
                    if (repoCliente.RemoveCliente(cliente)) // Remove o cliente
                        MessageBox.Show("Removida com Sucesso.");
                    else
                        MessageBox.Show("Ocorreu um erro ao tentar remover!");
                }
            }
            else
                MessageBox.Show("Tem de selecionar um cliente!");

            listBoxClientes.DataSource = repoCliente.GetClientes(); //Atualizar Lista Clientes
        }

        #endregion

    }
}
