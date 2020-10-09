using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Logic
{
    class Account
    {
        private string accountEmail { get; set; }
        private string accountUsername { get; set; }
        private string accountPass { get; set; }
        private bool accountAdmin { get; set; }

        public void Login(string username, string password)
        {

        }

        public void AccountChange(string email, string username, string password)
        {
            accountEmail = email;
            accountUsername = username;
            accountPass = password;
        }
    }
}
