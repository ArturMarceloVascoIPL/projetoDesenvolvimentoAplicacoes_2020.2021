
namespace Bookids.Forms
{
    partial class MostraDetalhesCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxDetalhesCompras = new System.Windows.Forms.ListBox();
            this.panelImagemCliente = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPrecoDetalhe = new System.Windows.Forms.Label();
            this.labelPrecoTotal = new System.Windows.Forms.Label();
            this.buttonExportarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDetalhesCompras
            // 
            this.listBoxDetalhesCompras.FormattingEnabled = true;
            this.listBoxDetalhesCompras.ItemHeight = 16;
            this.listBoxDetalhesCompras.Location = new System.Drawing.Point(16, 79);
            this.listBoxDetalhesCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDetalhesCompras.Name = "listBoxDetalhesCompras";
            this.listBoxDetalhesCompras.Size = new System.Drawing.Size(361, 388);
            this.listBoxDetalhesCompras.TabIndex = 0;
            this.listBoxDetalhesCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxDetalhesCompras_SelectedIndexChanged);
            // 
            // panelImagemCliente
            // 
            this.panelImagemCliente.BackgroundImage = global::Bookids.Properties.Resources.baseline_person_black_24dp;
            this.panelImagemCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImagemCliente.Location = new System.Drawing.Point(16, 9);
            this.panelImagemCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImagemCliente.Name = "panelImagemCliente";
            this.panelImagemCliente.Size = new System.Drawing.Size(53, 64);
            this.panelImagemCliente.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(83, 9);
            this.labelNome.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(157, 25);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "Nome do Cliente";
            // 
            // labelPrecoDetalhe
            // 
            this.labelPrecoDetalhe.AutoSize = true;
            this.labelPrecoDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoDetalhe.Location = new System.Drawing.Point(88, 46);
            this.labelPrecoDetalhe.Name = "labelPrecoDetalhe";
            this.labelPrecoDetalhe.Size = new System.Drawing.Size(63, 27);
            this.labelPrecoDetalhe.TabIndex = 24;
            this.labelPrecoDetalhe.Text = "0.00€";
            // 
            // labelPrecoTotal
            // 
            this.labelPrecoTotal.AutoSize = true;
            this.labelPrecoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotal.Location = new System.Drawing.Point(311, 11);
            this.labelPrecoTotal.Name = "labelPrecoTotal";
            this.labelPrecoTotal.Size = new System.Drawing.Size(63, 27);
            this.labelPrecoTotal.TabIndex = 25;
            this.labelPrecoTotal.Text = "0.00€";
            // 
            // buttonExportarVenda
            // 
            this.buttonExportarVenda.Location = new System.Drawing.Point(16, 475);
            this.buttonExportarVenda.Name = "buttonExportarVenda";
            this.buttonExportarVenda.Size = new System.Drawing.Size(358, 33);
            this.buttonExportarVenda.TabIndex = 26;
            this.buttonExportarVenda.Text = "Exportar Venda";
            this.buttonExportarVenda.UseVisualStyleBackColor = true;
            this.buttonExportarVenda.Click += new System.EventHandler(this.buttonExportarVenda_Click);
            // 
            // MostraDetalhesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 520);
            this.Controls.Add(this.buttonExportarVenda);
            this.Controls.Add(this.labelPrecoTotal);
            this.Controls.Add(this.labelPrecoDetalhe);
            this.Controls.Add(this.panelImagemCliente);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.listBoxDetalhesCompras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MostraDetalhesCompra";
            this.Text = "MostraDetalhesCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDetalhesCompras;
        private System.Windows.Forms.Panel panelImagemCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPrecoDetalhe;
        private System.Windows.Forms.Label labelPrecoTotal;
        private System.Windows.Forms.Button buttonExportarVenda;
    }
}