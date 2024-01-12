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
using VeresiyeDefteri.Helpers;

namespace VeresiyeDefteri
{
    public partial class PersonPageForm : Form
    {
        PersonController personController = new PersonController();
        InputHelpers inputHelper = new InputHelpers();
        MessageBoxes messageBoxes = new MessageBoxes();
        Person person = new Person();
        long selectedPersonId = 0;
        string? oldName;
        string? oldSurname;
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
            string messageBoxTitle;
            string messageBoxMessage;
            if(selectedPersonId == 0)
            {
                messageBoxTitle = "Kişi eklensin mi?";
                messageBoxMessage = $"Ad Soyad: {PersonNameTextBox.Text} {PersonSurnameTextBox.Text}";
            }
            else
            {
                messageBoxTitle = "Kişi güncellensin mi?";
                messageBoxMessage = $"Eski Ad Soyad: {oldName} {oldSurname}\nYeni Ad Soyad: {PersonNameTextBox.Text} {PersonSurnameTextBox.Text}";
            }

            if(messageBoxes.YesNoMessageBox(messageBoxTitle, messageBoxMessage))
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
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Yeni Kişi eklendi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Yeni Kişi eklenemedi."));
                    }
                }
                else
                {
                    person.PersonId = selectedPersonId;
                    if (personController.UpdatePerson(person))
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarılı", "Kişi değişiklikleri kaydedildi."));

                    }
                    else
                    {
                        ShowInfoMessageBoxAndClosePage(messageBoxes.InformationMessageBox("Başarısız", "Kişi değişiklikleri kaydedilemedi."));
                    }
                }
            }
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            var yesNoMessageBoxTitle = "Kişi silinsin mi?";
            var yesNomessageBoxMessage = $"Ad Soyad: {oldName} {oldSurname}";

            if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNomessageBoxMessage))
            {
                string infoMessageBoxTitle;
                string infoMessageBoxMessage;
                if (personController.DeletePerson(selectedPersonId))
                {
                    infoMessageBoxTitle = "Başarılı";
                    infoMessageBoxMessage = $"{oldName} {oldSurname} silindi.";
                }
                else
                {
                    infoMessageBoxTitle = "Başarısız";
                    infoMessageBoxMessage = $"{oldName} {oldSurname} silinemedi.";
                    
                }
                messageBoxes.InformationMessageBox(infoMessageBoxTitle, infoMessageBoxMessage);
            }
        }

        private void PreparePersonPage()
        {
            if (selectedPersonId != 0)
            {
                person = personController.GetPerson(selectedPersonId);

            }
            else
            {
                DeletePersonButton.Visible = false;
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
                oldName = person.Name;
                oldSurname = person.Surname;
            }
        }

        private void ShowInfoMessageBoxAndClosePage(bool res)
        {
            if (res)
            {
                Close();
            }
        }
        private void OnlyNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputHelper.AllowOnlyNumbers(sender, e);
        }

        private void OnlyNumberAndOneDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputHelper.AllowOnlyNumbersAndOneDigit(sender, e);
        }
    }
}
