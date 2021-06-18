
namespace Bookids
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelClock = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnCLientesFilhos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnEscolas = new System.Windows.Forms.Button();
            this.btnAnimadores = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(888, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Image = global::Bookids.Properties.Resources.baseline_home_black_24dp;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(34, 27);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarRecenteToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoEventoToolStripMenuItem_Click);
            // 
            // editarRecenteToolStripMenuItem
            // 
            this.editarRecenteToolStripMenuItem.Name = "editarRecenteToolStripMenuItem";
            this.editarRecenteToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.editarRecenteToolStripMenuItem.Text = "Editar Recente";
            this.editarRecenteToolStripMenuItem.Click += new System.EventHandler(this.editarRecenteEventoToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelClock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelHora);
            this.panel2.Controls.Add(this.labelData);
            this.panel2.Controls.Add(this.btnEventos);
            this.panel2.Controls.Add(this.btnCLientesFilhos);
            this.panel2.Controls.Add(this.btnCompras);
            this.panel2.Controls.Add(this.btnProdutos);
            this.panel2.Controls.Add(this.btnEscolas);
            this.panel2.Controls.Add(this.btnAnimadores);
            this.panel2.Location = new System.Drawing.Point(427, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 443);
            this.panel2.TabIndex = 4;
            // 
            // panelClock
            // 
            this.panelClock.BackgroundImage = global::Bookids.Properties.Resources.baseline_watch_later_black_24dp;
            this.panelClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelClock.Location = new System.Drawing.Point(296, 377);
            this.panelClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(51, 42);
            this.panelClock.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bookids.Properties.Resources.baseline_watch_later_black_24dp;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(417, 457);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 62);
            this.panel3.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(292, 334);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(50, 20);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = "09:03";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(292, 302);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(93, 20);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "01-01-2021";
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(16, 302);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(267, 117);
            this.btnEventos.TabIndex = 5;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnCLientesFilhos
            // 
            this.btnCLientesFilhos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLientesFilhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLientesFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLientesFilhos.Location = new System.Drawing.Point(16, 14);
            this.btnCLientesFilhos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCLientesFilhos.Name = "btnCLientesFilhos";
            this.btnCLientesFilhos.Size = new System.Drawing.Size(267, 117);
            this.btnCLientesFilhos.TabIndex = 0;
            this.btnCLientesFilhos.Text = "Clientes/Filhos";
            this.btnCLientesFilhos.UseVisualStyleBackColor = false;
            this.btnCLientesFilhos.Click += new System.EventHandler(this.btnCLientesFilhos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(16, 160);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(127, 117);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(156, 160);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(127, 117);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnEscolas
            // 
            this.btnEscolas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEscolas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolas.Location = new System.Drawing.Point(296, 160);
            this.btnEscolas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEscolas.Name = "btnEscolas";
            this.btnEscolas.Size = new System.Drawing.Size(127, 117);
            this.btnEscolas.TabIndex = 4;
            this.btnEscolas.Text = "Escolas";
            this.btnEscolas.UseVisualStyleBackColor = false;
            this.btnEscolas.Click += new System.EventHandler(this.btnEscola_Click);
            // 
            // btnAnimadores
            // 
            this.btnAnimadores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnimadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimadores.Location = new System.Drawing.Point(296, 14);
            this.btnAnimadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimadores.Name = "btnAnimadores";
            this.btnAnimadores.Size = new System.Drawing.Size(127, 117);
            this.btnAnimadores.TabIndex = 1;
            this.btnAnimadores.Text = "Animadores";
            this.btnAnimadores.UseVisualStyleBackColor = false;
            this.btnAnimadores.Click += new System.EventHandler(this.btnAnimadores_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(20, 122);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 244);
            this.panel4.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 205);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eventos Próximos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "BooKids";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bookids.Properties.Resources.baseline_home_black_24dp1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(20, 390);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 111);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTiposToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnCLientesFilhos;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnEscolas;
        private System.Windows.Forms.Button btnAnimadores;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelClock;
    }
}

