using Bookids.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace Bookids
{
    public partial class FormNovaCompra : Form
    {
        RepositorioProdutos repoProdutos = new RepositorioProdutos();
        RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();
        RepositorioCompras repositorioCompras = new RepositorioCompras();
        Model1Container model = new Model1Container();

        int idCliente = 0;
        bool card;


        public FormNovaCompra(Cliente cliente)
        {
            InitializeComponent();
            timer1.Start();
            panelCardNo.BackColor = Color.Red;
            if (cliente.NumCartao == null)
                panel6.Enabled = false;

            panelCardYes.BackColor = Color.White;
            idCliente = cliente.IdPessoa;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult salvarDialog = MessageBox.Show("Deseja Guardar?", "Exportar", MessageBoxButtons.YesNo);
            if (salvarDialog == DialogResult.Yes)
            {

                string data = DateTime.Today.ToString("dd/MM/yyyy");
                bool utilizouCartao;
                if (panelCardYes.BackColor == Color.Green && panel6.Enabled == true)
                {
                    utilizouCartao = true;
                }
                else
                {
                    utilizouCartao = false;
                }
                Compra compra = new Compra(data, utilizouCartao, idCliente);
                repositorioCompras.AddCompras(compra);


                foreach (Carrinho itensCarrinho in listaCarrinho.Items)
                {
                    DetalheCompra detalheCompra = new DetalheCompra(compra.IdCompra, itensCarrinho.IdProduto, itensCarrinho.Quantidade);
                    repositorioDetalhesCompras.AddDetalheCompra(detalheCompra);
                }

                foreach (Produto itensProduto in listaProdutos.Items)
                {
                    repoProdutos.EditProduto(itensProduto.IdProduto, itensProduto);
                }

                MessageBox.Show("Inserido com sucesso");


                //exportar ficheiro apos guardar compra
                DialogResult exportarDialog = MessageBox.Show("Deseja Exportar?", "Exportar", MessageBoxButtons.YesNo);
                if (exportarDialog == DialogResult.Yes)
                {
                    using (var form = new ExportarFile())
                    {
                        string val;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            val = form.option;

                            if (val == "TXT")
                            {
                                SaveFileDialog saveFile = new SaveFileDialog();
                                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                saveFile.RestoreDirectory = true;
                                saveFile.Title = "Selecionar localização e nome para o ficheiro";
                                saveFile.Filter = "Ficheiro TXT(*.txt)|*.txt  ";

                                if (saveFile.ShowDialog() == DialogResult.OK)
                                {
                                    string filePath = Path.Combine(saveFile.FileName, saveFile.FileName);

                                    FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                                    // Criar o buffer de texto de escrita
                                    StreamWriter sw = new StreamWriter(fs);
                                    // Guardar os dados no ficheio com string delimitados por ;

                                    sw.WriteLine("Cliente:\t" + compra.Cliente + "\n-----------------------------\n");

                                    foreach (var item in listaCarrinho.Items)
                                        sw.WriteLine(item);

                                    sw.WriteLine("\n-----------------------------\nPreço Total:\t" + labelPrecoTotalCompra.Text);

                                    // Fechar o ficheiro e o stream
                                    sw.Close();
                                    fs.Close();
                                }
                            }
                            else if (val == "PDF")
                            {
                                SaveFileDialog saveFile = new SaveFileDialog();
                                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                saveFile.RestoreDirectory = true;
                                saveFile.Title = "Selecionar localização e nome para o ficheiro";
                                saveFile.Filter = "Ficheiro PDF(*.pdf)|*.pdf";
                                if (saveFile.ShowDialog() == DialogResult.OK)
                                {
                                    PdfDocumentBuilder builder = new PdfDocumentBuilder();

                                    PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);
                                    PdfDocumentBuilder.AddedFont helveticaBold = builder.AddStandard14Font(Standard14Font.HelveticaBold);

                                    PdfPageBuilder page = builder.AddPage(PageSize.A4);

                                    PdfPoint closeToTop = new PdfPoint(15, page.PageSize.Top - 25);

                                    page.AddText("Cliente: <error>", 12, closeToTop, helveticaBold);
                                    int lineSpaceCounter = 0;
                                    foreach (var item in listaProdutos.Items)
                                    {
                                        lineSpaceCounter -= 25;
                                        page.AddText(Convert.ToString(item), 10, closeToTop.Translate(0, lineSpaceCounter), helvetica);
                                    }

                                    string precototal = labelPrecoTotalCompra.Text.Replace("€", string.Empty);
                                    page.AddText("Preco Total: " + precototal + " Euros", 12, closeToTop.Translate(0, lineSpaceCounter - 25), helveticaBold);

                                    string filePath = Path.Combine(saveFile.FileName, saveFile.FileName);
                                    File.WriteAllBytes(filePath, builder.Build());
                                }
                            }
                            MessageBox.Show("Salvo com Sucesso");
                        }
                    }
                }
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            labelData.Text = DateTime.Now.ToString("d");
        }

        private void panelCardYes_Click(object sender, EventArgs e)
        {
            card = true;
            panelCardYes.BackColor = Color.Green;
            panelCardNo.BackColor = Color.White;
        }

        private void panelCardNo_Click(object sender, EventArgs e)
        {
            card = false;
            panelCardNo.BackColor = Color.Red;
            panelCardYes.BackColor = Color.White;
        }

        private void FormNovaCompra_Load(object sender, EventArgs e)
        {
            RefreshProdutos();

        }

        public void RefreshProdutos()
        {
            int index = listaProdutos.SelectedIndex;
            listaProdutos.Items.Clear();
            foreach (var produto in repoProdutos.GetProdutos())
            {
                listaProdutos.Items.Add(produto);
            }
            listaProdutos.SelectedIndex = index;
        }

        Carrinho GetProdutoListaCarrinho(int id)
        {
            Produto produto = (Produto)listaProdutos.SelectedItem;

            List<Carrinho> listacarrinho = new List<Carrinho>();

            listacarrinho = listaCarrinho.Items.Cast<Carrinho>().ToList();

            foreach (var itemCarrinho in listacarrinho)
            {
                if (itemCarrinho.IdProduto == id)
                {
                    return itemCarrinho;
                }
            }
            return null;
        }

        Produto GetListaCarrinhoProduto(int id)
        {
            Produto produto = (Produto)listaProdutos.SelectedItem;

            List<Produto> listaProdutoItems = new List<Produto>();

            listaProdutoItems = listaProdutos.Items.Cast<Produto>().ToList();

            foreach (var itemProduto in listaProdutoItems)
            {
                if (itemProduto.IdProduto == id)
                {
                    return itemProduto;
                }
            }
            return null;
        }

        public void RefreshCarrinho<T>(List<Carrinho> listCarrinho, int index)
        {
            listaCarrinho.Items.Clear();
            foreach (var itemCarrinho in listCarrinho)
            {
                listaCarrinho.Items.Add(itemCarrinho);
            }
            if (index != -1)
            {
                listaCarrinho.SelectedIndex = index;
            }
        }

        public void calcularTotal<T>(List<Carrinho> listCarrinho)
        {
            decimal total = 0;
            foreach (var itemCarrinho in listCarrinho)
            {
                total = total + itemCarrinho.Preco * itemCarrinho.Quantidade;
            }
            labelPrecoTotalCompra.Text = $"{total}€";

        }

        List<Carrinho> listCarrinho = new List<Carrinho>();
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listaProdutos.SelectedItem;

            if (listaProdutos.SelectedItems.Count != 0)
            {
                Carrinho carrinho = GetProdutoListaCarrinho(produto.IdProduto);

                if (carrinho != null)
                {
                    if (produto.StockExistente != 0)
                    {
                        carrinho.Quantidade++;
                        produto.StockExistente--;
                        RefreshProdutos();
                        RefreshCarrinho<Carrinho>(listCarrinho, -1);
                        calcularTotal<Carrinho>(listCarrinho);
                    }
                    else
                    {
                        MessageBox.Show("Insira mais na página de produtos", "Não há mais stock para inserir", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (produto.StockExistente != 0)
                    {
                        carrinho = new Carrinho(produto.IdProduto, produto.Designacao, produto.Preco, produto.IdTipoProduto, 1);
                        listCarrinho.Add(carrinho);
                        produto.StockExistente--;
                        Model1Container model = new Model1Container();
                        RefreshProdutos();
                        RefreshCarrinho<Carrinho>(listCarrinho, -1);
                        calcularTotal<Carrinho>(listCarrinho);
                    }
                    else
                    {
                        MessageBox.Show("Não há mais stock para inserir", "Insira mais na página de produtos", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = (Carrinho)listaCarrinho.SelectedItem;
            int index = listaCarrinho.SelectedIndex;
            if (listaCarrinho.SelectedItems.Count != 0)
            {
                Produto produto = GetListaCarrinhoProduto(carrinho.IdProduto);

                if (produto != null)
                {
                    if (carrinho.Quantidade != 0)
                    {
                        carrinho.Quantidade--;
                        produto.StockExistente++;
                        if (carrinho.Quantidade == 0)
                        {
                            listCarrinho.Remove(carrinho);
                            index = -1;
                        }
                        RefreshProdutos();
                        RefreshCarrinho<Carrinho>(listCarrinho, index);
                        calcularTotal<Carrinho>(listCarrinho);

                    }
                    else
                    {
                        MessageBox.Show("Insira mais na página de produtos", "Não há mais stock para inserir", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void textBoxSearchClientes_TextChanged(object sender, EventArgs e)
        {
            listaProdutos.Items.Clear();
            foreach (var itemProdutos in repoProdutos.SearchByDesignacao(listaProdutos.Text))
            {
                listaProdutos.Items.Add(itemProdutos);
            }
        }

        private void buttonProdutosAtalho_Click(object sender, EventArgs e)
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

        // Cria um gradiente como fundo do Form
        private void FormNovaCompra_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.WhiteSmoke, Color.FromArgb(43, 177, 222), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
