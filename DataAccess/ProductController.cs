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
    public class ProductController
    {
        #region Constants
        DataAccessHelpers dataAccessHelper = new DataAccessHelpers();
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"data source =|DataDirectory|\TrySQlite.db");
        ReceiptItemController receiptItemController = new ReceiptItemController();
        #endregion

        #region Public Methods
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            string query = "select * from products where is_payment_type = 0 and is_active_product = 1";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        products.Add(ReadProductFromReader(reader));
                    }
                }
            }
            return products;
        }
        public Product GetProduct(long productId)
        {
            Product product = new Product();
            string query = $"select * from products where product_id = $productId and is_payment_type = 0 and is_active_product = 1";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$productId", productId);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = ReadProductFromReader(reader);
                    }
                }
            }
            return product;
        }
        public bool AddProduct(Product product)
        {
            string query = "insert into products " +
                "(stock_code, product_name, price, product_description, is_payment_type, is_active_product)" +
                "values($stockCode, $productName, $price, $productDescription, $isPaymentType, $isActiveProduct)";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$stockCode", product.StockCode);
            cmd.Parameters.AddWithValue("$productName", product.ProductName);
            cmd.Parameters.AddWithValue("$price", product.Price);
            cmd.Parameters.AddWithValue("$productDescription", product.ProductDescription);
            cmd.Parameters.AddWithValue("$isPaymentType", false);
            cmd.Parameters.AddWithValue("$isActiveProduct", true);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool UpdateProduct(Product product)
        {
            string query = "update products set " +
                "stock_code = $stockCode, product_name = $productName, price = $price, product_description = $productDescription " +
                "where product_id = $productId";

            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$stockCode", product.StockCode);
            cmd.Parameters.AddWithValue("$productName", product.ProductName);
            cmd.Parameters.AddWithValue("$price", product.Price);
            cmd.Parameters.AddWithValue("$productDescription", product.ProductDescription);
            cmd.Parameters.AddWithValue("$productId", product.ProductId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return receiptItemController.FindAndUpdateShouldBeUpdatedReceiptItemsAndPersons();
        }
        public bool DeleteProduct(long productId)
        {
            string query = "update products set is_active_product = 0 where product_id = $productId";
            CheckConnectionState();
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
            cmd.Parameters.AddWithValue("$productId", productId);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Private Methods
        private Product ReadProductFromReader(SQLiteDataReader reader)
        {
            return new Product
            {
                ProductId = dataAccessHelper.GetLongFromReader(reader, "product_id"),
                StockCode = dataAccessHelper.GetNullableStringFromReader(reader, "stock_code"),
                ProductName = dataAccessHelper.GetStringFromReader(reader, "product_name"),
                Price = dataAccessHelper.GetNullableDoubleFromReader(reader, "price"),
                ProductDescription = dataAccessHelper.GetNullableStringFromReader(reader, "product_description")
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
