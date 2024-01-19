namespace VeresiyeDefteri.Pages
{
    partial class LoginPageForm
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
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            UserLoginButton = new Button();
            ProgramNameLabel = new Label();
            UserPasswordLabel = new Label();
            UserPasswordTextBox = new TextBox();
            UserPasswordAgainLabel = new Label();
            UserPasswordAgainTextBox = new TextBox();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(10, 75);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(100, 23);
            UserNameLabel.TabIndex = 4;
            UserNameLabel.Text = "Kullanıcı Adı";
            UserNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(120, 75);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.PlaceholderText = "Kullanıcı Adı";
            UserNameTextBox.Size = new Size(150, 23);
            UserNameTextBox.TabIndex = 0;
            // 
            // UserLoginButton
            // 
            UserLoginButton.Location = new Point(40, 180);
            UserLoginButton.Name = "UserLoginButton";
            UserLoginButton.Size = new Size(200, 46);
            UserLoginButton.TabIndex = 3;
            UserLoginButton.Text = "Giriş";
            UserLoginButton.UseVisualStyleBackColor = true;
            UserLoginButton.Click += UserLoginButton_Click;
            // 
            // ProgramNameLabel
            // 
            ProgramNameLabel.AutoSize = true;
            ProgramNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProgramNameLabel.Location = new Point(43, 20);
            ProgramNameLabel.Name = "ProgramNameLabel";
            ProgramNameLabel.Size = new Size(194, 32);
            ProgramNameLabel.TabIndex = 7;
            ProgramNameLabel.Text = "Veresiye Defteri";
            // 
            // UserPasswordLabel
            // 
            UserPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserPasswordLabel.Location = new Point(10, 108);
            UserPasswordLabel.Name = "UserPasswordLabel";
            UserPasswordLabel.Size = new Size(100, 23);
            UserPasswordLabel.TabIndex = 5;
            UserPasswordLabel.Text = "Şifre";
            UserPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.Location = new Point(120, 108);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.PasswordChar = '*';
            UserPasswordTextBox.PlaceholderText = "Şifre";
            UserPasswordTextBox.Size = new Size(150, 23);
            UserPasswordTextBox.TabIndex = 1;
            UserPasswordTextBox.KeyPress += UserPasswordTextBox_KeyPress;
            // 
            // UserPasswordAgainLabel
            // 
            UserPasswordAgainLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserPasswordAgainLabel.Location = new Point(10, 141);
            UserPasswordAgainLabel.Name = "UserPasswordAgainLabel";
            UserPasswordAgainLabel.Size = new Size(100, 23);
            UserPasswordAgainLabel.TabIndex = 6;
            UserPasswordAgainLabel.Text = "Şifre Tekrar";
            UserPasswordAgainLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserPasswordAgainTextBox
            // 
            UserPasswordAgainTextBox.Location = new Point(120, 141);
            UserPasswordAgainTextBox.Name = "UserPasswordAgainTextBox";
            UserPasswordAgainTextBox.PasswordChar = '*';
            UserPasswordAgainTextBox.PlaceholderText = "Şifre Tekrar";
            UserPasswordAgainTextBox.Size = new Size(150, 23);
            UserPasswordAgainTextBox.TabIndex = 2;
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 246);
            Controls.Add(UserPasswordAgainTextBox);
            Controls.Add(UserPasswordAgainLabel);
            Controls.Add(UserPasswordTextBox);
            Controls.Add(UserPasswordLabel);
            Controls.Add(ProgramNameLabel);
            Controls.Add(UserLoginButton);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserNameLabel);
            Name = "LoginPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veresiye Defteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private Button UserLoginButton;
        private Label ProgramNameLabel;
        private Label UserPasswordLabel;
        private TextBox UserPasswordTextBox;
        private Label UserPasswordAgainLabel;
        private TextBox UserPasswordAgainTextBox;
    }
}