using VeresiyeDefteri.Pages.ListPages;

namespace VeresiyeDefteri
{
    public partial class HomePageForm : Form
    {
        #region Constants
        #endregion

        #region Constructors
        public HomePageForm()
        {
            InitializeComponent();
        }
        #endregion

        #region PreparePage
        #endregion

        #region DataGridViewOperations
        #endregion

        #region ButtonClick
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
        #endregion

        #region FormCloseCallBack
        #endregion

        #region MessageBoxes
        #endregion

        #region KeyPress
        #endregion
    }
}