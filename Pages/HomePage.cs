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
            personsPageForm.Show();
        }

        private void GoToProductsPageButton_Click(object sender, EventArgs e)
        {
            ProductsPageForm productsPageForm = new ProductsPageForm();
            productsPageForm.Show();
        }

        private void GoToReceiptsPageButton_Click(object sender, EventArgs e)
        {
            ReceiptsPageForm receiptsPageForm = new ReceiptsPageForm();
            receiptsPageForm.Show();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }
    }
}