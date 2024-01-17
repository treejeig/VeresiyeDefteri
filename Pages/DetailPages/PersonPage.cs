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
    public partial class PersonPageForm : Form
    {
        PersonController personController = new PersonController();
        ReceiptItemController receiptItemController = new ReceiptItemController();
        InputHelpers inputHelper = new InputHelpers();
        MessageBoxes messageBoxes = new MessageBoxes();
        Person person = new Person();
        List<ReceiptItem> receiptItems = new List<ReceiptItem>();
        long selectedPersonId = 0;
        string? oldName;
        string? oldSurname;
        long selectedReceiptItemId = 0;
        int productPriceColumnIndex = 5;
        int productPriceOnReceiptDateColumnIndex = 6;
        int productPriceOnPaymentDateColumnIndex = 7;
        int productSpecialPriceForPersonColumnIndex = 8;
        int productDiscountPriceColumnIndex = 9;
        int productDiscountRatioColumnIndex = 10;
        int productQuantityColumnIndex = 11;
        int productTotalPriceColumnIndex = 12;
        int paymentAmountColumnIndex = 13;
        public PersonPageForm(long personId)
        {
            selectedPersonId = personId;
            InitializeComponent();
            PreparePersonPage();
        }
        public PersonPageForm()
        {
            selectedPersonId = 0;
            InitializeComponent();
            PreparePersonPage();
        }
        private void SavePersonButton_Click(object sender, EventArgs e)
        {
            string messageBoxTitle;
            string messageBoxMessage;
            if (selectedPersonId == 0)
            {
                messageBoxTitle = "Kişi eklensin mi?";
                messageBoxMessage = $"Ad Soyad: {PersonNameTextBox.Text} {PersonSurnameTextBox.Text}";
            }
            else
            {
                messageBoxTitle = "Kişi güncellensin mi?";
                messageBoxMessage = $"Eski Ad Soyad: {oldName} {oldSurname}\nYeni Ad Soyad: {PersonNameTextBox.Text} {PersonSurnameTextBox.Text}";
            }

            if (messageBoxes.YesNoMessageBox(messageBoxTitle, messageBoxMessage))
            {
                Person person = new Person
                {
                    Name = PersonNameTextBox.Text,
                    Surname = PersonSurnameTextBox.Text,
                    Phone = string.IsNullOrEmpty(PersonPhoneTextBox.Text) ? null : (long)Convert.ToDouble(PersonPhoneTextBox.Text),
                    MobilePhone = string.IsNullOrEmpty(PersonMobilePhoneTextBox.Text) ? null : (long)Convert.ToDouble(PersonMobilePhoneTextBox.Text),
                    Email = string.IsNullOrEmpty(PersonEmailTextBox.Text) ? null : PersonEmailTextBox.Text,
                    IdentityNumber = string.IsNullOrEmpty(PersonIdentityNumberTextBox.Text) ? null : (long)Convert.ToDouble(PersonIdentityNumberTextBox.Text),
                    Address = string.IsNullOrEmpty(PersonAddressTextBox.Text) ? null : PersonAddressTextBox.Text,
                    Description = string.IsNullOrEmpty(PersonDescriptionTextBox.Text) ? null : PersonDescriptionTextBox.Text,
                    IncomingBalance = string.IsNullOrEmpty(PersonIncomingBalanceTextBox.Text) ? null : Convert.ToDouble(PersonIncomingBalanceTextBox.Text),
                    OutgoingBalance = string.IsNullOrEmpty(PersonOutgoingBalanceTextBox.Text) ? null : Convert.ToDouble(PersonOutgoingBalanceTextBox.Text)
                };
                if (selectedPersonId == 0)
                {
                    if (personController.AddPerson(person))
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Yeni Kişi eklendi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Yeni Kişi eklenemedi."));
                    }
                }
                else
                {
                    person.PersonId = selectedPersonId;
                    if (personController.UpdatePerson(person))
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Kişi değişiklikleri kaydedildi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Kişi değişiklikleri kaydedilemedi."));
                    }
                }
            }
        }
        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            var yesNoMessageBoxTitle = "Kişi silinsin mi?";
            var yesNomessageBoxMessage = $"Ad Soyad: {oldName} {oldSurname}";

            if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNomessageBoxMessage))
            {
                string infoMessageBoxTitle;
                string infoMessageBoxMessage;
                if (personController.DeletePerson(selectedPersonId))
                {
                    infoMessageBoxTitle = "Başarılı";
                    infoMessageBoxMessage = $"{oldName} {oldSurname} silindi.";
                }
                else
                {
                    infoMessageBoxTitle = "Başarısız";
                    infoMessageBoxMessage = $"{oldName} {oldSurname} silinemedi.";

                }
                ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox(infoMessageBoxTitle, infoMessageBoxMessage));
            }
        }
        private void PreparePersonPage()
        {
            PreparePersonInformation();
            PreparePersonReceiptItemInformation();
        }
        private void PreparePersonInformation()
        {
            if (selectedPersonId != 0)
            {
                person = personController.GetPerson(selectedPersonId);
            }
            else
            {
                DeletePersonButton.Visible = false;
            }
            if (person != null)
            {
                PersonNameTextBox.Text = person.Name;
                PersonSurnameTextBox.Text = person.Surname;
                PersonPhoneTextBox.Text = person.Phone.ToString();
                PersonMobilePhoneTextBox.Text = person.MobilePhone.ToString();
                PersonEmailTextBox.Text = person.Email;
                PersonIdentityNumberTextBox.Text = person.IdentityNumber.ToString();
                PersonAddressTextBox.Text = person.Address;
                PersonDescriptionTextBox.Text = person.Description;
                PersonIncomingBalanceTextBox.Text = person.IncomingBalance.ToString();
                PersonOutgoingBalanceTextBox.Text = person.OutgoingBalance.ToString();
                PersonTotalBalanceTextBox.Text = person.TotalBalance.ToString();
                oldName = person.Name;
                oldSurname = person.Surname;
            }
        }
        private void PreparePersonReceiptItemInformation()
        {
            if (selectedPersonId != 0)
            {
                receiptItems = receiptItemController.GetReceiptItemsByPersonId(selectedPersonId);
            }
            else
            {
                PersonReceiptsDataGridView.Visible = false;
            }
            if (receiptItems != null)
            {
                // disable autogenerate, reset dataGridView
                PersonReceiptsDataGridView.DataSource = null;
                PersonReceiptsDataGridView.AutoGenerateColumns = false;
                PersonReceiptsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // set column count
                PersonReceiptsDataGridView.ColumnCount = 16;
                // set id column
                PersonReceiptsDataGridView.Columns[0].Name = "ReceiptItemId";
                PersonReceiptsDataGridView.Columns[0].HeaderText = "ReceiptItemId";
                PersonReceiptsDataGridView.Columns[0].DataPropertyName = "ReceiptItemId";
                PersonReceiptsDataGridView.Columns[0].Visible = false;
                // set receipt_date column
                PersonReceiptsDataGridView.Columns[1].Name = "ReceiptDate";
                PersonReceiptsDataGridView.Columns[1].HeaderText = "Sipariş Tarihi";
                PersonReceiptsDataGridView.Columns[1].DataPropertyName = "ReceiptDate";
                PersonReceiptsDataGridView.Columns[1].ValueType = typeof(DateTime);
                // set payment_date column
                PersonReceiptsDataGridView.Columns[2].Name = "PaymentDate";
                PersonReceiptsDataGridView.Columns[2].HeaderText = "Ödeme Tarihi";
                PersonReceiptsDataGridView.Columns[2].DataPropertyName = "PaymentDate";
                PersonReceiptsDataGridView.Columns[2].ValueType = typeof(DateTime);
                // set product_stock_code column
                PersonReceiptsDataGridView.Columns[3].Name = "ProductStockCode";
                PersonReceiptsDataGridView.Columns[3].HeaderText = "Ürün Stok Kodu";
                PersonReceiptsDataGridView.Columns[3].DataPropertyName = "ProductStockCode";
                // set product_name column
                PersonReceiptsDataGridView.Columns[4].Name = "ProductName";
                PersonReceiptsDataGridView.Columns[4].HeaderText = "Ürün Adı";
                PersonReceiptsDataGridView.Columns[4].DataPropertyName = "ProductName";
                // set product_price column
                PersonReceiptsDataGridView.Columns[productPriceColumnIndex].Name = "ProductPrice";
                PersonReceiptsDataGridView.Columns[productPriceColumnIndex].HeaderText = "Ürün Güncel Fiyatı";
                PersonReceiptsDataGridView.Columns[productPriceColumnIndex].DataPropertyName = "ProductPrice";
                PersonReceiptsDataGridView.Columns[productPriceColumnIndex].ValueType = typeof(double);
                // set product_price_on_receipt_date column
                PersonReceiptsDataGridView.Columns[productPriceOnReceiptDateColumnIndex].Name = "ProductPriceOnReceiptDate";
                PersonReceiptsDataGridView.Columns[productPriceOnReceiptDateColumnIndex].HeaderText = "Sipariş Tarihi Ürün Fiyatı";
                PersonReceiptsDataGridView.Columns[productPriceOnReceiptDateColumnIndex].DataPropertyName = "ProductPriceOnReceiptDate";
                PersonReceiptsDataGridView.Columns[productPriceOnReceiptDateColumnIndex].ValueType = typeof(double);
                // set product_price_on_payment_date column
                PersonReceiptsDataGridView.Columns[productPriceOnPaymentDateColumnIndex].Name = "ProductPriceOnPaymentDate";
                PersonReceiptsDataGridView.Columns[productPriceOnPaymentDateColumnIndex].HeaderText = "Ödeme Tarihi Ürün Fiyatı";
                PersonReceiptsDataGridView.Columns[productPriceOnPaymentDateColumnIndex].DataPropertyName = "ProductPriceOnPaymentDate";
                PersonReceiptsDataGridView.Columns[productPriceOnPaymentDateColumnIndex].ValueType = typeof(double);
                // set special_price_for_person column
                PersonReceiptsDataGridView.Columns[productSpecialPriceForPersonColumnIndex].Name = "SpecialPriceForPerson";
                PersonReceiptsDataGridView.Columns[productSpecialPriceForPersonColumnIndex].HeaderText = "Kişiye Özel Fiyat";
                PersonReceiptsDataGridView.Columns[productSpecialPriceForPersonColumnIndex].DataPropertyName = "SpecialPriceForPerson";
                PersonReceiptsDataGridView.Columns[productSpecialPriceForPersonColumnIndex].ValueType = typeof(double);
                // set product_discount_price column
                PersonReceiptsDataGridView.Columns[productDiscountPriceColumnIndex].Name = "ProductDiscountPrice";
                PersonReceiptsDataGridView.Columns[productDiscountPriceColumnIndex].HeaderText = "İndirimli Fiyat";
                PersonReceiptsDataGridView.Columns[productDiscountPriceColumnIndex].DataPropertyName = "ProductDiscountPrice";
                PersonReceiptsDataGridView.Columns[productDiscountPriceColumnIndex].ValueType = typeof(double);
                // set product_discount_ratio column
                PersonReceiptsDataGridView.Columns[productDiscountRatioColumnIndex].Name = "ProductDiscountRatio";
                PersonReceiptsDataGridView.Columns[productDiscountRatioColumnIndex].HeaderText = "İndirim Oranı(%)";
                PersonReceiptsDataGridView.Columns[productDiscountRatioColumnIndex].DataPropertyName = "ProductDiscountRatio";
                PersonReceiptsDataGridView.Columns[productDiscountRatioColumnIndex].ValueType = typeof(double);
                // set product_quantity column
                PersonReceiptsDataGridView.Columns[productQuantityColumnIndex].Name = "ProductQuantity";
                PersonReceiptsDataGridView.Columns[productQuantityColumnIndex].HeaderText = "Ürün Adedi";
                PersonReceiptsDataGridView.Columns[productQuantityColumnIndex].DataPropertyName = "ProductQuantity";
                PersonReceiptsDataGridView.Columns[productQuantityColumnIndex].ValueType = typeof(double);
                // set product_total_price column
                PersonReceiptsDataGridView.Columns[productTotalPriceColumnIndex].Name = "ProductTotalPrice";
                PersonReceiptsDataGridView.Columns[productTotalPriceColumnIndex].HeaderText = "Ürün Toplam Fiyatı";
                PersonReceiptsDataGridView.Columns[productTotalPriceColumnIndex].DataPropertyName = "ProductTotalPrice";
                PersonReceiptsDataGridView.Columns[productTotalPriceColumnIndex].ValueType = typeof(double);
                // set payment_amount column
                PersonReceiptsDataGridView.Columns[paymentAmountColumnIndex].Name = "PaymentAmount";
                PersonReceiptsDataGridView.Columns[paymentAmountColumnIndex].HeaderText = "Ödeme Tutarı";
                PersonReceiptsDataGridView.Columns[paymentAmountColumnIndex].DataPropertyName = "PaymentAmount";
                PersonReceiptsDataGridView.Columns[paymentAmountColumnIndex].ValueType = typeof(double);
                //set save_edited_receipt_item column
                DataGridViewButtonColumn saveEditedReceiptItemButtonColumn = new DataGridViewButtonColumn();
                saveEditedReceiptItemButtonColumn.UseColumnTextForButtonValue = true;
                saveEditedReceiptItemButtonColumn.Name = "SaveEditedReceiptItem";
                saveEditedReceiptItemButtonColumn.HeaderText = "Değişiklikleri Kaydet";
                saveEditedReceiptItemButtonColumn.Text = "Kaydet";
                PersonReceiptsDataGridView.Columns.RemoveAt(14);
                PersonReceiptsDataGridView.Columns.Insert(14, saveEditedReceiptItemButtonColumn);
                //set delete_selected_person column
                DataGridViewButtonColumn deleteSelectedReceiptItemButtonColumn = new DataGridViewButtonColumn();
                deleteSelectedReceiptItemButtonColumn.UseColumnTextForButtonValue = true;
                deleteSelectedReceiptItemButtonColumn.Name = "DeleteSelectedReceiptItem";
                deleteSelectedReceiptItemButtonColumn.HeaderText = "Kaydı Sil";
                deleteSelectedReceiptItemButtonColumn.Text = "Sil";
                PersonReceiptsDataGridView.Columns.RemoveAt(15);
                PersonReceiptsDataGridView.Columns.Insert(15, deleteSelectedReceiptItemButtonColumn);

                PersonReceiptsDataGridView.DataSource = receiptItems;

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

        private void PersonReceiptsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                selectedReceiptItemId = (long)PersonReceiptsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                ReceiptItem selectedReceiptItem = receiptItemController.GetReceiptItem(selectedReceiptItemId);
                string yesNoMessageBoxTitle;
                string yesNoMessageBoxMessage;
                if (PersonReceiptsDataGridView.Columns[e.ColumnIndex].Name == "SaveEditedReceiptItem")
                {
                    double? oldTotalPrice = selectedReceiptItem.ProductTotalPrice;
                    double? newTotalPrice = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[e.RowIndex].Cells[productTotalPriceColumnIndex].Value, 2);
                    double? oldPaymentAmount = selectedReceiptItem.PaymentAmount;
                    double? newPaymentAmount = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[e.RowIndex].Cells[paymentAmountColumnIndex].Value, 2);
                    yesNoMessageBoxTitle = "Fiş güncellensin mi?";
                    yesNoMessageBoxMessage = $"Eski Toplam Alacak: {oldTotalPrice}\nYeni Toplam Alacak: {newTotalPrice}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        person.IncomingBalance += (newTotalPrice - oldTotalPrice);
                        person.OutgoingBalance += (newPaymentAmount - oldPaymentAmount);
                        if (UpdateReceiptItem(selectedReceiptItem, e.RowIndex) && personController.UpdatePerson(person))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Fiş değişikleri kaydedildi."), true);
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Fiş değişiklikleri kaydedilemedi."));
                        }
                    }
                }

                if (PersonReceiptsDataGridView.Columns[e.ColumnIndex].Name == "DeleteSelectedReceiptItem")
                {
                    yesNoMessageBoxTitle = "Fiş silinsin mi?";
                    yesNoMessageBoxMessage = $"Toplam Alacak: {selectedReceiptItem.ProductTotalPrice}\nToplam Alınan: {selectedReceiptItem.PaymentAmount}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        if (receiptItemController.DeleteReceiptItem(selectedReceiptItemId))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Fiş silindi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Fiş silinemedi."));
                        }
                    }
                }

            }
        }

        private bool UpdateReceiptItem(ReceiptItem receiptItem, int rowIndex)
        {
            var hasPaymentAmount = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[paymentAmountColumnIndex].Value, 2) != null
                                    && inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[paymentAmountColumnIndex].Value, 2) != 0;
            var isFirstPayment = receiptItem.PaymentDate == null;
            if (hasPaymentAmount)
            {
                if (isFirstPayment)
                {
                    receiptItem.PaymentDate = DateTime.Now;
                    receiptItem.ProductPriceOnPaymentDate = receiptItem.ProductPrice;
                }
                receiptItem.PaymentAmount = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[paymentAmountColumnIndex].Value, 2);
            }
            receiptItem.SpecialPriceForPerson = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value, 2);
            receiptItem.ProductDiscountPrice = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[productDiscountPriceColumnIndex].Value, 2);
            receiptItem.ProductDiscountRatio = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[productDiscountRatioColumnIndex].Value, 2);
            receiptItem.ProductQuantity = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[productQuantityColumnIndex].Value, 2);
            receiptItem.ProductTotalPrice = inputHelper.RoundNullableTwoDigit(PersonReceiptsDataGridView.Rows[rowIndex].Cells[productTotalPriceColumnIndex].Value, 2);
            return receiptItemController.UpdateReceiptItem(receiptItem);
        }
        private void PersonReceiptsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumberAndOneDigitTextBox_KeyPress);
            if (PersonReceiptsDataGridView.CurrentCell.ColumnIndex != -1)
            {
                TextBox textBox = e.Control as TextBox;
                if (PersonReceiptsDataGridView.CurrentCell.ColumnIndex == productDiscountPriceColumnIndex
                    || PersonReceiptsDataGridView.CurrentCell.ColumnIndex == productDiscountRatioColumnIndex
                    || PersonReceiptsDataGridView.CurrentCell.ColumnIndex == productQuantityColumnIndex
                    || PersonReceiptsDataGridView.CurrentCell.ColumnIndex == productTotalPriceColumnIndex
                    || PersonReceiptsDataGridView.CurrentCell.ColumnIndex == paymentAmountColumnIndex)
                {
                    textBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
                }
            }
        }
        private void PersonReceiptsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedColumnIndex = e.ColumnIndex;

            var hasPaymentDate = PersonReceiptsDataGridView.Rows[e.RowIndex].Cells[2].Value != null;

            var hasSpecialPriceForPerson = !(PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value == null
                                                    || (double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value == 0);

            var productCurrentPrice = hasPaymentDate
                                    ? Math.Round((double)PersonReceiptsDataGridView.Rows[e.RowIndex].Cells[productPriceOnPaymentDateColumnIndex].Value, 2)
                                    : hasSpecialPriceForPerson
                                        ? Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value, 2)
                                        : Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productPriceColumnIndex].Value, 2);

            var productQuantity = Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productQuantityColumnIndex].Value, 2);

            if (selectedColumnIndex == productSpecialPriceForPersonColumnIndex)
            {
                if (!hasSpecialPriceForPerson)
                {
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value = null;
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value = null;
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value = null;
                }
                if (hasPaymentDate)
                {
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productSpecialPriceForPersonColumnIndex].Value = null;
                }
                var productTotalPrice = Math.Round(productCurrentPrice * productQuantity, 2);
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productTotalPriceColumnIndex].Value = productTotalPrice;
            }

            if (selectedColumnIndex == productDiscountPriceColumnIndex)
            {
                var productDiscountPrice = Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value, 2);
                var productDiscountRatio = Math.Round((1 - (productDiscountPrice / productCurrentPrice)) * 100, 2);
                var productTotalPrice = Math.Round(productDiscountPrice * productQuantity, 2);
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value = productDiscountRatio;
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productTotalPriceColumnIndex].Value = productTotalPrice;
            }

            if (selectedColumnIndex == productDiscountRatioColumnIndex)
            {
                var hasDiscountRatio = !(PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value == null
                                                    || (double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value == 0);

                var productCurrentPriceForDiscountRatioCalculation = productCurrentPrice;
                if (hasDiscountRatio)
                {
                    var productDiscountRatio = Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value, 2);
                    productCurrentPriceForDiscountRatioCalculation = Math.Round(productCurrentPrice * (1 - productDiscountRatio / 100), 2);
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value = productCurrentPriceForDiscountRatioCalculation;
                }
                else
                {
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value = null;
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value = null;
                }
                var productTotalPrice = Math.Round(productCurrentPriceForDiscountRatioCalculation * productQuantity, 2);
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productTotalPriceColumnIndex].Value = productTotalPrice;
            }

            if (selectedColumnIndex == productQuantityColumnIndex)
            {
                var discountPriceNullOrEmpty = PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value == null
                                                    || (double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value == 0;

                var productCurrentPriceForQuantityCalculation = discountPriceNullOrEmpty
                                            ? productCurrentPrice
                                            : Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value, 2);
                if (discountPriceNullOrEmpty)
                {
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value = null;
                    PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value = null;
                }
                var productTotalPrice = Math.Round((double)productCurrentPriceForQuantityCalculation * productQuantity, 2);
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productTotalPriceColumnIndex].Value = productTotalPrice;
            }

            if (selectedColumnIndex == productTotalPriceColumnIndex)
            {
                var productTotalPrice = Math.Round((double)PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value, 2);
                var productDiscountPrice = Math.Round((double)(productTotalPrice / productQuantity), 2);
                var productDiscountRatio = Math.Round((1 - (productDiscountPrice / productCurrentPrice)) * 100, 2);
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountPriceColumnIndex].Value = productDiscountPrice;
                PersonReceiptsDataGridView.Rows[selectedRowIndex].Cells[productDiscountRatioColumnIndex].Value = productDiscountRatio;
            }
        }
        private void ShowInfoMessageBoxAndRefreshPage(bool res, bool updatePerson = false)
        {
            if (res && updatePerson)
            {
                PreparePersonPage();
            }
            if (res)
            {
                PreparePersonReceiptItemInformation();
            }
        }

        private void AddReceiptItemButton_Click(object sender, EventArgs e)
        {
            ReceiptItemAddingPageForm receiptPageForm = new ReceiptItemAddingPageForm(person);
            receiptPageForm.FormClosed += new FormClosedEventHandler(ReceiptPageForm_FormClosed);
            receiptPageForm.ShowDialog();
        }

        private void ReceiptPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreparePersonPage();
        }
    }
}
