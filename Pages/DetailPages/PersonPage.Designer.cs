namespace VeresiyeDefteri
{
    partial class PersonPageForm
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
            PersonNameLabel = new Label();
            PersonSurnameLabel = new Label();
            PersonPhoneLabel = new Label();
            PersonMobilePhoneLabel = new Label();
            PersonMailLabel = new Label();
            PersonIdentityNumberLabel = new Label();
            PersonAddressLabel = new Label();
            PersonDescriptionLabel = new Label();
            PersonIncomingBalanceLabel = new Label();
            PersonNameTextBox = new TextBox();
            PersonSurnameTextBox = new TextBox();
            PersonPhoneTextBox = new TextBox();
            PersonMobilePhoneTextBox = new TextBox();
            PersonEmailTextBox = new TextBox();
            PersonIdentityNumberTextBox = new TextBox();
            PersonAddressTextBox = new TextBox();
            PersonDescriptionTextBox = new TextBox();
            PersonIncomingBalanceTextBox = new TextBox();
            EnableEditPersonButton = new Button();
            SavePersonButton = new Button();
            DeletePersonButton = new Button();
            PersonOutgoingBalanceLabel = new Label();
            PersonOutgoingBalanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // PersonNameLabel
            // 
            PersonNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonNameLabel.Location = new Point(10, 10);
            PersonNameLabel.Name = "PersonNameLabel";
            PersonNameLabel.Size = new Size(100, 23);
            PersonNameLabel.TabIndex = 13;
            PersonNameLabel.Text = "Adı";
            PersonNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonSurnameLabel
            // 
            PersonSurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonSurnameLabel.Location = new Point(10, 43);
            PersonSurnameLabel.Name = "PersonSurnameLabel";
            PersonSurnameLabel.Size = new Size(100, 23);
            PersonSurnameLabel.TabIndex = 14;
            PersonSurnameLabel.Text = "Soyadı";
            PersonSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonPhoneLabel
            // 
            PersonPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonPhoneLabel.Location = new Point(10, 76);
            PersonPhoneLabel.Name = "PersonPhoneLabel";
            PersonPhoneLabel.Size = new Size(100, 23);
            PersonPhoneLabel.TabIndex = 15;
            PersonPhoneLabel.Text = "Telefon";
            PersonPhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonMobilePhoneLabel
            // 
            PersonMobilePhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonMobilePhoneLabel.Location = new Point(10, 109);
            PersonMobilePhoneLabel.Name = "PersonMobilePhoneLabel";
            PersonMobilePhoneLabel.Size = new Size(100, 23);
            PersonMobilePhoneLabel.TabIndex = 16;
            PersonMobilePhoneLabel.Text = "Cep Telefonu";
            PersonMobilePhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonMailLabel
            // 
            PersonMailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonMailLabel.Location = new Point(10, 142);
            PersonMailLabel.Name = "PersonMailLabel";
            PersonMailLabel.Size = new Size(100, 23);
            PersonMailLabel.TabIndex = 17;
            PersonMailLabel.Text = "Email";
            PersonMailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonIdentityNumberLabel
            // 
            PersonIdentityNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonIdentityNumberLabel.Location = new Point(10, 175);
            PersonIdentityNumberLabel.Name = "PersonIdentityNumberLabel";
            PersonIdentityNumberLabel.Size = new Size(100, 23);
            PersonIdentityNumberLabel.TabIndex = 18;
            PersonIdentityNumberLabel.Text = "TC Kimlik No";
            PersonIdentityNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonAddressLabel
            // 
            PersonAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonAddressLabel.Location = new Point(330, 10);
            PersonAddressLabel.Name = "PersonAddressLabel";
            PersonAddressLabel.Size = new Size(100, 23);
            PersonAddressLabel.TabIndex = 19;
            PersonAddressLabel.Text = "Adres";
            PersonAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonDescriptionLabel
            // 
            PersonDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonDescriptionLabel.Location = new Point(330, 76);
            PersonDescriptionLabel.Name = "PersonDescriptionLabel";
            PersonDescriptionLabel.Size = new Size(100, 23);
            PersonDescriptionLabel.TabIndex = 20;
            PersonDescriptionLabel.Text = "Açıklama";
            PersonDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonIncomingBalanceLabel
            // 
            PersonIncomingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonIncomingBalanceLabel.Location = new Point(330, 142);
            PersonIncomingBalanceLabel.Name = "PersonIncomingBalanceLabel";
            PersonIncomingBalanceLabel.Size = new Size(100, 23);
            PersonIncomingBalanceLabel.TabIndex = 21;
            PersonIncomingBalanceLabel.Text = "Alacak";
            PersonIncomingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonNameTextBox
            // 
            PersonNameTextBox.Location = new Point(120, 10);
            PersonNameTextBox.Name = "PersonNameTextBox";
            PersonNameTextBox.PlaceholderText = "Adı";
            PersonNameTextBox.Size = new Size(200, 23);
            PersonNameTextBox.TabIndex = 0;
            // 
            // PersonSurnameTextBox
            // 
            PersonSurnameTextBox.Location = new Point(120, 43);
            PersonSurnameTextBox.Name = "PersonSurnameTextBox";
            PersonSurnameTextBox.PlaceholderText = "Soyadı";
            PersonSurnameTextBox.Size = new Size(200, 23);
            PersonSurnameTextBox.TabIndex = 1;
            // 
            // PersonPhoneTextBox
            // 
            PersonPhoneTextBox.Location = new Point(120, 76);
            PersonPhoneTextBox.Name = "PersonPhoneTextBox";
            PersonPhoneTextBox.PlaceholderText = "Telefon";
            PersonPhoneTextBox.Size = new Size(200, 23);
            PersonPhoneTextBox.TabIndex = 2;
            // 
            // PersonMobilePhoneTextBox
            // 
            PersonMobilePhoneTextBox.Location = new Point(120, 109);
            PersonMobilePhoneTextBox.Name = "PersonMobilePhoneTextBox";
            PersonMobilePhoneTextBox.PlaceholderText = "Cep Telefonu";
            PersonMobilePhoneTextBox.Size = new Size(200, 23);
            PersonMobilePhoneTextBox.TabIndex = 3;
            // 
            // PersonEmailTextBox
            // 
            PersonEmailTextBox.Location = new Point(120, 142);
            PersonEmailTextBox.Name = "PersonEmailTextBox";
            PersonEmailTextBox.PlaceholderText = "Email";
            PersonEmailTextBox.Size = new Size(200, 23);
            PersonEmailTextBox.TabIndex = 4;
            // 
            // PersonIdentityNumberTextBox
            // 
            PersonIdentityNumberTextBox.Location = new Point(120, 175);
            PersonIdentityNumberTextBox.Name = "PersonIdentityNumberTextBox";
            PersonIdentityNumberTextBox.PlaceholderText = "TC Kimlik No";
            PersonIdentityNumberTextBox.Size = new Size(200, 23);
            PersonIdentityNumberTextBox.TabIndex = 5;
            // 
            // PersonAddressTextBox
            // 
            PersonAddressTextBox.Location = new Point(440, 10);
            PersonAddressTextBox.Multiline = true;
            PersonAddressTextBox.Name = "PersonAddressTextBox";
            PersonAddressTextBox.PlaceholderText = "Adres";
            PersonAddressTextBox.Size = new Size(200, 56);
            PersonAddressTextBox.TabIndex = 6;
            // 
            // PersonDescriptionTextBox
            // 
            PersonDescriptionTextBox.Location = new Point(440, 76);
            PersonDescriptionTextBox.Multiline = true;
            PersonDescriptionTextBox.Name = "PersonDescriptionTextBox";
            PersonDescriptionTextBox.PlaceholderText = "Açıklama";
            PersonDescriptionTextBox.Size = new Size(200, 56);
            PersonDescriptionTextBox.TabIndex = 7;
            // 
            // PersonIncomingBalanceTextBox
            // 
            PersonIncomingBalanceTextBox.Location = new Point(440, 142);
            PersonIncomingBalanceTextBox.Name = "PersonIncomingBalanceTextBox";
            PersonIncomingBalanceTextBox.PlaceholderText = "Alacak";
            PersonIncomingBalanceTextBox.Size = new Size(200, 23);
            PersonIncomingBalanceTextBox.TabIndex = 8;
            // 
            // EnableEditPersonButton
            // 
            EnableEditPersonButton.Location = new Point(670, 76);
            EnableEditPersonButton.Name = "EnableEditPersonButton";
            EnableEditPersonButton.Size = new Size(100, 56);
            EnableEditPersonButton.TabIndex = 11;
            EnableEditPersonButton.Text = "Düzenlemeyi Aç";
            EnableEditPersonButton.UseVisualStyleBackColor = true;
            EnableEditPersonButton.Click += EnableEditPersonButton_Click;
            // 
            // SavePersonButton
            // 
            SavePersonButton.Location = new Point(670, 142);
            SavePersonButton.Name = "SavePersonButton";
            SavePersonButton.Size = new Size(100, 56);
            SavePersonButton.TabIndex = 10;
            SavePersonButton.Text = "Kaydet";
            SavePersonButton.UseVisualStyleBackColor = true;
            SavePersonButton.Click += SavePersonButton_Click;
            // 
            // DeletePersonButton
            // 
            DeletePersonButton.Location = new Point(670, 10);
            DeletePersonButton.Name = "DeletePersonButton";
            DeletePersonButton.Size = new Size(100, 56);
            DeletePersonButton.TabIndex = 12;
            DeletePersonButton.Text = "Sil";
            DeletePersonButton.UseVisualStyleBackColor = true;
            DeletePersonButton.Click += DeletePersonButton_Click;
            // 
            // PersonOutgoingBalanceLabel
            // 
            PersonOutgoingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonOutgoingBalanceLabel.Location = new Point(330, 175);
            PersonOutgoingBalanceLabel.Name = "PersonOutgoingBalanceLabel";
            PersonOutgoingBalanceLabel.Size = new Size(100, 23);
            PersonOutgoingBalanceLabel.TabIndex = 22;
            PersonOutgoingBalanceLabel.Text = "Verecek";
            PersonOutgoingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonOutgoingBalanceTextBox
            // 
            PersonOutgoingBalanceTextBox.Location = new Point(440, 175);
            PersonOutgoingBalanceTextBox.Name = "PersonOutgoingBalanceTextBox";
            PersonOutgoingBalanceTextBox.PlaceholderText = "Verecek";
            PersonOutgoingBalanceTextBox.Size = new Size(200, 23);
            PersonOutgoingBalanceTextBox.TabIndex = 9;
            // 
            // PersonPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(PersonOutgoingBalanceTextBox);
            Controls.Add(PersonOutgoingBalanceLabel);
            Controls.Add(DeletePersonButton);
            Controls.Add(SavePersonButton);
            Controls.Add(EnableEditPersonButton);
            Controls.Add(PersonIncomingBalanceTextBox);
            Controls.Add(PersonDescriptionTextBox);
            Controls.Add(PersonAddressTextBox);
            Controls.Add(PersonIdentityNumberTextBox);
            Controls.Add(PersonEmailTextBox);
            Controls.Add(PersonMobilePhoneTextBox);
            Controls.Add(PersonPhoneTextBox);
            Controls.Add(PersonSurnameTextBox);
            Controls.Add(PersonNameTextBox);
            Controls.Add(PersonIncomingBalanceLabel);
            Controls.Add(PersonDescriptionLabel);
            Controls.Add(PersonAddressLabel);
            Controls.Add(PersonIdentityNumberLabel);
            Controls.Add(PersonMailLabel);
            Controls.Add(PersonMobilePhoneLabel);
            Controls.Add(PersonPhoneLabel);
            Controls.Add(PersonSurnameLabel);
            Controls.Add(PersonNameLabel);
            Name = "PersonPageForm";
            Text = "Kişi Detayı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonNameLabel;
        private Label PersonSurnameLabel;
        private Label PersonPhoneLabel;
        private Label PersonMobilePhoneLabel;
        private Label PersonMailLabel;
        private Label PersonIdentityNumberLabel;
        private Label PersonAddressLabel;
        private Label PersonDescriptionLabel;
        private Label PersonIncomingBalanceLabel;
        private TextBox PersonNameTextBox;
        private TextBox PersonSurnameTextBox;
        private TextBox PersonPhoneTextBox;
        private TextBox PersonMobilePhoneTextBox;
        private TextBox PersonEmailTextBox;
        private TextBox PersonIdentityNumberTextBox;
        private TextBox PersonAddressTextBox;
        private TextBox PersonDescriptionTextBox;
        private TextBox PersonIncomingBalanceTextBox;
        private Button EnableEditPersonButton;
        private Button SavePersonButton;
        private Button DeletePersonButton;
        private Label PersonOutgoingBalanceLabel;
        private TextBox PersonOutgoingBalanceTextBox;
    }
}