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
        Person person = new Person();
        long selectedPersonId = 0;
        public PersonPageForm(long personId)
        {
            selectedPersonId = personId;
            InitializeComponent();
            PreparePersonPage();
        }

        public PersonPageForm()
        {
            selectedPersonId = 0;
            InitializeComponent();
            PreparePersonPage();
        }

        private void SavePersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = PersonNameTextBox.Text,
                Surname = PersonSurnameTextBox.Text,
                Phone = string.IsNullOrEmpty(PersonPhoneTextBox.Text) ? null : (long)Convert.ToDouble(PersonPhoneTextBox.Text),
                MobilePhone = string.IsNullOrEmpty(PersonMobilePhoneTextBox.Text) ? null : (long)Convert.ToDouble(PersonMobilePhoneTextBox.Text),
                Email = string.IsNullOrEmpty(PersonEmailTextBox.Text) ? null : PersonEmailTextBox.Text,
                IdentityNumber = string.IsNullOrEmpty(PersonIdentityNumberTextBox.Text) ? null : (long)Convert.ToDouble(PersonIdentityNumberTextBox.Text),
                Address = string.IsNullOrEmpty(PersonAddressTextBox.Text) ? null : PersonAddressTextBox.Text,
                Description = string.IsNullOrEmpty(PersonDescriptionTextBox.Text) ? null : PersonDescriptionTextBox.Text,
                IncomingBalance = string.IsNullOrEmpty(PersonIncomingBalanceTextBox.Text) ? null : Convert.ToDouble(PersonIncomingBalanceTextBox.Text),
                OutgoingBalance = string.IsNullOrEmpty(PersonOutgoingBalanceTextBox.Text) ? null : Convert.ToDouble(PersonOutgoingBalanceTextBox.Text)
            };
            if (selectedPersonId == 0)
            {
                if (personController.AddPerson(person))
                {
                    ShowMessageBoxAndClosePage("Başarılı", "Yeni Kişi eklendi.");

                }
                else
                {
                    ShowMessageBoxAndClosePage("Başarısız", "Yeni Kişi eklenemedi.");
                }
            }
            else
            {
                person.PersonId = selectedPersonId;
                if (personController.UpdatePerson(person))
                {
                    ShowMessageBoxAndClosePage("Başarılı", "Kişi değişikleri kaydedildi.");

                }
                else
                {
                    ShowMessageBoxAndClosePage("Başarısız", "Kişi değişiklikleri kaydedilemedi.");
                }
            }


        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (personController.DeletePerson(selectedPersonId))
            {
                ShowMessageBoxAndClosePage("Başarılı", "Kişi silindi.");

            }
            else
            {
                ShowMessageBoxAndClosePage("Başarısız", "Kişi silinemedi.");
            }
        }

        private void PreparePersonPage()
        {
            if (selectedPersonId != 0)
            {
                person = personController.GetPerson(selectedPersonId);

            }
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
                PersonTotalBalanceTextBox.Text = person.TotalBalance.ToString();
            }
        }

        private void ShowMessageBoxAndClosePage(string title, string message)
        {
            var res = MessageBox.Show(message, title);
            if (res == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
