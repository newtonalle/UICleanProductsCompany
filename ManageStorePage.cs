using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class ManageStorePage : Form
    {
        public ManageStorePage()
        {
            InitializeComponent();

        }

        List<int> productIdsByIndex = new List<int>();
        List<int> shoppingIdsByIndex = new List<int>();

        private void CreateProduct(object sender, EventArgs e)
        {
            new SQLFunctions().GenericChangeDataInDatabase($"insert into products(name, type, price) values('{NewProductNameTextBox.Text}', '{NewProductTypeTextBox.Text}', {float.Parse(NewProductPriceTextBox.Text)})");
            ShowProducts();
            MessageBox.Show("Novo Produto Criado!");
        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);

            int permitionType = int.Parse(new SQLFunctions().GetDataFromDatabase($"select * from users where id = {SharedValues.Instance.GetCurrentUserId()}").Rows[0][4].ToString());

            switch (permitionType)
            {
                case 0:
                    {
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        NewProductGroupBox.Visible = false;
                        DeleteSelectedProductButton.Visible = false;
                        break;
                    }
                case 2:
                    {
                        NewProductGroupBox.Visible = true;
                        DeleteSelectedProductButton.Visible = true;

                        break;
                    }
                default:
                    break;
            }

            ShowProducts();
            ShowCurrentShopping();
        }
        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }

        public void ShowProducts()
        {
            // Show users
            ProductsListBox.Items.Clear();
            productIdsByIndex.Clear();

            DataTable foundProducts = new SQLFunctions().GetDataFromDatabase($"select * from products");
            foreach (DataRow products in foundProducts.Rows)
            {
                if ((ProductNameFilterTextBox.Text.Length <= 0 || products[1].ToString().ToLower().Contains(ProductNameFilterTextBox.Text.ToLower())) && (ProductTypeFilterTextBox.Text.Length <= 0 || products[2].ToString().ToLower().Contains(ProductTypeFilterTextBox.Text.ToLower())) && (ProductPriceHigherFilterTextBox.Text.Length <= 0 || float.Parse(products[3].ToString()) > float.Parse(ProductPriceHigherFilterTextBox.Text)) && (ProductPriceLowerFilterTextBox.Text.Length <= 0 || float.Parse(products[3].ToString()) < float.Parse(ProductPriceLowerFilterTextBox.Text)))
                {
                    productIdsByIndex.Add(int.Parse(products[0].ToString()));
                    ProductsListBox.Items.Add($"{products[1]} ({products[2]}) por {SharedValues.Instance.ConvertMoney(float.Parse(products[3].ToString())).ToString("F2")} {SharedValues.Instance.GetCurrency()}");
                }
            }
        }

        public void ShowCurrentShopping()
        {
            // Show users
            ShoppingListBox.Items.Clear();
            shoppingIdsByIndex.Clear();

            DataTable foundShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where status = 'open'");
            foreach (DataRow shopping in foundShopping.Rows)
            {
                int iloveyou = 1000;
                DataTable user = new SQLFunctions().GetDataFromDatabase($"select * from users where id = {shopping[1].ToString()}");

                string userName = user.Rows[0][1].ToString();

                float totalPrice = SharedValues.Instance.TotalPrice(int.Parse(shopping[1].ToString()));


                if ((BuyerNameFilterTextBox.Text.Length <= 0 || userName.ToLower().Contains(BuyerNameFilterTextBox.Text.ToLower())) && (ShoppingPriceHigherFilterTextBox.Text.Length <= 0 || totalPrice > float.Parse(ShoppingPriceHigherFilterTextBox.Text)) && (ShoppingPriceLowerFilterTextBox.Text.Length <= 0 || totalPrice < float.Parse(ShoppingPriceLowerFilterTextBox.Text)))
                {
                    shoppingIdsByIndex.Add(int.Parse(shopping[0].ToString()));
                    ShoppingListBox.Items.Add($"{userName}");
                }
            }
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            int selectedIndex = ProductsListBox.SelectedIndex;
            new SQLFunctions().GenericChangeDataInDatabase($"delete from products where id = {productIdsByIndex[selectedIndex]}");

            ShowProducts();

            MessageBox.Show("Product Deleted Successfully!");
        }

        private void ShowProductsLoad(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowShoppingLoad(object sender, EventArgs e)
        {
            ShowCurrentShopping();
        }

        private void ShoppingListBoxIndexChanged(object sender, EventArgs e)
        {
            ShopItemsListBox.Items.Clear();
            int shoppingId = shoppingIdsByIndex[ShoppingListBox.SelectedIndex];

            DataTable foundShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where id = {shoppingId}");

            DataTable user = new SQLFunctions().GetDataFromDatabase($"select * from users where id = {foundShopping.Rows[0][1].ToString()}");

            string userName = user.Rows[0][1].ToString();

            float totalPrice = SharedValues.Instance.TotalPrice(int.Parse(user.Rows[0][0].ToString()));          

            string jsonString = foundShopping.Rows[0][2].ToString();

            int[] convertedItemsJSON = JsonSerializer.Deserialize<int[]>(jsonString);

            foreach (int productId in convertedItemsJSON)
            {                
                DataTable foundItem = new SQLFunctions().GetDataFromDatabase($"select * from products where id = {productId}");

                ShopItemsListBox.Items.Add($"{foundItem.Rows[0][1].ToString()} ({foundItem.Rows[0][2].ToString()}) por {SharedValues.Instance.ConvertMoney(float.Parse(foundItem.Rows[0][3].ToString())).ToString("F2")} {SharedValues.Instance.GetCurrency()}");
            }

            TotalPriceLabel.Text = $"Total: {SharedValues.Instance.ConvertMoney(float.Parse(totalPrice.ToString())).ToString("F2")} {SharedValues.Instance.GetCurrency()}";
            BuyerNameLabel.Text = $"Comprador: {userName}";
        }
    }
}
