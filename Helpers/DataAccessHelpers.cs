using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.Helpers
{
    public class DataAccessHelpers
    {
        public string GetStringFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return reader.GetString(ordinal);
        }
        public long GetLongFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return reader.GetInt64(ordinal);
        }
        public double GetDoubleFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return reader.GetDouble(ordinal);
        }
        public string? GetNullableStringFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return CheckAndGetNullString(reader, ordinal);
        }
        public long? GetNullableLongFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return CheckAndGetNullLong(reader, ordinal);
        }
        public double? GetNullableDoubleFromReader(SQLiteDataReader reader, string ordinalName)
        {
            var ordinal = reader.GetOrdinal(ordinalName);
            return CheckAndGetNullDouble(reader, ordinal);
        }

        public string? CheckAndGetNullString(SQLiteDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }
        public long? CheckAndGetNullLong(SQLiteDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? null : reader.GetInt64(ordinal);
        }
        public double? CheckAndGetNullDouble(SQLiteDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? null : reader.GetDouble(ordinal);
        }
    }
}
