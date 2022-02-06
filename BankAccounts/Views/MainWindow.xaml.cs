using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAccounts.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Payment> payments = new List<Payment>();
        public uint accountID { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            using (BankAccountsContext context = new BankAccountsContext())
            {
                payments = context.Payments.ToList();
            }
            accountID = 1;
        }
        private void sendTransactionClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                decimal amount = Convert.ToDecimal(item.ToString().Split(" ")[0]);
                string info = item.ToString().Split(" ")[1];

                //paymentsList.Add(new Payments(accountID,))
            }
        }

        private void addPaymentClick(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal amount = 0;
                if (amountInput.Text != "")
                    amount = Convert.ToDecimal(amountInput.Text);
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
        private void openListWindowClick(object sender, RoutedEventArgs e)
        {
            ListWindow window = new ListWindow();
            window.Show();
        }
    }
}
