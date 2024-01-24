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

namespace VeresiyeDefteri.Pages.DetailPages
{
    public partial class PaymentItemAddingPageForm : Form
    {
        #region Constants
        Person person = new Person();
        PaymentTypeItemController paymentTypeItem = new PaymentTypeItemController();
        ReceiptItemController receiptItemController = new ReceiptItemController();
        PersonController personController = new PersonController();
        InputHelpers inputHelper = new InputHelpers();
        List<PaymentTypeItem> paymentItems = new List<PaymentTypeItem>();
        PaymentTypeItem selectedPaymentItem = new PaymentTypeItem();
        MessageBoxes messageBoxes = new MessageBoxes();
        #endregion

        #region Constructors
        public PaymentItemAddingPageForm(Person selectedPerson)
        {
            person = selectedPerson;
            InitializeComponent();
            PreparePaymentItemAddingPage();
        }
        #endregion

        #region PreparePage
        private void PreparePaymentItemAddingPage()
        {
            PreparePersonInformation();
            PreparePaymentTypesComboBox();

        }
        private void PreparePersonInformation()
        {
            PaymentPersonNameSurnameTextBox.Text = person.Name + " " + person.Surname;
            PaymentItemDateTextBox.Text = DateTime.Now.ToString();
            PaymentPersonIncomingBalanceTextBox.Text = person.IncomingBalance.ToString();
            PaymentPersonOutgoingBalanceTextBox.Text = person.OutgoingBalance.ToString();
            PaymentPersonTotalBalanceTextBox.Text = person.TotalBalance.ToString();
        }
        private void PreparePaymentTypesComboBox()
        {
            paymentItems = paymentTypeItem.GetPaymentTypeItems();
            SelectPaymentTypeItemComboBox.DisplayMember = "PaymentTypeItemName";
            SelectPaymentTypeItemComboBox.ValueMember = "PaymentTypeItemId";
            SelectPaymentTypeItemComboBox.DataSource = paymentItems;
        }
        #endregion

        #region TextBoxComBoxChanges
        private void SelectPaymentItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPaymentItem = (PaymentTypeItem)SelectPaymentTypeItemComboBox.SelectedItem;
        }
        #endregion

        #region ButtonClick
        private void SavePaymentItemButton_Click(object sender, EventArgs e)
        {
            if(PaymentAmountTextBox.Text != "")
            {
                double? paymentAmount = inputHelper.RoundNullableTwoDigit(double.Parse(PaymentAmountTextBox.Text), 2);

                string yesNoMessageBoxTitle = "Ödeme eklensin mi?";
                string yesNoMessageBoxMessage = $"Ödeme Türü: {selectedPaymentItem.PaymentTypeItemName}\nÖdeme Tutarı: {paymentAmount}\n";

                if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                {
                    ReceiptItem receiptItem = new ReceiptItem()
                    {
                        PersonId = person.PersonId,
                        ProductId = selectedPaymentItem.PaymentTypeItemId,
                        PaymentDate = DateTime.Now,
                        PaymentAmount = paymentAmount,
                    };
                    person.OutgoingBalance += paymentAmount;

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
        }
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
