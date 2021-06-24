
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
            this.listBoxDetalhesCompras.Location = new System.Drawing.Point(12, 64);
            this.listBoxDetalhesCompras.Name = "listBoxDetalhesCompras";
            this.listBoxDetalhesCompras.Size = new System.Drawing.Size(272, 316);
            this.listBoxDetalhesCompras.TabIndex = 0;
            this.listBoxDetalhesCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxDetalhesCompras_SelectedIndexChanged);
            // 
            // panelImagemCliente
            // 
            this.panelImagemCliente.BackColor = System.Drawing.Color.Transparent;
            this.panelImagemCliente.BackgroundImage = global::Bookids.Properties.Resources.baseline_person_black_24dp;
            this.panelImagemCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImagemCliente.Location = new System.Drawing.Point(12, 9);
            this.panelImagemCliente.Margin = new System.Windows.Forms.Padding(2);
            this.panelImagemCliente.Name = "panelImagemCliente";
            this.panelImagemCliente.Size = new System.Drawing.Size(50, 50);
            this.panelImagemCliente.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(66, 9);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 12, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(126, 20);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "Nome do Cliente";
            // 
            // labelPrecoDetalhe
            // 
            this.labelPrecoDetalhe.AutoSize = true;
            this.labelPrecoDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoDetalhe.Location = new System.Drawing.Point(70, 37);
            this.labelPrecoDetalhe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoDetalhe.Name = "labelPrecoDetalhe";
            this.labelPrecoDetalhe.Size = new System.Drawing.Size(51, 22);
            this.labelPrecoDetalhe.TabIndex = 24;
            this.labelPrecoDetalhe.Text = "0.00€";
            // 
            // labelPrecoTotal
            // 
            this.labelPrecoTotal.AutoSize = true;
            this.labelPrecoTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotal.Location = new System.Drawing.Point(229, 9);
            this.labelPrecoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoTotal.Name = "labelPrecoTotal";
            this.labelPrecoTotal.Size = new System.Drawing.Size(51, 22);
            this.labelPrecoTotal.TabIndex = 25;
            this.labelPrecoTotal.Text = "0.00€";
            // 
            // buttonExportarVenda
            // 
            this.buttonExportarVenda.BackColor = System.Drawing.Color.Gold;
            this.buttonExportarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportarVenda.ForeColor = System.Drawing.Color.Black;
            this.buttonExportarVenda.Location = new System.Drawing.Point(12, 386);
            this.buttonExportarVenda.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportarVenda.Name = "buttonExportarVenda";
            this.buttonExportarVenda.Size = new System.Drawing.Size(272, 27);
            this.buttonExportarVenda.TabIndex = 26;
            this.buttonExportarVenda.Text = "Exportar Venda";
            this.buttonExportarVenda.UseVisualStyleBackColor = false;
            this.buttonExportarVenda.Click += new System.EventHandler(this.buttonExportarVenda_Click);
            // 
            // MostraDetalhesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 422);
            this.Controls.Add(this.buttonExportarVenda);
            this.Controls.Add(this.labelPrecoTotal);
            this.Controls.Add(this.labelPrecoDetalhe);
            this.Controls.Add(this.panelImagemCliente);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.listBoxDetalhesCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MostraDetalhesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes da Compra";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MostraDetalhesCompra_Paint);
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