using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BankAccounts.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Payment> payments = new List<Payment>();
        BankAccountsContext context = new BankAccountsContext();

        public int accountID { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            payments = context.Payments.ToList();
        }
        private void sendTransactionClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                decimal amount = Convert.ToDecimal(item.ToString().Split(" ")[0]);
                string info = String.Join(" ",item.ToString().Split(" ").Skip(1));
                context.Payments.Add(new Payment(payments.Last().TransactionId + 1, accountID, DateTime.Now, amount, info));
            }
            context.SaveChanges();
            listBox.Items.Clear();
        }

        private void addPaymentClick(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal amount = 0;
                if (amountInput.Text != "")
                    amount = Convert.ToDecimal(Convert.ToDecimal(amountInput.Text).ToString("N2"));
                else throw new Exception();
                string info = "";
                if (infoInput.Text.Length < 51 && infoInput.Text != "")
                    info = infoInput.Text;
                else throw new Exception();
                listBox.Items.Add(amount + " " + info);
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void accountClick(object sender, RoutedEventArgs e)
        {
            string btnText = ((Button)sender).Content.ToString();
            accountID = Convert.ToInt32(btnText.Split(" ").Last());
            MessageBox.Show($"Logged into Account: {accountID}");
        }
        private void openListWindowClick(object sender, RoutedEventArgs e)
        {
            ListWindow window = new ListWindow(accountID);
            window.Show();
        }
    }
}
