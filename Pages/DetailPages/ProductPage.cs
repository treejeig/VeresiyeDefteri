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
        Product product = new Product();
        long selectedProductId = 0;
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
            Product product = new Product
            {
                StockCode = string.IsNullOrEmpty(ProductStockCodeTextBox.Text) ? null : ProductStockCodeTextBox.Text,
                Name = ProductNameTextBox.Text,
                Price = string.IsNullOrEmpty(ProductPriceTextBox.Text) ? null : (long)Convert.ToDouble(ProductPriceTextBox.Text),
                Description = string.IsNullOrEmpty(ProductDescriptionTextBox.Text) ? null : ProductDescriptionTextBox.Text,
            };
            if (selectedProductId == 0)
            {
                if (productController.AddProduct(product))
                {
                    ShowMessageBoxAndClosePage("Başarılı", "Yeni ürün eklendi.");

                }
                else
                {
                    ShowMessageBoxAndClosePage("Başarısız", "Yeni Ürün eklenemedi.");
                }
            }
            else
            {
                product.ProductId = selectedProductId;
                if (productController.UpdateProduct(product))
                {
                    ShowMessageBoxAndClosePage("Başarılı", "Ürün değişikleri kaydedildi.");

                }
                else
                {
                    ShowMessageBoxAndClosePage("Başarısız", "Ürün değişiklikleri kaydedilemedi.");
                }
            }


        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (productController.DeleteProduct(selectedProductId))
            {
                ShowMessageBoxAndClosePage("Başarılı", "Ürün silindi.");

            }
            else
            {
                ShowMessageBoxAndClosePage("Başarısız", "Ürün silinemedi.");
            }
        }

        private void PrepareProductPage()
        {
            if (selectedProductId != 0)
            {
                product = productController.GetProduct(selectedProductId);

            }
            if (product != null)
            {
                ProductStockCodeTextBox.Text = product.StockCode;
                ProductNameTextBox.Text = product.Name;
                ProductPriceTextBox.Text = product.Price.ToString();
                ProductDescriptionTextBox.Text = product.Description;
            }
        }

        private void ShowMessageBoxAndClosePage(string title, string message)
        {
            var res = MessageBox.Show(message, title);
            if (res == DialogResult.OK)
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
