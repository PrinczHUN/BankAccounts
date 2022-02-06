using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BankAccounts.Models
{
    public partial class BankAccountsContext : DbContext
    {
        public BankAccountsContext()
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BankAccounts;Trusted_Connection=True;");
            }
        }
    }
}
