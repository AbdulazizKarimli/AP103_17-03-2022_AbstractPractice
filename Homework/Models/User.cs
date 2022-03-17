using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class User
    {
        private int _age;
        private string _password;

        public string Username { get; set; }
        public int Age 
        {
            get => _age; 
            set 
            {
                if(value > 0)
                    _age = value;
            } 
        }
        public string Password 
        {
            get => _password;
            set 
            {
                
                if(!string.IsNullOrWhiteSpace(value) && value.Length >= 8 && HasUpper(value) && HasDigit(value))
                    _password = value;
            }
        }


        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        private bool HasUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    return true;
            }

            return false;
        }

        private bool HasDigit(string password)
        {
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                    return true;
            }

            return false;
        }
    }
}
