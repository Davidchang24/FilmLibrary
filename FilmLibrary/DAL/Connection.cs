using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "";
            return new MySqlConnection(connectionString);
        }
    }
}
