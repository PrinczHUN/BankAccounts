using System;

#nullable disable

namespace BankAccounts.Models
{
    public partial class Payment
    {
        public Payment(int transactionId, int accountId, DateTime dateTime, decimal amount, string information)
        {
            TransactionId = transactionId;
            AccountId = accountId;
            DateTime = dateTime;
            Amount = amount;
            Information = information ?? throw new ArgumentNullException(nameof(information));
        }

        public int PaymentId { get; set; }
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Information { get; set; }
    }
}
