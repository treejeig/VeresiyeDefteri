using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeresiyeDefteri.Pages.ListPages
{
    public partial class ProductsPageForm : Form
    {
        public ProductsPageForm()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductPageForm productPageForm = new ProductPageForm();
            productPageForm.ShowDialog();
        }
    }
}
