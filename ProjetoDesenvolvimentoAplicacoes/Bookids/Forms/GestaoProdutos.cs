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
        RepositorioProdutos repoProdutos = new RepositorioProdutos();
        RepositorioTipoProdutos repoTipos = new RepositorioTipoProdutos();

        bool editar = true; // Variavel para verificar se vai editar(true) ou criar(false) o produto

        /* Construtor */
        public GestaoProdutos()
        {
            InitializeComponent();            
        }

        /* Funções relacionadas com as gestão de produtos */
        #region GestaoProduto

        /* Desbloqueia e Limpa o painel para inserir os dados do novo produto */
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false; // Mete 'editar' a falso pois nao vai editar

            panelEditProdutos.Enabled = true; // Ativa o painel

            // Limpa o painel
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            textBoxStock.Clear();

            textBoxDesignacao.Focus(); // Coloca o cursor no painel
        }

        /* Desbloqueia o painel para permitir a edição do produto */
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar = true; // Mete 'editar' a verdadeiro pois vai editar

            panelEditProdutos.Enabled = true; // Ativa o painel

            textBoxDesignacao.Focus(); // Coloca o cursor no painel
        }

        /* Apaga o produto selecionado */
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listBoxProdutos.SelectedItem; // Guarda o produto selecionado

            if (produto != null) // Verifica se nao é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar!", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoProdutos.RemoveProduto(produto); // Remove o Tipo
                        MessageBox.Show("Eliminado com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Ocorreu um erro ao tentar eliminar! {err.Message}");
                    }
                    finally
                    {
                        refreshListas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um produto!");
            }
        }

        /* Limpa o painel de produtos e cancela a criação/edição */
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Limpa o painel
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            textBoxStock.Clear();

            panelEditProdutos.Enabled = false;
        }

        /* Guarda ou Edita o produto */
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            decimal preco = Decimal.Parse(textBoxPreco.Text); // Converte o preco para decimal
            int stock = Convert.ToInt32(textBoxStock.Text); // Converte o stock para inteiro
            TipoProduto tipoProduto = (TipoProduto)comboBoxTipoProduto.SelectedItem; // Guarda o objeto TipoProduto para ir buscar o seu id
            Produto produto = new Produto(textBoxDesignacao.Text, preco, tipoProduto.IdTipoProduto, stock); // Guarda a nova escola

            if (editar == true)
            {
                try
                {
                    Produto produtoEditado = (Produto)listBoxProdutos.SelectedItem; // 
                    repoProdutos.EditProduto(produtoEditado.IdProduto, produto); // 
                    MessageBox.Show("Editada com Sucesso.");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar editar o Produto! {err.Message}");
                }
                finally
                {
                    refreshListas();
                }
            }
            else
            {
                try
                {
                    repoProdutos.AddProduto(produto);
                    MessageBox.Show("Criada com Sucesso.");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar criar o Produto! {err.Message}");
                }
                finally
                {
                    refreshListas();
                }
            }            
        }

        /* Pesquisar os produtos por designação */
        private void textBoxPesquisaProdutos_TextChanged(object sender, EventArgs e)
        {
            listBoxProdutos.DataSource = repoProdutos.SearchByDesignacao(textBoxPesquisaProdutos.Text);
        }

        /* Bloqueia os paineis e apresenta a informação no painel */
        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = (Produto)listBoxProdutos.SelectedItem; // Guarda o produto selecionada

            // Apresenta os dados do produto
            textBoxDesignacao.Text = produto.Designacao;
            textBoxPreco.Text = produto.Preco.ToString();
            comboBoxTipoProduto.SelectedItem = repoTipos.SearchById(produto.IdTipoProduto);
            textBoxStock.Text = produto.StockExistente.ToString();
        }

        #endregion

        /* Funções relacionadas com as gestão dos tipos de produtos */
        #region GestaoTipos

        /* Desbloqueia o painel para criar/apagar os Tipos */
        private void btnAddTipos_Click(object sender, EventArgs e)
        {
            panelEditTipos.Enabled = true; // Desbloqueia o painel

            textBoxNomeTipo.Focus(); // Coloca o cursor no painel
        }

        /* Guarda o Tipo de Produto na base de dados */
        private void buttonSalvarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto tipoProduto = new TipoProduto(textBoxNomeTipo.Text); // Cria o objeto TipoProduto
                repoTipos.AddTipo(tipoProduto); // Cria o tipo
                MessageBox.Show("Criado com Sucesso.");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar eliminar! {err.Message}");
            }
            finally
            {
                refreshListas();
            }
        }

        /* Apaga o tipo selecionado da base de dados */
        private void buttonApagarTipo_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = (TipoProduto)listBoxTipos.SelectedItem; // Guarda o tipo de produto selecionado

            if (tipoProduto != null) // Verifica se o tipo nao é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar!", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    if (tipoProduto.Produtos.Count == 0) // Verifica se o tipo não está associado a nenhum produto
                    {
                        try
                        {
                            repoTipos.RemoveTipo(tipoProduto); // Remove o Tipo
                            MessageBox.Show("Eliminado com Sucesso.");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"Ocorreu um erro ao tentar eliminar! {err.Message}");
                        }
                        finally
                        {
                            refreshListas();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Já existe(m) {tipoProduto.Produtos.Count} Produto(s) com este Tipo, não pode eliminar.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um tipo!");
            }
        }

        #endregion               

        /* Funções relacionadas com a validação do texto inserido em alguns campos */
        #region TextBoxValidation

        /* Apenas permitir inserir numeros no campo do stock */
        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* Apenas permitir inserir numeros no campo do preco */
        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            var separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != separator[0]))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == separator[0]) && ((sender as TextBox).Text.IndexOf(separator[0]) > -1))
            {
                e.Handled = true;
            }
        }

        #endregion

        /* Funções Gerais */
        #region MiscEvents

        /* Carrega as listas quando a janela é aberta */
        private void GestaoProdutos_Load(object sender, EventArgs e)
        {
            refreshListas();
        }

        /* Atualiza a lista */
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshListas();
        }

        /* Fecha a janela e volta ao Menu Inicial */
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Atualizar as listas */
        private void refreshListas()
        {
            RepositorioProdutos repoProdutos = new RepositorioProdutos();
            RepositorioTipoProdutos repoTipos = new RepositorioTipoProdutos();

            listBoxProdutos.DataSource = repoProdutos.GetProdutos(); // Carrega os Produtos
            listBoxTipos.DataSource = repoTipos.GetTipos(); // Carrega os Tipos de Produtos
            comboBoxTipoProduto.DataSource = repoTipos.GetTipos(); // Carrega os Tipos de Produtos na ComboBox
        }

        /* Desbloqueia e permite criar/eliminar tipos de produtos */
        private void editarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEditTipos.Enabled = true; // Desbloqueia o painel

            textBoxNomeTipo.Focus(); // Coloca o cursor no painel
        }

        /* Desbloqueia e Limpa o painel para permitir a criação de um novo produto */
        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editar = false; // Mete 'editar' a falso pois nao vai editar

            panelEditProdutos.Enabled = true; // Ativa o painel

            // Limpa o painel
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            textBoxStock.Clear();

            textBoxDesignacao.Focus(); // Coloca o cursor no painel
        }

        private void GestaoProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoProdutos.Dispose();
        }

        #endregion

    }
}
