using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VeresiyeDefteri.DataAccess
{
    public class LoginController
    {
        #region Constants
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");
        #endregion

        #region Public Methods
        public long GetUserCount()
        {
            long count = 0;
            string query = $"select count(1) as count from users";
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = dataAccessHelper.GetLongFromReader(reader, "count");
                    }
                }
            }
            return count;
        }
        public bool CanLogin(string username, string password)
        {
            if(username == null || password == null)
            {
                return false;
            }
            string query = $"select * from users where username = $userName and password = $userPassword";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$userName", username);
            cmd.Parameters.AddWithValue("$userPassword", password);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AddUser(string username, string password)
        {
            string query = "insert into users " +
                "values($username, $password)";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$username", username);
            cmd.Parameters.AddWithValue("$password", password);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Private Methods
        private void CheckConnectionState()
        {
            if (sqliteConnection.State != ConnectionState.Open)
            {
                sqliteConnection.Open();
            }
        }
        #endregion
    }
}
