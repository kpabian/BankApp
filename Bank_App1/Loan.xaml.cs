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
    /// Logika interakcji dla klasy Loan.xaml
    /// </summary>
    public partial class Loan : Window
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void LoanButton_Click(object sender, RoutedEventArgs e)
        {
            int time = int.Parse(LoanTime.Text);
            int amount = int.Parse(LoanAmount.Text);

            MessageBoxResult result;
            result = MessageBox.Show($"Po akcptacji zostanie utworzony kredyt na {LoanTime.Text} miesięcy, o wartości {LoanAmount.Text}. Po tym okresie musisz zwrócić {LoanCalculator(time, amount)}. Czy akceptujesz?", "", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private double LoanCalculator(int time, int amount)
        {

            return Math.Round(time / 12.0 * (amount * 1.1), 2);
        }
    }
}
