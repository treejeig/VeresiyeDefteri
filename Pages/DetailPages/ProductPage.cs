using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeresiyeDefteri.DataAccess;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Helpers;

namespace VeresiyeDefteri
{
    public partial class ProductPageForm : Form
    {
        ProductController productController = new ProductController();
        InputHelpers inputHelper = new InputHelpers();
        MessageBoxes messageBoxes = new MessageBoxes();
        Product product = new Product();
        long selectedProductId = 0;
        string? oldStockCode;
        string? oldName;
        string? oldPrice;
        public ProductPageForm(long productId)
        {
            selectedProductId = productId;
            InitializeComponent();
            PrepareProductPage();
        }

        public ProductPageForm()
        {
            selectedProductId = 0;
            InitializeComponent();
            PrepareProductPage();
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            string messageBoxTitle;
            string messageBoxMessage;
            if (selectedProductId == 0)
            {
                messageBoxTitle = "Ürün eklensin mi?";
                messageBoxMessage = $"Stok Kodu: {ProductStockCodeTextBox.Text}\nAdı: {ProductNameTextBox.Text}\nFiyatı: {ProductPriceTextBox.Text}";
            }
            else
            {
                messageBoxTitle = "Ürün güncellensin mi?";
                messageBoxMessage = $"Stok Kodu: {oldStockCode} -> {ProductStockCodeTextBox.Text}\nAdı: {oldName} -> {ProductNameTextBox.Text}\nFiyatı: {oldPrice} -> {ProductPriceTextBox.Text}";
            }

            if (messageBoxes.YesNoMessageBox(messageBoxTitle, messageBoxMessage))
            {
                Product product = new Product
                {
                    StockCode = string.IsNullOrEmpty(ProductStockCodeTextBox.Text) ? null : ProductStockCodeTextBox.Text,
                    ProductName = ProductNameTextBox.Text,
                    Price = string.IsNullOrEmpty(ProductPriceTextBox.Text) ? null : Convert.ToDouble(ProductPriceTextBox.Text),
                    ProductDescription = string.IsNullOrEmpty(ProductDescriptionTextBox.Text) ? null : ProductDescriptionTextBox.Text,
                };
                if (selectedProductId == 0)
                {
                    if (productController.AddProduct(product))
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Yeni Ürün eklendi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Yeni Ürün eklenemedi."));
                    }
                }
                else
                {
                    product.ProductId = selectedProductId;
                    if (productController.UpdateProduct(product))
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Ürün değişiklikleri kaydedildi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Ürün değişiklikleri kaydedilemedi."));
                    }
                }
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            var yesNoMessageBoxTitle = "Ürün silinsin mi?";
            var yesNomessageBoxMessage = $"Stok Kodu: {oldStockCode}\nAdı: {oldName}\nFiyatı: {oldPrice}";

            if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNomessageBoxMessage))
            {
                string infoMessageBoxTitle;
                string infoMessageBoxMessage;
                if (productController.DeleteProduct(selectedProductId))
                {
                    infoMessageBoxTitle = "Başarılı";
                    infoMessageBoxMessage = $"{oldStockCode} - {oldName} - {oldPrice} silindi.";
                }
                else
                {
                    infoMessageBoxTitle = "Başarısız";
                    infoMessageBoxMessage = $"{oldStockCode} - {oldName} - {oldPrice} silinemedi.";

                }
                ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox(infoMessageBoxTitle, infoMessageBoxMessage));
            }
        }

        private void PrepareProductPage()
        {
            if (selectedProductId != 0)
            {
                product = productController.GetProduct(selectedProductId);
            }
            else
            {
                DeleteProductButton.Visible = false;
            }
            if (product != null)
            {
                ProductStockCodeTextBox.Text = product.StockCode;
                ProductNameTextBox.Text = product.ProductName;
                ProductPriceTextBox.Text = product.Price.ToString();
                ProductDescriptionTextBox.Text = product.ProductDescription;
                oldStockCode = product.StockCode;
                oldName = product.ProductName;
                oldPrice = product.Price.ToString();
            }
        }

        private void ShowInfoMessageBoxAndClosePage(bool res)
        {
            if (res)
            {
                Close();
            }
        }

        private void OnlyNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputHelper.AllowOnlyNumbers(sender, e);
        }
        private void OnlyNumberAndOneDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputHelper.AllowOnlyNumbersAndOneDigit(sender, e);
        }
    }
}
