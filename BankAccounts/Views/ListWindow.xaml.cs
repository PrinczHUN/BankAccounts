using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data;
using BankAccounts.Models;

namespace BankAccounts.Views
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        List<Payment> payments = new List<Payment>();
        List<Transaction> transactions = new List<Transaction>();
        public ListWindow(int accountID)
        {
            InitializeComponent();
            using (BankAccountsContext context = new BankAccountsContext())
            {
                payments = context.Payments.Where(x => x.AccountId == accountID).ToList();
                transactions = context.Transactions.Where(x => x.AccountId == accountID).ToList();
            }
        }

        private void listTransactionsClick(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = transactions;
        }

        private void listPaymentsClick(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = payments;
        }
    }
}
