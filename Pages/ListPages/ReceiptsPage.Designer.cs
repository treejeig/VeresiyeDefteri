namespace VeresiyeDefteri.Pages.ListPages
{
    partial class ReceiptsPageForm
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
            ReceiptsDataGridView = new DataGridView();
            PersonNameColumn = new DataGridViewTextBoxColumn();
            PersonSurnameColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            IncomingBalanceColumn = new DataGridViewTextBoxColumn();
            OutgoingBalanceColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            GoToReceiptDetailButtonColumn = new DataGridViewButtonColumn();
            AddReceiptButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ReceiptsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReceiptsDataGridView
            // 
            ReceiptsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceiptsDataGridView.Columns.AddRange(new DataGridViewColumn[] { PersonNameColumn, PersonSurnameColumn, DateColumn, IncomingBalanceColumn, OutgoingBalanceColumn, TotalColumn, GoToReceiptDetailButtonColumn });
            ReceiptsDataGridView.Location = new Point(10, 10);
            ReceiptsDataGridView.Name = "ReceiptsDataGridView";
            ReceiptsDataGridView.RowTemplate.Height = 25;
            ReceiptsDataGridView.Size = new Size(760, 375);
            ReceiptsDataGridView.TabIndex = 0;
            // 
            // PersonNameColumn
            // 
            PersonNameColumn.HeaderText = "Kişi Adı";
            PersonNameColumn.Name = "PersonNameColumn";
            // 
            // PersonSurnameColumn
            // 
            PersonSurnameColumn.HeaderText = "Kişi Soyadı";
            PersonSurnameColumn.Name = "PersonSurnameColumn";
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Tarih";
            DateColumn.Name = "DateColumn";
            // 
            // IncomingBalanceColumn
            // 
            IncomingBalanceColumn.HeaderText = "Alacak";
            IncomingBalanceColumn.Name = "IncomingBalanceColumn";
            // 
            // OutgoingBalanceColumn
            // 
            OutgoingBalanceColumn.HeaderText = "Verecek";
            OutgoingBalanceColumn.Name = "OutgoingBalanceColumn";
            // 
            // TotalColumn
            // 
            TotalColumn.HeaderText = "Toplam";
            TotalColumn.Name = "TotalColumn";
            // 
            // GoToReceiptDetailButtonColumn
            // 
            GoToReceiptDetailButtonColumn.HeaderText = "Fiş Detayı";
            GoToReceiptDetailButtonColumn.Name = "GoToReceiptDetailButtonColumn";
            GoToReceiptDetailButtonColumn.Resizable = DataGridViewTriState.True;
            GoToReceiptDetailButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AddReceiptButton
            // 
            AddReceiptButton.Location = new Point(10, 395);
            AddReceiptButton.Name = "AddReceiptButton";
            AddReceiptButton.Size = new Size(100, 56);
            AddReceiptButton.TabIndex = 1;
            AddReceiptButton.Text = "Yeni Fiş Ekle";
            AddReceiptButton.UseVisualStyleBackColor = true;
            AddReceiptButton.Click += AddReceiptButton_Click;
            // 
            // ReceiptsPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(AddReceiptButton);
            Controls.Add(ReceiptsDataGridView);
            Name = "ReceiptsPageForm";
            Text = "Fişler";
            ((System.ComponentModel.ISupportInitialize)ReceiptsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReceiptsDataGridView;
        private DataGridViewTextBoxColumn PersonNameColumn;
        private DataGridViewTextBoxColumn PersonSurnameColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn IncomingBalanceColumn;
        private DataGridViewTextBoxColumn OutgoingBalanceColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private DataGridViewButtonColumn GoToReceiptDetailButtonColumn;
        private Button AddReceiptButton;
    }
}