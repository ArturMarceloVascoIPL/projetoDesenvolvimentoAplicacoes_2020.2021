
namespace Bookids.Forms
{
    partial class GestaoEscolas
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
            this.panelEscola = new System.Windows.Forms.Panel();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.buttonGuardarEscola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLocalidade = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.panelAlunos = new System.Windows.Forms.Panel();
            this.listBoxAlunos = new System.Windows.Forms.ListBox();
            this.l_labelAlunos = new System.Windows.Forms.Label();
            this.buttonApagarEscola = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.textBoxPesquisaEscolas = new System.Windows.Forms.TextBox();
            this.listBoxEscolas = new System.Windows.Forms.ListBox();
            this.l_labelEscolas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this.l_labelEventos = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Panel();
            this.buttonPesquisarEscolas = new System.Windows.Forms.Panel();
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.labelEscola = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEscola.SuspendLayout();
            this.panelAlunos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEscola
            // 
            this.panelEscola.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEscola.Controls.Add(this.textBoxTelefone);
            this.panelEscola.Controls.Add(this.buttonGuardarEscola);
            this.panelEscola.Controls.Add(this.label1);
            this.panelEscola.Controls.Add(this.label9);
            this.panelEscola.Controls.Add(this.label2);
            this.panelEscola.Controls.Add(this.textBoxCodPostal);
            this.panelEscola.Controls.Add(this.label3);
            this.panelEscola.Controls.Add(this.label8);
            this.panelEscola.Controls.Add(this.label5);
            this.panelEscola.Controls.Add(this.textBoxEmail);
            this.panelEscola.Controls.Add(this.textBoxNome);
            this.panelEscola.Controls.Add(this.textBoxLocalidade);
            this.panelEscola.Controls.Add(this.textBoxMorada);
            this.panelEscola.Enabled = false;
            this.panelEscola.Location = new System.Drawing.Point(437, 150);
            this.panelEscola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEscola.Name = "panelEscola";
            this.panelEscola.Size = new System.Drawing.Size(528, 238);
            this.panelEscola.TabIndex = 6;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(144, 103);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.MaxLength = 9;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(369, 22);
            this.textBoxTelefone.TabIndex = 42;
            this.textBoxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefone_KeyPress);
            // 
            // buttonGuardarEscola
            // 
            this.buttonGuardarEscola.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonGuardarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarEscola.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarEscola.Location = new System.Drawing.Point(383, 164);
            this.buttonGuardarEscola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarEscola.Name = "buttonGuardarEscola";
            this.buttonGuardarEscola.Size = new System.Drawing.Size(133, 64);
            this.buttonGuardarEscola.TabIndex = 44;
            this.buttonGuardarEscola.Text = "Guardar";
            this.buttonGuardarEscola.UseVisualStyleBackColor = false;
            this.buttonGuardarEscola.Click += new System.EventHandler(this.buttonGuardarEscola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Morada:";
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(389, 73);
            this.textBoxCodPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodPostal.MaxLength = 10;
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(125, 22);
            this.textBoxCodPostal.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Localidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cod-Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(144, 134);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(371, 22);
            this.textBoxEmail.TabIndex = 43;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(144, 14);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(371, 22);
            this.textBoxNome.TabIndex = 38;
            // 
            // textBoxLocalidade
            // 
            this.textBoxLocalidade.Location = new System.Drawing.Point(144, 73);
            this.textBoxLocalidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocalidade.Name = "textBoxLocalidade";
            this.textBoxLocalidade.Size = new System.Drawing.Size(125, 22);
            this.textBoxLocalidade.TabIndex = 40;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(144, 43);
            this.textBoxMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(371, 22);
            this.textBoxMorada.TabIndex = 39;
            // 
            // panelAlunos
            // 
            this.panelAlunos.BackColor = System.Drawing.Color.Transparent;
            this.panelAlunos.Controls.Add(this.listBoxAlunos);
            this.panelAlunos.Controls.Add(this.l_labelAlunos);
            this.panelAlunos.Location = new System.Drawing.Point(968, 43);
            this.panelAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAlunos.Name = "panelAlunos";
            this.panelAlunos.Size = new System.Drawing.Size(459, 238);
            this.panelAlunos.TabIndex = 56;
            // 
            // listBoxAlunos
            // 
            this.listBoxAlunos.FormattingEnabled = true;
            this.listBoxAlunos.ItemHeight = 16;
            this.listBoxAlunos.Location = new System.Drawing.Point(20, 41);
            this.listBoxAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlunos.Name = "listBoxAlunos";
            this.listBoxAlunos.Size = new System.Drawing.Size(435, 180);
            this.listBoxAlunos.TabIndex = 58;
            // 
            // l_labelAlunos
            // 
            this.l_labelAlunos.AutoSize = true;
            this.l_labelAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_labelAlunos.Location = new System.Drawing.Point(15, 11);
            this.l_labelAlunos.Name = "l_labelAlunos";
            this.l_labelAlunos.Size = new System.Drawing.Size(73, 25);
            this.l_labelAlunos.TabIndex = 48;
            this.l_labelAlunos.Text = "Alunos";
            // 
            // buttonApagarEscola
            // 
            this.buttonApagarEscola.BackColor = System.Drawing.Color.Firebrick;
            this.buttonApagarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarEscola.ForeColor = System.Drawing.Color.White;
            this.buttonApagarEscola.Location = new System.Drawing.Point(299, 453);
            this.buttonApagarEscola.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarEscola.Name = "buttonApagarEscola";
            this.buttonApagarEscola.Size = new System.Drawing.Size(133, 64);
            this.buttonApagarEscola.TabIndex = 32;
            this.buttonApagarEscola.Text = "Apagar";
            this.buttonApagarEscola.UseVisualStyleBackColor = false;
            this.buttonApagarEscola.Click += new System.EventHandler(this.buttonApagarEscola_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(159, 453);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(135, 64);
            this.buttonEditar.TabIndex = 31;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.Color.White;
            this.buttonNovo.Location = new System.Drawing.Point(21, 453);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(133, 64);
            this.buttonNovo.TabIndex = 30;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // textBoxPesquisaEscolas
            // 
            this.textBoxPesquisaEscolas.Location = new System.Drawing.Point(89, 69);
            this.textBoxPesquisaEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaEscolas.Name = "textBoxPesquisaEscolas";
            this.textBoxPesquisaEscolas.Size = new System.Drawing.Size(341, 22);
            this.textBoxPesquisaEscolas.TabIndex = 28;
            this.textBoxPesquisaEscolas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisaEscolas_KeyPress);
            // 
            // listBoxEscolas
            // 
            this.listBoxEscolas.FormattingEnabled = true;
            this.listBoxEscolas.ItemHeight = 16;
            this.listBoxEscolas.Location = new System.Drawing.Point(20, 96);
            this.listBoxEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEscolas.Name = "listBoxEscolas";
            this.listBoxEscolas.Size = new System.Drawing.Size(411, 340);
            this.listBoxEscolas.TabIndex = 27;
            this.listBoxEscolas.SelectedIndexChanged += new System.EventHandler(this.listBoxEscolas_SelectedIndexChanged);
            // 
            // l_labelEscolas
            // 
            this.l_labelEscolas.AutoSize = true;
            this.l_labelEscolas.BackColor = System.Drawing.Color.Transparent;
            this.l_labelEscolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_labelEscolas.Location = new System.Drawing.Point(15, 43);
            this.l_labelEscolas.Name = "l_labelEscolas";
            this.l_labelEscolas.Size = new System.Drawing.Size(88, 25);
            this.l_labelEscolas.TabIndex = 26;
            this.l_labelEscolas.Text = "Escolas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listBoxEventos);
            this.panel1.Controls.Add(this.l_labelEventos);
            this.panel1.Location = new System.Drawing.Point(968, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 238);
            this.panel1.TabIndex = 57;
            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.ItemHeight = 16;
            this.listBoxEventos.Location = new System.Drawing.Point(20, 41);
            this.listBoxEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(435, 180);
            this.listBoxEventos.TabIndex = 58;
            // 
            // l_labelEventos
            // 
            this.l_labelEventos.AutoSize = true;
            this.l_labelEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_labelEventos.Location = new System.Drawing.Point(15, 11);
            this.l_labelEventos.Name = "l_labelEventos";
            this.l_labelEventos.Size = new System.Drawing.Size(181, 25);
            this.l_labelEventos.TabIndex = 48;
            this.l_labelEventos.Text = "Eventos Planeados";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.BackgroundImage = global::Bookids.Properties.Resources.baseline_autorenew_black_24dp;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(20, 69);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(29, 25);
            this.buttonRefresh.TabIndex = 58;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPesquisarEscolas
            // 
            this.buttonPesquisarEscolas.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesquisarEscolas.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.buttonPesquisarEscolas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisarEscolas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPesquisarEscolas.Location = new System.Drawing.Point(55, 69);
            this.buttonPesquisarEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesquisarEscolas.Name = "buttonPesquisarEscolas";
            this.buttonPesquisarEscolas.Size = new System.Drawing.Size(29, 25);
            this.buttonPesquisarEscolas.TabIndex = 29;
            // 
            // toolTipRefresh
            // 
            this.toolTipRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipRefresh.ToolTipTitle = "Limpar Filtro";
            // 
            // labelEscola
            // 
            this.labelEscola.AutoSize = true;
            this.labelEscola.BackColor = System.Drawing.Color.Transparent;
            this.labelEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscola.Location = new System.Drawing.Point(437, 117);
            this.labelEscola.Name = "labelEscola";
            this.labelEscola.Size = new System.Drawing.Size(96, 29);
            this.labelEscola.TabIndex = 59;
            this.labelEscola.Text = "Escola";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1435, 31);
            this.menuStrip1.TabIndex = 60;
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
            // GestaoEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelEscola);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAlunos);
            this.Controls.Add(this.buttonApagarEscola);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonPesquisarEscolas);
            this.Controls.Add(this.textBoxPesquisaEscolas);
            this.Controls.Add(this.listBoxEscolas);
            this.Controls.Add(this.l_labelEscolas);
            this.Controls.Add(this.panelEscola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoEscolas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Escolas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoEscolas_FormClosing);
            this.Load += new System.EventHandler(this.GestaoEscolas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GestaoEscolas_Paint);
            this.panelEscola.ResumeLayout(false);
            this.panelEscola.PerformLayout();
            this.panelAlunos.ResumeLayout(false);
            this.panelAlunos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelEscola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxLocalidade;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Button buttonGuardarEscola;
        private System.Windows.Forms.Panel panelAlunos;
        private System.Windows.Forms.Label l_labelAlunos;
        private System.Windows.Forms.Button buttonApagarEscola;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Panel buttonPesquisarEscolas;
        private System.Windows.Forms.TextBox textBoxPesquisaEscolas;
        private System.Windows.Forms.ListBox listBoxEscolas;
        private System.Windows.Forms.Label l_labelEscolas;
        private System.Windows.Forms.ListBox listBoxAlunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxEventos;
        private System.Windows.Forms.Label l_labelEventos;
        private System.Windows.Forms.Panel buttonRefresh;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelEscola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
    }
}