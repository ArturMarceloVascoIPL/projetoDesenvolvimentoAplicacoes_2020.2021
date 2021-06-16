using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bookids.Forms
{
    public partial class ExportarFile : Form
    {
        bool fichaInsc = false;
        bool listaInsc = false;
        bool faturaVenda = false;

        Evento evento;
        List<Pessoa> listaParticipantes;

        public ExportarFile()
        {

        }

        public ExportarFile(Evento evento)
        {
            fichaInsc = true;
            listaInsc = false;
            faturaVenda = false;

            this.evento = evento;

            InitializeComponent();
        }

        public ExportarFile(List<Pessoa> listaParticipantes)
        {
            fichaInsc = false;
            listaInsc = true;
            faturaVenda = false;

            this.listaParticipantes = listaParticipantes;

            InitializeComponent();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region ButtonMisc

        private void buttonPdf_MouseEnter(object sender, EventArgs e)
        {
            buttonPdf.Font = new Font(buttonPdf.Font, FontStyle.Bold);
            buttonPdf.ForeColor = Color.Green;
        }

        private void buttonPdf_MouseLeave(object sender, EventArgs e)
        {
            buttonPdf.Font = new Font(buttonPdf.Font, FontStyle.Regular);
            buttonPdf.ForeColor = Color.Black;
        }

        private void buttonTxt_MouseEnter(object sender, EventArgs e)
        {
            buttonTxt.Font = new Font(buttonTxt.Font, FontStyle.Bold);
            buttonTxt.ForeColor = Color.Green;
        }

        private void buttonTxt_MouseLeave(object sender, EventArgs e)
        {
            buttonTxt.Font = new Font(buttonTxt.Font, FontStyle.Regular);
            buttonTxt.ForeColor = Color.Black;
        }

        #endregion

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.Filter = "Text Files | *.txt";
            saveFileDialogExport.DefaultExt = "txt";

            saveFileDialogExport.ShowDialog();
            string filePath = saveFileDialogExport.FileName;

            if (fichaInsc == true)
            {
                try
                {
                    string[] fileContent = new string[] { "Ficha de Incrição\n", $"Evento: {evento.Descricao}", $"Local: {evento.Local}", $"Tipo de Evento: {evento.TipoEvento}", "\nNome do Parente: __________\nNome do Filho: __________\n\nParticipa?\nSim __ Nao __" };

                    using (StreamWriter outputfile = new StreamWriter(filePath))
                    {
                        foreach (var fileLine in fileContent)
                        {
                            outputfile.WriteLine(fileLine);
                        }
                    }

                    MessageBox.Show($"Guardado com Sucesso em\n{filePath}", "Ficheiro Guardado");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ocorreu um erro ao guardar o ficheiro!\n{err.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (listaInsc == true)
                {
                    try
                    {
                        using (StreamWriter outputfile = new StreamWriter(filePath))
                        {
                            outputfile.WriteLine("Lista de Participantes:\n");

                            foreach (var item in listaParticipantes)
                            {
                                outputfile.WriteLine(item);
                            }
                        }

                        MessageBox.Show($"Guardado com Sucesso em\n{filePath}", "Ficheiro Guardado");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Ocorreu um erro ao guardar o ficheiro!\n{err.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (faturaVenda == true)
                    {

                    }
                    else
                    {
                        // Debug
                        MessageBox.Show("Erro. Todos os bools a 'false'");
                    }
                }
            }
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
