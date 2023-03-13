using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App1
{
    public class User
    {
        private int accountNumber;
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private int phoneNumber;
        private string mail;
        private string login;
        private string password;
        public static int accountCounter = 100000000;


        //for registration it's needed to provide at least one form of contact (phone number and/or email)

        //registration with only phone number
        public User(string name, string surname, DateTime dateOfBirth, int phoneNumber, string login, string password)
        {
            accountNumber = ++accountCounter;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.login = login;
            this.password = password;
        }

        //registration with only mail
        public User(string name, string surname, DateTime dateOfBirth, string mail, string login, string password)
        {
            accountNumber = ++accountCounter;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.mail = mail;
            this.login = login;
            this.password = password;
        }

        //registration with pone number and mail
        public User(string name, string surname, DateTime dateOfBirth, string mail, int phoneNumber, string login, string password)
        {
            accountNumber = ++accountCounter;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            this.login = login;
            this.password = password;
        }



    }
}
