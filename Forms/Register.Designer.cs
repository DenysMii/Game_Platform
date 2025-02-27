namespace Games_Platform
{
    partial class Register
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
            registerLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            roleLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            registerButton = new Button();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            loginLink = new LinkLabel();
            rolesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // registerLabel
            // 
            registerLabel.Anchor = AnchorStyles.None;
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerLabel.Location = new Point(217, 49);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(182, 60);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Register";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(187, 195);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(187, 267);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(233, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // roleLabel
            // 
            roleLabel.Anchor = AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(137, 148);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(39, 20);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "Role";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(106, 199);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(110, 271);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.BackColor = SystemColors.Highlight;
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(187, 308);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(233, 45);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(187, 231);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(233, 27);
            emailTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(125, 235);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-mail";
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Location = new Point(282, 356);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(46, 20);
            loginLink.TabIndex = 11;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // rolesComboBox
            // 
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Items.AddRange(new object[] { "Gamer", "Developer" });
            rolesComboBox.Location = new Point(187, 145);
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(233, 28);
            rolesComboBox.TabIndex = 12;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 452);
            Controls.Add(rolesComboBox);
            Controls.Add(loginLink);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(registerButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(roleLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(registerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLabel;

        private Label roleLabel;
        private Label usernameLabel;
        private Label emailLabel;
        private Label passwordLabel;

        private ComboBox rolesComboBox;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;

        private Button registerButton;
        private LinkLabel loginLink;
        
    }
}