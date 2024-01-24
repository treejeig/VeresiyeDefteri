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
    public partial class PaymentTypeItemPageForm : Form
    {
        #region Constants
        PaymentTypeItemController paymentTypeItemController = new PaymentTypeItemController();
        MessageBoxes messageBoxes = new MessageBoxes();
        #endregion

        #region Constructors
        public PaymentTypeItemPageForm()
        {
            InitializeComponent();
        }
        #endregion

        #region ButtonClick
        private void SavePaymentTypeItemButton_Click(object sender, EventArgs e)
        {
            string messageBoxTitle = "Ödeme türü eklensin mi?";
            string messageBoxMessage = $"Adı: {PaymentTypeItemNameTextBox.Text}";

            if (messageBoxes.YesNoMessageBox(messageBoxTitle, messageBoxMessage))
            {
                PaymentTypeItem paymentTypeItem = new PaymentTypeItem
                {
                    PaymentTypeItemName = PaymentTypeItemNameTextBox.Text,
                };
                if (paymentTypeItemController.AddPaymentTypeItem(paymentTypeItem))
                {
                    ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Yeni Ödeme Türü eklendi."));

                }
                else
                {
                    ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Yeni Ödeme Türü eklenemedi."));
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
    }
}
