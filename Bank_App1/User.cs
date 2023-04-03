using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bank_App1
{
    public class User
    {
        private int accountNumber { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private int? phoneNumber { get; set; }
        private string mail { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        private decimal funds { get; set; }


    //for registration it's needed to provide at least one form of contact (phone number and/or email)

    //registration with pone number and mail
    //public User(string name, string surname, DateTime dateOfBirth, string mail, int phoneNumber, string login, string password)
    //{
    //    accountNumber = ++accountCounter;
    //    this.name = name;
    //    this.surname = surname;
    //    this.dateOfBirth = dateOfBirth;
    //    this.mail = mail;
    //    this.phoneNumber = phoneNumber;
    //    this.login = login;
    //    this.password = password;
    //}

    ////registration with only phone number
    //public User(string name, string surname, DateTime dateOfBirth, int phoneNumber, string login, string password) => new User(name, surname, dateOfBirth, null, phoneNumber, login, password);

    ////registration with only mail
    //public User(string name, string surname, DateTime dateOfBirth, string mail, string login, string password) => new User(name, surname, dateOfBirth, mail, -1, login, password);





}
}
