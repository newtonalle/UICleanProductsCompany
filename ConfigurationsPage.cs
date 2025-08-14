using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UICleanProductsCompany
{
    public partial class ConfigurationsPage : Form
    {
        // VolumeLabel
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public ConfigurationsPage()
        {
            InitializeComponent();
            // Configura o TrackBar
            VolumeBar.Minimum = 0;
            VolumeBar.Maximum = 100;
            VolumeBar.Value = 50; // Volume inicial
            VolumeBar.TickFrequency = 10;
            VolumeBar.Scroll += VolumeBar_Scroll;

            // Define volume inicial
            SetVolume(VolumeBar.Value);
        }

        private void TestSound(object sender, EventArgs e)
        {
            SoundPlayer som = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            som.Play();
            // VolumeBar.Value trackeia o valor da barra de volume
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            SetVolume(VolumeBar.Value);
            VolumeLabel.Text = VolumeBar.Value.ToString();
            SharedValues.Instance.appVolume = VolumeBar.Value;
            SharedValues.Instance.InvokeOnValueUpdate();
        }

        private void SetVolume(int volumePercent)
        {
            int volume = (ushort.MaxValue / 100) * volumePercent;
            uint volumeAllChannels = ((uint)volume & 0x0000ffff) | ((uint)volume << 16);
            waveOutSetVolume(IntPtr.Zero, volumeAllChannels);
        }

        private void ThemeLightModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeLightModeRadioButton.Checked)
            {
                SharedValues.Instance.ChangeTheme("light");
                this.BackColor = Color.White;

                SharedValues.Instance.ChangeTextColor(this.Controls, Color.Black);

            }
        }

        private void ThemeDarkModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeDarkModeRadioButton.Checked)
            {
                SharedValues.Instance.ChangeTheme("dark");
                this.BackColor = Color.Black;

                SharedValues.Instance.ChangeTextColor(this.Controls, Color.White);
            }
        }

        private void MoneyReaisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MoneyReaisRadioButton.Checked)
            {
                SharedValues.Instance.ChangeCurrency("R$");
            }
        }

        private void MoneyDollarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MoneyDollarsRadioButton.Checked)
            {
                SharedValues.Instance.ChangeCurrency("$");
            }
        }

        private void MoneyPoundsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MoneyPoundsRadioButton.Checked)
            {
                SharedValues.Instance.ChangeCurrency("£");
            }
        }

        private void RefreshPage(object sender, EventArgs e)
        {
            SharedValues.Instance.UpdatePageTheme(this.Controls, this);
            VolumeBar.Value = SharedValues.Instance.appVolume;
            VolumeLabel.Text = VolumeBar.Value.ToString();

            switch (SharedValues.Instance.GetAppTheme())
            {
                case "light":
                    {
                        ThemeLightModeRadioButton.Checked = true;
                        ThemeDarkModeRadioButton.Checked = false;
                        break;
                    }
                case "dark":
                    {
                        ThemeLightModeRadioButton.Checked = false;
                        ThemeDarkModeRadioButton.Checked = true;
                        break;
                    }
                default:
                    break;
            }

            switch (SharedValues.Instance.GetCurrency())
            {
                case "R$":
                    {
                        MoneyReaisRadioButton.Checked = true;
                        MoneyDollarsRadioButton.Checked = false;
                        MoneyPoundsRadioButton.Checked = false;
                        break;
                    }
                case "$":
                    {
                        MoneyReaisRadioButton.Checked = false;
                        MoneyDollarsRadioButton.Checked = true;
                        MoneyPoundsRadioButton.Checked = false;
                        break;
                    }
                case "£":
                    {
                        MoneyReaisRadioButton.Checked = false;
                        MoneyDollarsRadioButton.Checked = false;
                        MoneyPoundsRadioButton.Checked = true;
                        break;
                    }
                default:
                    break;
            }
        }
        private void Page_Load(object sender, EventArgs e)
        {
            SharedValues.OnValueUpdate += RefreshPage;
            RefreshPage(sender, e);
        }

        private void SaveConfigurations(object sender, EventArgs e)
        {
            if (SharedValues.Instance.GetCurrentUserId() == -1)
                return;

            DataTable oldConfigurations = new SQLFunctions().GetDataFromDatabase($"select * from configuration where userId = {SharedValues.Instance.GetCurrentUserId()}");
            if (oldConfigurations.Rows.Count > 0)
            {
                // Update Existing Configurations

                new SQLFunctions().GenericChangeDataInDatabase($"update configuration set theme = '{SharedValues.Instance.GetAppTheme()}', volume = {SharedValues.Instance.appVolume}, currency = '{SharedValues.Instance.GetCurrency()}' where id = {oldConfigurations.Rows[0][0]}");
            }
            else
            {
                // Create new Configurations

                new SQLFunctions().GenericChangeDataInDatabase($"insert into configuration(userId,theme,volume,currency) values({SharedValues.Instance.GetCurrentUserId()},'{SharedValues.Instance.GetAppTheme()}',{SharedValues.Instance.appVolume},'{SharedValues.Instance.GetCurrency()}')");
            }
            MessageBox.Show("Configurações Salvas!");
        }

    }
}
