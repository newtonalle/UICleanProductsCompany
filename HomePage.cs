using System;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class HomePage : Form
    {
        public static HomePage Instance;
        public HomePage()
        {
            InitializeComponent();

            Instance = this;

            if (SharedValues.Instance == null)
            {
                SharedValues sharedValues = new SharedValues();
            }

            new SQLFunctions().CreateTables();
        }

        private void LogisticsProductionButtonClicked(object sender, EventArgs e)
        {
            AboutProductionPage tempPage = new AboutProductionPage();
            tempPage.Show();
        }

        private void AboutUsButtonClicked(object sender, EventArgs e)
        {
            AboutUsPage tempPage = new AboutUsPage();
            tempPage.Show();
        }

        private void StoreButtonClicked(object sender, EventArgs e)
        {
            StorePage tempPage = new StorePage();
            tempPage.Show();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            LoginPage tempPage = new LoginPage();
            tempPage.Show();
        }

        private void SignUpButtonClicked(object sender, EventArgs e)
        {
            SignUpPage tempPage = new SignUpPage();
            tempPage.Show();
        }

        private void ManageStoreButtonClicked(object sender, EventArgs e)
        {
            ManageStorePage tempPage = new ManageStorePage();
            tempPage.Show();
        }

        private void ManageUsersButtonClicked(object sender, EventArgs e)
        {
            ManageUsersPage tempPage = new ManageUsersPage();
            tempPage.Show();
        }

        private void AdminStoreButtonClicked(object sender, EventArgs e)
        {
            ManageStorePage tempPage = new ManageStorePage();
            tempPage.Show();
        }

        private void AdminUsersButtonClicked(object sender, EventArgs e)
        {
            ManageUsersPage tempPage = new ManageUsersPage();
            tempPage.Show();
        }

        private void ConfigurationsButtonClicked(object sender, EventArgs e)
        {
            ConfigurationsPage tempPage = new ConfigurationsPage();
            tempPage.Show();
        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);
        }

        public void LoggedIn(int permitionType)
        {
            switch (permitionType)
            {
                case 0:
                    {
                        StoreButton.Enabled = true;
                        ManageButton.Enabled = false;
                        AdminButton.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        StoreButton.Enabled = true;
                        ManageButton.Enabled = true;
                        AdminButton.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        StoreButton.Enabled = true;
                        ManageButton.Enabled = false;
                        AdminButton.Enabled = true;

                        break;
                    }
                default:
                    break;
            }
        }

        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SharedValues.Instance.GetCurrentUserId() == -1)
                new SQLFunctions().GenericChangeDataInDatabase($"update users set isCurrentlyLoggedIn = false where id = {SharedValues.Instance.GetCurrentUserId()}");
        }
    }
}
