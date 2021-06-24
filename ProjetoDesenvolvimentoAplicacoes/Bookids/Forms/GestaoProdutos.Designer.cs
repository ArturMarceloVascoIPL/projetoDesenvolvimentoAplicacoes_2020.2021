
namespace Bookids.Forms
{
    partial class GestaoProdutos
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
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Panel();
            this.buttonPesquisarProdutos = new System.Windows.Forms.Panel();
            this.textBoxPesquisaProdutos = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEditProdutos = new System.Windows.Forms.Panel();
            this.textBoxDesignacao = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAddTipos = new System.Windows.Forms.Button();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEditTipos = new System.Windows.Forms.Panel();
            this.buttonApagarTipo = new System.Windows.Forms.Button();
            this.textBoxNomeTipo = new System.Windows.Forms.TextBox();
            this.listBoxTipos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSalvarTipo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.panelEditProdutos.SuspendLayout();
            this.panelEditTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 31);
            this.menuStrip1.TabIndex = 3;
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
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRecenteToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // verRecenteToolStripMenuItem
            // 
            this.verRecenteToolStripMenuItem.Name = "verRecenteToolStripMenuItem";
            this.verRecenteToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.verRecenteToolStripMenuItem.Text = "Ver Recente";
            this.verRecenteToolStripMenuItem.Click += new System.EventHandler(this.verCompraRecenteToolStripMenuItem_Click);
            // 
            // panelProdutos
            // 
            this.panelProdutos.Controls.Add(this.buttonRefresh);
            this.panelProdutos.Controls.Add(this.buttonPesquisarProdutos);
            this.panelProdutos.Controls.Add(this.textBoxPesquisaProdutos);
            this.panelProdutos.Controls.Add(this.buttonApagar);
            this.panelProdutos.Controls.Add(this.buttonEditar);
            this.panelProdutos.Controls.Add(this.buttonNovo);
            this.panelProdutos.Controls.Add(this.listBoxProdutos);
            this.panelProdutos.Controls.Add(this.label4);
            this.panelProdutos.Location = new System.Drawing.Point(15, 37);
            this.panelProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(445, 490);
            this.panelProdutos.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.BackgroundImage = global::Bookids.Properties.Resources.baseline_autorenew_black_24dp;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(19, 32);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(29, 25);
            this.buttonRefresh.TabIndex = 61;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPesquisarProdutos
            // 
            this.buttonPesquisarProdutos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.buttonPesquisarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisarProdutos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPesquisarProdutos.Location = new System.Drawing.Point(53, 32);
            this.buttonPesquisarProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesquisarProdutos.Name = "buttonPesquisarProdutos";
            this.buttonPesquisarProdutos.Size = new System.Drawing.Size(29, 25);
            this.buttonPesquisarProdutos.TabIndex = 60;
            // 
            // textBoxPesquisaProdutos
            // 
            this.textBoxPesquisaProdutos.Location = new System.Drawing.Point(88, 32);
            this.textBoxPesquisaProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaProdutos.Name = "textBoxPesquisaProdutos";
            this.textBoxPesquisaProdutos.Size = new System.Drawing.Size(341, 22);
            this.textBoxPesquisaProdutos.TabIndex = 59;
            this.textBoxPesquisaProdutos.TextChanged += new System.EventHandler(this.textBoxPesquisaProdutos_TextChanged);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(296, 423);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(133, 64);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(157, 423);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(133, 64);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(19, 423);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(133, 64);
            this.buttonNovo.TabIndex = 18;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 16;
            this.listBoxProdutos.Location = new System.Drawing.Point(19, 62);
            this.listBoxProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(411, 356);
            this.listBoxProdutos.TabIndex = 16;
            this.listBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.listBoxProdutos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Produtos";
            // 
            // panelEditProdutos
            // 
            this.panelEditProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEditProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditProdutos.Controls.Add(this.textBoxDesignacao);
            this.panelEditProdutos.Controls.Add(this.buttonCancelar);
            this.panelEditProdutos.Controls.Add(this.buttonSalvar);
            this.panelEditProdutos.Controls.Add(this.buttonAddTipos);
            this.panelEditProdutos.Controls.Add(this.comboBoxTipoProduto);
            this.panelEditProdutos.Controls.Add(this.label5);
            this.panelEditProdutos.Controls.Add(this.textBoxStock);
            this.panelEditProdutos.Controls.Add(this.label2);
            this.panelEditProdutos.Controls.Add(this.label1);
            this.panelEditProdutos.Controls.Add(this.textBoxPreco);
            this.panelEditProdutos.Controls.Add(this.label3);
            this.panelEditProdutos.Enabled = false;
            this.panelEditProdutos.Location = new System.Drawing.Point(465, 158);
            this.panelEditProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEditProdutos.Name = "panelEditProdutos";
            this.panelEditProdutos.Size = new System.Drawing.Size(387, 221);
            this.panelEditProdutos.TabIndex = 5;
            // 
            // textBoxDesignacao
            // 
            this.textBoxDesignacao.Location = new System.Drawing.Point(124, 15);
            this.textBoxDesignacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDesignacao.Name = "textBoxDesignacao";
            this.textBoxDesignacao.Size = new System.Drawing.Size(255, 22);
            this.textBoxDesignacao.TabIndex = 33;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(247, 153);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(133, 64);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(3, 153);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(133, 64);
            this.buttonSalvar.TabIndex = 22;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAddTipos
            // 
            this.buttonAddTipos.Location = new System.Drawing.Point(257, 75);
            this.buttonAddTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTipos.Name = "buttonAddTipos";
            this.buttonAddTipos.Size = new System.Drawing.Size(123, 26);
            this.buttonAddTipos.TabIndex = 32;
            this.buttonAddTipos.Text = "Editar Tipos +";
            this.buttonAddTipos.UseVisualStyleBackColor = true;
            this.buttonAddTipos.Click += new System.EventHandler(this.btnAddTipos_Click);
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(124, 75);
            this.comboBoxTipoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(127, 24);
            this.comboBoxTipoProduto.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo Prod:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(124, 106);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(127, 22);
            this.textBoxStock.TabIndex = 29;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Designação:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(124, 46);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(127, 22);
            this.textBoxPreco.TabIndex = 26;
            this.textBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPreco_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Preço:";
            // 
            // panelEditTipos
            // 
            this.panelEditTipos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEditTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditTipos.Controls.Add(this.buttonApagarTipo);
            this.panelEditTipos.Controls.Add(this.textBoxNomeTipo);
            this.panelEditTipos.Controls.Add(this.listBoxTipos);
            this.panelEditTipos.Controls.Add(this.label6);
            this.panelEditTipos.Controls.Add(this.buttonSalvarTipo);
            this.panelEditTipos.Controls.Add(this.label8);
            this.panelEditTipos.Enabled = false;
            this.panelEditTipos.Location = new System.Drawing.Point(859, 69);
            this.panelEditTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEditTipos.Name = "panelEditTipos";
            this.panelEditTipos.Size = new System.Drawing.Size(233, 374);
            this.panelEditTipos.TabIndex = 33;
            // 
            // buttonApagarTipo
            // 
            this.buttonApagarTipo.Location = new System.Drawing.Point(125, 324);
            this.buttonApagarTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagarTipo.Name = "buttonApagarTipo";
            this.buttonApagarTipo.Size = new System.Drawing.Size(93, 43);
            this.buttonApagarTipo.TabIndex = 35;
            this.buttonApagarTipo.Text = "Apagar";
            this.buttonApagarTipo.UseVisualStyleBackColor = false;
            this.buttonApagarTipo.Click += new System.EventHandler(this.buttonApagarTipo_Click);
            // 
            // textBoxNomeTipo
            // 
            this.textBoxNomeTipo.Location = new System.Drawing.Point(76, 294);
            this.textBoxNomeTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeTipo.Name = "textBoxNomeTipo";
            this.textBoxNomeTipo.Size = new System.Drawing.Size(141, 22);
            this.textBoxNomeTipo.TabIndex = 34;
            // 
            // listBoxTipos
            // 
            this.listBoxTipos.FormattingEnabled = true;
            this.listBoxTipos.ItemHeight = 16;
            this.listBoxTipos.Location = new System.Drawing.Point(9, 28);
            this.listBoxTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTipos.Name = "listBoxTipos";
            this.listBoxTipos.Size = new System.Drawing.Size(208, 260);
            this.listBoxTipos.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nome:";
            // 
            // buttonSalvarTipo
            // 
            this.buttonSalvarTipo.Location = new System.Drawing.Point(9, 324);
            this.buttonSalvarTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarTipo.Name = "buttonSalvarTipo";
            this.buttonSalvarTipo.Size = new System.Drawing.Size(93, 43);
            this.buttonSalvarTipo.TabIndex = 22;
            this.buttonSalvarTipo.Text = "Salvar";
            this.buttonSalvarTipo.UseVisualStyleBackColor = false;
            this.buttonSalvarTipo.Click += new System.EventHandler(this.buttonSalvarTipo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipos de Produto";
            // 
            // GestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 530);
            this.Controls.Add(this.panelEditTipos);
            this.Controls.Add(this.panelEditProdutos);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoProdutos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestaoProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoProdutos_FormClosing);
            this.Load += new System.EventHandler(this.GestaoProdutos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.panelEditProdutos.ResumeLayout(false);
            this.panelEditProdutos.PerformLayout();
            this.panelEditTipos.ResumeLayout(false);
            this.panelEditTipos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelEditProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipoProduto;
        private System.Windows.Forms.Button buttonAddTipos;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel buttonRefresh;
        private System.Windows.Forms.Panel buttonPesquisarProdutos;
        private System.Windows.Forms.TextBox textBoxPesquisaProdutos;
        private System.Windows.Forms.TextBox textBoxDesignacao;
        private System.Windows.Forms.Panel panelEditTipos;
        private System.Windows.Forms.Button buttonApagarTipo;
        private System.Windows.Forms.TextBox textBoxNomeTipo;
        private System.Windows.Forms.ListBox listBoxTipos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSalvarTipo;
        private System.Windows.Forms.Label label8;
    }
}