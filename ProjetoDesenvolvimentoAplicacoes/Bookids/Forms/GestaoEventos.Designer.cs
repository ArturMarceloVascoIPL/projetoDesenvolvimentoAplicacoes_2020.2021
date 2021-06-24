
namespace Bookids.Forms
{
    partial class GestaoEventos
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
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEvento = new System.Windows.Forms.Label();
            this.buttonExportFichaInsc = new System.Windows.Forms.Button();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.panelAnimadores = new System.Windows.Forms.Panel();
            this.comboBoxAnimadores = new System.Windows.Forms.ComboBox();
            this.buttonRemoverAnimador = new System.Windows.Forms.Button();
            this.buttonAdicionarAnimador = new System.Windows.Forms.Button();
            this.listBoxAnimadores = new System.Windows.Forms.ListBox();
            this._labelAnimadores = new System.Windows.Forms.Label();
            this.panelEscolas = new System.Windows.Forms.Panel();
            this.comboBoxEscolas = new System.Windows.Forms.ComboBox();
            this.buttonRemoverEscola = new System.Windows.Forms.Button();
            this.buttonAdicionarEscola = new System.Windows.Forms.Button();
            this.listBoxEscolas = new System.Windows.Forms.ListBox();
            this._labelEscolas = new System.Windows.Forms.Label();
            this.panelParticipantes = new System.Windows.Forms.Panel();
            this.panelPesquisaParticipantes = new System.Windows.Forms.Panel();
            this.textBoxPesquisaParticipantes = new System.Windows.Forms.TextBox();
            this.buttonExportInscritos = new System.Windows.Forms.Button();
            this.listBoxParticipantes = new System.Windows.Forms.ListBox();
            this._labelParticipantes = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Panel();
            this.buttonApagarEvento = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.textBoxPesquisaEventos = new System.Windows.Forms.TextBox();
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this._labelEventos = new System.Windows.Forms.Label();
            this.panelEvento = new System.Windows.Forms.Panel();
            this.textBoxIdadeMax = new System.Windows.Forms.TextBox();
            this._labelIdadeMax = new System.Windows.Forms.Label();
            this.textBoxIdadeMin = new System.Windows.Forms.TextBox();
            this._labelIdadeMin = new System.Windows.Forms.Label();
            this._labelIdades = new System.Windows.Forms.Label();
            this.textBoxTipoEvento = new System.Windows.Forms.TextBox();
            this.buttonGuardarEvento = new System.Windows.Forms.Button();
            this._labelDescrição = new System.Windows.Forms.Label();
            this._labelTipoEvento = new System.Windows.Forms.Label();
            this._labelLocal = new System.Windows.Forms.Label();
            this._labelDataHora = new System.Windows.Forms.Label();
            this._labelMaxParticipantes = new System.Windows.Forms.Label();
            this.textBoxMaxParticipantes = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.panelPesquisaEventos = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelAnimadores.SuspendLayout();
            this.panelEscolas.SuspendLayout();
            this.panelParticipantes.SuspendLayout();
            this.panelEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1849, 31);
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
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoTipoToolStripMenuItem_Click);
            // 
            // editarTiposToolStripMenuItem
            // 
            this.editarTiposToolStripMenuItem.Name = "editarTiposToolStripMenuItem";
            this.editarTiposToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.editarTiposToolStripMenuItem.Text = "Editar Tipos";
            this.editarTiposToolStripMenuItem.Click += new System.EventHandler(this.editarTiposToolStripMenuItem_Click);
            // 
            // labelEvento
            // 
            this.labelEvento.AutoSize = true;
            this.labelEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento.Location = new System.Drawing.Point(437, 130);
            this.labelEvento.Name = "labelEvento";
            this.labelEvento.Size = new System.Drawing.Size(98, 29);
            this.labelEvento.TabIndex = 23;
            this.labelEvento.Text = "Evento";
            // 
            // buttonExportFichaInsc
            // 
            this.buttonExportFichaInsc.BackColor = System.Drawing.Color.Gold;
            this.buttonExportFichaInsc.Enabled = false;
            this.buttonExportFichaInsc.Location = new System.Drawing.Point(19, 407);
            this.buttonExportFichaInsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportFichaInsc.Name = "buttonExportFichaInsc";
            this.buttonExportFichaInsc.Size = new System.Drawing.Size(133, 64);
            this.buttonExportFichaInsc.TabIndex = 51;
            this.buttonExportFichaInsc.Text = "Exportar Ficha de Inscrição";
            this.buttonExportFichaInsc.UseVisualStyleBackColor = false;
            this.buttonExportFichaInsc.Click += new System.EventHandler(this.btnExportFichaInsc_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerData.Location = new System.Drawing.Point(144, 133);
            this.dateTimePickerData.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(175, 22);
            this.dateTimePickerData.TabIndex = 42;
            // 
            // panelAnimadores
            // 
            this.panelAnimadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnimadores.Controls.Add(this.comboBoxAnimadores);
            this.panelAnimadores.Controls.Add(this.buttonRemoverAnimador);
            this.panelAnimadores.Controls.Add(this.buttonAdicionarAnimador);
            this.panelAnimadores.Controls.Add(this.listBoxAnimadores);
            this.panelAnimadores.Controls.Add(this._labelAnimadores);
            this.panelAnimadores.Enabled = false;
            this.panelAnimadores.Location = new System.Drawing.Point(969, 49);
            this.panelAnimadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAnimadores.Name = "panelAnimadores";
            this.panelAnimadores.Size = new System.Drawing.Size(426, 241);
            this.panelAnimadores.TabIndex = 22;
            // 
            // comboBoxAnimadores
            // 
            this.comboBoxAnimadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimadores.FormattingEnabled = true;
            this.comboBoxAnimadores.Location = new System.Drawing.Point(19, 192);
            this.comboBoxAnimadores.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAnimadores.Name = "comboBoxAnimadores";
            this.comboBoxAnimadores.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAnimadores.TabIndex = 21;
            // 
            // buttonRemoverAnimador
            // 
            this.buttonRemoverAnimador.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRemoverAnimador.ForeColor = System.Drawing.Color.White;
            this.buttonRemoverAnimador.Location = new System.Drawing.Point(324, 172);
            this.buttonRemoverAnimador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoverAnimador.Name = "buttonRemoverAnimador";
            this.buttonRemoverAnimador.Size = new System.Drawing.Size(93, 62);
            this.buttonRemoverAnimador.TabIndex = 20;
            this.buttonRemoverAnimador.Text = "Remover";
            this.buttonRemoverAnimador.UseVisualStyleBackColor = false;
            this.buttonRemoverAnimador.Click += new System.EventHandler(this.buttonRemoverAnimador_Click);
            // 
            // buttonAdicionarAnimador
            // 
            this.buttonAdicionarAnimador.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdicionarAnimador.Location = new System.Drawing.Point(225, 172);
            this.buttonAdicionarAnimador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarAnimador.Name = "buttonAdicionarAnimador";
            this.buttonAdicionarAnimador.Size = new System.Drawing.Size(93, 62);
            this.buttonAdicionarAnimador.TabIndex = 18;
            this.buttonAdicionarAnimador.Text = "Adicionar";
            this.buttonAdicionarAnimador.UseVisualStyleBackColor = false;
            this.buttonAdicionarAnimador.Click += new System.EventHandler(this.buttonAdicionarAnimador_Click);
            // 
            // listBoxAnimadores
            // 
            this.listBoxAnimadores.FormattingEnabled = true;
            this.listBoxAnimadores.ItemHeight = 16;
            this.listBoxAnimadores.Location = new System.Drawing.Point(17, 34);
            this.listBoxAnimadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAnimadores.Name = "listBoxAnimadores";
            this.listBoxAnimadores.Size = new System.Drawing.Size(399, 132);
            this.listBoxAnimadores.TabIndex = 16;
            // 
            // _labelAnimadores
            // 
            this._labelAnimadores.AutoSize = true;
            this._labelAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelAnimadores.Location = new System.Drawing.Point(13, 7);
            this._labelAnimadores.Name = "_labelAnimadores";
            this._labelAnimadores.Size = new System.Drawing.Size(117, 25);
            this._labelAnimadores.TabIndex = 15;
            this._labelAnimadores.Text = "Animadores";
            // 
            // panelEscolas
            // 
            this.panelEscolas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEscolas.Controls.Add(this.comboBoxEscolas);
            this.panelEscolas.Controls.Add(this.buttonRemoverEscola);
            this.panelEscolas.Controls.Add(this.buttonAdicionarEscola);
            this.panelEscolas.Controls.Add(this.listBoxEscolas);
            this.panelEscolas.Controls.Add(this._labelEscolas);
            this.panelEscolas.Enabled = false;
            this.panelEscolas.Location = new System.Drawing.Point(969, 298);
            this.panelEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEscolas.Name = "panelEscolas";
            this.panelEscolas.Size = new System.Drawing.Size(426, 241);
            this.panelEscolas.TabIndex = 23;
            // 
            // comboBoxEscolas
            // 
            this.comboBoxEscolas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEscolas.FormattingEnabled = true;
            this.comboBoxEscolas.Location = new System.Drawing.Point(19, 192);
            this.comboBoxEscolas.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEscolas.Name = "comboBoxEscolas";
            this.comboBoxEscolas.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEscolas.TabIndex = 21;
            // 
            // buttonRemoverEscola
            // 
            this.buttonRemoverEscola.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRemoverEscola.ForeColor = System.Drawing.Color.White;
            this.buttonRemoverEscola.Location = new System.Drawing.Point(324, 172);
            this.buttonRemoverEscola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoverEscola.Name = "buttonRemoverEscola";
            this.buttonRemoverEscola.Size = new System.Drawing.Size(93, 62);
            this.buttonRemoverEscola.TabIndex = 20;
            this.buttonRemoverEscola.Text = "Remover";
            this.buttonRemoverEscola.UseVisualStyleBackColor = false;
            this.buttonRemoverEscola.Click += new System.EventHandler(this.buttonRemoverEscola_Click);
            // 
            // buttonAdicionarEscola
            // 
            this.buttonAdicionarEscola.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdicionarEscola.Location = new System.Drawing.Point(225, 172);
            this.buttonAdicionarEscola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarEscola.Name = "buttonAdicionarEscola";
            this.buttonAdicionarEscola.Size = new System.Drawing.Size(93, 62);
            this.buttonAdicionarEscola.TabIndex = 18;
            this.buttonAdicionarEscola.Text = "Adicionar";
            this.buttonAdicionarEscola.UseVisualStyleBackColor = false;
            this.buttonAdicionarEscola.Click += new System.EventHandler(this.buttonAdicionarEscola_Click);
            // 
            // listBoxEscolas
            // 
            this.listBoxEscolas.FormattingEnabled = true;
            this.listBoxEscolas.ItemHeight = 16;
            this.listBoxEscolas.Location = new System.Drawing.Point(17, 34);
            this.listBoxEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEscolas.Name = "listBoxEscolas";
            this.listBoxEscolas.Size = new System.Drawing.Size(399, 132);
            this.listBoxEscolas.TabIndex = 16;
            // 
            // _labelEscolas
            // 
            this._labelEscolas.AutoSize = true;
            this._labelEscolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEscolas.Location = new System.Drawing.Point(13, 7);
            this._labelEscolas.Name = "_labelEscolas";
            this._labelEscolas.Size = new System.Drawing.Size(81, 25);
            this._labelEscolas.TabIndex = 15;
            this._labelEscolas.Text = "Escolas";
            // 
            // panelParticipantes
            // 
            this.panelParticipantes.Controls.Add(this.panelPesquisaParticipantes);
            this.panelParticipantes.Controls.Add(this.textBoxPesquisaParticipantes);
            this.panelParticipantes.Controls.Add(this.buttonExportInscritos);
            this.panelParticipantes.Controls.Add(this.listBoxParticipantes);
            this.panelParticipantes.Controls.Add(this._labelParticipantes);
            this.panelParticipantes.Controls.Add(this.buttonExportFichaInsc);
            this.panelParticipantes.Location = new System.Drawing.Point(1401, 49);
            this.panelParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelParticipantes.Name = "panelParticipantes";
            this.panelParticipantes.Size = new System.Drawing.Size(445, 490);
            this.panelParticipantes.TabIndex = 24;
            // 
            // panelPesquisaParticipantes
            // 
            this.panelPesquisaParticipantes.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panelPesquisaParticipantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPesquisaParticipantes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelPesquisaParticipantes.Location = new System.Drawing.Point(19, 34);
            this.panelPesquisaParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPesquisaParticipantes.Name = "panelPesquisaParticipantes";
            this.panelPesquisaParticipantes.Size = new System.Drawing.Size(29, 25);
            this.panelPesquisaParticipantes.TabIndex = 69;
            // 
            // textBoxPesquisaParticipantes
            // 
            this.textBoxPesquisaParticipantes.Location = new System.Drawing.Point(53, 34);
            this.textBoxPesquisaParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaParticipantes.Name = "textBoxPesquisaParticipantes";
            this.textBoxPesquisaParticipantes.Size = new System.Drawing.Size(376, 22);
            this.textBoxPesquisaParticipantes.TabIndex = 68;
            // 
            // buttonExportInscritos
            // 
            this.buttonExportInscritos.BackColor = System.Drawing.Color.Gold;
            this.buttonExportInscritos.Enabled = false;
            this.buttonExportInscritos.Location = new System.Drawing.Point(297, 407);
            this.buttonExportInscritos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportInscritos.Name = "buttonExportInscritos";
            this.buttonExportInscritos.Size = new System.Drawing.Size(133, 64);
            this.buttonExportInscritos.TabIndex = 20;
            this.buttonExportInscritos.Text = "Exportar Lista de Participantes";
            this.buttonExportInscritos.UseVisualStyleBackColor = false;
            this.buttonExportInscritos.Click += new System.EventHandler(this.btnExportInscritos_Click);
            // 
            // listBoxParticipantes
            // 
            this.listBoxParticipantes.FormattingEnabled = true;
            this.listBoxParticipantes.ItemHeight = 16;
            this.listBoxParticipantes.Location = new System.Drawing.Point(19, 62);
            this.listBoxParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxParticipantes.Name = "listBoxParticipantes";
            this.listBoxParticipantes.Size = new System.Drawing.Size(411, 340);
            this.listBoxParticipantes.TabIndex = 16;
            // 
            // _labelParticipantes
            // 
            this._labelParticipantes.AutoSize = true;
            this._labelParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelParticipantes.Location = new System.Drawing.Point(13, 7);
            this._labelParticipantes.Name = "_labelParticipantes";
            this._labelParticipantes.Size = new System.Drawing.Size(124, 25);
            this._labelParticipantes.TabIndex = 15;
            this._labelParticipantes.Text = "Participantes";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.BackgroundImage = global::Bookids.Properties.Resources.baseline_autorenew_black_24dp;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(20, 68);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(29, 25);
            this.buttonRefresh.TabIndex = 66;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonApagarEvento
            // 
            this.buttonApagarEvento.BackColor = System.Drawing.Color.Firebrick;
            this.buttonApagarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarEvento.ForeColor = System.Drawing.Color.White;
            this.buttonApagarEvento.Location = new System.Drawing.Point(299, 452);
            this.buttonApagarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagarEvento.Name = "buttonApagarEvento";
            this.buttonApagarEvento.Size = new System.Drawing.Size(133, 64);
            this.buttonApagarEvento.TabIndex = 3;
            this.buttonApagarEvento.Text = "Apagar";
            this.buttonApagarEvento.UseVisualStyleBackColor = false;
            this.buttonApagarEvento.Click += new System.EventHandler(this.buttonApagarEvento_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEditar.Location = new System.Drawing.Point(159, 452);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(135, 64);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNovo.Location = new System.Drawing.Point(20, 452);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(133, 64);
            this.buttonNovo.TabIndex = 1;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // textBoxPesquisaEventos
            // 
            this.textBoxPesquisaEventos.Location = new System.Drawing.Point(89, 68);
            this.textBoxPesquisaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaEventos.Name = "textBoxPesquisaEventos";
            this.textBoxPesquisaEventos.Size = new System.Drawing.Size(341, 22);
            this.textBoxPesquisaEventos.TabIndex = 61;
            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.ItemHeight = 16;
            this.listBoxEventos.Location = new System.Drawing.Point(20, 95);
            this.listBoxEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(411, 340);
            this.listBoxEventos.TabIndex = 60;
            this.listBoxEventos.SelectedIndexChanged += new System.EventHandler(this.listBoxEventos_SelectedIndexChanged);
            // 
            // _labelEventos
            // 
            this._labelEventos.AutoSize = true;
            this._labelEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEventos.Location = new System.Drawing.Point(15, 42);
            this._labelEventos.Name = "_labelEventos";
            this._labelEventos.Size = new System.Drawing.Size(90, 25);
            this._labelEventos.TabIndex = 59;
            this._labelEventos.Text = "Eventos";
            // 
            // panelEvento
            // 
            this.panelEvento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEvento.Controls.Add(this.textBoxIdadeMax);
            this.panelEvento.Controls.Add(this._labelIdadeMax);
            this.panelEvento.Controls.Add(this.textBoxIdadeMin);
            this.panelEvento.Controls.Add(this._labelIdadeMin);
            this.panelEvento.Controls.Add(this._labelIdades);
            this.panelEvento.Controls.Add(this.textBoxTipoEvento);
            this.panelEvento.Controls.Add(this.buttonGuardarEvento);
            this.panelEvento.Controls.Add(this._labelDescrição);
            this.panelEvento.Controls.Add(this._labelTipoEvento);
            this.panelEvento.Controls.Add(this._labelLocal);
            this.panelEvento.Controls.Add(this._labelDataHora);
            this.panelEvento.Controls.Add(this._labelMaxParticipantes);
            this.panelEvento.Controls.Add(this.textBoxMaxParticipantes);
            this.panelEvento.Controls.Add(this.textBoxDescricao);
            this.panelEvento.Controls.Add(this.dateTimePickerData);
            this.panelEvento.Controls.Add(this.textBoxLocal);
            this.panelEvento.Enabled = false;
            this.panelEvento.Location = new System.Drawing.Point(436, 164);
            this.panelEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEvento.Name = "panelEvento";
            this.panelEvento.Size = new System.Drawing.Size(528, 238);
            this.panelEvento.TabIndex = 67;
            // 
            // textBoxIdadeMax
            // 
            this.textBoxIdadeMax.Location = new System.Drawing.Point(401, 132);
            this.textBoxIdadeMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdadeMax.MaxLength = 3;
            this.textBoxIdadeMax.Name = "textBoxIdadeMax";
            this.textBoxIdadeMax.Size = new System.Drawing.Size(113, 22);
            this.textBoxIdadeMax.TabIndex = 56;
            this.textBoxIdadeMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdadeMax_KeyPress);
            // 
            // _labelIdadeMax
            // 
            this._labelIdadeMax.AutoSize = true;
            this._labelIdadeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelIdadeMax.Location = new System.Drawing.Point(347, 133);
            this._labelIdadeMax.Name = "_labelIdadeMax";
            this._labelIdadeMax.Size = new System.Drawing.Size(45, 20);
            this._labelIdadeMax.TabIndex = 55;
            this._labelIdadeMax.Text = "Max:";
            // 
            // textBoxIdadeMin
            // 
            this.textBoxIdadeMin.Location = new System.Drawing.Point(401, 102);
            this.textBoxIdadeMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdadeMin.MaxLength = 3;
            this.textBoxIdadeMin.Name = "textBoxIdadeMin";
            this.textBoxIdadeMin.Size = new System.Drawing.Size(113, 22);
            this.textBoxIdadeMin.TabIndex = 54;
            this.textBoxIdadeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdadeMin_KeyPress);
            // 
            // _labelIdadeMin
            // 
            this._labelIdadeMin.AutoSize = true;
            this._labelIdadeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelIdadeMin.Location = new System.Drawing.Point(351, 103);
            this._labelIdadeMin.Name = "_labelIdadeMin";
            this._labelIdadeMin.Size = new System.Drawing.Size(41, 20);
            this._labelIdadeMin.TabIndex = 53;
            this._labelIdadeMin.Text = "Min:";
            // 
            // _labelIdades
            // 
            this._labelIdades.AutoSize = true;
            this._labelIdades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelIdades.Location = new System.Drawing.Point(273, 103);
            this._labelIdades.Name = "_labelIdades";
            this._labelIdades.Size = new System.Drawing.Size(63, 20);
            this._labelIdades.TabIndex = 52;
            this._labelIdades.Text = "Idades:";
            // 
            // textBoxTipoEvento
            // 
            this.textBoxTipoEvento.Location = new System.Drawing.Point(144, 73);
            this.textBoxTipoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTipoEvento.Name = "textBoxTipoEvento";
            this.textBoxTipoEvento.Size = new System.Drawing.Size(371, 22);
            this.textBoxTipoEvento.TabIndex = 6;
            // 
            // buttonGuardarEvento
            // 
            this.buttonGuardarEvento.Location = new System.Drawing.Point(383, 164);
            this.buttonGuardarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarEvento.Name = "buttonGuardarEvento";
            this.buttonGuardarEvento.Size = new System.Drawing.Size(133, 64);
            this.buttonGuardarEvento.TabIndex = 44;
            this.buttonGuardarEvento.Text = "Guardar";
            this.buttonGuardarEvento.UseVisualStyleBackColor = false;
            this.buttonGuardarEvento.Click += new System.EventHandler(this.buttonGuardarEvento_Click);
            // 
            // _labelDescrição
            // 
            this._labelDescrição.AutoSize = true;
            this._labelDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrição.Location = new System.Drawing.Point(16, 15);
            this._labelDescrição.Name = "_labelDescrição";
            this._labelDescrição.Size = new System.Drawing.Size(91, 20);
            this._labelDescrição.TabIndex = 32;
            this._labelDescrição.Text = "Descrição:";
            // 
            // _labelTipoEvento
            // 
            this._labelTipoEvento.AutoSize = true;
            this._labelTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTipoEvento.Location = new System.Drawing.Point(16, 75);
            this._labelTipoEvento.Name = "_labelTipoEvento";
            this._labelTipoEvento.Size = new System.Drawing.Size(46, 20);
            this._labelTipoEvento.TabIndex = 46;
            this._labelTipoEvento.Text = "Tipo:";
            // 
            // _labelLocal
            // 
            this._labelLocal.AutoSize = true;
            this._labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLocal.Location = new System.Drawing.Point(16, 44);
            this._labelLocal.Name = "_labelLocal";
            this._labelLocal.Size = new System.Drawing.Size(55, 20);
            this._labelLocal.TabIndex = 33;
            this._labelLocal.Text = "Local:";
            // 
            // _labelDataHora
            // 
            this._labelDataHora.AutoSize = true;
            this._labelDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDataHora.Location = new System.Drawing.Point(16, 134);
            this._labelDataHora.Name = "_labelDataHora";
            this._labelDataHora.Size = new System.Drawing.Size(106, 20);
            this._labelDataHora.TabIndex = 34;
            this._labelDataHora.Text = "Data e Hora:";
            // 
            // _labelMaxParticipantes
            // 
            this._labelMaxParticipantes.AutoSize = true;
            this._labelMaxParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelMaxParticipantes.Location = new System.Drawing.Point(16, 103);
            this._labelMaxParticipantes.Name = "_labelMaxParticipantes";
            this._labelMaxParticipantes.Size = new System.Drawing.Size(148, 20);
            this._labelMaxParticipantes.TabIndex = 35;
            this._labelMaxParticipantes.Text = "Max Participantes:";
            // 
            // textBoxMaxParticipantes
            // 
            this.textBoxMaxParticipantes.Location = new System.Drawing.Point(185, 102);
            this.textBoxMaxParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxParticipantes.MaxLength = 5;
            this.textBoxMaxParticipantes.Name = "textBoxMaxParticipantes";
            this.textBoxMaxParticipantes.Size = new System.Drawing.Size(77, 22);
            this.textBoxMaxParticipantes.TabIndex = 7;
            this.textBoxMaxParticipantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxParticipantes_KeyPress);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(144, 14);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(371, 22);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(144, 43);
            this.textBoxLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(371, 22);
            this.textBoxLocal.TabIndex = 5;
            // 
            // panelPesquisaEventos
            // 
            this.panelPesquisaEventos.BackgroundImage = global::Bookids.Properties.Resources.baseline_search_black_24dp;
            this.panelPesquisaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPesquisaEventos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelPesquisaEventos.Location = new System.Drawing.Point(55, 68);
            this.panelPesquisaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPesquisaEventos.Name = "panelPesquisaEventos";
            this.panelPesquisaEventos.Size = new System.Drawing.Size(29, 25);
            this.panelPesquisaEventos.TabIndex = 70;
            // 
            // GestaoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 544);
            this.Controls.Add(this.panelPesquisaEventos);
            this.Controls.Add(this.panelParticipantes);
            this.Controls.Add(this.panelEvento);
            this.Controls.Add(this.panelAnimadores);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelEscolas);
            this.Controls.Add(this.buttonApagarEvento);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.textBoxPesquisaEventos);
            this.Controls.Add(this.listBoxEventos);
            this.Controls.Add(this._labelEventos);
            this.Controls.Add(this.labelEvento);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GestaoEventos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao de Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoEventos_FormClosing);
            this.Load += new System.EventHandler(this.GestaoEventos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAnimadores.ResumeLayout(false);
            this.panelAnimadores.PerformLayout();
            this.panelEscolas.ResumeLayout(false);
            this.panelEscolas.PerformLayout();
            this.panelParticipantes.ResumeLayout(false);
            this.panelParticipantes.PerformLayout();
            this.panelEvento.ResumeLayout(false);
            this.panelEvento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
        private System.Windows.Forms.Label labelEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonExportFichaInsc;
        private System.Windows.Forms.Panel panelAnimadores;
        private System.Windows.Forms.Button buttonRemoverAnimador;
        private System.Windows.Forms.Button buttonAdicionarAnimador;
        private System.Windows.Forms.ListBox listBoxAnimadores;
        private System.Windows.Forms.Label _labelAnimadores;
        private System.Windows.Forms.Panel panelEscolas;
        private System.Windows.Forms.Button buttonRemoverEscola;
        private System.Windows.Forms.Button buttonAdicionarEscola;
        private System.Windows.Forms.ListBox listBoxEscolas;
        private System.Windows.Forms.Label _labelEscolas;
        private System.Windows.Forms.Panel panelParticipantes;
        private System.Windows.Forms.Button buttonExportInscritos;
        private System.Windows.Forms.ListBox listBoxParticipantes;
        private System.Windows.Forms.Label _labelParticipantes;
        private System.Windows.Forms.Panel buttonRefresh;
        private System.Windows.Forms.Button buttonApagarEvento;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.TextBox textBoxPesquisaEventos;
        private System.Windows.Forms.ListBox listBoxEventos;
        private System.Windows.Forms.Label _labelEventos;
        private System.Windows.Forms.Panel panelEvento;
        private System.Windows.Forms.TextBox textBoxTipoEvento;
        private System.Windows.Forms.Button buttonGuardarEvento;
        private System.Windows.Forms.Label _labelDescrição;
        private System.Windows.Forms.Label _labelTipoEvento;
        private System.Windows.Forms.Label _labelLocal;
        private System.Windows.Forms.Label _labelDataHora;
        private System.Windows.Forms.Label _labelMaxParticipantes;
        private System.Windows.Forms.TextBox textBoxMaxParticipantes;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxIdadeMax;
        private System.Windows.Forms.Label _labelIdadeMax;
        private System.Windows.Forms.TextBox textBoxIdadeMin;
        private System.Windows.Forms.Label _labelIdadeMin;
        private System.Windows.Forms.Label _labelIdades;
        private System.Windows.Forms.Panel panelPesquisaParticipantes;
        private System.Windows.Forms.TextBox textBoxPesquisaParticipantes;
        private System.Windows.Forms.Panel panelPesquisaEventos;
        private System.Windows.Forms.ComboBox comboBoxAnimadores;
        private System.Windows.Forms.ComboBox comboBoxEscolas;
    }
}