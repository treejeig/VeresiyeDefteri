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
            string query = $"select * from persons where person_id = $personId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$personId", personId);
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
            string query = "insert into persons " +
                "(name, surname, phone, mobile_phone, email, identity_number, address, description, incoming_balance, outgoing_balance)" +
                "values($name, $surname, $phone, $mobilePhone, $email, $identityNumber, $address, $description, $incomingBalance, $outgoingBalance)";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$name", person.Name);
            cmd.Parameters.AddWithValue("$surname", person.Surname);
            cmd.Parameters.AddWithValue("$phone", person.Phone);
            cmd.Parameters.AddWithValue("$mobilePhone", person.MobilePhone);
            cmd.Parameters.AddWithValue("$email", person.Email);
            cmd.Parameters.AddWithValue("$identityNumber", person.IdentityNumber);
            cmd.Parameters.AddWithValue("$address", person.Address);
            cmd.Parameters.AddWithValue("$description", person.Description);
            cmd.Parameters.AddWithValue("$incomingBalance", person.IncomingBalance ?? 0);
            cmd.Parameters.AddWithValue("$outgoingBalance", person.OutgoingBalance ?? 0);
            int result = cmd.ExecuteNonQuery();
            if(result == 0)
            {
                return false;
            }
            return true;
        }

        public bool DeletePerson(long personId)
        {
            string query = "delete from persons where person_id = $personId";
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$personId", personId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePerson(Person person)
        {
            string query = "update persons set " +
                "name = $name, surname = $surname, phone = $phone, mobile_phone = $mobilePhone, email = $email, identity_number = $identityNumber, " +
                "address = $address, description = $description, incoming_balance = $incomingBalance, outgoing_balance = $outgoingBalance " +
                "where person_id = $personId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$name", person.Name);
            cmd.Parameters.AddWithValue("$surname", person.Surname);
            cmd.Parameters.AddWithValue("$phone", person.Phone);
            cmd.Parameters.AddWithValue("$mobilePhone", person.MobilePhone);
            cmd.Parameters.AddWithValue("$email", person.Email);
            cmd.Parameters.AddWithValue("$identityNumber", person.IdentityNumber);
            cmd.Parameters.AddWithValue("$address", person.Address);
            cmd.Parameters.AddWithValue("$description", person.Description);
            cmd.Parameters.AddWithValue("$incomingBalance", person.IncomingBalance);
            cmd.Parameters.AddWithValue("$outgoingBalance", person.OutgoingBalance);
            cmd.Parameters.AddWithValue("$personId", person.PersonId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public Person ReadPersonFromReader(SQLiteDataReader reader)
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
