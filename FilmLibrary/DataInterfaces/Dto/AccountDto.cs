using System;
using DataInterfaces;

namespace DataInterfaces
{
    public class AccountDto 
    {
        public int accountId { get; set; }
        public string accountEmail { get; set; }
        public string accountUsername { get; set; }
        public string accountPassword { get; set; }
        public string accountAdmin { get; set; }
    }
}

