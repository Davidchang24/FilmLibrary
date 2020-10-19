using System;
using System.Collections.Generic;
using DataInterfaces;
using DAL.Dto;
using MySql.Data.MySqlClient;

namespace DAL.Context
{
    public class AccountContext
    {
        public List<IAccountDto> GetAccounts()
        {
            string command = "SELECT * FROM account";
            List<IAccountDto> accounts = new List<IAccountDto>();
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new AccountDto()
                    {
                        accountId = Convert.ToInt32(reader["accountId"]),
                        accountEmail = reader["accountEmail"].ToString(),
                        accountUsername = reader["accountUsername"].ToString(),
                        accountPassword = reader["accountPassword"].ToString(),
                        accountAdmin = reader["accountAdmin"].ToString()
                    });
                }
                return accounts;
            }
        }
    }
}
