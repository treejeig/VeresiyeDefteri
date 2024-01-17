using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.DataObjects
{
    public class ReceiptItem
    {
        public long ReceiptItemId { get; set; }
        public long PersonId { get; set; }
        public long ProductId { get; set; }
        public string? ProductStockCode { get; set; }
        public string? ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? SpecialPriceForPerson { get; set; }
        public double? ProductPriceOnReceiptDate { get; set; }
        public double? ProductPriceOnPaymentDate { get; set; }
        public double? ProductDiscountPrice { get; set; }
        public double? ProductDiscountRatio { get; set; }
        public double? ProductQuantity { get; set; }
        public double? ProductTotalPrice { get; set; }
        public double? PaymentAmount { get; set; }
    }
}
