namespace UICleanProductsCompany
{
    partial class HomePage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nossaHistóriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoreButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarContarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminButton = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.StoreButton,
            this.AccountButton,
            this.ManageButton,
            this.AdminButton,
            this.ConfigurationsButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(471, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu Strip";
            // 
            // AboutButton
            // 
            this.AboutButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoToolStripMenuItem,
            this.nossaHistóriaToolStripMenuItem});
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(49, 20);
            this.AboutButton.Text = "Sobre";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.produçãoToolStripMenuItem.Text = "Lógistica/Produção";
            this.produçãoToolStripMenuItem.Click += new System.EventHandler(this.LogisticsProductionButtonClicked);
            // 
            // nossaHistóriaToolStripMenuItem
            // 
            this.nossaHistóriaToolStripMenuItem.Name = "nossaHistóriaToolStripMenuItem";
            this.nossaHistóriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nossaHistóriaToolStripMenuItem.Text = "Nossa História";
            this.nossaHistóriaToolStripMenuItem.Click += new System.EventHandler(this.AboutUsButtonClicked);
            // 
            // StoreButton
            // 
            this.StoreButton.Enabled = false;
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(41, 20);
            this.StoreButton.Text = "Loja";
            this.StoreButton.Click += new System.EventHandler(this.StoreButtonClicked);
            // 
            // AccountButton
            // 
            this.AccountButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.criarContarToolStripMenuItem});
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(51, 20);
            this.AccountButton.Text = "Conta";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Fazer Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginButtonClicked);
            // 
            // criarContarToolStripMenuItem
            // 
            this.criarContarToolStripMenuItem.Name = "criarContarToolStripMenuItem";
            this.criarContarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarContarToolStripMenuItem.Text = "Criar Conta";
            this.criarContarToolStripMenuItem.Click += new System.EventHandler(this.SignUpButtonClicked);
            // 
            // ManageButton
            // 
            this.ManageButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaToolStripMenuItem1,
            this.usuáriosToolStripMenuItem});
            this.ManageButton.Enabled = false;
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(44, 20);
            this.ManageButton.Text = "Gerir";
            // 
            // lojaToolStripMenuItem1
            // 
            this.lojaToolStripMenuItem1.Name = "lojaToolStripMenuItem1";
            this.lojaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.lojaToolStripMenuItem1.Text = "Loja";
            this.lojaToolStripMenuItem1.Click += new System.EventHandler(this.ManageStoreButtonClicked);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.ManageUsersButtonClicked);
            // 
            // AdminButton
            // 
            this.AdminButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaToolStripMenuItem2,
            this.serviçosToolStripMenuItem});
            this.AdminButton.Enabled = false;
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(81, 20);
            this.AdminButton.Text = "Administrar";
            // 
            // lojaToolStripMenuItem2
            // 
            this.lojaToolStripMenuItem2.Name = "lojaToolStripMenuItem2";
            this.lojaToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.lojaToolStripMenuItem2.Text = "Loja";
            this.lojaToolStripMenuItem2.Click += new System.EventHandler(this.AdminStoreButtonClicked);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.serviçosToolStripMenuItem.Text = "Usuários";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.AdminUsersButtonClicked);
            // 
            // ConfigurationsButton
            // 
            this.ConfigurationsButton.Name = "ConfigurationsButton";
            this.ConfigurationsButton.Size = new System.Drawing.Size(176, 20);
            this.ConfigurationsButton.Text = "Configurações/Acessibilidade";
            this.ConfigurationsButton.Click += new System.EventHandler(this.ConfigurationsButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.MinimumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nettoyage Limpezas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.MaximumSize = new System.Drawing.Size(225, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 126);
            this.label2.TabIndex = 5;
            this.label2.Text = "Use este aplicativo por meio dos botões acima, navegando através das páginas disp" +
    "oníveis para acesso, descobrindo mais sobre nós, comprando nossos incríveis prod" +
    "utos e se tornando um conosco!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UICleanProductsCompany.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(278, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "HomePage";
            this.Text = "Página Inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.Page_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoreButton;
        private System.Windows.Forms.ToolStripMenuItem AccountButton;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarContarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nossaHistóriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageButton;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminButton;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

