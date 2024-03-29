﻿using System;
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

namespace Bank_App1
{
    /// <summary>
    /// Logika interakcji dla klasy Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void transferButton_Click(object sender, RoutedEventArgs e)
        {
            Transfer win = new Transfer();
            win.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            Deposit win = new Deposit();
            win.Show();
            this.Close();
        }

        private void loanButton_Click(object sender, RoutedEventArgs e)
        {
            Loan win = new Loan();
            win.Show();
            this.Close();
        }
    }
}
