using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids.Forms
{
    public partial class GestaoProdutos : Form
    {
        RepositorioProdutos RepoProdutos = new RepositorioProdutos();
        RepositorioTipoProdutos RepoTipos = new RepositorioTipoProdutos();

        bool editar = true; // Variavel para verificar se vai editar(true) ou criar(false) o produto

        public GestaoProdutos()
        {
            InitializeComponent();
        }

        private void GestaoProdutos_Load(object sender, EventArgs e)
        {
            refreshListas();

            toolTipPesquisa.SetToolTip(buttonPesquisarProdutos, "Case Sensitive");
            toolTipRefresh.SetToolTip(buttonRefresh, "Atualizar Lista");
        }

        /* Desbloqueia e Limpa o painel para inserir os dados do novo produto */
        private void buttonNovoProduto_Click(object sender, EventArgs e)
        {
            editar = false; // Mete 'editar' a falso pois nao vai editar

            panelEditProdutos.Enabled = true; // Ativa o painel

            // Limpa o painel
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            textBoxStock.Clear();

            textBoxDesignacao.Focus(); // Coloca o cursor no painel

            refreshListas();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar = true; // Mete 'editar' a verdadeiro pois vai editar

            panelEditProdutos.Enabled = true; // Ativa o painel

            textBoxDesignacao.Focus(); // Coloca o cursor no painel

            refreshListas();
        }

        private void btnAddTipos_Click(object sender, EventArgs e)
        {
            panelEditTipos.Enabled = true;

            textBoxNomeTipo.Focus();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEditProdutos.Enabled = false; // Bloqueia o painel
            panelEditTipos.Enabled = false; // Bloqueia o painel

            Produto produto = (Produto)listBoxProdutos.SelectedItem; // Guarda o produto selecionada

            // Apresenta os dados do produto
            textBoxDesignacao.Text = produto.Designacao;
            textBoxPreco.Text = produto.Preco.ToString();
            comboBoxTipoProduto.SelectedItem = produto.TipoProduto;
            textBoxStock.Text = produto.StockExistente.ToString();
        }

        /* Pesquisar os produtos por designação */
        private void buttonPesquisarProdutos_Click(object sender, EventArgs e)
        {
            listBoxProdutos.DataSource = RepoProdutos.SearchByDesignacao(textBoxPesquisaProdutos.Text);
        }

        /* Atualizar lista ou Limpar a pesquisa */
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshListas();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            /* EXCEPTION NA CONVERÇÃO PARA DECIMAL */
            decimal preco = Decimal.Parse(textBoxPreco.Text); // Converte o preco para decimal
            int stock = Convert.ToInt32(textBoxStock.Text); // Converte o stock para inteiro
            TipoProduto tipoProduto = (TipoProduto)comboBoxTipoProduto.SelectedItem;
            Produto produto = new Produto(textBoxDesignacao.Text, preco, tipoProduto, stock); // Guarda a nova escola

            if (editar == true)
            {
                Produto produtoEditado = (Produto)listBoxProdutos.SelectedItem; // Guarda a escola selecionada

                RepoProdutos.EditProduto(produtoEditado.IdProduto, produto); // Edita a escola
                MessageBox.Show("Editada com Sucesso.");
            }
            else
            {                
                if (RepoProdutos.AddProduto(produto)) // Cria a escola
                {
                    MessageBox.Show("Criada com Sucesso.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar criar o Produto!");
                }
            }

            refreshListas();
        }

        /* Apenas permitir inserir numeros no campo do stock */
        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /* Apenas permitir inserir numeros no campo do preco */
        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Limpa o painel
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            textBoxStock.Clear();

            panelEditProdutos.Enabled = false;
        }

        private void buttonCancelarTipo_Click(object sender, EventArgs e)
        {
            textBoxDesignacao.Focus();

            textBoxNomeTipo.Clear();

            panelEditTipos.Enabled = false;
        }

        /* Atualizar as listas */
        private void refreshListas()
        {
            listBoxProdutos.DataSource = RepoProdutos.GetProdutos();
            listBoxTipos.DataSource = RepoTipos.GetTipos();
            comboBoxTipoProduto.DataSource = RepoTipos.GetTipos();
        }

        private void buttonSalvarTipo_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = new TipoProduto(textBoxNomeTipo.Text);

            if (RepoTipos.AddTipo(tipoProduto)) // Cria a escola
            {
                MessageBox.Show("Criada com Sucesso.");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao tentar criar a escola!");
            }

            refreshListas();
        }

        private void buttonApagarTipo_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = (TipoProduto)listBoxTipos.SelectedItem; // Guarda a escola selecionada

            if (tipoProduto != null) // Verifica se a escola nao e' null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    if (RepoTipos.RemoveTipo(tipoProduto)) // Remove a escola
                    {
                        MessageBox.Show("Removida com Sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar remover!");
                    }

                    refreshListas();
                }                
            }
            else
            {
                MessageBox.Show("Tem de selecionar um tipo!");
            }
        }
    }
}
