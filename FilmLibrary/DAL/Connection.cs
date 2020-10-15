using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "datasource=localhost;port=8080;database=Filmlibrary;username=root;password=;";
            return new MySqlConnection(connectionString);
        }
    }
}
