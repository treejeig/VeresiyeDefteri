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
    public class ReceiptItemController
    {
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");

        public List<ReceiptItem> GetReceiptItemsByPersonId(long personId)
        {
            var receiptItems = new List<ReceiptItem>();
            string query = "select ri.*, p.person_id, pr.* from receipt_items ri " +
                "inner join persons p on ri.person_id = p.person_id " +
                "inner join products pr on ri.product_id = pr.product_id " +
                "where ri.person_id = $personId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$personId", personId);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        receiptItems.Add(ReadReceiptItemFromReader(reader));
                    }
                }
            }
            return receiptItems;
        }

        public ReceiptItem GetReceiptItem(long receiptItemId)
        {
            ReceiptItem receiptItem = new ReceiptItem();
            string query = "select ri.*, p.person_id, pr.* from receipt_items ri " +
                "inner join persons p on ri.person_id = p.person_id " +
                "inner join products pr on ri.product_id = pr.product_id " +
                "where ri.receipt_item_id = $receiptItemId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$receiptItemId", receiptItemId);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        receiptItem = ReadReceiptItemFromReader(reader);
                    }
                }
            }
            return receiptItem;
        }
        public bool AddReceiptItem(ReceiptItem receiptItem)
        {
            string query = "insert into receipt_items " +
                "(person_id, product_id, receipt_date, payment_date, special_price_for_person, product_price_on_receipt_date, product_price_on_payment_date, " +
                "product_discount_price, product_discount_ratio, product_quantity, product_total_price, payment_amount) " +
                "values($personId, $productId, $receiptDate, $paymentDate, $specialPriceForPerson, $productPriceOnReceiptDate, $productPriceOnPaymentDate, " +
                "$productDiscountPrice, $productDiscountRatio, $productQuantity, $productTotalPrice, $paymentAmount)";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$personId", receiptItem.PersonId);
            cmd.Parameters.AddWithValue("$productId", receiptItem.ProductId);
            cmd.Parameters.AddWithValue("$receiptDate", receiptItem.ReceiptDate);
            cmd.Parameters.AddWithValue("$paymentDate", receiptItem.PaymentDate);
            cmd.Parameters.AddWithValue("$specialPriceForPerson", receiptItem.SpecialPriceForPerson);
            cmd.Parameters.AddWithValue("$productPriceOnReceiptDate", receiptItem.ProductPriceOnReceiptDate);
            cmd.Parameters.AddWithValue("$productPriceOnPaymentDate", receiptItem.ProductPriceOnPaymentDate);
            cmd.Parameters.AddWithValue("$productDiscountPrice", receiptItem.ProductDiscountPrice);
            cmd.Parameters.AddWithValue("$productDiscountRatio", receiptItem.ProductDiscountRatio);
            cmd.Parameters.AddWithValue("$productQuantity", receiptItem.ProductQuantity);
            cmd.Parameters.AddWithValue("$productTotalPrice", receiptItem.ProductTotalPrice);
            cmd.Parameters.AddWithValue("$paymentAmount", receiptItem.PaymentAmount);

            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool DeleteReceiptItem(long receiptItemId)
        {
            string query = "delete from receipt_items where receipt_item_id = $receiptItemId";
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$receiptItemId", receiptItemId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool UpdateReceiptItem(ReceiptItem receiptItem)
        {
            string query = "update receipt_items set " +
                "person_id = $personId, product_id = $productId, receipt_date = $receiptDate, payment_date = $paymentDate, special_price_for_person = $specialPriceForPerson, " +
                "product_price_on_receipt_date = $productPriceOnReceiptDate, product_price_on_payment_date = $productPriceOnPaymentDate, " +
                "product_discount_price = $productDiscountPrice, product_discount_ratio = $productDiscountRatio, " +
                "product_quantity = $productQuantity, product_total_price = $productTotalPrice, payment_amount = $paymentAmount " +
                "where receipt_item_id = $receiptItemId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$personId", receiptItem.PersonId);
            cmd.Parameters.AddWithValue("$productId", receiptItem.ProductId);
            cmd.Parameters.AddWithValue("$receiptDate", receiptItem.ReceiptDate);
            cmd.Parameters.AddWithValue("$paymentDate", receiptItem.PaymentDate);
            cmd.Parameters.AddWithValue("$specialPriceForPerson", receiptItem.SpecialPriceForPerson);
            cmd.Parameters.AddWithValue("$productPriceOnReceiptDate", receiptItem.ProductPriceOnReceiptDate);
            cmd.Parameters.AddWithValue("$productPriceOnPaymentDate", receiptItem.ProductPriceOnPaymentDate);
            cmd.Parameters.AddWithValue("$productDiscountPrice", receiptItem.ProductDiscountPrice);
            cmd.Parameters.AddWithValue("$productDiscountRatio", receiptItem.ProductDiscountRatio);
            cmd.Parameters.AddWithValue("$productQuantity", receiptItem.ProductQuantity);
            cmd.Parameters.AddWithValue("$productTotalPrice", receiptItem.ProductTotalPrice);
            cmd.Parameters.AddWithValue("$paymentAmount", receiptItem.PaymentAmount);
            cmd.Parameters.AddWithValue("$receiptItemId", receiptItem.ReceiptItemId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        private ReceiptItem ReadReceiptItemFromReader(SQLiteDataReader reader)
        {
            return new ReceiptItem
            {
                ReceiptItemId = dataAccessHelper.GetLongFromReader(reader, "receipt_item_id"),
                PersonId = dataAccessHelper.GetLongFromReader(reader, "person_id"),
                ProductId = dataAccessHelper.GetLongFromReader(reader, "product_id"),
                ProductStockCode = dataAccessHelper.GetNullableStringFromReader(reader, "stock_code"),
                ProductName = dataAccessHelper.GetNullableStringFromReader(reader, "product_name"),
                ProductPrice = dataAccessHelper.GetNullableDoubleFromReader(reader, "price"),
                SpecialPriceForPerson = dataAccessHelper.GetNullableDoubleFromReader(reader, "special_price_for_person"),
                ReceiptDate = dataAccessHelper.GetNullableDateTimeFromReader(reader, "receipt_date"),
                PaymentDate = dataAccessHelper.GetNullableDateTimeFromReader(reader, "payment_date"),
                ProductPriceOnReceiptDate = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_price_on_receipt_date"),
                ProductPriceOnPaymentDate = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_price_on_payment_date"),
                ProductDiscountPrice = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_discount_price"),
                ProductDiscountRatio = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_discount_ratio"),
                ProductQuantity = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_quantity"),
                ProductTotalPrice = dataAccessHelper.GetNullableDoubleFromReader(reader, "product_total_price"),
                PaymentAmount = dataAccessHelper.GetNullableDoubleFromReader(reader, "payment_amount")
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
