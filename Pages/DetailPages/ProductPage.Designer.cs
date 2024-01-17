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
            ProductStockCodeTextBox = new TextBox();
            ProductDescriptionTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            ProductStockCodeLabel = new Label();
            ProductDescriptionLabel = new Label();
            ProductNameLabel = new Label();
            SuspendLayout();
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(120, 76);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.PlaceholderText = "Fiyatı";
            ProductPriceTextBox.Size = new Size(200, 23);
            ProductPriceTextBox.TabIndex = 2;
            ProductPriceTextBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
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
            DeleteProductButton.Location = new Point(330, 10);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(100, 56);
            DeleteProductButton.TabIndex = 7;
            DeleteProductButton.Text = "Ürünü Sil";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += DeleteProductButton_Click;
            // 
            // SaveProductButton
            // 
            SaveProductButton.Location = new Point(330, 76);
            SaveProductButton.Name = "SaveProductButton";
            SaveProductButton.Size = new Size(100, 56);
            SaveProductButton.TabIndex = 5;
            SaveProductButton.Text = "Ürünü Kaydet";
            SaveProductButton.UseVisualStyleBackColor = true;
            SaveProductButton.Click += SaveProductButton_Click;
            // 
            // ProductStockCodeTextBox
            // 
            ProductStockCodeTextBox.Location = new Point(120, 10);
            ProductStockCodeTextBox.Name = "ProductStockCodeTextBox";
            ProductStockCodeTextBox.PlaceholderText = "Stok Kodu";
            ProductStockCodeTextBox.Size = new Size(200, 23);
            ProductStockCodeTextBox.TabIndex = 0;
            // 
            // ProductDescriptionTextBox
            // 
            ProductDescriptionTextBox.Location = new Point(120, 109);
            ProductDescriptionTextBox.Multiline = true;
            ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            ProductDescriptionTextBox.PlaceholderText = "Açıklama";
            ProductDescriptionTextBox.Size = new Size(200, 56);
            ProductDescriptionTextBox.TabIndex = 3;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(120, 43);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.PlaceholderText = "Adı";
            ProductNameTextBox.Size = new Size(200, 23);
            ProductNameTextBox.TabIndex = 1;
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
            ProductDescriptionLabel.Location = new Point(10, 109);
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
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 176);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductPriceLabel);
            Controls.Add(DeleteProductButton);
            Controls.Add(SaveProductButton);
            Controls.Add(ProductStockCodeTextBox);
            Controls.Add(ProductDescriptionTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductStockCodeLabel);
            Controls.Add(ProductDescriptionLabel);
            Controls.Add(ProductNameLabel);
            Name = "ProductPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Detayı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductPriceTextBox;
        private Label ProductPriceLabel;
        private Button DeleteProductButton;
        private Button SaveProductButton;
        private TextBox ProductStockCodeTextBox;
        private TextBox ProductDescriptionTextBox;
        private TextBox ProductNameTextBox;
        private Label ProductStockCodeLabel;
        private Label ProductDescriptionLabel;
        private Label ProductNameLabel;
    }
}