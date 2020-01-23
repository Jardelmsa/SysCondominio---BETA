namespace SysCondominio.APP
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMoradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMoradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 425);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(971, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.IconeGestao;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.icon_outsourcing;
            this.sobreToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.erro;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePagamentosToolStripMenuItem,
            this.relatóriosDePagamentosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources._20150218142428192978835;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // cadastroDePagamentosToolStripMenuItem
            // 
            this.cadastroDePagamentosToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.Banking_00017_A_icon_icons_com_59837;
            this.cadastroDePagamentosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDePagamentosToolStripMenuItem.Name = "cadastroDePagamentosToolStripMenuItem";
            this.cadastroDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cadastroDePagamentosToolStripMenuItem.Text = "Cadastro de Pagamentos";
            this.cadastroDePagamentosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePagamentosToolStripMenuItem_Click);
            // 
            // relatóriosDePagamentosToolStripMenuItem
            // 
            this.relatóriosDePagamentosToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.relatorios;
            this.relatóriosDePagamentosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.relatóriosDePagamentosToolStripMenuItem.Name = "relatóriosDePagamentosToolStripMenuItem";
            this.relatóriosDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.relatóriosDePagamentosToolStripMenuItem.Text = "Relatórios de Pagamentos";
            this.relatóriosDePagamentosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDePagamentosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMoradoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.Accept_Male_User_icon;
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroDeMoradoresToolStripMenuItem
            // 
            this.cadastroDeMoradoresToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.Cliente_;
            this.cadastroDeMoradoresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeMoradoresToolStripMenuItem.Name = "cadastroDeMoradoresToolStripMenuItem";
            this.cadastroDeMoradoresToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cadastroDeMoradoresToolStripMenuItem.Text = "Cadastro de Moradores";
            this.cadastroDeMoradoresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeMoradoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMoradoresToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMoradorToolStripMenuItem,
            this.consultarPagamentosToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.Autenticidade;
            this.consultasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarMoradorToolStripMenuItem
            // 
            this.consultarMoradorToolStripMenuItem.Image = global::SysCondominio.APP.Properties.Resources.user_icon;
            this.consultarMoradorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultarMoradorToolStripMenuItem.Name = "consultarMoradorToolStripMenuItem";
            this.consultarMoradorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarMoradorToolStripMenuItem.Text = "Consultar Morador";
            this.consultarMoradorToolStripMenuItem.Click += new System.EventHandler(this.consultarMoradorToolStripMenuItem_Click);
            // 
            // consultarPagamentosToolStripMenuItem
            // 
            this.consultarPagamentosToolStripMenuItem.Name = "consultarPagamentosToolStripMenuItem";
            this.consultarPagamentosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarPagamentosToolStripMenuItem.Text = "Caixa Mensal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysCondominio - v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDePagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMoradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMoradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPagamentosToolStripMenuItem;
    }
}