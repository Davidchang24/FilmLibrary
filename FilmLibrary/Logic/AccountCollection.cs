using DataInterfaces;
using DataFactory;
using LogicInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class AccountCollection : IAccountCollection
    {
        private IAccountContext db;
        private List<IAccount> accounts;

        public void RegisterAccount(IAccount account)
        {

        }
        public List<IAccount> GetAccounts()
        {
            return accounts;
        }
    }
}
