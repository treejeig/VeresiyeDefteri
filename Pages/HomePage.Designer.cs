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
            GoToReceiptsPageButton = new Button();
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
            // GoToReceiptsPageButton
            // 
            GoToReceiptsPageButton.Location = new Point(230, 10);
            GoToReceiptsPageButton.Name = "GoToReceiptsPageButton";
            GoToReceiptsPageButton.Size = new Size(100, 56);
            GoToReceiptsPageButton.TabIndex = 2;
            GoToReceiptsPageButton.Text = "Fişler Listesi";
            GoToReceiptsPageButton.UseVisualStyleBackColor = true;
            GoToReceiptsPageButton.Click += GoToReceiptsPageButton_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(GoToReceiptsPageButton);
            Controls.Add(GoToProductsPageButton);
            Controls.Add(GoToPersonsPageButton);
            Name = "HomePageForm";
            Text = "Veresiye Defteri";
            Load += HomePageForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button GoToPersonsPageButton;
        private Button GoToProductsPageButton;
        private Button GoToReceiptsPageButton;
    }
}