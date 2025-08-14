using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class StorePage : Form
    {
        public StorePage()
        {
            InitializeComponent();
        }


        List<int> productIdsByIndex = new List<int>();
        List<int> productIdsinCartByIndex = new List<int>();

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

        public void ShowProductsInCart()
        {
            // Show users
            ShoppingCartListBox.Items.Clear();
            productIdsinCartByIndex.Clear();

            DataTable currentShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where idBuyer = {SharedValues.Instance.GetCurrentUserId()} and status = 'open'");
            if (currentShopping.Rows.Count <= 0)
            {
                ShoppingCartListBox.Items.Add("No products in cart");
                TotalPriceLabel.Text = "";
                return;
            }

            string jsonString = currentShopping.Rows[0][2].ToString();

            int[] convertedItemsJSON = JsonSerializer.Deserialize<int[]>(jsonString);

            foreach (int productId in convertedItemsJSON)
            {
                productIdsinCartByIndex.Add(productId);
                DataTable foundItem = new SQLFunctions().GetDataFromDatabase($"select * from products where id = {productId}");

                ShoppingCartListBox.Items.Add($"{foundItem.Rows[0][1].ToString()} ({foundItem.Rows[0][2].ToString()}) por {SharedValues.Instance.ConvertMoney(float.Parse(foundItem.Rows[0][3].ToString())).ToString("F2")} {SharedValues.Instance.GetCurrency()}");
            }

            TotalPriceLabel.Text = $"{SharedValues.Instance.ConvertMoney(SharedValues.Instance.TotalPrice(SharedValues.Instance.GetCurrentUserId())).ToString("F2")} {SharedValues.Instance.GetCurrency()}";
        }

        private void AddProductSelectedToCart(object sender, EventArgs e)
        {
            int selectedIndex = ProductsListBox.SelectedIndex;

            // Add product ID to respective compra

            if (selectedIndex == -1)
                return;

            int productId = productIdsByIndex[selectedIndex];

            DataTable oldShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where idBuyer = {SharedValues.Instance.GetCurrentUserId()} and status = 'open'");
            if (oldShopping.Rows.Count > 0)
            {
                // Update Existing Shopping

                // Add product to list

                string oldJsonString = oldShopping.Rows[0][2].ToString();
                List<int> convertedItems = JsonSerializer.Deserialize<List<int>>(oldJsonString);
                convertedItems.Add(productId);
                string newJsonString = JsonSerializer.Serialize(convertedItems);

                new SQLFunctions().GenericChangeDataInDatabase($"update currentShopping set idProducts = '{newJsonString}' where id = {oldShopping.Rows[0][0]}");
            }
            else
            {
                // Create new Shopping

                List<int> items = new List<int>();
                items.Add(productId);
                string newJsonString = JsonSerializer.Serialize(items);

                new SQLFunctions().GenericChangeDataInDatabase($"insert into currentShopping(idBuyer,idProducts,status) values({SharedValues.Instance.GetCurrentUserId()},'{newJsonString}','open')");
            }
            MessageBox.Show("Item adicionado ao carrinho!");
            ShowProductsInCart();
        }

        private void ConcludeShopping(object sender, EventArgs e)
        {
            DataTable oldShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where idBuyer = {SharedValues.Instance.GetCurrentUserId()} and status = 'open'");
            if (oldShopping.Rows.Count <= 0)
            {
                return;
            }

            MessageBox.Show($"Compra Finalizada, total de {SharedValues.Instance.ConvertMoney(SharedValues.Instance.TotalPrice(SharedValues.Instance.GetCurrentUserId())).ToString("F2")} {SharedValues.Instance.GetCurrency()}");

            if (oldShopping.Rows.Count > 0)
                new SQLFunctions().GenericChangeDataInDatabase($"update currentShopping set status = 'ended' where id = {oldShopping.Rows[0][0]}");

            ShowProductsInCart();
        }

        private void RemoveSelectedProductFromCart(object sender, EventArgs e)
        {

            DataTable oldShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where idBuyer = {SharedValues.Instance.GetCurrentUserId()} and status = 'open'");
            if (oldShopping.Rows.Count <= 0)
            {
                return;
            }

            string oldJsonString = oldShopping.Rows[0][2].ToString();
            List<int> convertedItems = JsonSerializer.Deserialize<List<int>>(oldJsonString);
            convertedItems.RemoveAt(ShoppingCartListBox.SelectedIndex);
            string newJsonString = JsonSerializer.Serialize(convertedItems);

            if (convertedItems.Count <= 0)
            {
                new SQLFunctions().GenericChangeDataInDatabase($"delete from currentShopping where id = {oldShopping.Rows[0][0]}");
            }
            else
            {
                new SQLFunctions().GenericChangeDataInDatabase($"update currentShopping set idProducts = '{newJsonString}' where id = {oldShopping.Rows[0][0]}");
            }

            ShowProductsInCart();
        }

        private void StorePage_Load(object sender, EventArgs e)
        {
            ShowProducts();
            ShowProductsInCart();
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);

            int permitionType = int.Parse(new SQLFunctions().GetDataFromDatabase($"select * from users where id = {SharedValues.Instance.GetCurrentUserId()}").Rows[0][4].ToString());


            ShowProducts();
            ShowProductsInCart();
        }

        private void ShowProductsLoad(object sender, EventArgs e)
        {
            ShowProducts();

        }

        private void ChangedSelection(object sender, EventArgs e)
        {
            try
            {
                new SQLFunctions().CreateTables();

                if (productIdsByIndex.Count > ProductsListBox.SelectedIndex && ProductsListBox.SelectedIndex != -1)
                {
                    int selectedId = productIdsByIndex[ProductsListBox.SelectedIndex];

                    DataTable foundProducts = new SQLFunctions().GetDataFromDatabase($"select * from products where id = {selectedId}");

                    string URL = foundProducts.Rows[0][4].ToString();
                    ProductImage.Load($@"..\..\ProductImages\{URL}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado (link inválido, não conectado ao banco ou falta de internet): " + ex);
            }
        }
    }
}
