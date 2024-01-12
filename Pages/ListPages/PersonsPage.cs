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
        DataAccessHelpers dataAccessHelpers = new DataAccessHelpers();
        PersonController personController = new PersonController();
        List<Person> persons = new List<Person>();
        long selectedPersonId = 0;
        public PersonsPageForm()
        {
            InitializeComponent();
            PreparePersonsPage();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            PersonPageForm personPageForm = new PersonPageForm(0);
            personPageForm.ShowDialog();
        }

        private void PreparePersonsPage()
        {
            PreparePersonsDataGridView();

        }

        private void PreparePersonsDataGridView()
        {
            persons = personController.GetPersons();
            var top = persons.FirstOrDefault().TotalBalance;
            // disable autogenerate
            PersonsDataGridView.AutoGenerateColumns = false;
            PersonsDataGridView.ReadOnly = true;
            // set column count
            PersonsDataGridView.ColumnCount = 7;
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
            //set outgoing_balance column
            PersonsDataGridView.Columns[4].Name = "OutgoingBalance";
            PersonsDataGridView.Columns[4].HeaderText = "Verecek";
            PersonsDataGridView.Columns[4].DataPropertyName = "OutgoingBalance";
            //set total_balance column
            PersonsDataGridView.Columns[5].Name = "TotalBalance";
            PersonsDataGridView.Columns[5].HeaderText = "Toplam";
            PersonsDataGridView.Columns[5].DataPropertyName = "TotalBalance";
            //set go_to_person_detail column
            DataGridViewButtonColumn goToPersonDetailButtonColumn = new DataGridViewButtonColumn();
            goToPersonDetailButtonColumn.UseColumnTextForButtonValue = true;
            goToPersonDetailButtonColumn.Name = "GoToPersonDetail";
            goToPersonDetailButtonColumn.HeaderText = "Kişi Detayı";
            goToPersonDetailButtonColumn.Text = "Detaya Git";
            PersonsDataGridView.Columns.Insert(6, goToPersonDetailButtonColumn);
            PersonsDataGridView.Columns.RemoveAt(7);

            PersonsDataGridView.DataSource = persons;
        }

        private void PersonsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PersonsDataGridView.Columns[e.ColumnIndex].Name == "GoToPersonDetail")
            {
                selectedPersonId = (long)PersonsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                PersonPageForm personPageForm = new PersonPageForm(selectedPersonId);
                personPageForm.ShowDialog();
            }
        }
    }
}
