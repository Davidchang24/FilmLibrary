using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            // string connectionString = "Server=studmysql01.fhict.local;Uid=dbi434633;Database=dbi434633;Pwd=Bobbenktox2;";
            string connectionString1 = "Server=localhost;Uid=root;Database=dbi434633;Pwd=;";
            return new MySqlConnection(connectionString1);
        }
    }
}
