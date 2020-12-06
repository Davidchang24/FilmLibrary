using DataInterfaces;
using DataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class AccountCollection 
    {
        private List<Account> _accounts;

        public void RegisterAccount(Account account)
        {

        }
        public IReadOnlyList<Account> GetAccounts()
        {
            return _accounts;
        }
    }
}
