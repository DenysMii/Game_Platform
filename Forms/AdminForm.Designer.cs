namespace Games_Platform
{
    partial class AdminForm
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
            blueBG = new PictureBox();
            greetingLabel = new Label();
            getInfoButton = new Button();
            getInfoPanel = new Panel();
            registerDateLabel = new Label();
            roleLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            addAdminButton = new Button();
            addAdminPanel = new Panel();
            aaEmailTextBox = new TextBox();
            aaAddButton = new Button();
            aaPasswordTextBox = new TextBox();
            aaPasswordLabel = new Label();
            aaUsernameTextBox = new TextBox();
            aaEmailLabel = new Label();
            aaUsernameLabel = new Label();
            addPlatformButton = new Button();
            addPlatformPanel = new Panel();
            apAddButton = new Button();
            apNameTextBox = new TextBox();
            apManufTextBox = new TextBox();
            apManufLabel = new Label();
            apNameLabel = new Label();
            deletePlatformButton = new Button();
            deletePlatformPanel = new Panel();
            dpNameComboBox = new ComboBox();
            dpDeleteButton = new Button();
            dpNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)blueBG).BeginInit();
            getInfoPanel.SuspendLayout();
            addAdminPanel.SuspendLayout();
            addPlatformPanel.SuspendLayout();
            deletePlatformPanel.SuspendLayout();
            SuspendLayout();
            // 
            // blueBG
            // 
            blueBG.BackColor = SystemColors.Highlight;
            blueBG.Location = new Point(0, 0);
            blueBG.Name = "blueBG";
            blueBG.Size = new Size(801, 90);
            blueBG.TabIndex = 1;
            blueBG.TabStop = false;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = SystemColors.Highlight;
            greetingLabel.Font = new Font("Segoe UI", 36F);
            greetingLabel.ForeColor = SystemColors.ControlLightLight;
            greetingLabel.Location = new Point(12, 9);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(162, 65);
            greetingLabel.TabIndex = 2;
            greetingLabel.Text = "Hello, ";
            // 
            // getInfoButton
            // 
            getInfoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getInfoButton.Location = new Point(12, 96);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(200, 47);
            getInfoButton.TabIndex = 3;
            getInfoButton.Text = "Get Info";
            getInfoButton.UseVisualStyleBackColor = true;
            getInfoButton.Click += getInfoButton_Click;
            // 
            // getInfoPanel
            // 
            getInfoPanel.BackColor = SystemColors.Control;
            getInfoPanel.Controls.Add(registerDateLabel);
            getInfoPanel.Controls.Add(roleLabel);
            getInfoPanel.Controls.Add(emailLabel);
            getInfoPanel.Controls.Add(usernameLabel);
            getInfoPanel.Enabled = false;
            getInfoPanel.Location = new Point(230, 96);
            getInfoPanel.Name = "getInfoPanel";
            getInfoPanel.Size = new Size(571, 351);
            getInfoPanel.TabIndex = 7;
            getInfoPanel.Visible = false;
            // 
            // registerDateLabel
            // 
            registerDateLabel.AutoSize = true;
            registerDateLabel.Font = new Font("Segoe UI", 18F);
            registerDateLabel.Location = new Point(19, 174);
            registerDateLabel.Name = "registerDateLabel";
            registerDateLabel.Size = new Size(168, 32);
            registerDateLabel.TabIndex = 8;
            registerDateLabel.Text = "Register Date: ";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roleLabel.Location = new Point(19, 15);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(64, 32);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Role";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 18F);
            emailLabel.Location = new Point(19, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 32);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail: ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 18F);
            usernameLabel.Location = new Point(19, 68);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(133, 32);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username: ";
            // 
            // addAdminButton
            // 
            addAdminButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addAdminButton.Location = new Point(12, 149);
            addAdminButton.Name = "addAdminButton";
            addAdminButton.Size = new Size(200, 47);
            addAdminButton.TabIndex = 8;
            addAdminButton.Text = "Add Admin";
            addAdminButton.UseVisualStyleBackColor = true;
            addAdminButton.Click += addAdminButton_Click;
            // 
            // addAdminPanel
            // 
            addAdminPanel.BackColor = SystemColors.Control;
            addAdminPanel.Controls.Add(aaEmailTextBox);
            addAdminPanel.Controls.Add(aaAddButton);
            addAdminPanel.Controls.Add(aaPasswordTextBox);
            addAdminPanel.Controls.Add(aaPasswordLabel);
            addAdminPanel.Controls.Add(aaUsernameTextBox);
            addAdminPanel.Controls.Add(aaEmailLabel);
            addAdminPanel.Controls.Add(aaUsernameLabel);
            addAdminPanel.Enabled = false;
            addAdminPanel.Location = new Point(230, 96);
            addAdminPanel.Name = "addAdminPanel";
            addAdminPanel.Size = new Size(571, 351);
            addAdminPanel.TabIndex = 9;
            addAdminPanel.Visible = false;
            // 
            // aaEmailTextBox
            // 
            aaEmailTextBox.Location = new Point(134, 77);
            aaEmailTextBox.MaxLength = 255;
            aaEmailTextBox.Name = "aaEmailTextBox";
            aaEmailTextBox.Size = new Size(265, 23);
            aaEmailTextBox.TabIndex = 9;
            // 
            // aaAddButton
            // 
            aaAddButton.Font = new Font("Segoe UI", 14F);
            aaAddButton.Location = new Point(280, 183);
            aaAddButton.Name = "aaAddButton";
            aaAddButton.Size = new Size(119, 42);
            aaAddButton.TabIndex = 8;
            aaAddButton.Text = "ADD";
            aaAddButton.UseVisualStyleBackColor = true;
            aaAddButton.Click += aaAddButton_Click;
            // 
            // aaPasswordTextBox
            // 
            aaPasswordTextBox.Location = new Point(134, 130);
            aaPasswordTextBox.MaxLength = 50;
            aaPasswordTextBox.Name = "aaPasswordTextBox";
            aaPasswordTextBox.PasswordChar = '*';
            aaPasswordTextBox.Size = new Size(265, 23);
            aaPasswordTextBox.TabIndex = 5;
            // 
            // aaPasswordLabel
            // 
            aaPasswordLabel.AutoSize = true;
            aaPasswordLabel.Font = new Font("Segoe UI", 14F);
            aaPasswordLabel.Location = new Point(19, 128);
            aaPasswordLabel.Name = "aaPasswordLabel";
            aaPasswordLabel.Size = new Size(100, 25);
            aaPasswordLabel.TabIndex = 4;
            aaPasswordLabel.Text = "Password: ";
            // 
            // aaUsernameTextBox
            // 
            aaUsernameTextBox.Location = new Point(134, 24);
            aaUsernameTextBox.MaxLength = 50;
            aaUsernameTextBox.Name = "aaUsernameTextBox";
            aaUsernameTextBox.Size = new Size(265, 23);
            aaUsernameTextBox.TabIndex = 3;
            // 
            // aaEmailLabel
            // 
            aaEmailLabel.AutoSize = true;
            aaEmailLabel.Font = new Font("Segoe UI", 14F);
            aaEmailLabel.Location = new Point(19, 75);
            aaEmailLabel.Name = "aaEmailLabel";
            aaEmailLabel.Size = new Size(75, 25);
            aaEmailLabel.TabIndex = 2;
            aaEmailLabel.Text = "E-mail: ";
            // 
            // aaUsernameLabel
            // 
            aaUsernameLabel.AutoSize = true;
            aaUsernameLabel.Font = new Font("Segoe UI", 14F);
            aaUsernameLabel.Location = new Point(19, 22);
            aaUsernameLabel.Name = "aaUsernameLabel";
            aaUsernameLabel.Size = new Size(106, 25);
            aaUsernameLabel.TabIndex = 0;
            aaUsernameLabel.Text = "Username: ";
            // 
            // addPlatformButton
            // 
            addPlatformButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addPlatformButton.Location = new Point(12, 202);
            addPlatformButton.Name = "addPlatformButton";
            addPlatformButton.Size = new Size(200, 47);
            addPlatformButton.TabIndex = 10;
            addPlatformButton.Text = "Add Platform";
            addPlatformButton.UseVisualStyleBackColor = true;
            addPlatformButton.Click += addPlatformButton_Click;
            // 
            // addPlatformPanel
            // 
            addPlatformPanel.BackColor = SystemColors.Control;
            addPlatformPanel.Controls.Add(apAddButton);
            addPlatformPanel.Controls.Add(apNameTextBox);
            addPlatformPanel.Controls.Add(apManufTextBox);
            addPlatformPanel.Controls.Add(apManufLabel);
            addPlatformPanel.Controls.Add(apNameLabel);
            addPlatformPanel.Enabled = false;
            addPlatformPanel.Location = new Point(230, 96);
            addPlatformPanel.Name = "addPlatformPanel";
            addPlatformPanel.Size = new Size(571, 351);
            addPlatformPanel.TabIndex = 11;
            addPlatformPanel.Visible = false;
            // 
            // apAddButton
            // 
            apAddButton.Font = new Font("Segoe UI", 14F);
            apAddButton.Location = new Point(304, 130);
            apAddButton.Name = "apAddButton";
            apAddButton.Size = new Size(119, 42);
            apAddButton.TabIndex = 16;
            apAddButton.Text = "ADD";
            apAddButton.UseVisualStyleBackColor = true;
            apAddButton.Click += apAddButton_Click;
            // 
            // apNameTextBox
            // 
            apNameTextBox.Location = new Point(158, 24);
            apNameTextBox.MaxLength = 20;
            apNameTextBox.Name = "apNameTextBox";
            apNameTextBox.Size = new Size(265, 23);
            apNameTextBox.TabIndex = 15;
            // 
            // apManufTextBox
            // 
            apManufTextBox.Location = new Point(158, 77);
            apManufTextBox.MaxLength = 50;
            apManufTextBox.Name = "apManufTextBox";
            apManufTextBox.Size = new Size(265, 23);
            apManufTextBox.TabIndex = 14;
            // 
            // apManufLabel
            // 
            apManufLabel.AutoSize = true;
            apManufLabel.Font = new Font("Segoe UI", 14F);
            apManufLabel.Location = new Point(19, 75);
            apManufLabel.Name = "apManufLabel";
            apManufLabel.Size = new Size(136, 25);
            apManufLabel.TabIndex = 13;
            apManufLabel.Text = "Manufacturer: ";
            // 
            // apNameLabel
            // 
            apNameLabel.AutoSize = true;
            apNameLabel.Font = new Font("Segoe UI", 14F);
            apNameLabel.Location = new Point(19, 22);
            apNameLabel.Name = "apNameLabel";
            apNameLabel.Size = new Size(71, 25);
            apNameLabel.TabIndex = 12;
            apNameLabel.Text = "Name: ";
            // 
            // deletePlatformButton
            // 
            deletePlatformButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deletePlatformButton.Location = new Point(12, 255);
            deletePlatformButton.Name = "deletePlatformButton";
            deletePlatformButton.Size = new Size(200, 47);
            deletePlatformButton.TabIndex = 12;
            deletePlatformButton.Text = "Delete Platform";
            deletePlatformButton.UseVisualStyleBackColor = true;
            deletePlatformButton.Click += deletePlatformButton_Click;
            // 
            // deletePlatformPanel
            // 
            deletePlatformPanel.BackColor = SystemColors.Control;
            deletePlatformPanel.Controls.Add(dpNameComboBox);
            deletePlatformPanel.Controls.Add(dpDeleteButton);
            deletePlatformPanel.Controls.Add(dpNameLabel);
            deletePlatformPanel.Enabled = false;
            deletePlatformPanel.Location = new Point(230, 96);
            deletePlatformPanel.Name = "deletePlatformPanel";
            deletePlatformPanel.Size = new Size(571, 351);
            deletePlatformPanel.TabIndex = 13;
            deletePlatformPanel.Visible = false;
            // 
            // dpNameComboBox
            // 
            dpNameComboBox.FormattingEnabled = true;
            dpNameComboBox.Location = new Point(134, 24);
            dpNameComboBox.MaxLength = 20;
            dpNameComboBox.Name = "dpNameComboBox";
            dpNameComboBox.Size = new Size(265, 23);
            dpNameComboBox.TabIndex = 11;
            // 
            // dpDeleteButton
            // 
            dpDeleteButton.Font = new Font("Segoe UI", 14F);
            dpDeleteButton.Location = new Point(426, 13);
            dpDeleteButton.Name = "dpDeleteButton";
            dpDeleteButton.Size = new Size(119, 42);
            dpDeleteButton.TabIndex = 10;
            dpDeleteButton.Text = "DELETE";
            dpDeleteButton.UseVisualStyleBackColor = true;
            dpDeleteButton.Click += dpDeleteButton_Click;
            // 
            // dpNameLabel
            // 
            dpNameLabel.AutoSize = true;
            dpNameLabel.Font = new Font("Segoe UI", 14F);
            dpNameLabel.Location = new Point(19, 22);
            dpNameLabel.Name = "dpNameLabel";
            dpNameLabel.Size = new Size(71, 25);
            dpNameLabel.TabIndex = 9;
            dpNameLabel.Text = "Name: ";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(deletePlatformButton);
            Controls.Add(addPlatformButton);
            Controls.Add(addAdminButton);
            Controls.Add(getInfoButton);
            Controls.Add(greetingLabel);
            Controls.Add(blueBG);
            Controls.Add(deletePlatformPanel);
            Controls.Add(addPlatformPanel);
            Controls.Add(addAdminPanel);
            Controls.Add(getInfoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)blueBG).EndInit();
            getInfoPanel.ResumeLayout(false);
            getInfoPanel.PerformLayout();
            addAdminPanel.ResumeLayout(false);
            addAdminPanel.PerformLayout();
            addPlatformPanel.ResumeLayout(false);
            addPlatformPanel.PerformLayout();
            deletePlatformPanel.ResumeLayout(false);
            deletePlatformPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox blueBG;
        private Label greetingLabel;
        private Button getInfoButton;
        private Panel getInfoPanel;
        private Label registerDateLabel;
        private Label roleLabel;
        private Label emailLabel;
        private Label usernameLabel;
        private Button addAdminButton;
        private Panel addAdminPanel;
        private Button aaAddButton;
        private TextBox aaPasswordTextBox;
        private Label aaPasswordLabel;
        private TextBox aaUsernameTextBox;
        private Label aaEmailLabel;
        private Label aaUsernameLabel;
        private TextBox aaEmailTextBox;
        private Button addPlatformButton;
        private Panel addPlatformPanel;
        private Label apNameLabel;
        private Label apManufLabel;
        private TextBox apManufTextBox;
        private TextBox apNameTextBox;
        private Button apAddButton;
        private Button deletePlatformButton;
        private Panel deletePlatformPanel;
        private ComboBox dpNameComboBox;
        private Button dpDeleteButton;
        private Label dpNameLabel;
    }
}