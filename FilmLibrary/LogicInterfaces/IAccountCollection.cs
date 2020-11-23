using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface IAccountCollection
    {
        void RegisterAccount(IAccount account);
        IReadOnlyList<IAccount> GetAccounts();

    }
}
