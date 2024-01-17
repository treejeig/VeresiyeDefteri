using VeresiyeDefteri.DataAccess;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Pages.ListPages;

namespace VeresiyeDefteri
{
    public partial class HomePageForm : Form
    {
        #region Constants
        HomePageSpecificController homePageSpecificController = new HomePageSpecificController();
        TotalBalanceItem totalBalanceItem = new TotalBalanceItem();
        long personCount = 0;
        long productCount = 0;
        #endregion

        #region Constructors
        public HomePageForm()
        {
            InitializeComponent();
            PrepareHomePage();
        }
        #endregion

        #region PreparePage
        private void PrepareHomePage()
        {
            totalBalanceItem = homePageSpecificController.GetTotalBalance();
            TotalIncomingBalanceTextBox.Text = totalBalanceItem.TotalIncomingBalance.ToString();
            TotalOutgoingBalanceTextBox.Text = totalBalanceItem.TotalOutgoingBalance.ToString();
            TotalBalanceTextBox.Text = totalBalanceItem.TotalBalance.ToString();
            personCount = homePageSpecificController.GetPersonCount();
            GoToPersonsPageButton.Text = $"Kişiler Listesi\n({personCount} Kişi)";
            productCount = homePageSpecificController.GetProductCount();
            GoToProductsPageButton.Text = $"Ürünler Listesi\n({productCount} Ürün)";
        }
        #endregion

        #region DataGridViewOperations
        #endregion

        #region ButtonClick
        private void GoToPersonsPageButton_Click(object sender, EventArgs e)
        {
            PersonsPageForm personsPageForm = new PersonsPageForm();
            personsPageForm.FormClosed += new FormClosedEventHandler(ReturnedToHomePage_FormClosed);
            personsPageForm.ShowDialog();
        }
        private void GoToProductsPageButton_Click(object sender, EventArgs e)
        {
            ProductsPageForm productsPageForm = new ProductsPageForm();
            productsPageForm.FormClosed += new FormClosedEventHandler(ReturnedToHomePage_FormClosed);
            productsPageForm.ShowDialog();
        }
        #endregion

        #region FormCloseCallBack
        public void ReturnedToHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrepareHomePage();
        }
        #endregion

        #region MessageBoxes
        #endregion

        #region KeyPress
        #endregion
    }
}