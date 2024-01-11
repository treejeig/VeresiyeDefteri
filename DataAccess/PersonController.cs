using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Helpers;

namespace VeresiyeDefteri.DataAccess
{
    public class PersonController
    {
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");
        public List<Person> GetPersons()
        {
            var persons = new List<Person>();
            string query = "select * from persons";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        persons.Add(ReadPersonFromReader(reader));
                    }
                }
            }
            return persons;
        }

        public Person GetPerson(long personId)
        {
            Person person = new Person();
            string query = $"select * from persons where person_id = {personId}";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        person = ReadPersonFromReader(reader);
                    }
                }
            }
            return person;
        }

        public bool AddPerson(Person person)
        {
            string query = "" +
                "insert into persons " +
                "(name, surname, phone, mobile_phone, email, identity_number, address, description, incoming_balance, outgoing_balance)" +
                $"values ('{person.Name}', '{person.Surname}', {person.Phone}, {person.MobilePhone}, '{person.Email}', {person.IdentityNumber}, " +
                $"'{person.Address}', '{person.Description}', {person.IncomingBalance}, {person.OutgoingBalance})";
           
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.ExecuteNonQuery();
            return true;
        }

        private Person ReadPersonFromReader(SQLiteDataReader reader)
        {
            return new Person
            {
                PersonId = dataAccessHelper.GetLongFromReader(reader, "person_id"),
                Name = dataAccessHelper.GetStringFromReader(reader, "name"),
                Surname = dataAccessHelper.GetStringFromReader(reader, "surname"),
                Phone = dataAccessHelper.GetNullableLongFromReader(reader, "phone"),
                MobilePhone = dataAccessHelper.GetNullableLongFromReader(reader, "mobile_phone"),
                Email = dataAccessHelper.GetNullableStringFromReader(reader, "email"),
                IdentityNumber = dataAccessHelper.GetNullableLongFromReader(reader, "identity_number"),
                Address = dataAccessHelper.GetNullableStringFromReader(reader, "address"),
                Description = dataAccessHelper.GetNullableStringFromReader(reader, "description"),
                IncomingBalance = dataAccessHelper.GetNullableDoubleFromReader(reader, "incoming_balance"),
                OutgoingBalance = dataAccessHelper.GetNullableDoubleFromReader(reader, "outgoing_balance")
            };
        }

        private void CheckConnectionState()
        {
            if (sqliteConnection.State != ConnectionState.Open)
            {
                sqliteConnection.Open();
            }
        }
    }
}
