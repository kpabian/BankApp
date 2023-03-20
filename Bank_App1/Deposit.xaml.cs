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

namespace Bank_App1
{
    /// <summary>
    /// Logika interakcji dla klasy Deposit.xaml
    /// </summary>
    public partial class Deposit : Window
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            int time = int.Parse(DepositTime.Text);
            int amount = int.Parse(DepositAmount.Text);

            MessageBoxResult result;
            result = MessageBox.Show($"Po akcptacji zostanie utworzona lokata na {DepositTime.Text} miesięcy, o wartości {DepositAmount.Text}. Po tym okresie otrzymasz {DepositCalculator(time, amount)} na konto. Czy akceptujesz?", "", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private double DepositCalculator(int time, int amount)
        {

            return Math.Round(time / 12.0 * (amount * 1.05), 2);
        }
    }
}
