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
    public partial class ReceiptItemAddingPageForm : Form
    {

        #region Constants
        Person person = new Person();
        ProductController productController = new ProductController();
        ReceiptItemController receiptItemController = new ReceiptItemController();
        PersonController personController = new PersonController();
        InputHelpers inputHelper = new InputHelpers();
        List<Product> products = new List<Product>();
        Product selectedProduct = new Product();
        MessageBoxes messageBoxes = new MessageBoxes();
        #endregion

        #region Constructors
        public ReceiptItemAddingPageForm(Person selectedPerson)
        {
            person = selectedPerson;
            InitializeComponent();
            PrepareReceiptItemAddingPage();
        }
        #endregion

        #region PreparePage
        private void PrepareReceiptItemAddingPage()
        {
            PreparePersonInformation();
            PrepareProductsComboBox();

        }
        private void PreparePersonInformation()
        {
            ReceiptPersonNameSurnameTextBox.Text = person.Name + " " + person.Surname;
            ReceiptItemDateTextBox.Text = DateTime.Now.ToString();
            ReceiptPersonIncomingBalanceTextBox.Text = person.IncomingBalance.ToString();
            ReceiptPersonOutgoingBalanceTextBox.Text = person.OutgoingBalance.ToString();
            ReceiptPersonTotalBalanceTextBox.Text = person.TotalBalance.ToString();
        }
        private void PrepareProductsComboBox()
        {
            products = productController.GetProducts();
            SelectReceiptItemComboBox.DisplayMember = "ProductName";
            SelectReceiptItemComboBox.ValueMember = "ProductId";
            SelectReceiptItemComboBox.DataSource = products;
        }
        #endregion

        #region TextBoxComBoxChanges
        private void SelectReceiptItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)SelectReceiptItemComboBox.SelectedItem;
            ReceiptItemSpecialPriceTextBox.Text = null;
            CalculateReceiptItemPrices();
        }
        private void ReceiptItemQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateReceiptItemPrices();
        }
        private void ReceiptItemSpecialPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateReceiptItemPrices();
        }
        #endregion

        #region ButtonClick
        private void SaveReceiptItemButton_Click(object sender, EventArgs e)
        {
            double? specialPrice = null;
            double? productQuantity = inputHelper.RoundNullableTwoDigit(double.Parse(ReceiptItemQuantityTextBox.Text), 2);
            double? productTotalPrice = inputHelper.RoundNullableTwoDigit(double.Parse(ReceiptItemTotalPriceTextBox.Text), 2);

            string yesNoMessageBoxTitle = "Fiş eklensin mi?";
            string yesNoMessageBoxMessage = $"Ürün Adı: {selectedProduct.ProductName}\nÜrün Fiyatı: {selectedProduct.Price}\n";

            var hasSpecialPrice = !string.IsNullOrEmpty(ReceiptItemSpecialPriceTextBox.Text) && ReceiptItemSpecialPriceTextBox.Text != "0";

            if (hasSpecialPrice)
            {
                specialPrice = inputHelper.RoundNullableTwoDigit(double.Parse(ReceiptItemSpecialPriceTextBox.Text), 2);
                yesNoMessageBoxMessage += $"Kişiye Özel Fiyat: {specialPrice}\n";
            }

            yesNoMessageBoxMessage += $"Ürün Adedi: {productQuantity}\nÜrün Toplam Tutarı: {productTotalPrice}";

            if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
            {
                ReceiptItem receiptItem = new ReceiptItem()
                {
                    PersonId = person.PersonId,
                    ProductId = selectedProduct.ProductId,
                    ReceiptDate = DateTime.Now,
                    SpecialPriceForPerson = specialPrice,
                    ProductPriceOnReceiptDate = selectedProduct.Price,
                    ProductQuantity = productQuantity,
                    ProductTotalPrice = productTotalPrice,
                };
                person.IncomingBalance += productTotalPrice;

                if (receiptItemController.AddReceiptItem(receiptItem) && personController.UpdatePerson(person))
                {
                    ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Fiş kaydedildi."));
                }
                else
                {
                    ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Fiş kaydedilemedi."));
                }
            }
        }
        #endregion

        #region Calculations
        private void CalculateReceiptItemPrices()
        {
            ReceiptItemPriceTextBox.Text = selectedProduct.Price.ToString();
            var hasQuantity = !string.IsNullOrEmpty(ReceiptItemQuantityTextBox.Text) && ReceiptItemQuantityTextBox.Text != "0";
            var hasSpecialPrice = !string.IsNullOrEmpty(ReceiptItemSpecialPriceTextBox.Text) && ReceiptItemSpecialPriceTextBox.Text != "0";
            double quantity;
            if (hasQuantity)
            {
                quantity = double.Parse(ReceiptItemQuantityTextBox.Text);
            }
            else
            {
                quantity = 1;
                ReceiptItemQuantityTextBox.Text = quantity.ToString();
            }
            var currentPrice = hasSpecialPrice ? double.Parse(ReceiptItemSpecialPriceTextBox.Text) : selectedProduct.Price;
            var totalPrice = inputHelper.RoundNullableTwoDigit(quantity * currentPrice, 2);
            ReceiptItemTotalPriceTextBox.Text = totalPrice.ToString();
        }
        #endregion

        #region FormCloseCallBack
        #endregion

        #region MessageBoxes
        private void ShowInfoMessageBoxAndClosePage(bool res)
        {
            if (res)
            {
                Close();
            }
        }
        #endregion

        #region KeyPress
        private void OnlyNumberAndOneDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputHelper.AllowOnlyNumbersAndOneDigit(sender, e);
        }
        #endregion
    }
}
