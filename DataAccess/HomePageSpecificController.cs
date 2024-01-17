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
    public class HomePageSpecificController
    {
        #region Constants
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");
        #endregion

        #region Public Methods
        public TotalBalanceItem GetTotalBalance()
        {
            TotalBalanceItem totalBalanceItem = new TotalBalanceItem();
            string query = $"select sum(incoming_balance) as total_incoming_balance, sum(outgoing_balance) as total_outgoing_balance from persons";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        totalBalanceItem = ReadTotalBalanceFromReader(reader);
                    }
                }
            }
            return totalBalanceItem;
        }
        public long GetPersonCount()
        {
            return GetCount("persons");
        }
        public long GetProductCount()
        {
            return GetCount("products");
        }
        #endregion

        #region Private Methods
        private TotalBalanceItem ReadTotalBalanceFromReader(SQLiteDataReader reader)
        {
            return new TotalBalanceItem
            {
                TotalIncomingBalance = dataAccessHelper.GetNullableDoubleFromReader(reader, "total_incoming_balance"),
                TotalOutgoingBalance = dataAccessHelper.GetNullableDoubleFromReader(reader, "total_outgoing_balance")
            };
        }
        private long GetCount(string tableName)
        {
            long count = 0;
            string query = $"select count(1) as count from {tableName}";
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
