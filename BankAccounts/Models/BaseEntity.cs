using System;

namespace BankAccounts.Models
{
    public class BaseEntity
    {
        public uint AccountID { get; set; }
        public uint TransactionID { get; set; }
        public DateTime DateTime { get; set; }
    }
}
