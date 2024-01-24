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
using VeresiyeDefteri.Pages.DetailPages;

namespace VeresiyeDefteri.Pages.ListPages
{
    public partial class PaymentTypeItemsPageForm : Form
    {
        #region Constants
        PaymentTypeItemController paymentTypeItemController = new PaymentTypeItemController();
        InputHelpers inputHelper = new InputHelpers();
        MessageBoxes messageBoxes = new MessageBoxes();
        List<PaymentTypeItem> paymentTypeItems = new List<PaymentTypeItem>();
        long selectedPaymentTypeItemId = 0;
        #endregion

        #region Constructors
        public PaymentTypeItemsPageForm()
        {
            InitializeComponent();
            PreparePaymentTypeItemsPage();
        }
        #endregion

        #region PreparePage
        private void PreparePaymentTypeItemsPage()
        {
            PreparePaymentTypeItemsDataGridView();
        }
        private void PreparePaymentTypeItemsDataGridView()
        {
            paymentTypeItems = paymentTypeItemController.GetPaymentTypeItems();
            // disable autogenerate, reset dataGridView
            PaymentTypeItemsDataGridView.DataSource = null;
            PaymentTypeItemsDataGridView.AutoGenerateColumns = false;
            PaymentTypeItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set column count
            PaymentTypeItemsDataGridView.ColumnCount = 4;
            // set id column
            PaymentTypeItemsDataGridView.Columns[0].Name = "PaymentTypeItemId";
            PaymentTypeItemsDataGridView.Columns[0].HeaderText = "PaymentTypeItemId";
            PaymentTypeItemsDataGridView.Columns[0].DataPropertyName = "PaymentTypeItemId";
            PaymentTypeItemsDataGridView.Columns[0].Visible = false;
            //set name column
            PaymentTypeItemsDataGridView.Columns[1].Name = "PaymentTypeItemName";
            PaymentTypeItemsDataGridView.Columns[1].HeaderText = "Adı";
            PaymentTypeItemsDataGridView.Columns[1].DataPropertyName = "PaymentTypeItemName";
            //set save_edited_payment_type_item column
            DataGridViewButtonColumn saveEditedPaymentTypeItemButtonColumn = new DataGridViewButtonColumn();
            saveEditedPaymentTypeItemButtonColumn.UseColumnTextForButtonValue = true;
            saveEditedPaymentTypeItemButtonColumn.Name = "SaveEditedPaymentTypeItem";
            saveEditedPaymentTypeItemButtonColumn.HeaderText = "Değişiklikleri Kaydet";
            saveEditedPaymentTypeItemButtonColumn.Text = "Kaydet";
            PaymentTypeItemsDataGridView.Columns.RemoveAt(2);
            PaymentTypeItemsDataGridView.Columns.Insert(2, saveEditedPaymentTypeItemButtonColumn);
            //set delete_selected_product column
            DataGridViewButtonColumn deleteSelectedPaymentTypeItemButtonColumn = new DataGridViewButtonColumn();
            deleteSelectedPaymentTypeItemButtonColumn.UseColumnTextForButtonValue = true;
            deleteSelectedPaymentTypeItemButtonColumn.Name = "DeleteSelectedPaymentTypeItem";
            deleteSelectedPaymentTypeItemButtonColumn.HeaderText = "Ödeme Türünü Sil";
            deleteSelectedPaymentTypeItemButtonColumn.Text = "Sil";
            PaymentTypeItemsDataGridView.Columns.RemoveAt(3);
            PaymentTypeItemsDataGridView.Columns.Insert(3, deleteSelectedPaymentTypeItemButtonColumn);

            PaymentTypeItemsDataGridView.DataSource = paymentTypeItems;
        }
        #endregion

        #region DataGridViewOperations
        private void PaymentTypeItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                selectedPaymentTypeItemId = (long)PaymentTypeItemsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                PaymentTypeItem selectedPaymentTypeItem = paymentTypeItemController.GetPaymentTypeItem(selectedPaymentTypeItemId);
                string yesNoMessageBoxTitle;
                string yesNoMessageBoxMessage;

                if (PaymentTypeItemsDataGridView.Columns[e.ColumnIndex].Name == "SaveEditedPaymentTypeItem")
                {
                    string oldName = selectedPaymentTypeItem.PaymentTypeItemName;
                    string newName = (string)PaymentTypeItemsDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    yesNoMessageBoxTitle = "Ödeme türü güncellensin mi?";
                    yesNoMessageBoxMessage = $"Adı: {oldName} -> {newName}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        selectedPaymentTypeItem.PaymentTypeItemName = newName;
                        if (paymentTypeItemController.UpdatePaymentTypeItem(selectedPaymentTypeItem))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Ödeme türü değişikleri kaydedildi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Ödeme türü değişiklikleri kaydedilemedi."));
                        }
                    }
                }

                if (PaymentTypeItemsDataGridView.Columns[e.ColumnIndex].Name == "DeleteSelectedPaymentTypeItem")
                {
                    yesNoMessageBoxTitle = "Ödeme türü silinsin mi?";
                    yesNoMessageBoxMessage = $"Adı: {selectedPaymentTypeItem.PaymentTypeItemName}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        if (paymentTypeItemController.DeletePaymentTypeItem(selectedPaymentTypeItemId))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Ödeme türü silindi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Ödeme türü silinemedi."));
                        }
                    }
                }
            }
        }
        #endregion

        #region ButtonClick
        private void AddPaymentTypeItemButton_Click(object sender, EventArgs e)
        {
            PaymentTypeItemPageForm paymentTypeItemPage = new PaymentTypeItemPageForm();
            paymentTypeItemPage.FormClosed += new FormClosedEventHandler(PaymentTypeItemPageForm_FormClosed);
            paymentTypeItemPage.ShowDialog();
        }
        #endregion

        #region FormCloseCallBack
        private void PaymentTypeItemPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreparePaymentTypeItemsPage();
        }
        #endregion

        #region MessageBoxes
        private void ShowInfoMessageBoxAndRefreshPage(bool res)
        {
            if (res)
            {
                PreparePaymentTypeItemsPage();
            }
        }
        #endregion
    }
}
