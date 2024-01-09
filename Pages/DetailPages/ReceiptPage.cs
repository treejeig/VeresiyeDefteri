using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeresiyeDefteri
{
    public partial class ReceiptPageForm : Form
    {
        public ReceiptPageForm()
        {
            InitializeComponent();
            SelectReceiptPersonComboBox.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 1, PersonNameSurname = "İlker Yıldırım"},
                new ComboItem{ ID = 2, PersonNameSurname = "Haktan Adatepe"},
                new ComboItem{ ID = 3, PersonNameSurname = "Serhat Pınar"},
                new ComboItem{ ID = 4, PersonNameSurname = "Cem Diner"},
            };
        }

        private void SelectReceiptPersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectedItem = (ComboItem)SelectReceiptPersonComboBox.SelectedItem;
            ReceiptPersonNameSurnameTextBox.Text = selectedItem.PersonNameSurname;
        }
    }

    public class ComboItem
    {
        public int ID { get; set; }
        public string PersonNameSurname { get; set; }

        public override string ToString()
        {
            return PersonNameSurname;
        }
    }
}
