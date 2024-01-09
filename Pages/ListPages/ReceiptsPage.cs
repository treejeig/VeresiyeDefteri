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
    public partial class ReceiptsPageForm : Form
    {
        public ReceiptsPageForm()
        {
            InitializeComponent();
        }

        private void AddReceiptButton_Click(object sender, EventArgs e)
        {
            ReceiptPageForm receiptPageForm = new ReceiptPageForm();
            receiptPageForm.ShowDialog();
        }
    }
}
