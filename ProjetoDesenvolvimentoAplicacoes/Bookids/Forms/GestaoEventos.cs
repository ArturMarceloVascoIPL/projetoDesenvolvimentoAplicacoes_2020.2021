using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace Bookids.Forms
{
    public partial class GestaoEventos : Form
    {
        RepositorioAnimadores repoAnimadores = new RepositorioAnimadores();
        RepositorioColaboracao repoColaboracao = new RepositorioColaboracao();
        RepositorioEscolas repoEscolas = new RepositorioEscolas();
        RepositorioEventos repoEventos = new RepositorioEventos();
        RepositorioInscricoes repoInscricoes = new RepositorioInscricoes();
        RepositorioParticipacao repoParticipacao = new RepositorioParticipacao();

        bool editar = false;

        public GestaoEventos()
        {
            InitializeComponent();
        }

        private void GestaoEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            repoAnimadores.Dispose();
            repoColaboracao.Dispose();
            repoEscolas.Dispose();
            repoEventos.Dispose();
            repoInscricoes.Dispose();
            repoParticipacao.Dispose();
        }

        private void btnExportFichaInsc_Click(object sender, EventArgs e)
        {
            using (var form = new ExportarFile())
            {
                Evento fichaInscricao = (Evento)listBoxEventos.SelectedItem;

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

                            sw.WriteLine("EVENTO");
                            sw.WriteLine("\n------------------\n\n");

                            sw.WriteLine("Descricao: " + Convert.ToString(fichaInscricao.Descricao));
                            sw.WriteLine("\nLocal: " + Convert.ToString(fichaInscricao.Local));
                            sw.WriteLine("\nTipo de Evento: " + Convert.ToString(fichaInscricao.TipoEvento));
                            sw.WriteLine("\nLimite de Participantes: " + Convert.ToString(fichaInscricao.LimiteParticipacao));
                            sw.WriteLine("\nIdade Mínima: " + Convert.ToString(fichaInscricao.IdadeInferiror + " | Idade Máxima: " + Convert.ToString(fichaInscricao.IdadeInferiror)));
                            sw.WriteLine("\nData e Hora: " + Convert.ToString(fichaInscricao.DataHora));

                            sw.WriteLine("\n\n------------------");

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

                            page.AddText("EVENTO: " + Convert.ToString(fichaInscricao.Descricao), 12, closeToTop, helveticaBold);

                            page.AddText("Local: " + Convert.ToString(fichaInscricao.Local), 10, closeToTop.Translate(0, -25), helvetica);

                            page.AddText("Tipo de Evento: " + Convert.ToString(fichaInscricao.TipoEvento), 10, closeToTop.Translate(0, -50), helvetica);

                            page.AddText("Limite de Participantes: " + Convert.ToString(fichaInscricao.LimiteParticipacao), 10, closeToTop.Translate(0, -75), helvetica);

                            page.AddText("Idade Minima: " + Convert.ToString(fichaInscricao.IdadeInferiror + " | Idade Maxima: " + Convert.ToString(fichaInscricao.IdadeInferiror)), 10, closeToTop.Translate(0, -100), helveticaBold);

                            page.AddText("Data e Hora: " + Convert.ToString(fichaInscricao.DataHora), 10, closeToTop.Translate(0, -125), helvetica);

                            string filePath = Path.Combine(saveFile.FileName, saveFile.FileName);
                            File.WriteAllBytes(filePath, builder.Build());
                        }
                    }
                    MessageBox.Show("Salvo com Sucesso");
                }
            }
        }

        private void btnExportInscritos_Click(object sender, EventArgs e)
        {
            using (var form = new ExportarFile())
            {
                Evento exportInscritos = (Evento)listBoxEventos.SelectedItem;

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

                            sw.WriteLine("Lista de Participantes\nEVENTO: " + Convert.ToString(exportInscritos.Descricao));
                            sw.WriteLine("\n------------------\n\n");

                            int c = 0;
                            foreach (var item in listBoxParticipantes.Items)
                            {
                                c++;
                                sw.WriteLine("\t Participante {0} {1}\n", c, item);
                            }

                            sw.WriteLine("\nData e Hora: " + Convert.ToString(exportInscritos.DataHora));
                            sw.WriteLine("\n\n------------------");

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

                            page.AddText("Lista de Participantes | EVENTO: " + Convert.ToString(exportInscritos.Descricao), 12, closeToTop, helveticaBold);

                            int pageLiner = 0;
                            foreach (var item in listBoxParticipantes.Items)
                            {
                                pageLiner += 25;
                                page.AddText("   Participante: " + item, 10, closeToTop.Translate(0, -pageLiner), helvetica);
                            }
                            page.AddText("Data e Hora: " + Convert.ToString(exportInscritos.DataHora), 10, closeToTop.Translate(0, -125), helvetica);

                            string filePath = Path.Combine(saveFile.FileName, saveFile.FileName);
                            File.WriteAllBytes(filePath, builder.Build());
                        }
                    }
                    MessageBox.Show("Salvo com Sucesso");
                }
            }

        }

        #region GestaoEventos

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            editar = false;

            labelEvento.Text = "Novo Evento";
            buttonGuardarEvento.Text = "Criar";

            panelEvento.Enabled = true;

            textBoxDescricao.Clear();
            textBoxLocal.Clear();
            textBoxTipoEvento.Clear();
            textBoxMaxParticipantes.Clear();
            textBoxIdadeMin.Clear();
            textBoxIdadeMax.Clear();
            dateTimePickerData.Value = DateTime.Now;

            textBoxDescricao.Focus();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar = true;

            labelEvento.Text = "Editar Evento";
            buttonGuardarEvento.Text = "Guardar";

            panelEvento.Enabled = true;
            panelAnimadores.Enabled = true;
            panelEscolas.Enabled = true;

            textBoxDescricao.Focus();
        }

        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;

            listBoxAnimadores.DataSource = repoEventos.GetColaboradoresEvento(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolasEvento(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);

            textBoxDescricao.Text = evento.Descricao;
            textBoxLocal.Text = evento.Local;
            textBoxTipoEvento.Text = evento.TipoEvento;
            textBoxMaxParticipantes.Text = evento.LimiteParticipacao.ToString();
            textBoxIdadeMin.Text = evento.IdadeInferiror.ToString();
            textBoxIdadeMax.Text = evento.IdadeSuperior.ToString();
            dateTimePickerData.Value = evento.DataHora;

            buttonExportFichaInsc.Enabled = true;
            buttonExportInscritos.Enabled = true;
        }

        /* Edita ou Cria o Evento */
        private void buttonGuardarEvento_Click(object sender, EventArgs e)
        {
            // Verificar que a data é superior á data atual
            if (dateTimePickerData.Value > DateTime.Now)
            {
                // Verificar se tem todos os campos preenchidos 
                if (!String.IsNullOrWhiteSpace(textBoxMaxParticipantes.Text) && !String.IsNullOrWhiteSpace(textBoxIdadeMin.Text)
                    && !String.IsNullOrWhiteSpace(textBoxIdadeMax.Text) && !String.IsNullOrWhiteSpace(textBoxDescricao.Text)
                    && !String.IsNullOrWhiteSpace(textBoxLocal.Text) && !String.IsNullOrWhiteSpace(textBoxTipoEvento.Text))
                {
                    // Convert os valores das TextBox
                    int maxParticipantes = Convert.ToInt32(textBoxMaxParticipantes.Text);
                    int idadeMin = Convert.ToInt32(textBoxIdadeMin.Text);
                    int idadeMax = Convert.ToInt32(textBoxIdadeMax.Text);

                    Evento evento = new Evento(textBoxDescricao.Text, textBoxLocal.Text, textBoxTipoEvento.Text, maxParticipantes, idadeMin, idadeMax, dateTimePickerData.Value); // Guarda o novo Evento

                    if (editar == true)
                    {
                        try
                        {
                            Evento eventoEditado = (Evento)listBoxEventos.SelectedItem; // Guarda o Evento selecionado

                            repoEventos.EditEvento(eventoEditado.IdEvento, evento); // Edita o Evento
                            MessageBox.Show("Editado com Sucesso.");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"Ocorreu um erro ao tentar editar!\n{err.Message}");
                        }
                    }
                    else
                    {
                        try
                        {
                            repoEventos.AddEvento(evento); // Cria o Evento                
                            MessageBox.Show("Criado com Sucesso.");

                            panelAnimadores.Enabled = true;
                            panelEscolas.Enabled = true;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"Ocorreu um erro ao tentar criar!\n{err.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tem campos inválidos ou não preenchidos!");
                }
            }
            else
            {
                MessageBox.Show("A data inserida já passou!");
            }

            refreshListas();
        }

        private void buttonApagarEvento_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem; // Guarda o evento selecionado

            if (evento != null) // Verifica se não é null
            {
                if (MessageBox.Show("Quer mesmo apagar?", "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirmacao para apagar
                {
                    try
                    {
                        repoEventos.RemoveEvento(evento); // Remove
                        MessageBox.Show("Removido com Sucesso.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Ocorreu um erro ao tentar remover!\n{err.Message}");
                    }
                }

                refreshListas();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um Evento!");
            }
        }

        #endregion

        /* Animadores do Evento */
        #region GestaoColaboracao

        private void buttonAdicionarAnimador_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Animador animador = (Animador)comboBoxAnimadores.SelectedItem;

            if (animador != null || evento != null)
            {
                Colaboracao colaboracao = new Colaboracao(animador.IdPessoa, evento.IdEvento);
                repoColaboracao.AddColaboracao(colaboracao);
            }

            listBoxAnimadores.DataSource = repoEventos.GetColaboradoresEvento(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolasEvento(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);

            refreshListas();
        }

        private void buttonRemoverAnimador_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Animador animador = (Animador)listBoxAnimadores.SelectedItem;

            if (animador != null || evento != null)
            {
                Colaboracao colaboracao = new Colaboracao(animador.IdPessoa, evento.IdEvento);
                repoColaboracao.RemoveColaboracao(colaboracao);
            }

            listBoxAnimadores.DataSource = repoEventos.GetColaboradoresEvento(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolasEvento(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);
            refreshListas();
        }

        #endregion

        /* Escolas e Filhos do Evento */
        #region GestaoParticipacao
        private void buttonAdicionarEscola_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Escola escola = (Escola)comboBoxEscolas.SelectedItem;

            if (escola != null || evento != null)
            {
                Participacao participacao = new Participacao(escola.IdEscola, evento.IdEvento);
                repoParticipacao.AddParticipacao(participacao);

                foreach (Filho filho in escola.Filhos)
                {
                    Inscricao inscricao = new Inscricao(filho.IdPessoa, evento.IdEvento);

                    repoInscricoes.AddIncricao(inscricao);
                }
            }

            listBoxAnimadores.DataSource = repoEventos.GetColaboradoresEvento(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolasEvento(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);

            refreshListas();
        }

        private void buttonRemoverEscola_Click(object sender, EventArgs e)
        {
            Evento evento = (Evento)listBoxEventos.SelectedItem;
            Escola escola = (Escola)listBoxEscolas.SelectedItem;

            if (escola != null || evento != null)
            {
                Participacao participacao = new Participacao(escola.IdEscola, evento.IdEvento);
                repoParticipacao.RemoveParticipacao(participacao);

                foreach (Filho filho in escola.Filhos)
                {
                    Inscricao inscricao = new Inscricao(filho.IdPessoa, evento.IdEvento);

                    repoInscricoes.RemoveIncricao(inscricao);
                }
            }

            listBoxAnimadores.DataSource = repoEventos.GetColaboradoresEvento(evento.IdEvento);
            listBoxEscolas.DataSource = repoEventos.GetEscolasEvento(evento.IdEvento);
            listBoxParticipantes.DataSource = repoEventos.GetParticipantes(evento.IdEvento);

            refreshListas();
        }

        #endregion

        #region TextBoxValidation

        private void textBoxMaxParticipantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdadeMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdadeMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region MiscFuncoes

        void refreshListas()
        {
            RepositorioEventos repoEventos = new RepositorioEventos();
            RepositorioAnimadores repoAnimadores = new RepositorioAnimadores();
            RepositorioEscolas repoEscolas = new RepositorioEscolas();

            listBoxEventos.DataSource = repoEventos.GetEventos();
            comboBoxAnimadores.DataSource = repoAnimadores.GetAnimadores();
            comboBoxEscolas.DataSource = repoEscolas.GetEscolas();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshListas();
        }

        private void GestaoEventos_Load(object sender, EventArgs e)
        {
            refreshListas();
        }

        #endregion

        #region MenuStrip

        //MenuStrip
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Compras
        private void verCompraRecenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioClientes repoClientes = new RepositorioClientes();
            RepositorioCompras repoCompras = new RepositorioCompras();
            RepositorioDetalhesCompras repositorioDetalhesCompras = new RepositorioDetalhesCompras();

            MessageBox.Show("trolling");
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