using System;
using DataInterfaces;
namespace DAL.Dto
{
    public class AccountDto : IAccountDto
    {
        public int accountId { get; set; }
        public string accountEmail { get; set; }
        public string accountUsername { get; set; }
        public string accountPassword { get; set; }
        public string accountAdmin { get; set; }
    }
}

