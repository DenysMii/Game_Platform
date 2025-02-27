namespace Games_Platform
{
    partial class Login
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
            loginLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            roleLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerLink = new LinkLabel();
            rolesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(207, 37);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(106, 47);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(164, 146);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(204, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(164, 171);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(204, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // roleLabel
            // 
            roleLabel.Anchor = AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(120, 112);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(30, 15);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "Role";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(51, 149);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 15);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username/E-mail";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(93, 174);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = SystemColors.Highlight;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(164, 206);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(204, 34);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerLink
            // 
            registerLink.Anchor = AnchorStyles.None;
            registerLink.AutoSize = true;
            registerLink.Location = new Point(242, 242);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(49, 15);
            registerLink.TabIndex = 9;
            registerLink.TabStop = true;
            registerLink.Text = "Register";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // rolesComboBox
            // 
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Items.AddRange(new object[] { "Gamer", "Developer", "Admin" });
            rolesComboBox.Location = new Point(164, 109);
            rolesComboBox.Margin = new Padding(3, 2, 3, 2);
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(204, 23);
            rolesComboBox.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 339);
            Controls.Add(rolesComboBox);
            Controls.Add(registerLink);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(roleLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;

        private Label roleLabel;
        private Label usernameLabel;
        private Label passwordLabel;

        private ComboBox rolesComboBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        
        private Button loginButton;
        private LinkLabel registerLink;
        
    }
}