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
            SavePersonButton = new Button();
            DeletePersonButton = new Button();
            PersonOutgoingBalanceLabel = new Label();
            PersonOutgoingBalanceTextBox = new TextBox();
            PersonTotalBalanceLabel = new Label();
            PersonTotalBalanceTextBox = new TextBox();
            PersonReceiptsDataGridView = new DataGridView();
            ReceiptItemIdColumn = new DataGridViewTextBoxColumn();
            ReceiptDateColumn = new DataGridViewTextBoxColumn();
            PaymentDateColumn = new DataGridViewTextBoxColumn();
            ProductStockCodeColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            ProductPriceColumn = new DataGridViewTextBoxColumn();
            ProductPriceOnReceiptDateColumn = new DataGridViewTextBoxColumn();
            ProductPriceOnPaymentDateColumn = new DataGridViewTextBoxColumn();
            SpecialPriceForPersonColumn = new DataGridViewTextBoxColumn();
            ProductDiscountPriceColumn = new DataGridViewTextBoxColumn();
            ProductDiscountRatioColumn = new DataGridViewTextBoxColumn();
            ProductQuantityColumn = new DataGridViewTextBoxColumn();
            ProductTotalPriceColumn = new DataGridViewTextBoxColumn();
            PaymentAmountColumn = new DataGridViewTextBoxColumn();
            SaveEditedReceiptItemButtonColumn = new DataGridViewButtonColumn();
            DeleteSelectedReceiptItemButtonColumn = new DataGridViewButtonColumn();
            AddReceiptItemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonReceiptsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PersonNameLabel
            // 
            PersonNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonNameLabel.Location = new Point(10, 10);
            PersonNameLabel.Name = "PersonNameLabel";
            PersonNameLabel.Size = new Size(100, 23);
            PersonNameLabel.TabIndex = 11;
            PersonNameLabel.Text = "Adı";
            PersonNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonSurnameLabel
            // 
            PersonSurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonSurnameLabel.Location = new Point(10, 43);
            PersonSurnameLabel.Name = "PersonSurnameLabel";
            PersonSurnameLabel.Size = new Size(100, 23);
            PersonSurnameLabel.TabIndex = 12;
            PersonSurnameLabel.Text = "Soyadı";
            PersonSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonPhoneLabel
            // 
            PersonPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonPhoneLabel.Location = new Point(10, 76);
            PersonPhoneLabel.Name = "PersonPhoneLabel";
            PersonPhoneLabel.Size = new Size(100, 23);
            PersonPhoneLabel.TabIndex = 13;
            PersonPhoneLabel.Text = "Telefon";
            PersonPhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonMobilePhoneLabel
            // 
            PersonMobilePhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonMobilePhoneLabel.Location = new Point(10, 109);
            PersonMobilePhoneLabel.Name = "PersonMobilePhoneLabel";
            PersonMobilePhoneLabel.Size = new Size(100, 23);
            PersonMobilePhoneLabel.TabIndex = 14;
            PersonMobilePhoneLabel.Text = "Cep Telefonu";
            PersonMobilePhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonMailLabel
            // 
            PersonMailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonMailLabel.Location = new Point(10, 142);
            PersonMailLabel.Name = "PersonMailLabel";
            PersonMailLabel.Size = new Size(100, 23);
            PersonMailLabel.TabIndex = 15;
            PersonMailLabel.Text = "Email";
            PersonMailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonIdentityNumberLabel
            // 
            PersonIdentityNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonIdentityNumberLabel.Location = new Point(10, 175);
            PersonIdentityNumberLabel.Name = "PersonIdentityNumberLabel";
            PersonIdentityNumberLabel.Size = new Size(100, 23);
            PersonIdentityNumberLabel.TabIndex = 16;
            PersonIdentityNumberLabel.Text = "TC Kimlik No";
            PersonIdentityNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonAddressLabel
            // 
            PersonAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonAddressLabel.Location = new Point(330, 10);
            PersonAddressLabel.Name = "PersonAddressLabel";
            PersonAddressLabel.Size = new Size(100, 23);
            PersonAddressLabel.TabIndex = 17;
            PersonAddressLabel.Text = "Adres";
            PersonAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonDescriptionLabel
            // 
            PersonDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonDescriptionLabel.Location = new Point(330, 76);
            PersonDescriptionLabel.Name = "PersonDescriptionLabel";
            PersonDescriptionLabel.Size = new Size(100, 23);
            PersonDescriptionLabel.TabIndex = 18;
            PersonDescriptionLabel.Text = "Açıklama";
            PersonDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonIncomingBalanceLabel
            // 
            PersonIncomingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonIncomingBalanceLabel.Location = new Point(650, 10);
            PersonIncomingBalanceLabel.Name = "PersonIncomingBalanceLabel";
            PersonIncomingBalanceLabel.Size = new Size(100, 23);
            PersonIncomingBalanceLabel.TabIndex = 19;
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
            PersonPhoneTextBox.KeyPress += OnlyNumberTextBox_KeyPress;
            // 
            // PersonMobilePhoneTextBox
            // 
            PersonMobilePhoneTextBox.Location = new Point(120, 109);
            PersonMobilePhoneTextBox.Name = "PersonMobilePhoneTextBox";
            PersonMobilePhoneTextBox.PlaceholderText = "Cep Telefonu";
            PersonMobilePhoneTextBox.Size = new Size(200, 23);
            PersonMobilePhoneTextBox.TabIndex = 3;
            PersonMobilePhoneTextBox.KeyPress += OnlyNumberTextBox_KeyPress;
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
            PersonIdentityNumberTextBox.KeyPress += OnlyNumberTextBox_KeyPress;
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
            PersonIncomingBalanceTextBox.Enabled = false;
            PersonIncomingBalanceTextBox.Location = new Point(760, 10);
            PersonIncomingBalanceTextBox.Name = "PersonIncomingBalanceTextBox";
            PersonIncomingBalanceTextBox.PlaceholderText = "Alacak";
            PersonIncomingBalanceTextBox.ReadOnly = true;
            PersonIncomingBalanceTextBox.Size = new Size(200, 23);
            PersonIncomingBalanceTextBox.TabIndex = 22;
            PersonIncomingBalanceTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // SavePersonButton
            // 
            SavePersonButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SavePersonButton.Location = new Point(1075, 76);
            SavePersonButton.Name = "SavePersonButton";
            SavePersonButton.Size = new Size(100, 56);
            SavePersonButton.TabIndex = 8;
            SavePersonButton.Text = "Kişiyi Kaydet";
            SavePersonButton.UseVisualStyleBackColor = true;
            SavePersonButton.Click += SavePersonButton_Click;
            // 
            // DeletePersonButton
            // 
            DeletePersonButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeletePersonButton.Location = new Point(1075, 10);
            DeletePersonButton.Name = "DeletePersonButton";
            DeletePersonButton.Size = new Size(100, 56);
            DeletePersonButton.TabIndex = 9;
            DeletePersonButton.Text = "Kişiyi Sil";
            DeletePersonButton.UseVisualStyleBackColor = true;
            DeletePersonButton.Click += DeletePersonButton_Click;
            // 
            // PersonOutgoingBalanceLabel
            // 
            PersonOutgoingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonOutgoingBalanceLabel.Location = new Point(650, 43);
            PersonOutgoingBalanceLabel.Name = "PersonOutgoingBalanceLabel";
            PersonOutgoingBalanceLabel.Size = new Size(100, 23);
            PersonOutgoingBalanceLabel.TabIndex = 20;
            PersonOutgoingBalanceLabel.Text = "Verecek";
            PersonOutgoingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonOutgoingBalanceTextBox
            // 
            PersonOutgoingBalanceTextBox.Enabled = false;
            PersonOutgoingBalanceTextBox.Location = new Point(760, 43);
            PersonOutgoingBalanceTextBox.Name = "PersonOutgoingBalanceTextBox";
            PersonOutgoingBalanceTextBox.PlaceholderText = "Verecek";
            PersonOutgoingBalanceTextBox.ReadOnly = true;
            PersonOutgoingBalanceTextBox.Size = new Size(200, 23);
            PersonOutgoingBalanceTextBox.TabIndex = 23;
            PersonOutgoingBalanceTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // PersonTotalBalanceLabel
            // 
            PersonTotalBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonTotalBalanceLabel.Location = new Point(650, 76);
            PersonTotalBalanceLabel.Name = "PersonTotalBalanceLabel";
            PersonTotalBalanceLabel.Size = new Size(100, 23);
            PersonTotalBalanceLabel.TabIndex = 21;
            PersonTotalBalanceLabel.Text = "Toplam";
            PersonTotalBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PersonTotalBalanceTextBox
            // 
            PersonTotalBalanceTextBox.Enabled = false;
            PersonTotalBalanceTextBox.Location = new Point(760, 76);
            PersonTotalBalanceTextBox.Name = "PersonTotalBalanceTextBox";
            PersonTotalBalanceTextBox.PlaceholderText = "Toplam";
            PersonTotalBalanceTextBox.ReadOnly = true;
            PersonTotalBalanceTextBox.Size = new Size(200, 23);
            PersonTotalBalanceTextBox.TabIndex = 24;
            PersonTotalBalanceTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
            // 
            // PersonReceiptsDataGridView
            // 
            PersonReceiptsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PersonReceiptsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonReceiptsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ReceiptItemIdColumn, ReceiptDateColumn, PaymentDateColumn, ProductStockCodeColumn, ProductNameColumn, ProductPriceColumn, ProductPriceOnReceiptDateColumn, ProductPriceOnPaymentDateColumn, SpecialPriceForPersonColumn, ProductDiscountPriceColumn, ProductDiscountRatioColumn, ProductQuantityColumn, ProductTotalPriceColumn, PaymentAmountColumn, SaveEditedReceiptItemButtonColumn, DeleteSelectedReceiptItemButtonColumn });
            PersonReceiptsDataGridView.Location = new Point(10, 236);
            PersonReceiptsDataGridView.Name = "PersonReceiptsDataGridView";
            PersonReceiptsDataGridView.RowTemplate.Height = 25;
            PersonReceiptsDataGridView.Size = new Size(1160, 460);
            PersonReceiptsDataGridView.TabIndex = 25;
            PersonReceiptsDataGridView.CellClick += PersonReceiptsDataGridView_CellClick;
            PersonReceiptsDataGridView.CellEndEdit += PersonReceiptsDataGridView_CellEndEdit;
            PersonReceiptsDataGridView.EditingControlShowing += PersonReceiptsDataGridView_EditingControlShowing;
            // 
            // ReceiptItemIdColumn
            // 
            ReceiptItemIdColumn.HeaderText = "ReceiptItemId";
            ReceiptItemIdColumn.Name = "ReceiptItemIdColumn";
            ReceiptItemIdColumn.Visible = false;
            // 
            // ReceiptDateColumn
            // 
            ReceiptDateColumn.HeaderText = "Sipariş Tarihi";
            ReceiptDateColumn.Name = "ReceiptDateColumn";
            // 
            // PaymentDateColumn
            // 
            PaymentDateColumn.HeaderText = "Ödeme Tarihi";
            PaymentDateColumn.Name = "PaymentDateColumn";
            // 
            // ProductStockCodeColumn
            // 
            ProductStockCodeColumn.HeaderText = "Ürün Stok Kodu";
            ProductStockCodeColumn.Name = "ProductStockCodeColumn";
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Ürün Adı";
            ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            ProductPriceColumn.HeaderText = "Ürün Güncel Fiyatı";
            ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductPriceOnReceiptDateColumn
            // 
            ProductPriceOnReceiptDateColumn.HeaderText = "Sipariş Tarihi Fiyatı";
            ProductPriceOnReceiptDateColumn.Name = "ProductPriceOnReceiptDateColumn";
            // 
            // ProductPriceOnPaymentDateColumn
            // 
            ProductPriceOnPaymentDateColumn.HeaderText = "Ödeme Zamanı Fiyatı";
            ProductPriceOnPaymentDateColumn.Name = "ProductPriceOnPaymentDateColumn";
            // 
            // SpecialPriceForPersonColumn
            // 
            SpecialPriceForPersonColumn.HeaderText = "Kişiye Özel Fiyat";
            SpecialPriceForPersonColumn.Name = "SpecialPriceForPersonColumn";
            // 
            // ProductDiscountPriceColumn
            // 
            ProductDiscountPriceColumn.HeaderText = "İndirimli Fiyat";
            ProductDiscountPriceColumn.Name = "ProductDiscountPriceColumn";
            // 
            // ProductDiscountRatioColumn
            // 
            ProductDiscountRatioColumn.HeaderText = "İndirim Oranı(%)";
            ProductDiscountRatioColumn.Name = "ProductDiscountRatioColumn";
            // 
            // ProductQuantityColumn
            // 
            ProductQuantityColumn.HeaderText = "Ürün Adedi";
            ProductQuantityColumn.Name = "ProductQuantityColumn";
            // 
            // ProductTotalPriceColumn
            // 
            ProductTotalPriceColumn.HeaderText = "Ürün Toplam Fiyatı";
            ProductTotalPriceColumn.Name = "ProductTotalPriceColumn";
            // 
            // PaymentAmountColumn
            // 
            PaymentAmountColumn.HeaderText = "Ödeme Tutarı";
            PaymentAmountColumn.Name = "PaymentAmountColumn";
            // 
            // SaveEditedReceiptItemButtonColumn
            // 
            SaveEditedReceiptItemButtonColumn.HeaderText = "Değişiklikleri Kaydet";
            SaveEditedReceiptItemButtonColumn.Name = "SaveEditedReceiptItemButtonColumn";
            // 
            // DeleteSelectedReceiptItemButtonColumn
            // 
            DeleteSelectedReceiptItemButtonColumn.HeaderText = "Sil";
            DeleteSelectedReceiptItemButtonColumn.Name = "DeleteSelectedReceiptItemButtonColumn";
            // 
            // AddReceiptItemButton
            // 
            AddReceiptItemButton.Location = new Point(440, 142);
            AddReceiptItemButton.Name = "AddReceiptItemButton";
            AddReceiptItemButton.Size = new Size(200, 56);
            AddReceiptItemButton.TabIndex = 10;
            AddReceiptItemButton.Text = "Yeni Fiş Ekle";
            AddReceiptItemButton.UseVisualStyleBackColor = true;
            AddReceiptItemButton.Click += AddReceiptItemButton_Click;
            // 
            // PersonPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(AddReceiptItemButton);
            Controls.Add(PersonReceiptsDataGridView);
            Controls.Add(PersonTotalBalanceTextBox);
            Controls.Add(PersonTotalBalanceLabel);
            Controls.Add(PersonOutgoingBalanceTextBox);
            Controls.Add(PersonOutgoingBalanceLabel);
            Controls.Add(DeletePersonButton);
            Controls.Add(SavePersonButton);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kişi Detayı";
            ((System.ComponentModel.ISupportInitialize)PersonReceiptsDataGridView).EndInit();
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
        private Button SavePersonButton;
        private Button DeletePersonButton;
        private Label PersonOutgoingBalanceLabel;
        private TextBox PersonOutgoingBalanceTextBox;
        private Label PersonTotalBalanceLabel;
        private TextBox PersonTotalBalanceTextBox;
        private DataGridView PersonReceiptsDataGridView;
        private DataGridViewTextBoxColumn ReceiptItemIdColumn;
        private DataGridViewTextBoxColumn ReceiptDateColumn;
        private DataGridViewTextBoxColumn PaymentDateColumn;
        private DataGridViewTextBoxColumn ProductStockCodeColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn ProductPriceColumn;
        private DataGridViewTextBoxColumn ProductPriceOnReceiptDateColumn;
        private DataGridViewTextBoxColumn ProductPriceOnPaymentDateColumn;
        private DataGridViewTextBoxColumn SpecialPriceForPersonColumn;
        private DataGridViewTextBoxColumn ProductDiscountPriceColumn;
        private DataGridViewTextBoxColumn ProductDiscountRatioColumn;
        private DataGridViewTextBoxColumn ProductQuantityColumn;
        private DataGridViewTextBoxColumn ProductTotalPriceColumn;
        private DataGridViewTextBoxColumn PaymentAmountColumn;
        private DataGridViewButtonColumn SaveEditedReceiptItemButtonColumn;
        private DataGridViewButtonColumn DeleteSelectedReceiptItemButtonColumn;
        private Button AddReceiptItemButton;
    }
}