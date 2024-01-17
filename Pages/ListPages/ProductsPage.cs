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

namespace VeresiyeDefteri.Pages.ListPages
{
    public partial class ProductsPageForm : Form
    {
        #region Constants
        ProductController productController = new ProductController();
        InputHelpers inputHelper = new InputHelpers();
        MessageBoxes messageBoxes = new MessageBoxes();
        List<Product> products = new List<Product>();
        long selectedProductId = 0;
        #endregion

        #region Constructors
        public ProductsPageForm()
        {
            InitializeComponent();
            PrepareProductsPage();
        }
        #endregion

        #region PreparePage
        private void PrepareProductsPage()
        {
            PrepareProductsDataGridView();
        }
        private void PrepareProductsDataGridView()
        {
            products = productController.GetProducts();
            // disable autogenerate, reset dataGridView
            ProductsDataGridView.DataSource = null;
            ProductsDataGridView.AutoGenerateColumns = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set column count
            ProductsDataGridView.ColumnCount = 8;
            // set id column
            ProductsDataGridView.Columns[0].Name = "ProductId";
            ProductsDataGridView.Columns[0].HeaderText = "ProductId";
            ProductsDataGridView.Columns[0].DataPropertyName = "ProductId";
            ProductsDataGridView.Columns[0].Visible = false;
            // set stock_code column
            ProductsDataGridView.Columns[1].Name = "StockCode";
            ProductsDataGridView.Columns[1].HeaderText = "Stok Kodu";
            ProductsDataGridView.Columns[1].DataPropertyName = "StockCode";
            //set name column
            ProductsDataGridView.Columns[2].Name = "ProductName";
            ProductsDataGridView.Columns[2].HeaderText = "Adı";
            ProductsDataGridView.Columns[2].DataPropertyName = "ProductName";
            //set price column
            ProductsDataGridView.Columns[3].Name = "Price";
            ProductsDataGridView.Columns[3].HeaderText = "Fiyatı";
            ProductsDataGridView.Columns[3].DataPropertyName = "Price";
            //set description column
            ProductsDataGridView.Columns[4].Name = "ProductDescription";
            ProductsDataGridView.Columns[4].HeaderText = "Açıklama";
            ProductsDataGridView.Columns[4].DataPropertyName = "ProductDescription";
            //set go_to_product_detail column
            DataGridViewButtonColumn goToProductDetailButtonColumn = new DataGridViewButtonColumn();
            goToProductDetailButtonColumn.UseColumnTextForButtonValue = true;
            goToProductDetailButtonColumn.Name = "GoToProductDetail";
            goToProductDetailButtonColumn.HeaderText = "Ürün Detayı";
            goToProductDetailButtonColumn.Text = "Detaya Git";
            ProductsDataGridView.Columns.RemoveAt(5);
            ProductsDataGridView.Columns.Insert(5, goToProductDetailButtonColumn);
            //set save_edited_product column
            DataGridViewButtonColumn saveEditedProductButtonColumn = new DataGridViewButtonColumn();
            saveEditedProductButtonColumn.UseColumnTextForButtonValue = true;
            saveEditedProductButtonColumn.Name = "SaveEditedProduct";
            saveEditedProductButtonColumn.HeaderText = "Değişiklikleri Kaydet";
            saveEditedProductButtonColumn.Text = "Kaydet";
            ProductsDataGridView.Columns.RemoveAt(6);
            ProductsDataGridView.Columns.Insert(6, saveEditedProductButtonColumn);
            //set delete_selected_product column
            DataGridViewButtonColumn deleteSelectedProductButtonColumn = new DataGridViewButtonColumn();
            deleteSelectedProductButtonColumn.UseColumnTextForButtonValue = true;
            deleteSelectedProductButtonColumn.Name = "DeleteSelectedProduct";
            deleteSelectedProductButtonColumn.HeaderText = "Ürünü Sil";
            deleteSelectedProductButtonColumn.Text = "Sil";
            ProductsDataGridView.Columns.RemoveAt(7);
            ProductsDataGridView.Columns.Insert(7, deleteSelectedProductButtonColumn);

            ProductsDataGridView.DataSource = products;
        }
        #endregion

        #region DataGridViewOperations
        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                selectedProductId = (long)ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                Product selectedProduct = productController.GetProduct(selectedProductId);
                string yesNoMessageBoxTitle;
                string yesNoMessageBoxMessage;

                if (ProductsDataGridView.Columns[e.ColumnIndex].Name == "GoToProductDetail")
                {
                    selectedProductId = (long)ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    ProductPageForm productPageForm = new ProductPageForm(selectedProductId);
                    productPageForm.FormClosed += new FormClosedEventHandler(ProductPageForm_FormClosed);
                    productPageForm.ShowDialog();
                }

                if (ProductsDataGridView.Columns[e.ColumnIndex].Name == "SaveEditedProduct")
                {
                    string oldStockCode = selectedProduct.StockCode ?? "";
                    string oldName = selectedProduct.ProductName;
                    double? oldPrice = selectedProduct.Price ?? 0;
                    string oldDescription = selectedProduct.ProductDescription ?? "";
                    string newStockCode = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    string newName = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    double? newPrice = inputHelper.RoundNullableTwoDigit(ProductsDataGridView.Rows[e.RowIndex].Cells[3].Value, 2) ?? 0;
                    string newDescription = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    yesNoMessageBoxTitle = "Ürün güncellensin mi?";
                    yesNoMessageBoxMessage = $"Stok Kodu: {oldStockCode} -> {newStockCode}\nAdı: {oldName} -> {newName}\nFiyatı: {oldPrice} -> {newPrice}\nAçıklama: {oldDescription} -> {newDescription}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        selectedProduct.StockCode = newStockCode;
                        selectedProduct.ProductName = newName;
                        selectedProduct.Price = newPrice;
                        selectedProduct.ProductDescription = newDescription;
                        if (productController.UpdateProduct(selectedProduct))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Ürün değişikleri kaydedildi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Ürün değişiklikleri kaydedilemedi."));
                        }
                    }
                }

                if (ProductsDataGridView.Columns[e.ColumnIndex].Name == "DeleteSelectedProduct")
                {
                    yesNoMessageBoxTitle = "Ürün silinsin mi?";
                    yesNoMessageBoxMessage = $"Stok Kodu: {selectedProduct.StockCode}\nAdı: {selectedProduct.ProductName}\nAçıklama: {selectedProduct.ProductDescription}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        if (productController.DeleteProduct(selectedProductId))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Ürün silindi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Ürün silinemedi."));
                        }
                    }
                }
            }
        }
        private void ProductsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyNumberAndOneDigitTextBox_KeyPress);
            if (ProductsDataGridView.CurrentCell.ColumnIndex != -1)
            {
                TextBox textBox = e.Control as TextBox;
                if (ProductsDataGridView.CurrentCell.ColumnIndex == 3)
                {
                    textBox.KeyPress += OnlyNumberAndOneDigitTextBox_KeyPress;
                }
            }
        }
        #endregion

        #region ButtonClick
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductPageForm productPageForm = new ProductPageForm();
            productPageForm.FormClosed += new FormClosedEventHandler(ProductPageForm_FormClosed);
            productPageForm.ShowDialog();
        }
        #endregion

        #region FormCloseCallBack
        private void ProductPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrepareProductsPage();
        }
        #endregion

        #region MessageBoxes
        private void ShowInfoMessageBoxAndRefreshPage(bool res)
        {
            if (res)
            {
                PrepareProductsPage();
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
