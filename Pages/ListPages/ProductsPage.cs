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

namespace VeresiyeDefteri.Pages.ListPages
{
    public partial class ProductsPageForm : Form
    {
        ProductController productController = new ProductController();
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
            ProductsDataGridView.ReadOnly = true;
            // set column count
            ProductsDataGridView.ColumnCount = 6;
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

            ProductsDataGridView.DataSource = products;
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && ProductsDataGridView.Columns[e.ColumnIndex].Name == "GoToProductDetail")
            {
                selectedProductId = (long)ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                ProductPageForm productPageForm = new ProductPageForm(selectedProductId);
                productPageForm.FormClosed += new FormClosedEventHandler(ProductPageForm_FormClosed);
                productPageForm.ShowDialog();
            }
        }
        private void ProductPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrepareProductsPage();
        }
    }
}
