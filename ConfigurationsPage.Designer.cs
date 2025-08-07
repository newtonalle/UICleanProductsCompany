namespace UICleanProductsCompany
{
    partial class ConfigurationsPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MoneyPoundsRadioButton = new System.Windows.Forms.RadioButton();
            this.MoneyDollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.MoneyReaisRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.testSoundButton = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ThemeDarkModeRadioButton = new System.Windows.Forms.RadioButton();
            this.ThemeLightModeRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MoneyPoundsRadioButton);
            this.groupBox4.Controls.Add(this.MoneyDollarsRadioButton);
            this.groupBox4.Controls.Add(this.MoneyReaisRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 92);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unidade Monetária";
            // 
            // MoneyPoundsRadioButton
            // 
            this.MoneyPoundsRadioButton.AutoSize = true;
            this.MoneyPoundsRadioButton.Location = new System.Drawing.Point(6, 65);
            this.MoneyPoundsRadioButton.Name = "MoneyPoundsRadioButton";
            this.MoneyPoundsRadioButton.Size = new System.Drawing.Size(68, 17);
            this.MoneyPoundsRadioButton.TabIndex = 2;
            this.MoneyPoundsRadioButton.Text = "Libras (£)";
            this.MoneyPoundsRadioButton.UseVisualStyleBackColor = true;
            this.MoneyPoundsRadioButton.CheckedChanged += new System.EventHandler(this.MoneyPoundsRadioButton_CheckedChanged);
            // 
            // MoneyDollarsRadioButton
            // 
            this.MoneyDollarsRadioButton.AutoSize = true;
            this.MoneyDollarsRadioButton.Location = new System.Drawing.Point(6, 42);
            this.MoneyDollarsRadioButton.Name = "MoneyDollarsRadioButton";
            this.MoneyDollarsRadioButton.Size = new System.Drawing.Size(76, 17);
            this.MoneyDollarsRadioButton.TabIndex = 1;
            this.MoneyDollarsRadioButton.Text = "Dólares ($)";
            this.MoneyDollarsRadioButton.UseVisualStyleBackColor = true;
            this.MoneyDollarsRadioButton.CheckedChanged += new System.EventHandler(this.MoneyDollarsRadioButton_CheckedChanged);
            // 
            // MoneyReaisRadioButton
            // 
            this.MoneyReaisRadioButton.AutoSize = true;
            this.MoneyReaisRadioButton.Checked = true;
            this.MoneyReaisRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MoneyReaisRadioButton.Name = "MoneyReaisRadioButton";
            this.MoneyReaisRadioButton.Size = new System.Drawing.Size(75, 17);
            this.MoneyReaisRadioButton.TabIndex = 0;
            this.MoneyReaisRadioButton.TabStop = true;
            this.MoneyReaisRadioButton.Text = "Reais (R$)";
            this.MoneyReaisRadioButton.UseVisualStyleBackColor = true;
            this.MoneyReaisRadioButton.CheckedChanged += new System.EventHandler(this.MoneyReaisRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VolumeLabel);
            this.groupBox3.Controls.Add(this.testSoundButton);
            this.groupBox3.Controls.Add(this.VolumeBar);
            this.groupBox3.Location = new System.Drawing.Point(6, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Áudio";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(6, 20);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(19, 13);
            this.VolumeLabel.TabIndex = 4;
            this.VolumeLabel.Text = "50";
            // 
            // testSoundButton
            // 
            this.testSoundButton.BackColor = System.Drawing.Color.SteelBlue;
            this.testSoundButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.testSoundButton.Location = new System.Drawing.Point(9, 79);
            this.testSoundButton.Name = "testSoundButton";
            this.testSoundButton.Size = new System.Drawing.Size(185, 31);
            this.testSoundButton.TabIndex = 3;
            this.testSoundButton.Text = "Testar Som";
            this.testSoundButton.UseVisualStyleBackColor = false;
            this.testSoundButton.Click += new System.EventHandler(this.TestSound);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(6, 36);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(188, 45);
            this.VolumeBar.TabIndex = 0;
            this.VolumeBar.Value = 5;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ThemeDarkModeRadioButton);
            this.groupBox2.Controls.Add(this.ThemeLightModeRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tema";
            // 
            // ThemeDarkModeRadioButton
            // 
            this.ThemeDarkModeRadioButton.AutoSize = true;
            this.ThemeDarkModeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ThemeDarkModeRadioButton.Name = "ThemeDarkModeRadioButton";
            this.ThemeDarkModeRadioButton.Size = new System.Drawing.Size(88, 17);
            this.ThemeDarkModeRadioButton.TabIndex = 1;
            this.ThemeDarkModeRadioButton.Text = "Modo Escuro";
            this.ThemeDarkModeRadioButton.UseVisualStyleBackColor = true;
            this.ThemeDarkModeRadioButton.CheckedChanged += new System.EventHandler(this.ThemeDarkModeRadioButton_CheckedChanged);
            // 
            // ThemeLightModeRadioButton
            // 
            this.ThemeLightModeRadioButton.AutoSize = true;
            this.ThemeLightModeRadioButton.Checked = true;
            this.ThemeLightModeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ThemeLightModeRadioButton.Name = "ThemeLightModeRadioButton";
            this.ThemeLightModeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ThemeLightModeRadioButton.TabIndex = 0;
            this.ThemeLightModeRadioButton.TabStop = true;
            this.ThemeLightModeRadioButton.Text = "Modo Claro";
            this.ThemeLightModeRadioButton.UseVisualStyleBackColor = true;
            this.ThemeLightModeRadioButton.CheckedChanged += new System.EventHandler(this.ThemeLightModeRadioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar Configurações";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveConfigurations);
            // 
            // ConfigurationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationsPage";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Page_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ThemeLightModeRadioButton;
        private System.Windows.Forms.RadioButton ThemeDarkModeRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton MoneyPoundsRadioButton;
        private System.Windows.Forms.RadioButton MoneyDollarsRadioButton;
        private System.Windows.Forms.RadioButton MoneyReaisRadioButton;
        private System.Windows.Forms.Button testSoundButton;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button button1;
    }
}