﻿using System;
using System.Collections.Generic;
using DataInterfaces;
using MySql.Data.MySqlClient;

namespace DAL.Context
{
    public class AccountContext : IAccountContext
    {
        public List<AccountDto> GetAccounts()
        {
            string command = "SELECT * FROM account";
            List<AccountDto> accounts = new List<AccountDto>();
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
