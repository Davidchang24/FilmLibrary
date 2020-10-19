using System;
namespace DataInterfaces
{
    public interface IAccountDto
    {
        int accountId { get; set; }
        string accountEmail { get; set; }
        string accountUsername { get; set; }
        string accountPassword { get; set; }
        string accountAdmin { get; set; }


    }
}
