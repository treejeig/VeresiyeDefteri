namespace VeresiyeDefteri
{
    partial class ProductPageForm
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
            ProductPriceTextBox = new TextBox();
            ProductPriceLabel = new Label();
            DeleteProductButton = new Button();
            SaveProductButton = new Button();
            EnableEditProductButton = new Button();
            ProductStockCodeTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            ProductStockCodeLabel = new Label();
            ProductDescriptionLabel = new Label();
            ProductNameLabel = new Label();
            ProductStockCountTextBox = new TextBox();
            ProductStockCountLabel = new Label();
            SuspendLayout();
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(120, 76);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.PlaceholderText = "Fiyatı";
            ProductPriceTextBox.Size = new Size(200, 23);
            ProductPriceTextBox.TabIndex = 2;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductPriceLabel.Location = new Point(10, 76);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(100, 23);
            ProductPriceLabel.TabIndex = 10;
            ProductPriceLabel.Text = "Fiyatı";
            ProductPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(670, 10);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(100, 56);
            DeleteProductButton.TabIndex = 7;
            DeleteProductButton.Text = "Sil";
            DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // SaveProductButton
            // 
            SaveProductButton.Location = new Point(670, 142);
            SaveProductButton.Name = "SaveProductButton";
            SaveProductButton.Size = new Size(100, 56);
            SaveProductButton.TabIndex = 5;
            SaveProductButton.Text = "Kaydet";
            SaveProductButton.UseVisualStyleBackColor = true;
            // 
            // EnableEditProductButton
            // 
            EnableEditProductButton.Location = new Point(670, 76);
            EnableEditProductButton.Name = "EnableEditProductButton";
            EnableEditProductButton.Size = new Size(100, 56);
            EnableEditProductButton.TabIndex = 6;
            EnableEditProductButton.Text = "Düzenlemeyi Aç";
            EnableEditProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductStockCodeTextBox
            // 
            ProductStockCodeTextBox.Location = new Point(120, 10);
            ProductStockCodeTextBox.Name = "ProductStockCodeTextBox";
            ProductStockCodeTextBox.PlaceholderText = "Stok Kodu";
            ProductStockCodeTextBox.Size = new Size(200, 23);
            ProductStockCodeTextBox.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(440, 10);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Açıklama";
            DescriptionTextBox.Size = new Size(200, 56);
            DescriptionTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(120, 43);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Adı";
            NameTextBox.Size = new Size(200, 23);
            NameTextBox.TabIndex = 1;
            // 
            // ProductStockCodeLabel
            // 
            ProductStockCodeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductStockCodeLabel.Location = new Point(10, 10);
            ProductStockCodeLabel.Name = "ProductStockCodeLabel";
            ProductStockCodeLabel.Size = new Size(100, 23);
            ProductStockCodeLabel.TabIndex = 8;
            ProductStockCodeLabel.Text = "Stok Kodu";
            ProductStockCodeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductDescriptionLabel
            // 
            ProductDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductDescriptionLabel.Location = new Point(330, 10);
            ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            ProductDescriptionLabel.Size = new Size(100, 23);
            ProductDescriptionLabel.TabIndex = 11;
            ProductDescriptionLabel.Text = "Açıklama";
            ProductDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(10, 43);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(100, 23);
            ProductNameLabel.TabIndex = 9;
            ProductNameLabel.Text = "Adı";
            ProductNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductStockCountTextBox
            // 
            ProductStockCountTextBox.Location = new Point(440, 76);
            ProductStockCountTextBox.Name = "ProductStockCountTextBox";
            ProductStockCountTextBox.PlaceholderText = "Stok Adedi";
            ProductStockCountTextBox.Size = new Size(200, 23);
            ProductStockCountTextBox.TabIndex = 4;
            // 
            // ProductStockCountLabel
            // 
            ProductStockCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductStockCountLabel.Location = new Point(330, 76);
            ProductStockCountLabel.Name = "ProductStockCountLabel";
            ProductStockCountLabel.Size = new Size(100, 23);
            ProductStockCountLabel.TabIndex = 12;
            ProductStockCountLabel.Text = "Stok Adedi";
            ProductStockCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ProductStockCountTextBox);
            Controls.Add(ProductStockCountLabel);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductPriceLabel);
            Controls.Add(DeleteProductButton);
            Controls.Add(SaveProductButton);
            Controls.Add(EnableEditProductButton);
            Controls.Add(ProductStockCodeTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(ProductStockCodeLabel);
            Controls.Add(ProductDescriptionLabel);
            Controls.Add(ProductNameLabel);
            Name = "ProductPageForm";
            Text = "Ürün Detayı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductPriceTextBox;
        private Label ProductPriceLabel;
        private Button DeleteProductButton;
        private Button SaveProductButton;
        private Button EnableEditProductButton;
        private TextBox ProductStockCodeTextBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Label ProductStockCodeLabel;
        private Label ProductDescriptionLabel;
        private Label ProductNameLabel;
        private TextBox ProductStockCountTextBox;
        private Label ProductStockCountLabel;
    }
}