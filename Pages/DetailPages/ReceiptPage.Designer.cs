namespace VeresiyeDefteri
{
    partial class ReceiptPageForm
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
            ReceiptProductsDataGridView = new DataGridView();
            ReceiptProductName = new DataGridViewTextBoxColumn();
            ReceiptProductQuantity = new DataGridViewTextBoxColumn();
            ReceiptProductPrice = new DataGridViewTextBoxColumn();
            ReceiptProductTotalPrice = new DataGridViewTextBoxColumn();
            ReceiptPersonNameSurnameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DeleteProductButton = new Button();
            SaveProductButton = new Button();
            button1 = new Button();
            SelectReceiptPersonComboBox = new ComboBox();
            SelectReceiptPersonLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ReceiptProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReceiptPersonNameSurnameTextBox
            // 
            ReceiptPersonNameSurnameTextBox.Location = new Point(440, 10);
            ReceiptPersonNameSurnameTextBox.Name = "ReceiptPersonNameSurnameTextBox";
            ReceiptPersonNameSurnameTextBox.PlaceholderText = "Kişi Adı Soyadı";
            ReceiptPersonNameSurnameTextBox.Size = new Size(200, 23);
            ReceiptPersonNameSurnameTextBox.TabIndex = 0;
            // 
            // ReceiptProductsDataGridView
            // 
            ReceiptProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceiptProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ReceiptProductName, ReceiptProductQuantity, ReceiptProductPrice, ReceiptProductTotalPrice });
            ReceiptProductsDataGridView.Location = new Point(12, 187);
            ReceiptProductsDataGridView.Name = "ReceiptProductsDataGridView";
            ReceiptProductsDataGridView.RowTemplate.Height = 25;
            ReceiptProductsDataGridView.Size = new Size(850, 500);
            ReceiptProductsDataGridView.TabIndex = 1;
            // 
            // ReceiptProductName
            // 
            ReceiptProductName.HeaderText = "Ürün Adı";
            ReceiptProductName.Name = "ReceiptProductName";
            // 
            // ReceiptProductQuantity
            // 
            ReceiptProductQuantity.HeaderText = "Ürün Adedi";
            ReceiptProductQuantity.Name = "ReceiptProductQuantity";
            // 
            // ReceiptProductPrice
            // 
            ReceiptProductPrice.HeaderText = "Ürün Fiyatı";
            ReceiptProductPrice.Name = "ReceiptProductPrice";
            // 
            // ReceiptProductTotalPrice
            // 
            ReceiptProductTotalPrice.HeaderText = "Ürün Toplam Fiyatı";
            ReceiptProductTotalPrice.Name = "ReceiptProductTotalPrice";
            // 
            // ReceiptPersonNameSurnameLabel
            // 
            ReceiptPersonNameSurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptPersonNameSurnameLabel.Location = new Point(330, 10);
            ReceiptPersonNameSurnameLabel.Name = "ReceiptPersonNameSurnameLabel";
            ReceiptPersonNameSurnameLabel.Size = new Size(100, 23);
            ReceiptPersonNameSurnameLabel.TabIndex = 0;
            ReceiptPersonNameSurnameLabel.Text = "Kişi Adı Soyadı";
            ReceiptPersonNameSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(330, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "Tarih";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(330, 142);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Toplam Tutar";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(330, 76);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Alacak";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(330, 109);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 5;
            label4.Text = "Verecek";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(875, 10);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(100, 56);
            DeleteProductButton.TabIndex = 10;
            DeleteProductButton.Text = "Sil";
            DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // SaveProductButton
            // 
            SaveProductButton.Location = new Point(875, 76);
            SaveProductButton.Name = "SaveProductButton";
            SaveProductButton.Size = new Size(100, 56);
            SaveProductButton.TabIndex = 8;
            SaveProductButton.Text = "Kaydet";
            SaveProductButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(215, 118);
            button1.Name = "button1";
            button1.Size = new Size(100, 56);
            button1.TabIndex = 11;
            button1.Text = "Fişe Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // SelectReceiptPersonComboBox
            // 
            SelectReceiptPersonComboBox.FormattingEnabled = true;
            SelectReceiptPersonComboBox.Location = new Point(120, 10);
            SelectReceiptPersonComboBox.Name = "SelectReceiptPersonComboBox";
            SelectReceiptPersonComboBox.Size = new Size(200, 23);
            SelectReceiptPersonComboBox.Sorted = true;
            SelectReceiptPersonComboBox.TabIndex = 12;
            SelectReceiptPersonComboBox.SelectedIndexChanged += SelectReceiptPersonComboBox_SelectedIndexChanged;
            // 
            // SelectReceiptPersonLabel
            // 
            SelectReceiptPersonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectReceiptPersonLabel.Location = new Point(10, 10);
            SelectReceiptPersonLabel.Name = "SelectReceiptPersonLabel";
            SelectReceiptPersonLabel.Size = new Size(100, 23);
            SelectReceiptPersonLabel.TabIndex = 13;
            SelectReceiptPersonLabel.Text = "Kişi Seç";
            SelectReceiptPersonLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 43);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tarih";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 76);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Alacak";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(440, 109);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Verecek";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(440, 142);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Toplam Tutar";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 17;
            // 
            // ReceiptPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SelectReceiptPersonLabel);
            Controls.Add(SelectReceiptPersonComboBox);
            Controls.Add(button1);
            Controls.Add(DeleteProductButton);
            Controls.Add(SaveProductButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReceiptProductsDataGridView);
            Controls.Add(ReceiptPersonNameSurnameTextBox);
            Controls.Add(ReceiptPersonNameSurnameLabel);
            Name = "ReceiptPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fiş Detayı";
            ((System.ComponentModel.ISupportInitialize)ReceiptProductsDataGridView).EndInit();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button DeleteProductButton;
        private Button SaveProductButton;
        private Button button1;
        private ComboBox SelectReceiptPersonComboBox;
        private Label SelectReceiptPersonLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}