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
    public partial class PersonsPageForm : Form
    {
        public PersonsPageForm()
        {
            InitializeComponent();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            PersonPageForm personPageForm = new PersonPageForm();
            personPageForm.ShowDialog();
        }
    }
}
