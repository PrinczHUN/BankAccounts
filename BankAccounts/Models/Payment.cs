using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccounts.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Information { get; set; }
    }
}
