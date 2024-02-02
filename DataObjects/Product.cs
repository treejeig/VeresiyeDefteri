using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.DataObjects
{
    public class Product
    {
        public long ProductId { get; set; }
        public string? StockCode { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public string? ProductDescription { get; set; }
    }
}
