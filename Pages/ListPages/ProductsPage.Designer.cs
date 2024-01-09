namespace VeresiyeDefteri.Pages.ListPages
{
    partial class ProductsPageForm
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
            ProductsDataGridView = new DataGridView();
            AddProductButton = new Button();
            ProductStockCodeColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantityColumn = new DataGridViewTextBoxColumn();
            GoToProductDetailButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductStockCodeColumn, ProductNameColumn, ProductPrice, ProductQuantityColumn, GoToProductDetailButtonColumn });
            ProductsDataGridView.Location = new Point(10, 10);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowTemplate.Height = 25;
            ProductsDataGridView.Size = new Size(760, 375);
            ProductsDataGridView.TabIndex = 0;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(10, 395);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(100, 56);
            AddProductButton.TabIndex = 1;
            AddProductButton.Text = "Yeni Ürün Ekle";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ProductStockCodeColumn
            // 
            ProductStockCodeColumn.HeaderText = "Stok Kodu";
            ProductStockCodeColumn.Name = "ProductStockCodeColumn";
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Adı";
            ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Fiyatı";
            ProductPrice.Name = "ProductPrice";
            // 
            // ProductQuantityColumn
            // 
            ProductQuantityColumn.HeaderText = "Stok Adedi";
            ProductQuantityColumn.Name = "ProductQuantityColumn";
            // 
            // GoToProductDetailButtonColumn
            // 
            GoToProductDetailButtonColumn.HeaderText = "Ürün Detayı";
            GoToProductDetailButtonColumn.Name = "GoToProductDetailButtonColumn";
            GoToProductDetailButtonColumn.Resizable = DataGridViewTriState.True;
            GoToProductDetailButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ProductsPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(AddProductButton);
            Controls.Add(ProductsDataGridView);
            Name = "ProductsPageForm";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private Button AddProductButton;
        private DataGridViewTextBoxColumn ProductStockCodeColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantityColumn;
        private DataGridViewButtonColumn GoToProductDetailButtonColumn;
    }
}