namespace VeresiyeDefteri.Pages.ListPages
{
    partial class PersonsPageForm
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
            PersonsDataGridView = new DataGridView();
            PersonIdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            SurnameColumn = new DataGridViewTextBoxColumn();
            IncomingBalanceColumn = new DataGridViewTextBoxColumn();
            OutgoingBalanceColumn = new DataGridViewTextBoxColumn();
            TotalBalanceColumn = new DataGridViewTextBoxColumn();
            GoToPersonDetailButtonColumn = new DataGridViewButtonColumn();
            SaveEditedPersonButtonColumn = new DataGridViewButtonColumn();
            AddPersonButton = new Button();
            DeletePersonButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PersonsDataGridView
            // 
            PersonsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonsDataGridView.Columns.AddRange(new DataGridViewColumn[] { PersonIdColumn, NameColumn, SurnameColumn, IncomingBalanceColumn, OutgoingBalanceColumn, TotalBalanceColumn, GoToPersonDetailButtonColumn, SaveEditedPersonButtonColumn, DeletePersonButtonColumn });
            PersonsDataGridView.Location = new Point(10, 10);
            PersonsDataGridView.Name = "PersonsDataGridView";
            PersonsDataGridView.RowTemplate.Height = 25;
            PersonsDataGridView.Size = new Size(850, 690);
            PersonsDataGridView.TabIndex = 1;
            PersonsDataGridView.CellClick += PersonsDataGridView_CellClick;
            // 
            // PersonIdColumn
            // 
            PersonIdColumn.HeaderText = "PersonId";
            PersonIdColumn.Name = "PersonIdColumn";
            PersonIdColumn.Visible = false;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Adı";
            NameColumn.Name = "NameColumn";
            // 
            // SurnameColumn
            // 
            SurnameColumn.HeaderText = "Soyadı";
            SurnameColumn.Name = "SurnameColumn";
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
            // TotalBalanceColumn
            // 
            TotalBalanceColumn.HeaderText = "Toplam";
            TotalBalanceColumn.Name = "TotalBalanceColumn";
            // 
            // GoToPersonDetailButtonColumn
            // 
            GoToPersonDetailButtonColumn.HeaderText = "Kişi Detayı";
            GoToPersonDetailButtonColumn.Name = "GoToPersonDetailButtonColumn";
            // 
            // SaveEditedPersonButtonColumn
            // 
            SaveEditedPersonButtonColumn.HeaderText = "Kişiyi Kaydet";
            SaveEditedPersonButtonColumn.Name = "SaveEditedPersonButtonColumn";
            // 
            // AddPersonButton
            // 
            AddPersonButton.Location = new Point(875, 10);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(100, 56);
            AddPersonButton.TabIndex = 0;
            AddPersonButton.Text = "Yeni Kişi Ekle";
            AddPersonButton.UseVisualStyleBackColor = true;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // DeletePersonButtonColumn
            // 
            DeletePersonButtonColumn.HeaderText = "Kişiyi Sil";
            DeletePersonButtonColumn.Name = "DeletePersonButtonColumn";
            // 
            // PersonsPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(PersonsDataGridView);
            Controls.Add(AddPersonButton);
            Name = "PersonsPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kişiler";
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddPersonButton;
        private DataGridView PersonsDataGridView;
        private DataGridViewTextBoxColumn PersonIdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn SurnameColumn;
        private DataGridViewTextBoxColumn IncomingBalanceColumn;
        private DataGridViewTextBoxColumn OutgoingBalanceColumn;
        private DataGridViewTextBoxColumn TotalBalanceColumn;
        private DataGridViewButtonColumn GoToPersonDetailButtonColumn;
        private DataGridViewButtonColumn SaveEditedPersonButtonColumn;
        private DataGridViewButtonColumn DeletePersonButtonColumn;
    }
}