namespace VeresiyeDefteri.Pages.DetailPages
{
    partial class PaymentTypeItemPageForm
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
            PaymentTypeItemNameLabel = new Label();
            PaymentTypeItemNameTextBox = new TextBox();
            SavePaymentTypeItemButton = new Button();
            SuspendLayout();
            // 
            // PaymentTypeItemNameLabel
            // 
            PaymentTypeItemNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentTypeItemNameLabel.Location = new Point(10, 10);
            PaymentTypeItemNameLabel.Name = "PaymentTypeItemNameLabel";
            PaymentTypeItemNameLabel.Size = new Size(100, 23);
            PaymentTypeItemNameLabel.TabIndex = 2;
            PaymentTypeItemNameLabel.Text = "Ödeme Türü Adı";
            PaymentTypeItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentTypeItemNameTextBox
            // 
            PaymentTypeItemNameTextBox.Location = new Point(120, 10);
            PaymentTypeItemNameTextBox.Name = "PaymentTypeItemNameTextBox";
            PaymentTypeItemNameTextBox.PlaceholderText = "Ödeme Türü Adı";
            PaymentTypeItemNameTextBox.Size = new Size(200, 23);
            PaymentTypeItemNameTextBox.TabIndex = 0;
            // 
            // SavePaymentTypeItemButton
            // 
            SavePaymentTypeItemButton.Location = new Point(120, 43);
            SavePaymentTypeItemButton.Name = "SavePaymentTypeItemButton";
            SavePaymentTypeItemButton.Size = new Size(200, 56);
            SavePaymentTypeItemButton.TabIndex = 1;
            SavePaymentTypeItemButton.Text = "Ödeme Türünü Kaydet";
            SavePaymentTypeItemButton.UseVisualStyleBackColor = true;
            SavePaymentTypeItemButton.Click += SavePaymentTypeItemButton_Click;
            // 
            // PaymentTypeItemPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 111);
            Controls.Add(SavePaymentTypeItemButton);
            Controls.Add(PaymentTypeItemNameTextBox);
            Controls.Add(PaymentTypeItemNameLabel);
            Name = "PaymentTypeItemPageForm";
            Text = "Ödeme Türü Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PaymentTypeItemNameLabel;
        private TextBox PaymentTypeItemNameTextBox;
        private Button SavePaymentTypeItemButton;
    }
}