namespace VeresiyeDefteri.Pages.ListPages
{
    partial class PaymentTypeItemsPageForm
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
            PaymentTypeItemsDataGridView = new DataGridView();
            PaymentTypeIdColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            SaveEditedPaymentTypeItemButtonColumn = new DataGridViewButtonColumn();
            DeleteSelectedPaymentTypeItemButtonColumn = new DataGridViewButtonColumn();
            AddPaymentTypeItemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PaymentTypeItemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PaymentTypeItemsDataGridView
            // 
            PaymentTypeItemsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PaymentTypeItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentTypeItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { PaymentTypeIdColumn, ProductNameColumn, SaveEditedPaymentTypeItemButtonColumn, DeleteSelectedPaymentTypeItemButtonColumn });
            PaymentTypeItemsDataGridView.Location = new Point(10, 10);
            PaymentTypeItemsDataGridView.Name = "PaymentTypeItemsDataGridView";
            PaymentTypeItemsDataGridView.RowTemplate.Height = 25;
            PaymentTypeItemsDataGridView.Size = new Size(400, 250);
            PaymentTypeItemsDataGridView.TabIndex = 1;
            // 
            // PaymentTypeIdColumn
            // 
            PaymentTypeIdColumn.HeaderText = "PaymentTypeId";
            PaymentTypeIdColumn.Name = "PaymentTypeIdColumn";
            PaymentTypeIdColumn.Visible = false;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Adı";
            ProductNameColumn.Name = "ProductNameColumn";
            // 
            // SaveEditedPaymentTypeItemButtonColumn
            // 
            SaveEditedPaymentTypeItemButtonColumn.HeaderText = "Ödeme Türünü Kaydet";
            SaveEditedPaymentTypeItemButtonColumn.Name = "SaveEditedPaymentTypeItemButtonColumn";
            SaveEditedPaymentTypeItemButtonColumn.Resizable = DataGridViewTriState.True;
            SaveEditedPaymentTypeItemButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteSelectedPaymentTypeItemButtonColumn
            // 
            DeleteSelectedPaymentTypeItemButtonColumn.HeaderText = "Ödeme Türünü Sil";
            DeleteSelectedPaymentTypeItemButtonColumn.Name = "DeleteSelectedPaymentTypeItemButtonColumn";
            // 
            // AddPaymentTypeItemButton
            // 
            AddPaymentTypeItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPaymentTypeItemButton.Location = new Point(425, 10);
            AddPaymentTypeItemButton.Name = "AddPaymentTypeItemButton";
            AddPaymentTypeItemButton.Size = new Size(100, 56);
            AddPaymentTypeItemButton.TabIndex = 2;
            AddPaymentTypeItemButton.Text = "Yeni Ödeme Türü Ekle";
            AddPaymentTypeItemButton.UseVisualStyleBackColor = true;
            AddPaymentTypeItemButton.Click += AddPaymentTypeItemButton_Click;
            // 
            // PaymentTypeItemsPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 276);
            Controls.Add(AddPaymentTypeItemButton);
            Controls.Add(PaymentTypeItemsDataGridView);
            Name = "PaymentTypeItemsPageForm";
            Text = "Ödeme Türleri";
            ((System.ComponentModel.ISupportInitialize)PaymentTypeItemsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PaymentTypeItemsDataGridView;
        private Button AddPaymentTypeItemButton;
        private DataGridViewTextBoxColumn PaymentTypeIdColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewButtonColumn SaveEditedPaymentTypeItemButtonColumn;
        private DataGridViewButtonColumn DeleteSelectedPaymentTypeItemButtonColumn;
    }
}