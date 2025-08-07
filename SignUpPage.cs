using System;
using System.Data;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void CreateUser(object sender, EventArgs e)
        {

            DataTable foundUsers = new SQLFunctions().GetDataFromDatabase($"select * from users where email = '{EmailTextBox.Text}'");
            if (foundUsers.Rows.Count > 0)
            {
                MessageBox.Show("Já existe um usuário com este email!");
                return;
            }

            if (PasswordTextBox.Text.Length < 7)
            {
                MessageBox.Show("Insira uma senha com mais que 6 caractéres!");
                return;
            }

            if (PasswordConfirmationTextBox.Text == PasswordTextBox.Text)
            {
                int userType = 0;
                if (AdminRadioButton.Checked)
                {
                    userType = 2;
                }
                else if (ManagerRadioButton.Checked)
                {
                    userType = 1;
                }
                else
                {
                    userType = 0;
                }

                string password = PasswordTextBox.Text;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                new SQLFunctions().GenericChangeDataInDatabase($"insert into users(username,email,password,type) values('{NameTextBox.Text}', '{EmailTextBox.Text}', '{hashedPassword}', {userType})");
                MessageBox.Show("Novo Usuário criado com sucesso");
            }

            else
            {
                MessageBox.Show("A senha de confirmação é diferente da senha inserida");
            }

        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);

            // Load page according to current permitions

            if (SharedValues.Instance.GetCurrentUserId() != -1)
            {
                int permitionType = int.Parse(new SQLFunctions().GetDataFromDatabase($"select * from users where id = {SharedValues.Instance.GetCurrentUserId()}").Rows[0][4].ToString());

                switch (permitionType)
                {
                    case 0:
                        {
                            AdminRadioButton.Enabled = false;
                            ManagerRadioButton.Enabled = false;
                            break;
                        }
                    case 1:
                        {
                            AdminRadioButton.Enabled = false;
                            ManagerRadioButton.Enabled = false;
                            break;
                        }
                    case 2:
                        {
                            AdminRadioButton.Enabled = true;
                            ManagerRadioButton.Enabled = true;
                            break;
                        }
                    default:
                        break;
                }
            } else
            {
                AdminRadioButton.Enabled = false;
                ManagerRadioButton.Enabled = false;
            }
        }
        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }
    }
}
