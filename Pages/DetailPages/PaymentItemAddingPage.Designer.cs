namespace VeresiyeDefteri.Pages.DetailPages
{
    partial class PaymentItemAddingPageForm
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
            SelectPaymentTypeItemLabel = new Label();
            SelectPaymentTypeItemComboBox = new ComboBox();
            PaymentAmountLabel = new Label();
            PaymentAmountTextBox = new TextBox();
            PaymentPersonTotalBalanceTextBox = new TextBox();
            PaymentPersonOutgoingBalanceTextBox = new TextBox();
            PaymentPersonIncomingBalanceTextBox = new TextBox();
            PaymentItemDateTextBox = new TextBox();
            PaymentPersonOutgoingBalanceLabel = new Label();
            PaymentPersonIncomingBalanceLabel = new Label();
            PaymentPersonTotalBalanceLabel = new Label();
            PaymentItemDateLabel = new Label();
            PaymentPersonNameSurnameTextBox = new TextBox();
            PaymentPersonNameSurnameLabel = new Label();
            SavePaymentItemButton = new Button();
            SuspendLayout();
            // 
            // SelectPaymentTypeItemLabel
            // 
            SelectPaymentTypeItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectPaymentTypeItemLabel.Location = new Point(10, 10);
            SelectPaymentTypeItemLabel.Name = "SelectPaymentTypeItemLabel";
            SelectPaymentTypeItemLabel.Size = new Size(150, 23);
            SelectPaymentTypeItemLabel.TabIndex = 8;
            SelectPaymentTypeItemLabel.Text = "Ödeme Türü Seç";
            SelectPaymentTypeItemLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectPaymentTypeItemComboBox
            // 
            SelectPaymentTypeItemComboBox.FormattingEnabled = true;
            SelectPaymentTypeItemComboBox.Location = new Point(170, 10);
            SelectPaymentTypeItemComboBox.Name = "SelectPaymentTypeItemComboBox";
            SelectPaymentTypeItemComboBox.Size = new Size(200, 23);
            SelectPaymentTypeItemComboBox.TabIndex = 2;
            SelectPaymentTypeItemComboBox.SelectedIndexChanged += SelectPaymentItemComboBox_SelectedIndexChanged;
            // 
            // PaymentAmountLabel
            // 
            PaymentAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentAmountLabel.Location = new Point(10, 43);
            PaymentAmountLabel.Name = "PaymentAmountLabel";
            PaymentAmountLabel.Size = new Size(150, 23);
            PaymentAmountLabel.TabIndex = 9;
            PaymentAmountLabel.Text = "Ödeme Tutarı";
            PaymentAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentAmountTextBox
            // 
            PaymentAmountTextBox.Location = new Point(170, 43);
            PaymentAmountTextBox.Name = "PaymentAmountTextBox";
            PaymentAmountTextBox.PlaceholderText = "Ödeme Tutarı";
            PaymentAmountTextBox.Size = new Size(200, 23);
            PaymentAmountTextBox.TabIndex = 0;
            PaymentAmountTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // PaymentPersonTotalBalanceTextBox
            // 
            PaymentPersonTotalBalanceTextBox.Location = new Point(510, 142);
            PaymentPersonTotalBalanceTextBox.Name = "PaymentPersonTotalBalanceTextBox";
            PaymentPersonTotalBalanceTextBox.PlaceholderText = "Toplam Tutar";
            PaymentPersonTotalBalanceTextBox.ReadOnly = true;
            PaymentPersonTotalBalanceTextBox.Size = new Size(200, 23);
            PaymentPersonTotalBalanceTextBox.TabIndex = 7;
            // 
            // PaymentPersonOutgoingBalanceTextBox
            // 
            PaymentPersonOutgoingBalanceTextBox.Location = new Point(510, 109);
            PaymentPersonOutgoingBalanceTextBox.Name = "PaymentPersonOutgoingBalanceTextBox";
            PaymentPersonOutgoingBalanceTextBox.PlaceholderText = "Verecek";
            PaymentPersonOutgoingBalanceTextBox.ReadOnly = true;
            PaymentPersonOutgoingBalanceTextBox.Size = new Size(200, 23);
            PaymentPersonOutgoingBalanceTextBox.TabIndex = 6;
            // 
            // PaymentPersonIncomingBalanceTextBox
            // 
            PaymentPersonIncomingBalanceTextBox.Location = new Point(510, 76);
            PaymentPersonIncomingBalanceTextBox.Name = "PaymentPersonIncomingBalanceTextBox";
            PaymentPersonIncomingBalanceTextBox.PlaceholderText = "Alacak";
            PaymentPersonIncomingBalanceTextBox.ReadOnly = true;
            PaymentPersonIncomingBalanceTextBox.Size = new Size(200, 23);
            PaymentPersonIncomingBalanceTextBox.TabIndex = 5;
            // 
            // PaymentItemDateTextBox
            // 
            PaymentItemDateTextBox.Location = new Point(510, 43);
            PaymentItemDateTextBox.Name = "PaymentItemDateTextBox";
            PaymentItemDateTextBox.PlaceholderText = "Tarih";
            PaymentItemDateTextBox.ReadOnly = true;
            PaymentItemDateTextBox.Size = new Size(200, 23);
            PaymentItemDateTextBox.TabIndex = 4;
            // 
            // PaymentPersonOutgoingBalanceLabel
            // 
            PaymentPersonOutgoingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentPersonOutgoingBalanceLabel.Location = new Point(400, 109);
            PaymentPersonOutgoingBalanceLabel.Name = "PaymentPersonOutgoingBalanceLabel";
            PaymentPersonOutgoingBalanceLabel.Size = new Size(100, 23);
            PaymentPersonOutgoingBalanceLabel.TabIndex = 13;
            PaymentPersonOutgoingBalanceLabel.Text = "Verecek";
            PaymentPersonOutgoingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentPersonIncomingBalanceLabel
            // 
            PaymentPersonIncomingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentPersonIncomingBalanceLabel.Location = new Point(400, 76);
            PaymentPersonIncomingBalanceLabel.Name = "PaymentPersonIncomingBalanceLabel";
            PaymentPersonIncomingBalanceLabel.Size = new Size(100, 23);
            PaymentPersonIncomingBalanceLabel.TabIndex = 12;
            PaymentPersonIncomingBalanceLabel.Text = "Alacak";
            PaymentPersonIncomingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentPersonTotalBalanceLabel
            // 
            PaymentPersonTotalBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentPersonTotalBalanceLabel.Location = new Point(400, 142);
            PaymentPersonTotalBalanceLabel.Name = "PaymentPersonTotalBalanceLabel";
            PaymentPersonTotalBalanceLabel.Size = new Size(100, 23);
            PaymentPersonTotalBalanceLabel.TabIndex = 14;
            PaymentPersonTotalBalanceLabel.Text = "Toplam Tutar";
            PaymentPersonTotalBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentItemDateLabel
            // 
            PaymentItemDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentItemDateLabel.Location = new Point(400, 43);
            PaymentItemDateLabel.Name = "PaymentItemDateLabel";
            PaymentItemDateLabel.Size = new Size(100, 23);
            PaymentItemDateLabel.TabIndex = 11;
            PaymentItemDateLabel.Text = "Tarih";
            PaymentItemDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentPersonNameSurnameTextBox
            // 
            PaymentPersonNameSurnameTextBox.Location = new Point(510, 10);
            PaymentPersonNameSurnameTextBox.Name = "PaymentPersonNameSurnameTextBox";
            PaymentPersonNameSurnameTextBox.PlaceholderText = "Kişi Adı Soyadı";
            PaymentPersonNameSurnameTextBox.ReadOnly = true;
            PaymentPersonNameSurnameTextBox.Size = new Size(200, 23);
            PaymentPersonNameSurnameTextBox.TabIndex = 3;
            // 
            // PaymentPersonNameSurnameLabel
            // 
            PaymentPersonNameSurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentPersonNameSurnameLabel.Location = new Point(400, 10);
            PaymentPersonNameSurnameLabel.Name = "PaymentPersonNameSurnameLabel";
            PaymentPersonNameSurnameLabel.Size = new Size(100, 23);
            PaymentPersonNameSurnameLabel.TabIndex = 10;
            PaymentPersonNameSurnameLabel.Text = "Kişi Adı Soyadı";
            PaymentPersonNameSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SavePaymentItemButton
            // 
            SavePaymentItemButton.Location = new Point(10, 109);
            SavePaymentItemButton.Name = "SavePaymentItemButton";
            SavePaymentItemButton.Size = new Size(360, 56);
            SavePaymentItemButton.TabIndex = 1;
            SavePaymentItemButton.Text = "Ekle";
            SavePaymentItemButton.UseVisualStyleBackColor = true;
            SavePaymentItemButton.Click += SavePaymentItemButton_Click;
            // 
            // PaymentItemAddingPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 181);
            Controls.Add(SavePaymentItemButton);
            Controls.Add(PaymentPersonTotalBalanceTextBox);
            Controls.Add(PaymentPersonOutgoingBalanceTextBox);
            Controls.Add(PaymentPersonIncomingBalanceTextBox);
            Controls.Add(PaymentItemDateTextBox);
            Controls.Add(PaymentPersonOutgoingBalanceLabel);
            Controls.Add(PaymentPersonIncomingBalanceLabel);
            Controls.Add(PaymentPersonTotalBalanceLabel);
            Controls.Add(PaymentItemDateLabel);
            Controls.Add(PaymentPersonNameSurnameTextBox);
            Controls.Add(PaymentPersonNameSurnameLabel);
            Controls.Add(PaymentAmountTextBox);
            Controls.Add(PaymentAmountLabel);
            Controls.Add(SelectPaymentTypeItemComboBox);
            Controls.Add(SelectPaymentTypeItemLabel);
            Name = "PaymentItemAddingPageForm";
            Text = "Ödeme Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectPaymentTypeItemLabel;
        private ComboBox SelectPaymentTypeItemComboBox;
        private Label PaymentAmountLabel;
        private TextBox PaymentAmountTextBox;
        private TextBox PaymentPersonTotalBalanceTextBox;
        private TextBox PaymentPersonOutgoingBalanceTextBox;
        private TextBox PaymentPersonIncomingBalanceTextBox;
        private TextBox PaymentItemDateTextBox;
        private Label PaymentPersonOutgoingBalanceLabel;
        private Label PaymentPersonIncomingBalanceLabel;
        private Label PaymentPersonTotalBalanceLabel;
        private Label PaymentItemDateLabel;
        private TextBox PaymentPersonNameSurnameTextBox;
        private Label PaymentPersonNameSurnameLabel;
        private Button SavePaymentItemButton;
    }
}