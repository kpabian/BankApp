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

namespace Bank_App1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Loging(username.Text, password.Text);
        }
        private void newAccountButton_Click(object sender, RoutedEventArgs e)
        {
            
            //User user = new User(name.Text, surname.Text, DateTime.Parse(dateOfBirth.Text), int.Parse(phoneNumber.Text), username.Text, password.Text);

            Account win = new Account();
            win.Show();
            this.Close();

            MessageBoxResult result;
            result = MessageBox.Show("Konto utworzone pomyślnie", "", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }
        public void Loging(string username, string password)
        {
            Account win = new Account();
            win.Show();
            this.Close();

            win.name.Text = username;
        }

        public void NewUser(string name, string surname, DateTime dateOfBirth, string mail, int phoneNumber, string login, string password)
        {
            //User user = new User(name, surname, dateOfBirth, phoneNumber, username, password);

            Account win = new Account();
            win.Show();
            this.Close();

        }
    }
}
