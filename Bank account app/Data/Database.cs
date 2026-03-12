using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bank_account_app.Data
{
    public static class Database
    {
        public static string connectionString="server=localhost;user=root;password=sadmanuddin1323;database=bankapp;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
