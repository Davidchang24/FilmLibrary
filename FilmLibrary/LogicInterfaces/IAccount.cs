using System;
namespace LogicInterfaces
{
    public interface IAccount
    {
        int accountId { get; set; }
        string accountEmail { get; set; }
        string accountUsername { get; set; }
        string accountPassword { get; set; }
        string accountAdmin { get; set; }


        void Login(string username, string password);
        void AccountChange(string email, string username, string password);
    }
}

