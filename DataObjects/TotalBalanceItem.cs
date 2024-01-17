using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.DataObjects
{
    public class TotalBalanceItem
    {
        public double? TotalIncomingBalance { get; set; }
        public double? TotalOutgoingBalance { get; set; }
        public double? TotalBalance => (double)Math.Round((decimal)((TotalIncomingBalance ?? 0) - (TotalOutgoingBalance ?? 0)), 2);
    }
}
