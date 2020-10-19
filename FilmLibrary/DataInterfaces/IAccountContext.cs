using System.Collections.Generic;

namespace DataInterfaces

{
    public interface IAccountContext
    {
        List<IAccountDto> GetAccounts();
    }
}
