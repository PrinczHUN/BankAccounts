using BankAccounts.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAccounts.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Payments> paymentsList = new List<Payments>();
        List<string> paymentList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void addPaymentClick(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(amountInput.Text);
                string info = infoInput.Text;
                listBox.Items.Add(amount + " " + info);
            }
            catch
            {
                MessageBox.Show("rossz input");
            }
        }
        private void openListWindowClick(object sender, RoutedEventArgs e)
        {
            ListWindow window = new ListWindow();
            window.Show();
        }
    }
}
