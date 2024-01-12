using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeDefteri.DataObjects
{
    public class Person
    {
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long? Phone { get; set; }
        public long? MobilePhone { get; set; }
        public string? Email { get; set; }
        public long? IdentityNumber { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public double? IncomingBalance { get; set; }
        public double? OutgoingBalance { get; set; }
        public double? TotalBalance => (double)Math.Round((decimal)((IncomingBalance ?? 0) - (OutgoingBalance ?? 0)), 2);

        public string ToString() => Name + ' ' + Surname;

    }
}
