
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRetirar = new System.Windows.Forms.Panel();
            this.buttonProdutosAtalho = new System.Windows.Forms.Button();
            this.panelPesquisaEventos = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrecoTotalCompra
            // 
            this.labelPrecoTotalCompra.AutoSize = true;
            this.labelPrecoTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotalCompra.Location = new System.Drawing.Point(401, 19);
            this.labelPrecoTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoTotalCompra.Name = "labelPrecoTotalCompra";
            this.labelPrecoTotalCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrecoTotalCompra.Size = new System.Drawing.Size(51, 22);
            this.labelPrecoTotalCompra.TabIndex = 24;
            this.labelPrecoTotalCompra.Text = "0.00€";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(373, 362);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 52);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBoxSearchClientes
            // 
            this.textBoxSearchClientes.Location = new System.Drawing.Point(33, 41);
            this.textBoxSearchClientes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchClientes.Name = "textBoxSearchClientes";
            this.textBoxSearchClientes.Size = new System.Drawing.Size(159, 20);
            this.textBoxSearchClientes.TabIndex = 28;
            this.textBoxSearchClientes.TextChanged += new System.EventHandler(this.textBoxSearchClientes_TextChanged);
            // 
            // listaProdutos
            // 
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.Location = new System.Drawing.Point(7, 63);
            this.listaProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(185, 290);
            this.listaProdutos.TabIndex = 30;
            // 
            // listaCarrinho
            // 
            this.listaCarrinho.FormattingEnabled = true;
            this.listaCarrinho.Location = new System.Drawing.Point(256, 63);
            this.listaCarrinho.Margin = new System.Windows.Forms.Padding(2);
            this.listaCarrinho.Name = "listaCarrinho";
            this.listaCarrinho.Size = new System.Drawing.Size(199, 290);
            this.listaCarrinho.TabIndex = 31;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(53, 396);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(44, 17);
            this.labelHora.TabIndex = 34;
            this.labelHora.Text = "09:30";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(53, 373);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(82, 17);
            this.labelData.TabIndex = 33;
            this.labelData.Text = "01-01-2021";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panelCardNo);
            this.panel6.Controls.Add(this.panelCardYes);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(256, 362);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 51);
            this.panel6.TabIndex = 35;
            // 
            // panelCardNo
            // 
            this.panelCardNo.BackColor = System.Drawing.Color.White;
            this.panelCardNo.BackgroundImage = global::Bookids.Properties.Resources.baseline_clear_black_24dp;
            this.panelCardNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCardNo.Location = new System.Drawing.Point(38, 10);
            this.panelCardNo.Margin = new System.Windows.Forms.Padding(2);
            this.panelCardNo.Name = "panelCardNo";
            this.panelCardNo.Size = new System.Drawing.Size(31, 31);
            this.panelCardNo.TabIndex = 35;
            this.panelCardNo.Click += new System.EventHandler(this.panelCardNo_Click);
            // 
            // panelCardYes
            // 
            this.panelCardYes.BackColor = System.Drawing.Color.White;
            this.panelCardYes.BackgroundImage = global::Bookids.Properties.Resources.baseline_check_black_24dp;
            this.panelCardYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCardYes.Location = new System.Drawing.Point(2, 10);
            this.panelCardYes.Margin = new System.Windows.Forms.Padding(2);
            this.panelCardYes.Name = "panelCardYes";
            this.panelCardYes.Size = new System.Drawing.Size(31, 31);
            this.panelCardYes.TabIndex = 34;
            this.panelCardYes.Click += new System.EventHandler(this.panelCardYes_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::Bookids.Properties.Resources.baseline_credit_card_black_24dp;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(76, 10);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(31, 31);
            this.panel7.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Bookids.Properties.Resources.baseline_watch_later_black_24dp;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(7, 373);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 40);
            this.panel5.TabIndex = 32;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonInserir.BackgroundImage = global::Bookids.Properties.Resources.baseline_arrow_forward_black_24dp;
            this.buttonInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInserir.Location = new System.Drawing.Point(208, 200);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(30, 30);
            this.buttonInserir.TabIndex = 26;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Bookids.Properties.Resources.baseline_add_box_black_24dp;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 28);
            this.panel1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Bookids.Properties.Resources.baseline_shopping_cart_black_24dp;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(256, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 40);
            this.panel3.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.BackColor = System.Drawing.Color.Brown;
            this.buttonRetirar.BackgroundImage = global::Bookids.Properties.Resources.baseline_arrow_back_black_24dp;
            this.buttonRetirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRetirar.Location = new System.Drawing.Point(208, 166);
            this.buttonRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(30, 30);
            this.buttonRetirar.TabIndex = 36;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // buttonProdutosAtalho
            // 
            this.buttonProdutosAtalho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProdutosAtalho.Location = new System.Drawing.Point(33, 6);
            this.buttonProdutosAtalho.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProdutosAtalho.Name = "buttonProdutosAtalho";
            this.buttonProdutosAtalho.Size = new System.Drawing.Size(159, 28);
            this.buttonProdutosAtalho.TabIndex = 37;
            this.buttonProdutosAtalho.Text = "Editar Produtos";
            this.buttonProdutosAtalho.UseVisualStyleBackColor = true;
            this.buttonProdutosAtalho.Click += new System.EventHandler(this.buttonProdutosAtalho_Click);
            // 
            // panelPesquisaEventos
            // 
            this.panelPesquisaEventos.BackColor = System.Drawing.Color.Transparent;
            this.panelPesquisaEventos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panelPesquisaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPesquisaEventos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelPesquisaEventos.Location = new System.Drawing.Point(7, 41);
            this.panelPesquisaEventos.Margin = new System.Windows.Forms.Padding(2);
            this.panelPesquisaEventos.Name = "panelPesquisaEventos";
            this.panelPesquisaEventos.Size = new System.Drawing.Size(22, 20);
            this.panelPesquisaEventos.TabIndex = 72;
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 424);
            this.Controls.Add(this.panelPesquisaEventos);
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
            this.Controls.Add(this.textBoxSearchClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPrecoTotalCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormNovaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Compra";
            this.Load += new System.EventHandler(this.FormNovaCompra_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormNovaCompra_Paint);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrecoTotalCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalvar;
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
        private System.Windows.Forms.Panel panelPesquisaEventos;
    }
}