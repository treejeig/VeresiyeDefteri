using VeresiyeDefteri.Pages.ListPages;

namespace VeresiyeDefteri
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void GoToPersonsPageButton_Click(object sender, EventArgs e)
        {
            PersonsPageForm personsPageForm = new PersonsPageForm();
            personsPageForm.ShowDialog();
        }

        private void GoToProductsPageButton_Click(object sender, EventArgs e)
        {
            ProductsPageForm productsPageForm = new ProductsPageForm();
            productsPageForm.ShowDialog();
        }

        private void GoToReceiptsPageButton_Click(object sender, EventArgs e)
        {
            ReceiptsPageForm receiptsPageForm = new ReceiptsPageForm();
            receiptsPageForm.ShowDialog();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }
    }
}