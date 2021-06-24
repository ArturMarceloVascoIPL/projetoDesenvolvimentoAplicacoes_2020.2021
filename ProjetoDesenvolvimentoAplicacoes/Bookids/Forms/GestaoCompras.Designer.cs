
namespace Bookids
{
    partial class GestaoCompras
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_3 = new System.Windows.Forms.Label();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.panelPesquisaEventos = new System.Windows.Forms.Panel();
            this.textBoxSearchClientes = new System.Windows.Forms.TextBox();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.l_1 = new System.Windows.Forms.Label();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.labelPrecoTotalCompra = new System.Windows.Forms.Label();
            this.btnApagarCompra = new System.Windows.Forms.Button();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.listaCompras = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.l_2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Image = global::Bookids.Properties.Resources.baseline_home_black_24dp;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(34, 27);
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoEventoToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.editarTiposToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(183, 28);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoTipoToolStripMenuItem_Click);
            // 
            // editarTiposToolStripMenuItem
            // 
            this.editarTiposToolStripMenuItem.Name = "editarTiposToolStripMenuItem";
            this.editarTiposToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.editarTiposToolStripMenuItem.Text = "Editar Tipos";
            this.editarTiposToolStripMenuItem.Click += new System.EventHandler(this.editarTiposToolStripMenuItem_Click);
            // 
            // l_3
            // 
            this.l_3.AutoSize = true;
            this.l_3.BackColor = System.Drawing.Color.Transparent;
            this.l_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_3.Location = new System.Drawing.Point(9, 38);
            this.l_3.Name = "l_3";
            this.l_3.Size = new System.Drawing.Size(204, 25);
            this.l_3.TabIndex = 16;
            this.l_3.Text = "Gestão de Compras";
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.Transparent;
            this.panelProdutos.Controls.Add(this.panelPesquisaEventos);
            this.panelProdutos.Controls.Add(this.textBoxSearchClientes);
            this.panelProdutos.Controls.Add(this.btnNovaCompra);
            this.panelProdutos.Controls.Add(this.listaClientes);
            this.panelProdutos.Controls.Add(this.l_1);
            this.panelProdutos.Location = new System.Drawing.Point(15, 66);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(431, 497);
            this.panelProdutos.TabIndex = 17;
            // 
            // panelPesquisaEventos
            // 
            this.panelPesquisaEventos.BackColor = System.Drawing.Color.Transparent;
            this.panelPesquisaEventos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panelPesquisaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPesquisaEventos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelPesquisaEventos.Location = new System.Drawing.Point(8, 33);
            this.panelPesquisaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPesquisaEventos.Name = "panelPesquisaEventos";
            this.panelPesquisaEventos.Size = new System.Drawing.Size(29, 25);
            this.panelPesquisaEventos.TabIndex = 71;
            // 
            // textBoxSearchClientes
            // 
            this.textBoxSearchClientes.Location = new System.Drawing.Point(43, 33);
            this.textBoxSearchClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchClientes.Name = "textBoxSearchClientes";
            this.textBoxSearchClientes.Size = new System.Drawing.Size(376, 22);
            this.textBoxSearchClientes.TabIndex = 17;
            this.textBoxSearchClientes.TextChanged += new System.EventHandler(this.textBoxSearchClientes_TextChanged);
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaCompra.ForeColor = System.Drawing.Color.White;
            this.btnNovaCompra.Location = new System.Drawing.Point(286, 422);
            this.btnNovaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(133, 64);
            this.btnNovaCompra.TabIndex = 20;
            this.btnNovaCompra.Text = "Nova Compra";
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.ItemHeight = 16;
            this.listaClientes.Location = new System.Drawing.Point(8, 62);
            this.listaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(411, 356);
            this.listaClientes.TabIndex = 16;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.listaClientes_SelectedIndexChanged);
            // 
            // l_1
            // 
            this.l_1.AutoSize = true;
            this.l_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_1.Location = new System.Drawing.Point(3, 7);
            this.l_1.Name = "l_1";
            this.l_1.Size = new System.Drawing.Size(83, 25);
            this.l_1.TabIndex = 15;
            this.l_1.Text = "Clientes";
            // 
            // panelCompras
            // 
            this.panelCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCompras.Controls.Add(this.labelPrecoTotalCompra);
            this.panelCompras.Controls.Add(this.btnApagarCompra);
            this.panelCompras.Controls.Add(this.btnVerDetalhes);
            this.panelCompras.Controls.Add(this.listaCompras);
            this.panelCompras.Controls.Add(this.panel3);
            this.panelCompras.Controls.Add(this.flowLayoutPanel1);
            this.panelCompras.Enabled = false;
            this.panelCompras.Location = new System.Drawing.Point(473, 66);
            this.panelCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(651, 497);
            this.panelCompras.TabIndex = 18;
            // 
            // labelPrecoTotalCompra
            // 
            this.labelPrecoTotalCompra.AutoSize = true;
            this.labelPrecoTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotalCompra.Location = new System.Drawing.Point(552, 17);
            this.labelPrecoTotalCompra.Name = "labelPrecoTotalCompra";
            this.labelPrecoTotalCompra.Size = new System.Drawing.Size(63, 27);
            this.labelPrecoTotalCompra.TabIndex = 23;
            this.labelPrecoTotalCompra.Text = "0.00€";
            // 
            // btnApagarCompra
            // 
            this.btnApagarCompra.BackColor = System.Drawing.Color.Firebrick;
            this.btnApagarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarCompra.ForeColor = System.Drawing.Color.White;
            this.btnApagarCompra.Location = new System.Drawing.Point(507, 423);
            this.btnApagarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApagarCompra.Name = "btnApagarCompra";
            this.btnApagarCompra.Size = new System.Drawing.Size(133, 64);
            this.btnApagarCompra.TabIndex = 23;
            this.btnApagarCompra.Text = "Apagar";
            this.btnApagarCompra.UseVisualStyleBackColor = false;
            this.btnApagarCompra.Click += new System.EventHandler(this.btnApagarCompra_Click);
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalhes.Location = new System.Drawing.Point(13, 423);
            this.btnVerDetalhes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(133, 64);
            this.btnVerDetalhes.TabIndex = 22;
            this.btnVerDetalhes.Text = "Detalhes";
            this.btnVerDetalhes.UseVisualStyleBackColor = false;
            this.btnVerDetalhes.Click += new System.EventHandler(this.btnVerDetalhes_Click);
            // 
            // listaCompras
            // 
            this.listaCompras.FormattingEnabled = true;
            this.listaCompras.ItemHeight = 16;
            this.listaCompras.Location = new System.Drawing.Point(13, 64);
            this.listaCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.Size = new System.Drawing.Size(625, 356);
            this.listaCompras.TabIndex = 17;
            this.listaCompras.SelectedIndexChanged += new System.EventHandler(this.listaCompras_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Bookids.Properties.Resources.baseline_shopping_cart_black_24dp;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(13, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 49);
            this.panel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.labelNomeCliente);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 55);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Bookids.Properties.Resources.baseline_person_black_24dp;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 49);
            this.panel4.TabIndex = 1;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(62, 15);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(157, 25);
            this.labelNomeCliente.TabIndex = 23;
            this.labelNomeCliente.Text = "Nome do Cliente";
            // 
            // l_2
            // 
            this.l_2.AutoSize = true;
            this.l_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_2.Location = new System.Drawing.Point(468, 38);
            this.l_2.Name = "l_2";
            this.l_2.Size = new System.Drawing.Size(203, 25);
            this.l_2.TabIndex = 22;
            this.l_2.Text = "Compras do Cliente";
            // 
            // GestaoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 570);
            this.Controls.Add(this.l_2);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.l_3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Compras";
            this.Load += new System.EventHandler(this.GestaoCompras_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GestaoCompras_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
        private System.Windows.Forms.Label l_3;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.TextBox textBoxSearchClientes;
        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Label l_1;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnApagarCompra;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.ListBox listaCompras;
        private System.Windows.Forms.Label l_2;
        private System.Windows.Forms.Label labelPrecoTotalCompra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelPesquisaEventos;
    }
}