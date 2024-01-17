namespace VeresiyeDefteri
{
    partial class ReceiptItemAddingPageForm
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
            ReceiptPersonNameSurnameTextBox = new TextBox();
            ReceiptPersonNameSurnameLabel = new Label();
            ReceiptItemDateLabel = new Label();
            ReceiptPersonTotalBalanceLabel = new Label();
            ReceiptPersonIncomingBalanceLabel = new Label();
            ReceiptPersonOutgoingBalanceLabel = new Label();
            SaveReceiptItemButton = new Button();
            SelectReceiptItemLabel = new Label();
            ReceiptItemDateTextBox = new TextBox();
            ReceiptPersonIncomingBalanceTextBox = new TextBox();
            ReceiptPersonOutgoingBalanceTextBox = new TextBox();
            ReceiptPersonTotalBalanceTextBox = new TextBox();
            ReceiptItemPriceLabel = new Label();
            ReceiptItemSpecialPriceLabel = new Label();
            SelectReceiptItemComboBox = new ComboBox();
            ReceiptItemPriceTextBox = new TextBox();
            ReceiptItemSpecialPriceTextBox = new TextBox();
            ReceiptItemQuantityLabel = new Label();
            ReceiptItemQuantityTextBox = new TextBox();
            ReceiptItemTotalPriceLabel = new Label();
            ReceiptItemTotalPriceTextBox = new TextBox();
            SuspendLayout();
            // 
            // ReceiptPersonNameSurnameTextBox
            // 
            ReceiptPersonNameSurnameTextBox.Location = new Point(510, 10);
            ReceiptPersonNameSurnameTextBox.Name = "ReceiptPersonNameSurnameTextBox";
            ReceiptPersonNameSurnameTextBox.PlaceholderText = "Kişi Adı Soyadı";
            ReceiptPersonNameSurnameTextBox.ReadOnly = true;
            ReceiptPersonNameSurnameTextBox.Size = new Size(200, 23);
            ReceiptPersonNameSurnameTextBox.TabIndex = 5;
            // 
            // ReceiptPersonNameSurnameLabel
            // 
            ReceiptPersonNameSurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptPersonNameSurnameLabel.Location = new Point(400, 10);
            ReceiptPersonNameSurnameLabel.Name = "ReceiptPersonNameSurnameLabel";
            ReceiptPersonNameSurnameLabel.Size = new Size(100, 23);
            ReceiptPersonNameSurnameLabel.TabIndex = 0;
            ReceiptPersonNameSurnameLabel.Text = "Kişi Adı Soyadı";
            ReceiptPersonNameSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptItemDateLabel
            // 
            ReceiptItemDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptItemDateLabel.Location = new Point(400, 43);
            ReceiptItemDateLabel.Name = "ReceiptItemDateLabel";
            ReceiptItemDateLabel.Size = new Size(100, 23);
            ReceiptItemDateLabel.TabIndex = 2;
            ReceiptItemDateLabel.Text = "Tarih";
            ReceiptItemDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptPersonTotalBalanceLabel
            // 
            ReceiptPersonTotalBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptPersonTotalBalanceLabel.Location = new Point(400, 142);
            ReceiptPersonTotalBalanceLabel.Name = "ReceiptPersonTotalBalanceLabel";
            ReceiptPersonTotalBalanceLabel.Size = new Size(100, 23);
            ReceiptPersonTotalBalanceLabel.TabIndex = 3;
            ReceiptPersonTotalBalanceLabel.Text = "Toplam Tutar";
            ReceiptPersonTotalBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptPersonIncomingBalanceLabel
            // 
            ReceiptPersonIncomingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptPersonIncomingBalanceLabel.Location = new Point(400, 76);
            ReceiptPersonIncomingBalanceLabel.Name = "ReceiptPersonIncomingBalanceLabel";
            ReceiptPersonIncomingBalanceLabel.Size = new Size(100, 23);
            ReceiptPersonIncomingBalanceLabel.TabIndex = 4;
            ReceiptPersonIncomingBalanceLabel.Text = "Alacak";
            ReceiptPersonIncomingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptPersonOutgoingBalanceLabel
            // 
            ReceiptPersonOutgoingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptPersonOutgoingBalanceLabel.Location = new Point(400, 109);
            ReceiptPersonOutgoingBalanceLabel.Name = "ReceiptPersonOutgoingBalanceLabel";
            ReceiptPersonOutgoingBalanceLabel.Size = new Size(100, 23);
            ReceiptPersonOutgoingBalanceLabel.TabIndex = 5;
            ReceiptPersonOutgoingBalanceLabel.Text = "Verecek";
            ReceiptPersonOutgoingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SaveReceiptItemButton
            // 
            SaveReceiptItemButton.Location = new Point(10, 175);
            SaveReceiptItemButton.Name = "SaveReceiptItemButton";
            SaveReceiptItemButton.Size = new Size(360, 56);
            SaveReceiptItemButton.TabIndex = 4;
            SaveReceiptItemButton.Text = "Ekle";
            SaveReceiptItemButton.UseVisualStyleBackColor = true;
            SaveReceiptItemButton.Click += SaveReceiptItemButton_Click;
            // 
            // SelectReceiptItemLabel
            // 
            SelectReceiptItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectReceiptItemLabel.Location = new Point(10, 10);
            SelectReceiptItemLabel.Name = "SelectReceiptItemLabel";
            SelectReceiptItemLabel.Size = new Size(150, 23);
            SelectReceiptItemLabel.TabIndex = 13;
            SelectReceiptItemLabel.Text = "Ürün Seç";
            SelectReceiptItemLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptItemDateTextBox
            // 
            ReceiptItemDateTextBox.Location = new Point(510, 43);
            ReceiptItemDateTextBox.Name = "ReceiptItemDateTextBox";
            ReceiptItemDateTextBox.PlaceholderText = "Tarih";
            ReceiptItemDateTextBox.ReadOnly = true;
            ReceiptItemDateTextBox.Size = new Size(200, 23);
            ReceiptItemDateTextBox.TabIndex = 6;
            // 
            // ReceiptPersonIncomingBalanceTextBox
            // 
            ReceiptPersonIncomingBalanceTextBox.Location = new Point(510, 76);
            ReceiptPersonIncomingBalanceTextBox.Name = "ReceiptPersonIncomingBalanceTextBox";
            ReceiptPersonIncomingBalanceTextBox.PlaceholderText = "Alacak";
            ReceiptPersonIncomingBalanceTextBox.ReadOnly = true;
            ReceiptPersonIncomingBalanceTextBox.Size = new Size(200, 23);
            ReceiptPersonIncomingBalanceTextBox.TabIndex = 7;
            // 
            // ReceiptPersonOutgoingBalanceTextBox
            // 
            ReceiptPersonOutgoingBalanceTextBox.Location = new Point(510, 109);
            ReceiptPersonOutgoingBalanceTextBox.Name = "ReceiptPersonOutgoingBalanceTextBox";
            ReceiptPersonOutgoingBalanceTextBox.PlaceholderText = "Verecek";
            ReceiptPersonOutgoingBalanceTextBox.ReadOnly = true;
            ReceiptPersonOutgoingBalanceTextBox.Size = new Size(200, 23);
            ReceiptPersonOutgoingBalanceTextBox.TabIndex = 8;
            // 
            // ReceiptPersonTotalBalanceTextBox
            // 
            ReceiptPersonTotalBalanceTextBox.Location = new Point(510, 142);
            ReceiptPersonTotalBalanceTextBox.Name = "ReceiptPersonTotalBalanceTextBox";
            ReceiptPersonTotalBalanceTextBox.PlaceholderText = "Toplam Tutar";
            ReceiptPersonTotalBalanceTextBox.ReadOnly = true;
            ReceiptPersonTotalBalanceTextBox.Size = new Size(200, 23);
            ReceiptPersonTotalBalanceTextBox.TabIndex = 9;
            // 
            // ReceiptItemPriceLabel
            // 
            ReceiptItemPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptItemPriceLabel.Location = new Point(10, 43);
            ReceiptItemPriceLabel.Name = "ReceiptItemPriceLabel";
            ReceiptItemPriceLabel.Size = new Size(150, 23);
            ReceiptItemPriceLabel.TabIndex = 18;
            ReceiptItemPriceLabel.Text = "Ürün Güncel Fiyatı";
            ReceiptItemPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptItemSpecialPriceLabel
            // 
            ReceiptItemSpecialPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptItemSpecialPriceLabel.Location = new Point(10, 76);
            ReceiptItemSpecialPriceLabel.Name = "ReceiptItemSpecialPriceLabel";
            ReceiptItemSpecialPriceLabel.Size = new Size(150, 23);
            ReceiptItemSpecialPriceLabel.TabIndex = 19;
            ReceiptItemSpecialPriceLabel.Text = "Kişiye Özel Fiyat";
            ReceiptItemSpecialPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectReceiptItemComboBox
            // 
            SelectReceiptItemComboBox.FormattingEnabled = true;
            SelectReceiptItemComboBox.Location = new Point(170, 10);
            SelectReceiptItemComboBox.Name = "SelectReceiptItemComboBox";
            SelectReceiptItemComboBox.Size = new Size(200, 23);
            SelectReceiptItemComboBox.TabIndex = 0;
            SelectReceiptItemComboBox.SelectedIndexChanged += SelectReceiptItemComboBox_SelectedIndexChanged;
            // 
            // ReceiptItemPriceTextBox
            // 
            ReceiptItemPriceTextBox.Location = new Point(170, 43);
            ReceiptItemPriceTextBox.Name = "ReceiptItemPriceTextBox";
            ReceiptItemPriceTextBox.PlaceholderText = "Ürün Güncel Fiyatı";
            ReceiptItemPriceTextBox.ReadOnly = true;
            ReceiptItemPriceTextBox.Size = new Size(200, 23);
            ReceiptItemPriceTextBox.TabIndex = 1;
            // 
            // ReceiptItemSpecialPriceTextBox
            // 
            ReceiptItemSpecialPriceTextBox.Location = new Point(170, 76);
            ReceiptItemSpecialPriceTextBox.Name = "ReceiptItemSpecialPriceTextBox";
            ReceiptItemSpecialPriceTextBox.PlaceholderText = "Kişiye Özel Fiyat";
            ReceiptItemSpecialPriceTextBox.Size = new Size(200, 23);
            ReceiptItemSpecialPriceTextBox.TabIndex = 2;
            ReceiptItemSpecialPriceTextBox.TextChanged += ReceiptItemSpecialPriceTextBox_TextChanged;
            ReceiptItemSpecialPriceTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // ReceiptItemQuantityLabel
            // 
            ReceiptItemQuantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptItemQuantityLabel.Location = new Point(10, 109);
            ReceiptItemQuantityLabel.Name = "ReceiptItemQuantityLabel";
            ReceiptItemQuantityLabel.Size = new Size(150, 23);
            ReceiptItemQuantityLabel.TabIndex = 23;
            ReceiptItemQuantityLabel.Text = "Ürün Adedi";
            ReceiptItemQuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptItemQuantityTextBox
            // 
            ReceiptItemQuantityTextBox.Location = new Point(170, 109);
            ReceiptItemQuantityTextBox.Name = "ReceiptItemQuantityTextBox";
            ReceiptItemQuantityTextBox.PlaceholderText = "Ürün Adedi";
            ReceiptItemQuantityTextBox.Size = new Size(200, 23);
            ReceiptItemQuantityTextBox.TabIndex = 3;
            ReceiptItemQuantityTextBox.TextChanged += ReceiptItemQuantityTextBox_TextChanged;
            ReceiptItemQuantityTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // ReceiptItemTotalPriceLabel
            // 
            ReceiptItemTotalPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptItemTotalPriceLabel.Location = new Point(10, 142);
            ReceiptItemTotalPriceLabel.Name = "ReceiptItemTotalPriceLabel";
            ReceiptItemTotalPriceLabel.Size = new Size(150, 23);
            ReceiptItemTotalPriceLabel.TabIndex = 24;
            ReceiptItemTotalPriceLabel.Text = "Ürün Toplamı";
            ReceiptItemTotalPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReceiptItemTotalPriceTextBox
            // 
            ReceiptItemTotalPriceTextBox.Location = new Point(170, 142);
            ReceiptItemTotalPriceTextBox.Name = "ReceiptItemTotalPriceTextBox";
            ReceiptItemTotalPriceTextBox.PlaceholderText = "Ürün Toplam Tutarı";
            ReceiptItemTotalPriceTextBox.ReadOnly = true;
            ReceiptItemTotalPriceTextBox.Size = new Size(200, 23);
            ReceiptItemTotalPriceTextBox.TabIndex = 25;
            // 
            // ReceiptItemAddingPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 241);
            Controls.Add(ReceiptItemTotalPriceTextBox);
            Controls.Add(ReceiptItemTotalPriceLabel);
            Controls.Add(ReceiptItemQuantityTextBox);
            Controls.Add(ReceiptItemQuantityLabel);
            Controls.Add(ReceiptItemSpecialPriceTextBox);
            Controls.Add(ReceiptItemPriceTextBox);
            Controls.Add(SelectReceiptItemComboBox);
            Controls.Add(ReceiptItemSpecialPriceLabel);
            Controls.Add(ReceiptItemPriceLabel);
            Controls.Add(ReceiptPersonTotalBalanceTextBox);
            Controls.Add(ReceiptPersonOutgoingBalanceTextBox);
            Controls.Add(ReceiptPersonIncomingBalanceTextBox);
            Controls.Add(ReceiptItemDateTextBox);
            Controls.Add(SelectReceiptItemLabel);
            Controls.Add(SaveReceiptItemButton);
            Controls.Add(ReceiptPersonOutgoingBalanceLabel);
            Controls.Add(ReceiptPersonIncomingBalanceLabel);
            Controls.Add(ReceiptPersonTotalBalanceLabel);
            Controls.Add(ReceiptItemDateLabel);
            Controls.Add(ReceiptPersonNameSurnameTextBox);
            Controls.Add(ReceiptPersonNameSurnameLabel);
            Name = "ReceiptItemAddingPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fiş Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ReceiptPersonNameSurnameTextBox;
        private DataGridView ReceiptProductsDataGridView;
        private DataGridViewTextBoxColumn ReceiptProductName;
        private DataGridViewTextBoxColumn ReceiptProductQuantity;
        private DataGridViewTextBoxColumn ReceiptProductPrice;
        private DataGridViewTextBoxColumn ReceiptProductTotalPrice;
        private Label ReceiptPersonNameSurnameLabel;
        private Label ReceiptItemDateLabel;
        private Label ReceiptPersonTotalBalanceLabel;
        private Label ReceiptPersonIncomingBalanceLabel;
        private Label ReceiptPersonOutgoingBalanceLabel;
        private Button DeleteProductButton;
        private Button SaveReceiptItemButton;
        private Button button1;
        private ComboBox SelectReceiptPersonComboBox;
        private Label SelectReceiptItemLabel;
        private TextBox ReceiptItemDateTextBox;
        private TextBox ReceiptPersonIncomingBalanceTextBox;
        private TextBox ReceiptPersonOutgoingBalanceTextBox;
        private TextBox ReceiptPersonTotalBalanceTextBox;
        private Label ReceiptItemPriceLabel;
        private Label ReceiptItemSpecialPriceLabel;
        private ComboBox SelectReceiptItemComboBox;
        private TextBox ReceiptItemPriceTextBox;
        private TextBox ReceiptItemSpecialPriceTextBox;
        private Label ReceiptItemQuantityLabel;
        private TextBox ReceiptItemQuantityTextBox;
        private Label ReceiptItemTotalPriceLabel;
        private TextBox ReceiptItemTotalPriceTextBox;
    }
}