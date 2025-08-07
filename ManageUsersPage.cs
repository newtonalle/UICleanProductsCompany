using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class ManageUsersPage : Form
    {
        public ManageUsersPage()
        {
            InitializeComponent();
        }

        List<int> userIdsByIndex = new List<int>();

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);

            // Load page according to current permitions

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
                        DeleteUserButton.Visible = false;
                        break;
                    }
                case 2:
                    {
                        DeleteUserButton.Visible = true;
                        break;
                    }
                default:
                    break;
            }

            // Show users

            ShowUsers();
        }

        public void ShowUsers()
        {
            // Show users
            UsersListBox.Items.Clear();
            userIdsByIndex.Clear();

            DataTable foundUsers = new SQLFunctions().GetDataFromDatabase($"select * from users");
            foreach (DataRow user in foundUsers.Rows)
            {
                if ((NameFilterTextBox.Text.Length <= 0 || user[1].ToString().ToLower().Contains(NameFilterTextBox.Text.ToLower())) && (EmailFilterTextBox.Text.Length <= 0 || user[2].ToString().ToLower().Contains(EmailFilterTextBox.Text.ToLower())))
                {
                    string permitionString = "";

                    switch (user[4])
                    {
                        case 1:
                            {
                                permitionString = " (Gerente)";
                                break;
                            }
                        case 2:
                            {
                                permitionString = " (Administrador)";
                                break;
                            }
                    }

                    userIdsByIndex.Add(int.Parse(user[0].ToString()));
                    UsersListBox.Items.Add(user[1] + permitionString);
                }
            }
        }
        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            int selectedIndex = UsersListBox.SelectedIndex;

            if(userIdsByIndex[selectedIndex] == SharedValues.Instance.GetCurrentUserId())
            {
                MessageBox.Show("Can't delete yourself!");
                return;
            }
            new SQLFunctions().GenericChangeDataInDatabase($"delete from users where id = {userIdsByIndex[selectedIndex]}");

            ShowUsers();
        }

        private void ShowUsersLoad(object sender, EventArgs e)
        {
            ShowUsers();
        }
    }
}
