using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace Bookids.Forms
{
    public partial class MostraDetalhesCompra : Form
    {
        RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();
        Compra compra;
        public MostraDetalhesCompra(Compra compra)
        {
            InitializeComponent();

            labelNome.Text = compra.Cliente.Nome;
            labelPrecoTotal.Text = $"{repositorioDetalhesCompras.GetDinheiroTotal(compra)} €";
            foreach (var item in compra.DetalhesCompras)
            {
                listBoxDetalhesCompras.Items.Add(item);
            }

            this.compra = compra;
        }

        private void listBoxDetalhesCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalheCompra detalheCompra = (DetalheCompra)listBoxDetalhesCompras.SelectedItem;

            if (detalheCompra != null)
            {
                labelPrecoDetalhe.Text = $"{detalheCompra.Produto.Preco * detalheCompra.Quantidade} €";
            }
        }

        private void buttonExportarVenda_Click(object sender, EventArgs e)
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

                            sw.WriteLine("Cliente:\t" + labelNome.Text + "\n-----------------------------\n");

                            foreach (var item in listBoxDetalhesCompras.Items)
                                sw.WriteLine(item);

                            sw.WriteLine("\n-----------------------------\nPreço Total:\t" + labelPrecoTotal.Text);

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

                            page.AddText("Cliente:" + labelNome.Text, 12, closeToTop, helveticaBold);
                            int lineSpaceCounter = 0;
                            foreach (var item in listBoxDetalhesCompras.Items)
                            {
                                lineSpaceCounter -= 25;
                                page.AddText(Convert.ToString(item), 10, closeToTop.Translate(0, lineSpaceCounter), helvetica);
                            }

                            string precototal = labelPrecoTotal.Text.Replace("€", string.Empty);
                            page.AddText("Preco Total: " + precototal + " Euros", 12, closeToTop.Translate(0, lineSpaceCounter - 25), helveticaBold);

                            string filePath = Path.Combine(saveFile.FileName, saveFile.FileName);
                            File.WriteAllBytes(filePath, builder.Build());
                        }
                    }
                    MessageBox.Show("Salvo com Sucesso");
                }
            }
        }
    }
}
