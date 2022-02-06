using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccounts.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Information { get; set; }
    }
}
