namespace Games_Platform
{
    partial class GamerForm
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
            addGameButton = new Button();
            deleteGameButton = new Button();
            addReviewButton = new Button();
            addGamePanel = new Panel();
            agTitleComboBox = new ComboBox();
            agAddButton = new Button();
            agTitleLabel = new Label();
            deleteGamePanel = new Panel();
            dgTitleComboBox = new ComboBox();
            dgDeleteButton = new Button();
            dgTitleLabel = new Label();
            addReviewPanel = new Panel();
            arTitleComboBox = new ComboBox();
            arRatingNum = new NumericUpDown();
            arAddButton = new Button();
            arReviewTextBox = new TextBox();
            arReviewLabel = new Label();
            arRatingLabel = new Label();
            arTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)blueBG).BeginInit();
            getInfoPanel.SuspendLayout();
            addGamePanel.SuspendLayout();
            deleteGamePanel.SuspendLayout();
            addReviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arRatingNum).BeginInit();
            SuspendLayout();
            // 
            // blueBG
            // 
            blueBG.BackColor = SystemColors.Highlight;
            blueBG.Location = new Point(0, 0);
            blueBG.Name = "blueBG";
            blueBG.Size = new Size(801, 90);
            blueBG.TabIndex = 2;
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
            greetingLabel.TabIndex = 3;
            greetingLabel.Text = "Hello, ";
            // 
            // getInfoButton
            // 
            getInfoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getInfoButton.Location = new Point(12, 96);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(200, 47);
            getInfoButton.TabIndex = 4;
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
            getInfoPanel.TabIndex = 8;
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
            // addGameButton
            // 
            addGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addGameButton.Location = new Point(12, 149);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(200, 47);
            addGameButton.TabIndex = 9;
            addGameButton.Text = "Add Game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
            // 
            // deleteGameButton
            // 
            deleteGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteGameButton.Location = new Point(12, 202);
            deleteGameButton.Name = "deleteGameButton";
            deleteGameButton.Size = new Size(200, 47);
            deleteGameButton.TabIndex = 10;
            deleteGameButton.Text = "Delete Game";
            deleteGameButton.UseVisualStyleBackColor = true;
            deleteGameButton.Click += deleteGameButton_Click;
            // 
            // addReviewButton
            // 
            addReviewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addReviewButton.Location = new Point(12, 255);
            addReviewButton.Name = "addReviewButton";
            addReviewButton.Size = new Size(200, 47);
            addReviewButton.TabIndex = 11;
            addReviewButton.Text = "Add Review";
            addReviewButton.UseVisualStyleBackColor = true;
            addReviewButton.Click += addReviewButton_Click;
            // 
            // addGamePanel
            // 
            addGamePanel.BackColor = SystemColors.Control;
            addGamePanel.Controls.Add(agTitleComboBox);
            addGamePanel.Controls.Add(agAddButton);
            addGamePanel.Controls.Add(agTitleLabel);
            addGamePanel.Enabled = false;
            addGamePanel.Location = new Point(230, 96);
            addGamePanel.Name = "addGamePanel";
            addGamePanel.Size = new Size(571, 351);
            addGamePanel.TabIndex = 13;
            addGamePanel.Visible = false;
            // 
            // agTitleComboBox
            // 
            agTitleComboBox.FormattingEnabled = true;
            agTitleComboBox.Location = new Point(134, 24);
            agTitleComboBox.MaxLength = 50;
            agTitleComboBox.Name = "agTitleComboBox";
            agTitleComboBox.Size = new Size(265, 23);
            agTitleComboBox.TabIndex = 11;
            // 
            // agAddButton
            // 
            agAddButton.Font = new Font("Segoe UI", 14F);
            agAddButton.Location = new Point(426, 13);
            agAddButton.Name = "agAddButton";
            agAddButton.Size = new Size(119, 42);
            agAddButton.TabIndex = 10;
            agAddButton.Text = "ADD";
            agAddButton.UseVisualStyleBackColor = true;
            agAddButton.Click += agAddButton_Click;
            // 
            // agTitleLabel
            // 
            agTitleLabel.AutoSize = true;
            agTitleLabel.Font = new Font("Segoe UI", 14F);
            agTitleLabel.Location = new Point(19, 22);
            agTitleLabel.Name = "agTitleLabel";
            agTitleLabel.Size = new Size(111, 25);
            agTitleLabel.TabIndex = 9;
            agTitleLabel.Text = "Game Title: ";
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
            deleteGamePanel.TabIndex = 14;
            deleteGamePanel.Visible = false;
            // 
            // dgTitleComboBox
            // 
            dgTitleComboBox.FormattingEnabled = true;
            dgTitleComboBox.Location = new Point(134, 24);
            dgTitleComboBox.MaxLength = 50;
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
            // addReviewPanel
            // 
            addReviewPanel.BackColor = SystemColors.Control;
            addReviewPanel.Controls.Add(arTitleComboBox);
            addReviewPanel.Controls.Add(arRatingNum);
            addReviewPanel.Controls.Add(arAddButton);
            addReviewPanel.Controls.Add(arReviewTextBox);
            addReviewPanel.Controls.Add(arReviewLabel);
            addReviewPanel.Controls.Add(arRatingLabel);
            addReviewPanel.Controls.Add(arTitleLabel);
            addReviewPanel.Enabled = false;
            addReviewPanel.Location = new Point(230, 96);
            addReviewPanel.Name = "addReviewPanel";
            addReviewPanel.Size = new Size(571, 351);
            addReviewPanel.TabIndex = 15;
            addReviewPanel.Visible = false;
            // 
            // arTitleComboBox
            // 
            arTitleComboBox.FormattingEnabled = true;
            arTitleComboBox.Location = new Point(134, 24);
            arTitleComboBox.MaxLength = 50;
            arTitleComboBox.Name = "arTitleComboBox";
            arTitleComboBox.Size = new Size(265, 23);
            arTitleComboBox.TabIndex = 15;
            // 
            // arRatingNum
            // 
            arRatingNum.Font = new Font("Segoe UI", 14F);
            arRatingNum.Location = new Point(134, 72);
            arRatingNum.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            arRatingNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            arRatingNum.Name = "arRatingNum";
            arRatingNum.Size = new Size(53, 32);
            arRatingNum.TabIndex = 9;
            arRatingNum.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // arAddButton
            // 
            arAddButton.Font = new Font("Segoe UI", 14F);
            arAddButton.Location = new Point(280, 300);
            arAddButton.Name = "arAddButton";
            arAddButton.Size = new Size(119, 42);
            arAddButton.TabIndex = 8;
            arAddButton.Text = "ADD";
            arAddButton.UseVisualStyleBackColor = true;
            arAddButton.Click += arAddButton_Click;
            // 
            // arReviewTextBox
            // 
            arReviewTextBox.Location = new Point(134, 130);
            arReviewTextBox.MaxLength = 4000;
            arReviewTextBox.Multiline = true;
            arReviewTextBox.Name = "arReviewTextBox";
            arReviewTextBox.Size = new Size(265, 159);
            arReviewTextBox.TabIndex = 7;
            // 
            // arReviewLabel
            // 
            arReviewLabel.AutoSize = true;
            arReviewLabel.Font = new Font("Segoe UI", 14F);
            arReviewLabel.Location = new Point(19, 128);
            arReviewLabel.Name = "arReviewLabel";
            arReviewLabel.Size = new Size(79, 25);
            arReviewLabel.TabIndex = 6;
            arReviewLabel.Text = "Review: ";
            // 
            // arRatingLabel
            // 
            arRatingLabel.AutoSize = true;
            arRatingLabel.Font = new Font("Segoe UI", 14F);
            arRatingLabel.Location = new Point(19, 75);
            arRatingLabel.Name = "arRatingLabel";
            arRatingLabel.Size = new Size(75, 25);
            arRatingLabel.TabIndex = 2;
            arRatingLabel.Text = "Rating: ";
            // 
            // arTitleLabel
            // 
            arTitleLabel.AutoSize = true;
            arTitleLabel.Font = new Font("Segoe UI", 14F);
            arTitleLabel.Location = new Point(19, 22);
            arTitleLabel.Name = "arTitleLabel";
            arTitleLabel.Size = new Size(111, 25);
            arTitleLabel.TabIndex = 0;
            arTitleLabel.Text = "Game Title: ";
            // 
            // GamerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(addReviewButton);
            Controls.Add(deleteGameButton);
            Controls.Add(addGameButton);
            Controls.Add(getInfoButton);
            Controls.Add(greetingLabel);
            Controls.Add(blueBG);
            Controls.Add(addReviewPanel);
            Controls.Add(deleteGamePanel);
            Controls.Add(addGamePanel);
            Controls.Add(getInfoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GamerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamerForm";
            Load += GamerForm_Load;
            ((System.ComponentModel.ISupportInitialize)blueBG).EndInit();
            getInfoPanel.ResumeLayout(false);
            getInfoPanel.PerformLayout();
            addGamePanel.ResumeLayout(false);
            addGamePanel.PerformLayout();
            deleteGamePanel.ResumeLayout(false);
            deleteGamePanel.PerformLayout();
            addReviewPanel.ResumeLayout(false);
            addReviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)arRatingNum).EndInit();
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
        private Button addGameButton;
        private Button deleteGameButton;
        private Button addReviewButton;
        private Panel addGamePanel;
        private ComboBox agTitleComboBox;
        private Button agAddButton;
        private Label agTitleLabel;
        private Panel deleteGamePanel;
        private ComboBox dgTitleComboBox;
        private Button dgDeleteButton;
        private Label dgTitleLabel;
        private Panel addReviewPanel;
        private Button arAddButton;
        private TextBox arReviewTextBox;
        private Label arReviewLabel;
        private Label arRatingLabel;
        private Label arTitleLabel;
        private NumericUpDown arRatingNum;
        private ComboBox arTitleComboBox;
    }
}