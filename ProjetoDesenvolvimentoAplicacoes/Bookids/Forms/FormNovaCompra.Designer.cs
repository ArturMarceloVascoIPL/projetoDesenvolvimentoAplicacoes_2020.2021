
namespace Bookids
{
    partial class FormNovaCompra
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
            this.components = new System.ComponentModel.Container();
            this.labelPrecoTotalCompra = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBoxSearchClientes = new System.Windows.Forms.TextBox();
            this.listaProdutos = new System.Windows.Forms.ListBox();
            this.listaCarrinho = new System.Windows.Forms.ListBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelCardNo = new System.Windows.Forms.Panel();
            this.panelCardYes = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonInserir = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRetirar = new System.Windows.Forms.Panel();
            this.buttonProdutosAtalho = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrecoTotalCompra
            // 
            this.labelPrecoTotalCompra.AutoSize = true;
            this.labelPrecoTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotalCompra.Location = new System.Drawing.Point(541, 25);
            this.labelPrecoTotalCompra.Name = "labelPrecoTotalCompra";
            this.labelPrecoTotalCompra.Size = new System.Drawing.Size(63, 27);
            this.labelPrecoTotalCompra.TabIndex = 24;
            this.labelPrecoTotalCompra.Text = "0.00€";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(497, 446);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 64);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBoxSearchClientes
            // 
            this.textBoxSearchClientes.Location = new System.Drawing.Point(36, 51);
            this.textBoxSearchClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchClientes.Name = "textBoxSearchClientes";
            this.textBoxSearchClientes.Size = new System.Drawing.Size(219, 22);
            this.textBoxSearchClientes.TabIndex = 28;
            this.textBoxSearchClientes.TextChanged += new System.EventHandler(this.textBoxSearchClientes_TextChanged);
            // 
            // listaProdutos
            // 
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.ItemHeight = 16;
            this.listaProdutos.Location = new System.Drawing.Point(12, 78);
            this.listaProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(243, 356);
            this.listaProdutos.TabIndex = 30;
            // 
            // listaCarrinho
            // 
            this.listaCarrinho.FormattingEnabled = true;
            this.listaCarrinho.ItemHeight = 16;
            this.listaCarrinho.Location = new System.Drawing.Point(341, 78);
            this.listaCarrinho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaCarrinho.Name = "listaCarrinho";
            this.listaCarrinho.Size = new System.Drawing.Size(264, 356);
            this.listaCarrinho.TabIndex = 31;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(169, 466);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(50, 20);
            this.labelHora.TabIndex = 34;
            this.labelHora.Text = "09:30";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(69, 466);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(93, 20);
            this.labelData.TabIndex = 33;
            this.labelData.Text = "01-01-2021";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelCardNo);
            this.panel6.Controls.Add(this.panelCardYes);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(341, 446);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 64);
            this.panel6.TabIndex = 35;
            // 
            // panelCardNo
            // 
            this.panelCardNo.BackColor = System.Drawing.Color.White;
            this.panelCardNo.BackgroundImage = global::Bookids.Properties.Resources.baseline_clear_black_24dp;
            this.panelCardNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCardNo.Location = new System.Drawing.Point(51, 12);
            this.panelCardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCardNo.Name = "panelCardNo";
            this.panelCardNo.Size = new System.Drawing.Size(41, 38);
            this.panelCardNo.TabIndex = 35;
            this.panelCardNo.Click += new System.EventHandler(this.panelCardNo_Click);
            // 
            // panelCardYes
            // 
            this.panelCardYes.BackColor = System.Drawing.Color.White;
            this.panelCardYes.BackgroundImage = global::Bookids.Properties.Resources.baseline_check_black_24dp;
            this.panelCardYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCardYes.Location = new System.Drawing.Point(3, 12);
            this.panelCardYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCardYes.Name = "panelCardYes";
            this.panelCardYes.Size = new System.Drawing.Size(41, 38);
            this.panelCardYes.TabIndex = 34;
            this.panelCardYes.Click += new System.EventHandler(this.panelCardYes_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Bookids.Properties.Resources.baseline_credit_card_black_24dp;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(101, 12);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 38);
            this.panel7.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Bookids.Properties.Resources.baseline_watch_later_black_24dp;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(13, 446);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(51, 50);
            this.panel5.TabIndex = 32;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackgroundImage = global::Bookids.Properties.Resources.baseline_arrow_forward_black_24dp;
            this.buttonInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInserir.Location = new System.Drawing.Point(280, 314);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(37, 39);
            this.buttonInserir.TabIndex = 26;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bookids.Properties.Resources.baseline_add_box_black_24dp;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(2, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 31);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(8, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 22);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bookids.Properties.Resources.baseline_shopping_cart_black_24dp;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(341, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.BackgroundImage = global::Bookids.Properties.Resources.baseline_arrow_back_black_24dp;
            this.buttonRetirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRetirar.Location = new System.Drawing.Point(280, 165);
            this.buttonRetirar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(37, 39);
            this.buttonRetirar.TabIndex = 36;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // buttonProdutosAtalho
            // 
            this.buttonProdutosAtalho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProdutosAtalho.Location = new System.Drawing.Point(43, 8);
            this.buttonProdutosAtalho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProdutosAtalho.Name = "buttonProdutosAtalho";
            this.buttonProdutosAtalho.Size = new System.Drawing.Size(212, 34);
            this.buttonProdutosAtalho.TabIndex = 37;
            this.buttonProdutosAtalho.Text = "Editar Produtos";
            this.buttonProdutosAtalho.UseVisualStyleBackColor = true;
            this.buttonProdutosAtalho.Click += new System.EventHandler(this.buttonProdutosAtalho_Click);
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 522);
            this.Controls.Add(this.buttonProdutosAtalho);
            this.Controls.Add(this.buttonRetirar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listaCarrinho);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearchClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPrecoTotalCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormNovaCompra";
            this.Text = "Nova Compra";
            this.Load += new System.EventHandler(this.FormNovaCompra_Load);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrecoTotalCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearchClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaProdutos;
        private System.Windows.Forms.ListBox listaCarrinho;
        private System.Windows.Forms.Panel buttonInserir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelCardNo;
        private System.Windows.Forms.Panel panelCardYes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel buttonRetirar;
        private System.Windows.Forms.Button buttonProdutosAtalho;
    }
}