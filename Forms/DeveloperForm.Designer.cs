namespace Games_Platform
{
    partial class DeveloperForm
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
            addGameButton = new Button();
            getInfoPanel = new Panel();
            registerDateLabel = new Label();
            roleLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            addGamePanel = new Panel();
            agAddButton = new Button();
            agDescTextBox = new TextBox();
            agDescLabel = new Label();
            agGenreTextBox = new TextBox();
            agGenreLabel = new Label();
            agTitleTextBox = new TextBox();
            agPlatformLabel = new Label();
            agPlatformComboBox = new ComboBox();
            agTitleLabel = new Label();
            deleteGameButton = new Button();
            deleteGamePanel = new Panel();
            dgTitleComboBox = new ComboBox();
            dgDeleteButton = new Button();
            dgTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)blueBG).BeginInit();
            getInfoPanel.SuspendLayout();
            addGamePanel.SuspendLayout();
            deleteGamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // blueBG
            // 
            blueBG.BackColor = SystemColors.Highlight;
            blueBG.Location = new Point(0, 0);
            blueBG.Name = "blueBG";
            blueBG.Size = new Size(801, 90);
            blueBG.TabIndex = 0;
            blueBG.TabStop = false;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = SystemColors.Highlight;
            greetingLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            greetingLabel.ForeColor = SystemColors.ControlLightLight;
            greetingLabel.Location = new Point(12, 9);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(162, 65);
            greetingLabel.TabIndex = 1;
            greetingLabel.Text = "Hello, ";
            // 
            // getInfoButton
            // 
            getInfoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getInfoButton.Location = new Point(12, 96);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(200, 47);
            getInfoButton.TabIndex = 2;
            getInfoButton.Text = "Get Info";
            getInfoButton.UseVisualStyleBackColor = true;
            getInfoButton.Click += getInfoButton_Click;
            // 
            // addGameButton
            // 
            addGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addGameButton.Location = new Point(12, 149);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(200, 47);
            addGameButton.TabIndex = 3;
            addGameButton.Text = "Add Game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
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
            getInfoPanel.TabIndex = 6;
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
            // addGamePanel
            // 
            addGamePanel.BackColor = SystemColors.Control;
            addGamePanel.Controls.Add(agAddButton);
            addGamePanel.Controls.Add(agDescTextBox);
            addGamePanel.Controls.Add(agDescLabel);
            addGamePanel.Controls.Add(agGenreTextBox);
            addGamePanel.Controls.Add(agGenreLabel);
            addGamePanel.Controls.Add(agTitleTextBox);
            addGamePanel.Controls.Add(agPlatformLabel);
            addGamePanel.Controls.Add(agPlatformComboBox);
            addGamePanel.Controls.Add(agTitleLabel);
            addGamePanel.Enabled = false;
            addGamePanel.Location = new Point(230, 96);
            addGamePanel.Name = "addGamePanel";
            addGamePanel.Size = new Size(571, 351);
            addGamePanel.TabIndex = 7;
            addGamePanel.Visible = false;
            // 
            // agAddButton
            // 
            agAddButton.Font = new Font("Segoe UI", 14F);
            agAddButton.Location = new Point(426, 300);
            agAddButton.Name = "agAddButton";
            agAddButton.Size = new Size(119, 42);
            agAddButton.TabIndex = 8;
            agAddButton.Text = "ADD";
            agAddButton.UseVisualStyleBackColor = true;
            agAddButton.Click += agAddButton_Click;
            // 
            // agDescTextBox
            // 
            agDescTextBox.Location = new Point(134, 183);
            agDescTextBox.MaxLength = 4000;
            agDescTextBox.Multiline = true;
            agDescTextBox.Name = "agDescTextBox";
            agDescTextBox.Size = new Size(265, 159);
            agDescTextBox.TabIndex = 7;
            // 
            // agDescLabel
            // 
            agDescLabel.AutoSize = true;
            agDescLabel.Font = new Font("Segoe UI", 14F);
            agDescLabel.Location = new Point(19, 181);
            agDescLabel.Name = "agDescLabel";
            agDescLabel.Size = new Size(117, 25);
            agDescLabel.TabIndex = 6;
            agDescLabel.Text = "Description: ";
            // 
            // agGenreTextBox
            // 
            agGenreTextBox.Location = new Point(134, 130);
            agGenreTextBox.MaxLength = 20;
            agGenreTextBox.Name = "agGenreTextBox";
            agGenreTextBox.Size = new Size(265, 23);
            agGenreTextBox.TabIndex = 5;
            // 
            // agGenreLabel
            // 
            agGenreLabel.AutoSize = true;
            agGenreLabel.Font = new Font("Segoe UI", 14F);
            agGenreLabel.Location = new Point(19, 128);
            agGenreLabel.Name = "agGenreLabel";
            agGenreLabel.Size = new Size(72, 25);
            agGenreLabel.TabIndex = 4;
            agGenreLabel.Text = "Genre: ";
            // 
            // agTitleTextBox
            // 
            agTitleTextBox.Location = new Point(134, 24);
            agTitleTextBox.MaxLength = 50;
            agTitleTextBox.Name = "agTitleTextBox";
            agTitleTextBox.Size = new Size(265, 23);
            agTitleTextBox.TabIndex = 3;
            // 
            // agPlatformLabel
            // 
            agPlatformLabel.AutoSize = true;
            agPlatformLabel.Font = new Font("Segoe UI", 14F);
            agPlatformLabel.Location = new Point(19, 75);
            agPlatformLabel.Name = "agPlatformLabel";
            agPlatformLabel.Size = new Size(93, 25);
            agPlatformLabel.TabIndex = 2;
            agPlatformLabel.Text = "Platform: ";
            // 
            // agPlatformComboBox
            // 
            agPlatformComboBox.FormattingEnabled = true;
            agPlatformComboBox.Location = new Point(134, 77);
            agPlatformComboBox.Name = "agPlatformComboBox";
            agPlatformComboBox.Size = new Size(265, 23);
            agPlatformComboBox.TabIndex = 1;
            // 
            // agTitleLabel
            // 
            agTitleLabel.AutoSize = true;
            agTitleLabel.Font = new Font("Segoe UI", 14F);
            agTitleLabel.Location = new Point(19, 22);
            agTitleLabel.Name = "agTitleLabel";
            agTitleLabel.Size = new Size(111, 25);
            agTitleLabel.TabIndex = 0;
            agTitleLabel.Text = "Game Title: ";
            // 
            // deleteGameButton
            // 
            deleteGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteGameButton.Location = new Point(12, 202);
            deleteGameButton.Name = "deleteGameButton";
            deleteGameButton.Size = new Size(200, 47);
            deleteGameButton.TabIndex = 8;
            deleteGameButton.Text = "Delete Game";
            deleteGameButton.UseVisualStyleBackColor = true;
            deleteGameButton.Click += deleteGameButton_Click;
            // 
            // deleteGamePanel
            // 
            deleteGamePanel.BackColor = SystemColors.Control;
            deleteGamePanel.Controls.Add(dgTitleComboBox);
            deleteGamePanel.Controls.Add(dgDeleteButton);
            deleteGamePanel.Controls.Add(dgTitleLabel);
            deleteGamePanel.Enabled = false;
            deleteGamePanel.Location = new Point(230, 96);
            deleteGamePanel.Name = "deleteGamePanel";
            deleteGamePanel.Size = new Size(571, 351);
            deleteGamePanel.TabIndex = 9;
            deleteGamePanel.Visible = false;
            // 
            // dgTitleComboBox
            // 
            dgTitleComboBox.FormattingEnabled = true;
            dgTitleComboBox.Location = new Point(134, 24);
            dgTitleComboBox.Name = "dgTitleComboBox";
            dgTitleComboBox.Size = new Size(265, 23);
            dgTitleComboBox.TabIndex = 11;
            // 
            // dgDeleteButton
            // 
            dgDeleteButton.Font = new Font("Segoe UI", 14F);
            dgDeleteButton.Location = new Point(426, 13);
            dgDeleteButton.Name = "dgDeleteButton";
            dgDeleteButton.Size = new Size(119, 42);
            dgDeleteButton.TabIndex = 10;
            dgDeleteButton.Text = "DELETE";
            dgDeleteButton.UseVisualStyleBackColor = true;
            dgDeleteButton.Click += dgDeleteButton_Click;
            // 
            // dgTitleLabel
            // 
            dgTitleLabel.AutoSize = true;
            dgTitleLabel.Font = new Font("Segoe UI", 14F);
            dgTitleLabel.Location = new Point(19, 22);
            dgTitleLabel.Name = "dgTitleLabel";
            dgTitleLabel.Size = new Size(111, 25);
            dgTitleLabel.TabIndex = 9;
            dgTitleLabel.Text = "Game Title: ";
            // 
            // DeveloperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteGameButton);
            Controls.Add(addGameButton);
            Controls.Add(getInfoButton);
            Controls.Add(greetingLabel);
            Controls.Add(blueBG);
            Controls.Add(deleteGamePanel);
            Controls.Add(addGamePanel);
            Controls.Add(getInfoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DeveloperForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeveloperForm";
            Load += DeveloperForm_Load;
            ((System.ComponentModel.ISupportInitialize)blueBG).EndInit();
            getInfoPanel.ResumeLayout(false);
            getInfoPanel.PerformLayout();
            addGamePanel.ResumeLayout(false);
            addGamePanel.PerformLayout();
            deleteGamePanel.ResumeLayout(false);
            deleteGamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox blueBG;
        private Label greetingLabel;
        private Button getInfoButton;
        private Button addGameButton;
        private Panel getInfoPanel;
        private Label roleLabel;
        private Label emailLabel;
        private Label usernameLabel;
        private Label registerDateLabel;
        private Panel addGamePanel;
        private Label agTitleLabel;
        private Label agPlatformLabel;
        private TextBox agTitleTextBox;
        private Button agAddButton;
        private TextBox agDescTextBox;
        private Label agDescLabel;
        private Button deleteGameButton;
        private Panel deleteGamePanel;
        private Button dgDeleteButton;
        private Label dgTitleLabel;
        private ComboBox dgTitleComboBox;
        private TextBox agGenreTextBox;
        private Label agGenreLabel;
        private ComboBox agPlatformComboBox;
    }
}