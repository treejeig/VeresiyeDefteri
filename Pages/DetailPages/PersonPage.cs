using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using VeresiyeDefteri.DataAccess;
using VeresiyeDefteri.DataObjects;

namespace VeresiyeDefteri
{
    public partial class PersonPageForm : Form
    {
        PersonController personController = new PersonController();
        public PersonPageForm()
        {
            InitializeComponent();

            var person = personController.GetPersons().FirstOrDefault();
            if (person != null)
            {
                PersonNameTextBox.Text = person.Name;
                PersonSurnameTextBox.Text = person.Surname;
                PersonPhoneTextBox.Text = person.Phone.ToString();
                PersonMobilePhoneTextBox.Text = person.MobilePhone.ToString();
                PersonEmailTextBox.Text = person.Email;
                PersonIdentityNumberTextBox.Text = person.IdentityNumber.ToString();
                PersonAddressTextBox.Text = person.Address;
                PersonDescriptionTextBox.Text = person.Description;
                PersonIncomingBalanceTextBox.Text = person.IncomingBalance.ToString();
                PersonOutgoingBalanceTextBox.Text = person.OutgoingBalance.ToString();
            }
        }

        private void SavePersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person {
                Name = PersonNameTextBox.Text,
                Surname = PersonSurnameTextBox.Text,
                Phone = (long)Convert.ToDouble(PersonPhoneTextBox.Text),
                MobilePhone = (long)Convert.ToDouble(PersonMobilePhoneTextBox.Text),
                Email = PersonEmailTextBox.Text,
                IdentityNumber = (long)Convert.ToDouble(PersonIdentityNumberTextBox.Text),
                Address = PersonAddressTextBox.Text,
                Description = PersonDescriptionTextBox.Text,
                IncomingBalance = Convert.ToDouble(PersonIncomingBalanceTextBox.Text),
                OutgoingBalance = Convert.ToDouble(PersonOutgoingBalanceTextBox.Text)
            };
        }

        private void EnableEditPersonButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {

        }
    }
}
