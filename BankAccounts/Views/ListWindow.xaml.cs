using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data;
using BankAccounts.Models;
using System.Windows.Controls;
using System.IO;
using System;

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

        private void printListClick(object sender, RoutedEventArgs e)
        {
            try
            {
                IsEnabled = false;
                PrintDialog printD = new PrintDialog();
                if (printD.ShowDialog() == true)
                {
                    printD.PrintVisual(dataGrid, "Data");
                }
            }
            finally
            {
                IsEnabled = true;
            }
        }

        private void listClick(object sender, RoutedEventArgs e)
        {
            string btnText = ((Button)sender).Content.ToString();
            var start = dateStartPicker.SelectedDate;
            var end = dateEndPicker.SelectedDate;
            if(start != null && end != null)
            {
                if(btnText.Split(" ").Last() == "Transactions")
                    dataGrid.ItemsSource = transactions.Where(x => x.DateTime < end && x.DateTime > start);
                else
                    dataGrid.ItemsSource = payments.Where(x => x.DateTime < end && x.DateTime > start);
            }
            else
            {
                if (btnText.Split(" ").Last() == "Transactions")
                    dataGrid.ItemsSource = transactions;
                else
                    dataGrid.ItemsSource = payments;
            }
        }
    }
}
