using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    public class Payments : BaseEntity
    {
        public uint PaymentID { get; set; }
        public decimal Amount { get; set; }
        public string Info { get; set; }
    }
}
