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
        ProductController productController = new ProductController();
        MessageBoxes messageBoxes = new MessageBoxes();
        List<Product> products = new List<Product>();
        long selectedProductId = 0;
        public ProductsPageForm()
        {
            InitializeComponent();
            PrepareProductsPage();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductPageForm productPageForm = new ProductPageForm();
            productPageForm.FormClosed += new FormClosedEventHandler(ProductPageForm_FormClosed);
            productPageForm.ShowDialog();
        }

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
            ProductsDataGridView.Columns[2].Name = "Name";
            ProductsDataGridView.Columns[2].HeaderText = "Adı";
            ProductsDataGridView.Columns[2].DataPropertyName = "Name";
            //set price column
            ProductsDataGridView.Columns[3].Name = "Price";
            ProductsDataGridView.Columns[3].HeaderText = "Fiyatı";
            ProductsDataGridView.Columns[3].DataPropertyName = "Price";
            ProductsDataGridView.Columns[3].ReadOnly = true;
            //set description column
            ProductsDataGridView.Columns[4].Name = "Description";
            ProductsDataGridView.Columns[4].HeaderText = "Açıklama";
            ProductsDataGridView.Columns[4].DataPropertyName = "Description";
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

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
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
                    string oldName = selectedProduct.Name;
                    string oldDescription = selectedProduct.Description ?? "";
                    string newStockCode = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    string newName = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    string newDescription = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    yesNoMessageBoxTitle = "Ürün güncellensin mi?";
                    yesNoMessageBoxMessage = $"Stok Kodu: {oldStockCode} -> {newStockCode}\nAdı: {oldName} -> {newName}\nAçıklama: {oldDescription} -> {newDescription}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        selectedProduct.StockCode = newStockCode;
                        selectedProduct.Name = newName;
                        selectedProduct.Description = newDescription;
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
                    yesNoMessageBoxMessage = $"Stok Kodu: {selectedProduct.StockCode}\nAdı: {selectedProduct.Name}\nAçıklama: {selectedProduct.Description}";
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
        private void ProductPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrepareProductsPage();
        }

        private void ShowInfoMessageBoxAndRefreshPage(bool res)
        {
            if (res)
            {
                PrepareProductsPage();
            }
        }
    }
}
