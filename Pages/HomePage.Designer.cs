namespace VeresiyeDefteri
{
    partial class HomePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GoToPersonsPageButton = new Button();
            GoToProductsPageButton = new Button();
            TotalIncomingBalanceLabel = new Label();
            TotalIncomingBalanceTextBox = new TextBox();
            TotalOutgoinBalanceLabel = new Label();
            TotalOutgoingBalanceTextBox = new TextBox();
            TotalBalanceLabel = new Label();
            TotalBalanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // GoToPersonsPageButton
            // 
            GoToPersonsPageButton.ImageAlign = ContentAlignment.TopCenter;
            GoToPersonsPageButton.Location = new Point(10, 10);
            GoToPersonsPageButton.Name = "GoToPersonsPageButton";
            GoToPersonsPageButton.Size = new Size(100, 56);
            GoToPersonsPageButton.TabIndex = 0;
            GoToPersonsPageButton.Text = "Kişiler Listesi";
            GoToPersonsPageButton.UseVisualStyleBackColor = true;
            GoToPersonsPageButton.Click += GoToPersonsPageButton_Click;
            // 
            // GoToProductsPageButton
            // 
            GoToProductsPageButton.Location = new Point(120, 10);
            GoToProductsPageButton.Name = "GoToProductsPageButton";
            GoToProductsPageButton.Size = new Size(100, 56);
            GoToProductsPageButton.TabIndex = 1;
            GoToProductsPageButton.Text = "Ürünler Listesi";
            GoToProductsPageButton.UseVisualStyleBackColor = true;
            GoToProductsPageButton.Click += GoToProductsPageButton_Click;
            // 
            // TotalIncomingBalanceLabel
            // 
            TotalIncomingBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalIncomingBalanceLabel.Location = new Point(10, 76);
            TotalIncomingBalanceLabel.Name = "TotalIncomingBalanceLabel";
            TotalIncomingBalanceLabel.Size = new Size(100, 23);
            TotalIncomingBalanceLabel.TabIndex = 9;
            TotalIncomingBalanceLabel.Text = "Toplam Alacak";
            TotalIncomingBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotalIncomingBalanceTextBox
            // 
            TotalIncomingBalanceTextBox.Enabled = false;
            TotalIncomingBalanceTextBox.Location = new Point(120, 76);
            TotalIncomingBalanceTextBox.Name = "TotalIncomingBalanceTextBox";
            TotalIncomingBalanceTextBox.PlaceholderText = "Toplam Alacak";
            TotalIncomingBalanceTextBox.ReadOnly = true;
            TotalIncomingBalanceTextBox.Size = new Size(100, 23);
            TotalIncomingBalanceTextBox.TabIndex = 10;
            // 
            // TotalOutgoinBalanceLabel
            // 
            TotalOutgoinBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalOutgoinBalanceLabel.Location = new Point(10, 109);
            TotalOutgoinBalanceLabel.Name = "TotalOutgoinBalanceLabel";
            TotalOutgoinBalanceLabel.Size = new Size(100, 23);
            TotalOutgoinBalanceLabel.TabIndex = 11;
            TotalOutgoinBalanceLabel.Text = "Toplam Verecek";
            TotalOutgoinBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotalOutgoingBalanceTextBox
            // 
            TotalOutgoingBalanceTextBox.Enabled = false;
            TotalOutgoingBalanceTextBox.Location = new Point(120, 109);
            TotalOutgoingBalanceTextBox.Name = "TotalOutgoingBalanceTextBox";
            TotalOutgoingBalanceTextBox.PlaceholderText = "Toplam Verecek";
            TotalOutgoingBalanceTextBox.ReadOnly = true;
            TotalOutgoingBalanceTextBox.Size = new Size(100, 23);
            TotalOutgoingBalanceTextBox.TabIndex = 12;
            // 
            // TotalBalanceLabel
            // 
            TotalBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalBalanceLabel.Location = new Point(10, 142);
            TotalBalanceLabel.Name = "TotalBalanceLabel";
            TotalBalanceLabel.Size = new Size(100, 23);
            TotalBalanceLabel.TabIndex = 13;
            TotalBalanceLabel.Text = "Toplam";
            TotalBalanceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotalBalanceTextBox
            // 
            TotalBalanceTextBox.Enabled = false;
            TotalBalanceTextBox.Location = new Point(120, 142);
            TotalBalanceTextBox.Name = "TotalBalanceTextBox";
            TotalBalanceTextBox.PlaceholderText = "Toplam";
            TotalBalanceTextBox.ReadOnly = true;
            TotalBalanceTextBox.Size = new Size(100, 23);
            TotalBalanceTextBox.TabIndex = 14;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 181);
            Controls.Add(TotalBalanceTextBox);
            Controls.Add(TotalBalanceLabel);
            Controls.Add(TotalOutgoingBalanceTextBox);
            Controls.Add(TotalOutgoinBalanceLabel);
            Controls.Add(TotalIncomingBalanceTextBox);
            Controls.Add(TotalIncomingBalanceLabel);
            Controls.Add(GoToProductsPageButton);
            Controls.Add(GoToPersonsPageButton);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veresiye Defteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GoToPersonsPageButton;
        private Button GoToProductsPageButton;
        private Label TotalIncomingBalanceLabel;
        private TextBox TotalIncomingBalanceTextBox;
        private Label TotalOutgoinBalanceLabel;
        private TextBox TotalOutgoingBalanceTextBox;
        private Label TotalBalanceLabel;
        private TextBox TotalBalanceTextBox;
    }
}