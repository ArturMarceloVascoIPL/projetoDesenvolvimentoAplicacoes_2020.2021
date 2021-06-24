
namespace Bookids.Forms
{
    partial class GestaoAnimador
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAnimador = new System.Windows.Forms.Panel();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.l_7 = new System.Windows.Forms.Label();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.l_5 = new System.Windows.Forms.Label();
            this.textBoxEspecialidade = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.textBoxLocalidade = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.l_6 = new System.Windows.Forms.Label();
            this.l_9 = new System.Windows.Forms.Label();
            this.l_8 = new System.Windows.Forms.Label();
            this.l_4 = new System.Windows.Forms.Label();
            this.l_3 = new System.Windows.Forms.Label();
            this.l_2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelAnimador = new System.Windows.Forms.Label();
            this._labelAnimadores = new System.Windows.Forms.Label();
            this.listBoxAnimadores = new System.Windows.Forms.ListBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.panelPesquisaEventos = new System.Windows.Forms.Panel();
            this.panelRefresh = new System.Windows.Forms.Panel();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.panelAnimador.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(993, 31);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
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
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoTipoToolStripMenuItem_Click);
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
            this.verRecenteToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.verRecenteToolStripMenuItem.Text = "Ver Recente";
            this.verRecenteToolStripMenuItem.Click += new System.EventHandler(this.verCompraRecenteToolStripMenuItem_Click);
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
            // panelAnimador
            // 
            this.panelAnimador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAnimador.Controls.Add(this.textBoxTelefone);
            this.panelAnimador.Controls.Add(this.l_7);
            this.panelAnimador.Controls.Add(this.textBoxCodPostal);
            this.panelAnimador.Controls.Add(this.l_5);
            this.panelAnimador.Controls.Add(this.textBoxEspecialidade);
            this.panelAnimador.Controls.Add(this.textBoxEmail);
            this.panelAnimador.Controls.Add(this.textBoxTelemovel);
            this.panelAnimador.Controls.Add(this.textBoxLocalidade);
            this.panelAnimador.Controls.Add(this.textBoxMorada);
            this.panelAnimador.Controls.Add(this.textBoxNome);
            this.panelAnimador.Controls.Add(this.l_6);
            this.panelAnimador.Controls.Add(this.l_9);
            this.panelAnimador.Controls.Add(this.l_8);
            this.panelAnimador.Controls.Add(this.l_4);
            this.panelAnimador.Controls.Add(this.l_3);
            this.panelAnimador.Controls.Add(this.l_2);
            this.panelAnimador.Controls.Add(this.buttonCancelar);
            this.panelAnimador.Controls.Add(this.buttonGuardar);
            this.panelAnimador.Enabled = false;
            this.panelAnimador.Location = new System.Drawing.Point(452, 148);
            this.panelAnimador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAnimador.Name = "panelAnimador";
            this.panelAnimador.Size = new System.Drawing.Size(528, 289);
            this.panelAnimador.TabIndex = 13;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(403, 102);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.MaxLength = 9;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(109, 22);
            this.textBoxTelefone.TabIndex = 27;
            this.textBoxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumApena_KeyPress);
            // 
            // l_7
            // 
            this.l_7.AutoSize = true;
            this.l_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_7.Location = new System.Drawing.Point(307, 103);
            this.l_7.Name = "l_7";
            this.l_7.Size = new System.Drawing.Size(78, 20);
            this.l_7.TabIndex = 30;
            this.l_7.Text = "Telefone:";
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(403, 73);
            this.textBoxCodPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodPostal.MaxLength = 9;
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(109, 22);
            this.textBoxCodPostal.TabIndex = 25;
            this.textBoxCodPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumApena_KeyPress);
            // 
            // l_5
            // 
            this.l_5.AutoSize = true;
            this.l_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_5.Location = new System.Drawing.Point(289, 74);
            this.l_5.Name = "l_5";
            this.l_5.Size = new System.Drawing.Size(97, 20);
            this.l_5.TabIndex = 28;
            this.l_5.Text = "Cod-Postal:";
            // 
            // textBoxEspecialidade
            // 
            this.textBoxEspecialidade.Location = new System.Drawing.Point(141, 161);
            this.textBoxEspecialidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEspecialidade.Name = "textBoxEspecialidade";
            this.textBoxEspecialidade.Size = new System.Drawing.Size(371, 22);
            this.textBoxEspecialidade.TabIndex = 29;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(141, 132);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(371, 22);
            this.textBoxEmail.TabIndex = 28;
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(141, 103);
            this.textBoxTelemovel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelemovel.MaxLength = 9;
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(109, 22);
            this.textBoxTelemovel.TabIndex = 26;
            this.textBoxTelemovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumApena_KeyPress);
            // 
            // textBoxLocalidade
            // 
            this.textBoxLocalidade.Location = new System.Drawing.Point(141, 74);
            this.textBoxLocalidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocalidade.Name = "textBoxLocalidade";
            this.textBoxLocalidade.Size = new System.Drawing.Size(109, 22);
            this.textBoxLocalidade.TabIndex = 24;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(141, 43);
            this.textBoxMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(371, 22);
            this.textBoxMorada.TabIndex = 23;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(141, 14);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(371, 22);
            this.textBoxNome.TabIndex = 22;
            // 
            // l_6
            // 
            this.l_6.AutoSize = true;
            this.l_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_6.Location = new System.Drawing.Point(3, 103);
            this.l_6.Name = "l_6";
            this.l_6.Size = new System.Drawing.Size(90, 20);
            this.l_6.TabIndex = 21;
            this.l_6.Text = "Telemovel:";
            // 
            // l_9
            // 
            this.l_9.AutoSize = true;
            this.l_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_9.Location = new System.Drawing.Point(3, 162);
            this.l_9.Name = "l_9";
            this.l_9.Size = new System.Drawing.Size(118, 20);
            this.l_9.TabIndex = 20;
            this.l_9.Text = "Especialidade:";
            // 
            // l_8
            // 
            this.l_8.AutoSize = true;
            this.l_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_8.Location = new System.Drawing.Point(3, 133);
            this.l_8.Name = "l_8";
            this.l_8.Size = new System.Drawing.Size(56, 20);
            this.l_8.TabIndex = 19;
            this.l_8.Text = "Email:";
            // 
            // l_4
            // 
            this.l_4.AutoSize = true;
            this.l_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_4.Location = new System.Drawing.Point(3, 74);
            this.l_4.Name = "l_4";
            this.l_4.Size = new System.Drawing.Size(95, 20);
            this.l_4.TabIndex = 18;
            this.l_4.Text = "Localidade:";
            // 
            // l_3
            // 
            this.l_3.AutoSize = true;
            this.l_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_3.Location = new System.Drawing.Point(3, 44);
            this.l_3.Name = "l_3";
            this.l_3.Size = new System.Drawing.Size(70, 20);
            this.l_3.TabIndex = 17;
            this.l_3.Text = "Morada:";
            // 
            // l_2
            // 
            this.l_2.AutoSize = true;
            this.l_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_2.Location = new System.Drawing.Point(3, 15);
            this.l_2.Name = "l_2";
            this.l_2.Size = new System.Drawing.Size(58, 20);
            this.l_2.TabIndex = 16;
            this.l_2.Text = "Nome:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(380, 213);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(133, 64);
            this.buttonCancelar.TabIndex = 31;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(7, 213);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(133, 64);
            this.buttonGuardar.TabIndex = 30;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelAnimador
            // 
            this.labelAnimador.AutoSize = true;
            this.labelAnimador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnimador.Location = new System.Drawing.Point(453, 114);
            this.labelAnimador.Name = "labelAnimador";
            this.labelAnimador.Size = new System.Drawing.Size(130, 29);
            this.labelAnimador.TabIndex = 16;
            this.labelAnimador.Text = "Animador";
            // 
            // _labelAnimadores
            // 
            this._labelAnimadores.AutoSize = true;
            this._labelAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelAnimadores.Location = new System.Drawing.Point(12, 47);
            this._labelAnimadores.Name = "_labelAnimadores";
            this._labelAnimadores.Size = new System.Drawing.Size(127, 25);
            this._labelAnimadores.TabIndex = 7;
            this._labelAnimadores.Text = "Animadores";
            // 
            // listBoxAnimadores
            // 
            this.listBoxAnimadores.FormattingEnabled = true;
            this.listBoxAnimadores.ItemHeight = 16;
            this.listBoxAnimadores.Location = new System.Drawing.Point(17, 103);
            this.listBoxAnimadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAnimadores.Name = "listBoxAnimadores";
            this.listBoxAnimadores.Size = new System.Drawing.Size(411, 356);
            this.listBoxAnimadores.TabIndex = 8;
            this.listBoxAnimadores.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimadores_SelectedIndexChanged);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(17, 466);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(133, 64);
            this.buttonNovo.TabIndex = 10;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(156, 466);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(133, 64);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.Color.White;
            this.buttonApagar.Location = new System.Drawing.Point(295, 466);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(133, 64);
            this.buttonApagar.TabIndex = 12;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // panelPesquisaEventos
            // 
            this.panelPesquisaEventos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panelPesquisaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPesquisaEventos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelPesquisaEventos.Location = new System.Drawing.Point(52, 74);
            this.panelPesquisaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPesquisaEventos.Name = "panelPesquisaEventos";
            this.panelPesquisaEventos.Size = new System.Drawing.Size(29, 25);
            this.panelPesquisaEventos.TabIndex = 73;
            // 
            // panelRefresh
            // 
            this.panelRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRefresh.BackgroundImage = global::Bookids.Properties.Resources.baseline_autorenew_black_24dp;
            this.panelRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRefresh.Location = new System.Drawing.Point(17, 74);
            this.panelRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRefresh.Name = "panelRefresh";
            this.panelRefresh.Size = new System.Drawing.Size(29, 25);
            this.panelRefresh.TabIndex = 72;
            this.panelRefresh.Click += new System.EventHandler(this.panelRefresh_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(87, 74);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(341, 22);
            this.textBoxPesquisa.TabIndex = 71;
            // 
            // GestaoAnimador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 538);
            this.Controls.Add(this.labelAnimador);
            this.Controls.Add(this.panelPesquisaEventos);
            this.Controls.Add(this.panelRefresh);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.panelAnimador);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.listBoxAnimadores);
            this.Controls.Add(this._labelAnimadores);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoAnimador";
            this.Text = "GestaoAnimador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoAnimador_FormClosing);
            this.Load += new System.EventHandler(this.GestaoAnimador_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelAnimador.ResumeLayout(false);
            this.panelAnimador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
        private System.Windows.Forms.Panel panelAnimador;
        private System.Windows.Forms.Label l_6;
        private System.Windows.Forms.Label l_9;
        private System.Windows.Forms.Label l_8;
        private System.Windows.Forms.Label l_4;
        private System.Windows.Forms.Label l_3;
        private System.Windows.Forms.Label l_2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.TextBox textBoxLocalidade;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxEspecialidade;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label l_7;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label l_5;
        private System.Windows.Forms.Label _labelAnimadores;
        private System.Windows.Forms.ListBox listBoxAnimadores;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelAnimador;
        private System.Windows.Forms.Panel panelPesquisaEventos;
        private System.Windows.Forms.Panel panelRefresh;
        private System.Windows.Forms.TextBox textBoxPesquisa;
    }
}