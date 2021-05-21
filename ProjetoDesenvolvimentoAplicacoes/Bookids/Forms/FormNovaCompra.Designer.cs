
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrecoTotalCompra
            // 
            this.labelPrecoTotalCompra.AutoSize = true;
            this.labelPrecoTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecoTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoTotalCompra.Location = new System.Drawing.Point(542, 24);
            this.labelPrecoTotalCompra.Name = "labelPrecoTotalCompra";
            this.labelPrecoTotalCompra.Size = new System.Drawing.Size(63, 27);
            this.labelPrecoTotalCompra.TabIndex = 24;
            this.labelPrecoTotalCompra.Text = "0.00€";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(497, 446);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 64);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBoxSearchClientes
            // 
            this.textBoxSearchClientes.Location = new System.Drawing.Point(41, 20);
            this.textBoxSearchClientes.Name = "textBoxSearchClientes";
            this.textBoxSearchClientes.Size = new System.Drawing.Size(219, 22);
            this.textBoxSearchClientes.TabIndex = 28;
            // 
            // listaProdutos
            // 
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.ItemHeight = 16;
            this.listaProdutos.Location = new System.Drawing.Point(12, 77);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(219, 356);
            this.listaProdutos.TabIndex = 30;
            // 
            // listaCarrinho
            // 
            this.listaCarrinho.FormattingEnabled = true;
            this.listaCarrinho.ItemHeight = 16;
            this.listaCarrinho.Location = new System.Drawing.Point(341, 77);
            this.listaCarrinho.Name = "listaCarrinho";
            this.listaCarrinho.Size = new System.Drawing.Size(264, 356);
            this.listaCarrinho.TabIndex = 31;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(169, 467);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(50, 20);
            this.labelHora.TabIndex = 34;
            this.labelHora.Text = "09:30";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(70, 467);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(93, 20);
            this.labelData.TabIndex = 33;
            this.labelData.Text = "01-01-2021";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(341, 446);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 64);
            this.panel6.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::Bookids.Properties.Resources.baseline_clear_black_24dp;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(50, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(41, 38);
            this.panel8.TabIndex = 35;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Bookids.Properties.Resources.baseline_check_black_24dp;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(3, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 38);
            this.panel9.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Bookids.Properties.Resources.baseline_credit_card_black_24dp;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(102, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 38);
            this.panel7.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Bookids.Properties.Resources.baseline_watch_later_black_24dp;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(14, 446);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Bookids.Properties.Resources.baseline_arrow_forward_black_24dp;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(261, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 40);
            this.panel4.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bookids.Properties.Resources.baseline_add_box_black_24dp;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(280, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 31);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(14, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 22);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bookids.Properties.Resources.baseline_shopping_cart_black_24dp;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(341, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 522);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listaCarrinho);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearchClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPrecoTotalCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormNovaCompra";
            this.Text = "Nova Compra";
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Timer timer1;
    }
}