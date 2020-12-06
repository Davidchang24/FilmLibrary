using DataFactory;
using DataInterfaces;

namespace Logic
{
    public class Account 
    {
        public int accountId { get; set; }
        public string accountEmail { get; set; }
        public string accountUsername { get; set; }
        public string accountPassword { get; set; }
        public string accountAdmin { get; set; }

        public void Login(string username, string password)
        {

        }

        public void AccountChange(string email, string username, string password)
        {
            accountEmail = email;
            accountUsername = username;
            accountPassword = password;
        }
    }
}
