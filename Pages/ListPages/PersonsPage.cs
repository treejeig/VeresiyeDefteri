using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeresiyeDefteri.DataAccess;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Helpers;

namespace VeresiyeDefteri.Pages.ListPages
{
    public partial class PersonsPageForm : Form
    {
        PersonController personController = new PersonController();
        MessageBoxes messageBoxes = new MessageBoxes();
        List<Person> persons = new List<Person>();
        long selectedPersonId = 0;
        public PersonsPageForm()
        {
            InitializeComponent();
            PreparePersonsPage();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            PersonPageForm personPageForm = new PersonPageForm();
            personPageForm.FormClosed += new FormClosedEventHandler(PersonPageForm_FormClosed);
            personPageForm.ShowDialog();
        }

        private void PreparePersonsPage()
        {
            PreparePersonsDataGridView();
        }

        private void PreparePersonsDataGridView()
        {
            persons = personController.GetPersons();
            // disable autogenerate, reset dataGridView
            PersonsDataGridView.DataSource = null;
            PersonsDataGridView.AutoGenerateColumns = false;
            // PersonsDataGridView.ReadOnly = true;
            // set column count
            PersonsDataGridView.ColumnCount = 9;
            PersonsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // set id column
            PersonsDataGridView.Columns[0].Name = "PersonId";
            PersonsDataGridView.Columns[0].HeaderText = "PersonId";
            PersonsDataGridView.Columns[0].DataPropertyName = "PersonId";
            PersonsDataGridView.Columns[0].Visible = false;
            // set name column
            PersonsDataGridView.Columns[1].Name = "Name";
            PersonsDataGridView.Columns[1].HeaderText = "Adı";
            PersonsDataGridView.Columns[1].DataPropertyName = "Name";
            //set surname column
            PersonsDataGridView.Columns[2].Name = "Surname";
            PersonsDataGridView.Columns[2].HeaderText = "Soyadı";
            PersonsDataGridView.Columns[2].DataPropertyName = "Surname";
            //set incoming_balance column
            PersonsDataGridView.Columns[3].Name = "IncomingBalance";
            PersonsDataGridView.Columns[3].HeaderText = "Alacak";
            PersonsDataGridView.Columns[3].DataPropertyName = "IncomingBalance";
            PersonsDataGridView.Columns[3].ReadOnly = true;
            //set outgoing_balance column
            PersonsDataGridView.Columns[4].Name = "OutgoingBalance";
            PersonsDataGridView.Columns[4].HeaderText = "Verecek";
            PersonsDataGridView.Columns[4].DataPropertyName = "OutgoingBalance";
            PersonsDataGridView.Columns[4].ReadOnly = true;
            //set total_balance column
            PersonsDataGridView.Columns[5].Name = "TotalBalance";
            PersonsDataGridView.Columns[5].HeaderText = "Toplam";
            PersonsDataGridView.Columns[5].DataPropertyName = "TotalBalance";
            PersonsDataGridView.Columns[5].ReadOnly = true;
            //set go_to_person_detail column
            DataGridViewButtonColumn goToPersonDetailButtonColumn = new DataGridViewButtonColumn();
            goToPersonDetailButtonColumn.UseColumnTextForButtonValue = true;
            goToPersonDetailButtonColumn.Name = "GoToPersonDetail";
            goToPersonDetailButtonColumn.HeaderText = "Kişi Detayı";
            goToPersonDetailButtonColumn.Text = "Detaya Git";
            PersonsDataGridView.Columns.RemoveAt(6);
            PersonsDataGridView.Columns.Insert(6, goToPersonDetailButtonColumn);
            //set save_edited_person column
            DataGridViewButtonColumn saveEditedPersonButtonColumn = new DataGridViewButtonColumn();
            saveEditedPersonButtonColumn.UseColumnTextForButtonValue = true;
            saveEditedPersonButtonColumn.Name = "SaveEditedPerson";
            saveEditedPersonButtonColumn.HeaderText = "Değişiklikleri Kaydet";
            saveEditedPersonButtonColumn.Text = "Kaydet";
            PersonsDataGridView.Columns.RemoveAt(7);
            PersonsDataGridView.Columns.Insert(7, saveEditedPersonButtonColumn);
            //set delete_selected_person column
            DataGridViewButtonColumn deleteSelectedPersonButtonColumn = new DataGridViewButtonColumn();
            deleteSelectedPersonButtonColumn.UseColumnTextForButtonValue = true;
            deleteSelectedPersonButtonColumn.Name = "DeleteSelectedPerson";
            deleteSelectedPersonButtonColumn.HeaderText = "Kişiyi Sil";
            deleteSelectedPersonButtonColumn.Text = "Sil";
            PersonsDataGridView.Columns.RemoveAt(8);
            PersonsDataGridView.Columns.Insert(8, deleteSelectedPersonButtonColumn);

            PersonsDataGridView.DataSource = persons;
        }

        private void PersonsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                selectedPersonId = (long)PersonsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                Person selectedPerson = personController.GetPerson(selectedPersonId);
                string yesNoMessageBoxTitle;
                string yesNoMessageBoxMessage;

                if (PersonsDataGridView.Columns[e.ColumnIndex].Name == "GoToPersonDetail")
                {
                    selectedPersonId = (long)PersonsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    PersonPageForm personPageForm = new PersonPageForm(selectedPersonId);
                    personPageForm.FormClosed += new FormClosedEventHandler(PersonPageForm_FormClosed);
                    personPageForm.ShowDialog();
                }

                if (PersonsDataGridView.Columns[e.ColumnIndex].Name == "SaveEditedPerson")
                {
                    string oldName = selectedPerson.Name;
                    string oldSurname = selectedPerson.Surname;
                    string newName = (string)PersonsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    string newSurname = (string)PersonsDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    yesNoMessageBoxTitle = "Kişi güncellensin mi?";
                    yesNoMessageBoxMessage = $"Eski Ad Soyad: {oldName} {oldSurname}\nYeni Ad Soyad: {newName} {newSurname}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        selectedPerson.Name = newName;
                        selectedPerson.Surname = newSurname;
                        if (personController.UpdatePerson(selectedPerson))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Kişi değişikleri kaydedildi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Kişi değişiklikleri kaydedilemedi."));
                        }
                    }
                }

                if (PersonsDataGridView.Columns[e.ColumnIndex].Name == "DeleteSelectedPerson")
                {
                    yesNoMessageBoxTitle = "Kişi silinsin mi?";
                    yesNoMessageBoxMessage = $"Ad Soyad: {selectedPerson.Name} {selectedPerson.Surname}";
                    if (messageBoxes.YesNoMessageBox(yesNoMessageBoxTitle, yesNoMessageBoxMessage))
                    {
                        if (personController.DeletePerson(selectedPersonId))
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", "Kişi silindi."));
                        }
                        else
                        {
                            ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarısız", "Kişi silinemedi."));
                        }
                    }
                }
            }
        }

        private void PersonPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreparePersonsPage();
        }

        private void ShowInfoMessageBoxAndRefreshPage(bool res)
        {
            if (res)
            {
                PreparePersonsPage();
            }
        }
    }
}
