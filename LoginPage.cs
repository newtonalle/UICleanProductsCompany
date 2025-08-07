using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);
        }
        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }

        private void Login(object sender, EventArgs e)
        {
            DataTable foundUsers = new SQLFunctions().GetDataFromDatabase($"select * from users where email = '{EmailTextBox.Text}'");
            if(foundUsers.Rows.Count > 0)
            {

                string password = PasswordTextBox.Text;                

                bool correctPassword = BCrypt.Net.BCrypt.Verify(password, foundUsers.Rows[0][3].ToString());

                if (correctPassword)
                {                    
                    MessageBox.Show($"Bem-Vindo(a), {foundUsers.Rows[0][1].ToString()}!");
                    SharedValues.Instance.LogIntoId(int.Parse(foundUsers.Rows[0][0].ToString()));
                    HomePage.Instance.LoggedIn(int.Parse(foundUsers.Rows[0][4].ToString()));
                    DataTable savedConfigurations = new SQLFunctions().GetDataFromDatabase($"select * from configuration where userId = {int.Parse(foundUsers.Rows[0][0].ToString())}");
                    if(savedConfigurations.Rows.Count > 0)
                    {
                        SharedValues.Instance.ChangeTheme(savedConfigurations.Rows[0][2].ToString());
                        SharedValues.Instance.appVolume = int.Parse(savedConfigurations.Rows[0][3].ToString());
                        SharedValues.Instance.ChangeCurrency(savedConfigurations.Rows[0][4].ToString());
                    }
                    new SQLFunctions().GenericChangeDataInDatabase($"update users set isCurrentlyLoggedIn = true where id = {SharedValues.Instance.GetCurrentUserId()}");
                    this.Close();


                } else
                {
                    MessageBox.Show("Senha incorreta!");
                }
            } else
            {
                MessageBox.Show("Email inserido está incorreto!");
            }
        }
    }
}
