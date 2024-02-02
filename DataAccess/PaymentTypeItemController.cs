using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeresiyeDefteri.DataObjects;
using VeresiyeDefteri.Helpers;

namespace VeresiyeDefteri.DataAccess
{
    public class PaymentTypeItemController
    {
        #region Constants
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");
        #endregion

        #region Public Methods
        public List<PaymentTypeItem> GetPaymentTypeItems()
        {
            var paymentTypeItems = new List<PaymentTypeItem>();
            string query = "select * from products where is_payment_type = 1 and is_active_product = 1";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        paymentTypeItems.Add(ReadPaymentTypeItemFromReader(reader));
                    }
                }
            }
            return paymentTypeItems;
        }
        public PaymentTypeItem GetPaymentTypeItem(long paymentTypeItemId)
        {
            PaymentTypeItem paymentTypeItem = new PaymentTypeItem();
            string query = $"select * from products where product_id = $paymentTypeItemId and is_payment_type = 1 and is_active_product = 1";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$paymentTypeItemId", paymentTypeItemId);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        paymentTypeItem = ReadPaymentTypeItemFromReader(reader);
                    }
                }
            }
            return paymentTypeItem;
        }
        public bool AddPaymentTypeItem(PaymentTypeItem paymentTypeItem)
        {
            string query = "insert into products " +
                "(product_name, is_payment_type, is_active_product)" +
                "values($paymentTypeItemName, $isPaymentType, $isActiveProduct)";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$paymentTypeItemName", paymentTypeItem.PaymentTypeItemName);
            cmd.Parameters.AddWithValue("$isPaymentType", true);
            cmd.Parameters.AddWithValue("$isActiveProduct", true);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePaymentTypeItem(PaymentTypeItem paymentTypeItem)
        {
            string query = "update products set " +
                "product_name = $paymentTypeItemName " +
                "where product_id = $paymentTypeItemId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$paymentTypeItemName", paymentTypeItem.PaymentTypeItemName);
            cmd.Parameters.AddWithValue("$paymentTypeItemId", paymentTypeItem.PaymentTypeItemId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool DeletePaymentTypeItem(long paymentTypeItemId)
        {
            string query = "update products set is_active_product = 0 where product_id = $paymentTypeItemId";
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$paymentTypeItemId", paymentTypeItemId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Private Methods
        private PaymentTypeItem ReadPaymentTypeItemFromReader(SQLiteDataReader reader)
        {
            return new PaymentTypeItem
            {
                PaymentTypeItemId = dataAccessHelper.GetLongFromReader(reader, "product_id"),
                PaymentTypeItemName = dataAccessHelper.GetStringFromReader(reader, "product_name")
            };
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
