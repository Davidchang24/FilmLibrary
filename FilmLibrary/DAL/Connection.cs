using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=studmysql01.fhict.local;Uid=dbi434633;Database=dbi434633;Pwd=Test123;";
            return new MySqlConnection(connectionString);
        }
    }
}
