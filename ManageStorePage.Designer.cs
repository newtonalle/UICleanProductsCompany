namespace UICleanProductsCompany
{
    partial class ManageStorePage
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
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceHigherFilterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPriceLowerFilterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductTypeFilterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ShoppingListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShoppingPriceHigherFilterTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShoppingPriceLowerFilterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BuyerNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BuyerNameLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.CurrentShoppingItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShopItemsListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NewProductGroupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NewProductNameTextBox = new System.Windows.Forms.TextBox();
            this.NewProductTypeTextBox = new System.Windows.Forms.TextBox();
            this.NewProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteSelectedProductButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.CurrentShoppingItemsGroupBox.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.NewProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(9, 16);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(425, 212);
            this.ProductsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductsListBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deixe os campos vazios para nenhum filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // ProductNameFilterTextBox
            // 
            this.ProductNameFilterTextBox.Location = new System.Drawing.Point(6, 35);
            this.ProductNameFilterTextBox.Name = "ProductNameFilterTextBox";
            this.ProductNameFilterTextBox.Size = new System.Drawing.Size(214, 20);
            this.ProductNameFilterTextBox.TabIndex = 2;
            this.ProductNameFilterTextBox.TextChanged += new System.EventHandler(this.ShowProductsLoad);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ProductTypeFilterTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ProductNameFilterTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(454, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 244);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FIltro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ProductPriceHigherFilterTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ProductPriceLowerFilterTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 63);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Superior a";
            // 
            // ProductPriceHigherFilterTextBox
            // 
            this.ProductPriceHigherFilterTextBox.Location = new System.Drawing.Point(122, 33);
            this.ProductPriceHigherFilterTextBox.Name = "ProductPriceHigherFilterTextBox";
            this.ProductPriceHigherFilterTextBox.Size = new System.Drawing.Size(89, 20);
            this.ProductPriceHigherFilterTextBox.TabIndex = 8;
            this.ProductPriceHigherFilterTextBox.TextChanged += new System.EventHandler(this.ShowProductsLoad);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inferior a";
            // 
            // ProductPriceLowerFilterTextBox
            // 
            this.ProductPriceLowerFilterTextBox.Location = new System.Drawing.Point(6, 33);
            this.ProductPriceLowerFilterTextBox.Name = "ProductPriceLowerFilterTextBox";
            this.ProductPriceLowerFilterTextBox.Size = new System.Drawing.Size(95, 20);
            this.ProductPriceLowerFilterTextBox.TabIndex = 7;
            this.ProductPriceLowerFilterTextBox.TextChanged += new System.EventHandler(this.ShowProductsLoad);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // ProductTypeFilterTextBox
            // 
            this.ProductTypeFilterTextBox.Location = new System.Drawing.Point(6, 86);
            this.ProductTypeFilterTextBox.Name = "ProductTypeFilterTextBox";
            this.ProductTypeFilterTextBox.Size = new System.Drawing.Size(214, 20);
            this.ProductTypeFilterTextBox.TabIndex = 4;
            this.ProductTypeFilterTextBox.TextChanged += new System.EventHandler(this.ShowProductsLoad);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShoppingListBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 214);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compradores";
            // 
            // ShoppingListBox
            // 
            this.ShoppingListBox.FormattingEnabled = true;
            this.ShoppingListBox.Location = new System.Drawing.Point(6, 19);
            this.ShoppingListBox.Name = "ShoppingListBox";
            this.ShoppingListBox.Size = new System.Drawing.Size(255, 186);
            this.ShoppingListBox.TabIndex = 0;
            this.ShoppingListBox.SelectedIndexChanged += new System.EventHandler(this.ShoppingListBoxIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.BuyerNameFilterTextBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 160);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FIltro";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.ShoppingPriceHigherFilterTextBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.ShoppingPriceLowerFilterTextBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 63);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lucro Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Superior a";
            // 
            // ShoppingPriceHigherFilterTextBox
            // 
            this.ShoppingPriceHigherFilterTextBox.Location = new System.Drawing.Point(134, 33);
            this.ShoppingPriceHigherFilterTextBox.Name = "ShoppingPriceHigherFilterTextBox";
            this.ShoppingPriceHigherFilterTextBox.Size = new System.Drawing.Size(115, 20);
            this.ShoppingPriceHigherFilterTextBox.TabIndex = 8;
            this.ShoppingPriceHigherFilterTextBox.TextChanged += new System.EventHandler(this.ShowShoppingLoad);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inferior a";
            // 
            // ShoppingPriceLowerFilterTextBox
            // 
            this.ShoppingPriceLowerFilterTextBox.Location = new System.Drawing.Point(6, 33);
            this.ShoppingPriceLowerFilterTextBox.Name = "ShoppingPriceLowerFilterTextBox";
            this.ShoppingPriceLowerFilterTextBox.Size = new System.Drawing.Size(112, 20);
            this.ShoppingPriceLowerFilterTextBox.TabIndex = 7;
            this.ShoppingPriceLowerFilterTextBox.TextChanged += new System.EventHandler(this.ShowShoppingLoad);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Deixe os campos vazios para nenhum filtro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nome";
            // 
            // BuyerNameFilterTextBox
            // 
            this.BuyerNameFilterTextBox.Location = new System.Drawing.Point(6, 35);
            this.BuyerNameFilterTextBox.Name = "BuyerNameFilterTextBox";
            this.BuyerNameFilterTextBox.Size = new System.Drawing.Size(255, 20);
            this.BuyerNameFilterTextBox.TabIndex = 2;
            this.BuyerNameFilterTextBox.TextChanged += new System.EventHandler(this.ShowShoppingLoad);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Selecione um dos compradores para ver mais informações sobre a compra";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BuyerNameLabel);
            this.groupBox7.Controls.Add(this.TotalPriceLabel);
            this.groupBox7.Controls.Add(this.CurrentShoppingItemsGroupBox);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(284, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(587, 434);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Compra Selecionada";
            // 
            // BuyerNameLabel
            // 
            this.BuyerNameLabel.AutoSize = true;
            this.BuyerNameLabel.Location = new System.Drawing.Point(380, 192);
            this.BuyerNameLabel.Name = "BuyerNameLabel";
            this.BuyerNameLabel.Size = new System.Drawing.Size(107, 13);
            this.BuyerNameLabel.TabIndex = 11;
            this.BuyerNameLabel.Text = "Nome do Comprador:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(380, 236);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(60, 13);
            this.TotalPriceLabel.TabIndex = 10;
            this.TotalPriceLabel.Text = "Total: 0 R$";
            // 
            // CurrentShoppingItemsGroupBox
            // 
            this.CurrentShoppingItemsGroupBox.Controls.Add(this.ShopItemsListBox);
            this.CurrentShoppingItemsGroupBox.Location = new System.Drawing.Point(9, 55);
            this.CurrentShoppingItemsGroupBox.Name = "CurrentShoppingItemsGroupBox";
            this.CurrentShoppingItemsGroupBox.Size = new System.Drawing.Size(354, 352);
            this.CurrentShoppingItemsGroupBox.TabIndex = 9;
            this.CurrentShoppingItemsGroupBox.TabStop = false;
            this.CurrentShoppingItemsGroupBox.Text = "Items";
            // 
            // ShopItemsListBox
            // 
            this.ShopItemsListBox.FormattingEnabled = true;
            this.ShopItemsListBox.Location = new System.Drawing.Point(6, 19);
            this.ShopItemsListBox.Name = "ShopItemsListBox";
            this.ShopItemsListBox.Size = new System.Drawing.Size(342, 316);
            this.ShopItemsListBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 8;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Controls.Add(this.groupBox7);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Location = new System.Drawing.Point(12, 287);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(877, 426);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Administrar Compras em Andamento";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NewProductGroupBox);
            this.groupBox9.Controls.Add(this.DeleteSelectedProductButton);
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(877, 269);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Administrar Produtos";
            // 
            // NewProductGroupBox
            // 
            this.NewProductGroupBox.Controls.Add(this.label17);
            this.NewProductGroupBox.Controls.Add(this.label16);
            this.NewProductGroupBox.Controls.Add(this.FileNameTextBox);
            this.NewProductGroupBox.Controls.Add(this.label15);
            this.NewProductGroupBox.Controls.Add(this.label13);
            this.NewProductGroupBox.Controls.Add(this.label12);
            this.NewProductGroupBox.Controls.Add(this.label11);
            this.NewProductGroupBox.Controls.Add(this.NewProductNameTextBox);
            this.NewProductGroupBox.Controls.Add(this.NewProductTypeTextBox);
            this.NewProductGroupBox.Controls.Add(this.NewProductPriceTextBox);
            this.NewProductGroupBox.Controls.Add(this.button2);
            this.NewProductGroupBox.Location = new System.Drawing.Point(690, 19);
            this.NewProductGroupBox.Name = "NewProductGroupBox";
            this.NewProductGroupBox.Size = new System.Drawing.Size(181, 208);
            this.NewProductGroupBox.TabIndex = 11;
            this.NewProductGroupBox.TabStop = false;
            this.NewProductGroupBox.Text = "Novo Produto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 137);
            this.label17.MaximumSize = new System.Drawing.Size(170, 0);
            this.label17.MinimumSize = new System.Drawing.Size(20, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 26);
            this.label17.TabIndex = 12;
            this.label17.Text = "Arquivo deve ser importado a partir da pasta ProductImages";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(86, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Nome do Arquivo";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(87, 110);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(85, 20);
            this.FileNameTextBox.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(139, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Preço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tipo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nome";
            // 
            // NewProductNameTextBox
            // 
            this.NewProductNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.NewProductNameTextBox.Name = "NewProductNameTextBox";
            this.NewProductNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.NewProductNameTextBox.TabIndex = 3;
            // 
            // NewProductTypeTextBox
            // 
            this.NewProductTypeTextBox.Location = new System.Drawing.Point(6, 71);
            this.NewProductTypeTextBox.Name = "NewProductTypeTextBox";
            this.NewProductTypeTextBox.Size = new System.Drawing.Size(168, 20);
            this.NewProductTypeTextBox.TabIndex = 2;
            // 
            // NewProductPriceTextBox
            // 
            this.NewProductPriceTextBox.Location = new System.Drawing.Point(6, 110);
            this.NewProductPriceTextBox.Name = "NewProductPriceTextBox";
            this.NewProductPriceTextBox.Size = new System.Drawing.Size(75, 20);
            this.NewProductPriceTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Criar Produto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CreateProduct);
            // 
            // DeleteSelectedProductButton
            // 
            this.DeleteSelectedProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteSelectedProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedProductButton.Location = new System.Drawing.Point(690, 232);
            this.DeleteSelectedProductButton.Name = "DeleteSelectedProductButton";
            this.DeleteSelectedProductButton.Size = new System.Drawing.Size(181, 31);
            this.DeleteSelectedProductButton.TabIndex = 10;
            this.DeleteSelectedProductButton.Text = "Excluir Produto Selecionado";
            this.DeleteSelectedProductButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedProductButton.Click += new System.EventHandler(this.DeleteSelectedProduct);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManageStorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 716);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Name = "ManageStorePage";
            this.Text = "Gerenciar/Administrar Loja";
            this.Load += new System.EventHandler(this.Page_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.CurrentShoppingItemsGroupBox.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.NewProductGroupBox.ResumeLayout(false);
            this.NewProductGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductNameFilterTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceHigherFilterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductPriceLowerFilterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductTypeFilterTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox ShoppingListBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShoppingPriceHigherFilterTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShoppingPriceLowerFilterTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BuyerNameFilterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox NewProductGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NewProductNameTextBox;
        private System.Windows.Forms.TextBox NewProductTypeTextBox;
        private System.Windows.Forms.TextBox NewProductPriceTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteSelectedProductButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox ShopItemsListBox;
        private System.Windows.Forms.GroupBox CurrentShoppingItemsGroupBox;
        private System.Windows.Forms.Label BuyerNameLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label17;
    }
}