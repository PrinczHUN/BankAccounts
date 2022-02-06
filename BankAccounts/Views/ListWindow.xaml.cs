using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
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
        public ListWindow()
        {
            InitializeComponent();
            using (BankAccountsContext context = new BankAccountsContext())
            {
                payments = context.Payments.ToList();
                transactions = context.Transactions.ToList();
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
