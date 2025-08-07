using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class SharedValues : Form
    {
        public static SharedValues Instance;

        public static event EventHandler OnValueUpdate;

        private static int _loggedUserId = -1;

        public static int loggedUserId
        {
            get => _loggedUserId;
            private set
            {
                _loggedUserId = value;
                OnValueUpdate?.Invoke(null, null);
            }
        }

        public void LogIntoId(int id)
        {
            loggedUserId = id;
        }

        public int GetCurrentUserId()
        {
            return loggedUserId;
        }


        // App Configurations
        public int appVolume = 50;

        private static string _appTheme = "light"; // "light" or "dark"
        public static string appTheme
        {
            get => _appTheme;
            private set
            {
                _appTheme = value;
                OnValueUpdate?.Invoke(null, null);
            }
        }
        public void InvokeOnValueUpdate()
        {
            OnValueUpdate?.Invoke(null, null);
        }

        public float TotalPrice(int userId)
        {
            DataTable oldShopping = new SQLFunctions().GetDataFromDatabase($"select * from currentShopping where idBuyer = {userId} and status = 'open'");
            if (oldShopping.Rows.Count <= 0)
            {
                return -1;
            }
            float totalPrice = 0;
            List<int> convertedItems = JsonSerializer.Deserialize<List<int>>(oldShopping.Rows[0][2].ToString());
            foreach (int itemId in convertedItems)
            {
                DataTable foundItem = new SQLFunctions().GetDataFromDatabase($"select * from products where id = {itemId}");
                totalPrice += float.Parse(foundItem.Rows[0][3].ToString());
            }
            return totalPrice;
        }

        public void ChangeTextColor(Control.ControlCollection controls, Color textColor)
        {
            foreach (Control control in controls)
            {
                control.ForeColor = textColor;

                // Se o controle tiver controles filhos (como um Panel ou GroupBox), aplica recursivamente
                if (control.HasChildren)
                {
                    ChangeTextColor(control.Controls, textColor);
                }
            }
        }

        public void ChangeBackColor(Control.ControlCollection controls, Color backColor)
        {
            foreach (Control control in controls)
            {
                control.BackColor = backColor;

                // Se o controle tiver controles filhos (como um Panel ou GroupBox), aplica recursivamente
                if (control.HasChildren)
                {
                    ChangeBackColor(control.Controls, backColor);
                }
            }
        }

        public void UpdatePageTheme(Control.ControlCollection controls, Form form)
        {          
            if (appTheme == "light")
            {
                ChangeBackColor(controls, Color.White);
                ChangeTextColor(controls, Color.Black);
                form.BackColor = Color.White;
            }
            else
            {
                ChangeBackColor(controls, Color.Black);
                ChangeTextColor(controls, Color.White);
                form.BackColor = Color.Black;
            }
        }

        public void ChangeTheme(string theme)
        {
            appTheme = theme;
        }

        public string GetAppTheme() {
            return appTheme;
        }

        public void ChangeCurrency(string currency)
        {
            preferedCurrency = currency;
        }
        public string GetCurrency()
        {
            return preferedCurrency;
        }

        private static string _preferedCurrency = "R$"; // "R$", "$" or "£" 
        public static string preferedCurrency
        {
            get => _preferedCurrency;
            private set
            {
                _preferedCurrency = value;
                OnValueUpdate?.Invoke(null, null);
            }
        }

        public float ConvertMoney(float moneyReais)
        {
            float convertedMoney;
            switch (preferedCurrency)
            {
                case "R$":
                    convertedMoney = moneyReais;
                    break;
                case "$":
                    convertedMoney = moneyReais / 5.57f;
                    break;
                case "£":
                    convertedMoney = moneyReais / 7.49f;
                    break;
                default:
                    convertedMoney = moneyReais;
                    break;
            }
            return convertedMoney;
        }


        public SharedValues()
        {
            InitializeComponent();

            Instance = this;
        }
    }
}
