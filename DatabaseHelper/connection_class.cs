using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TicketTracker.DatabaseHelper
{
    class connection_class
    {
        public MySqlConnection connectdb;

        public connection_class()
        {
            var dbHost = "localhost";
            string dbUsername = "root";
            string dbPassword = "david";
            string dbPort = "3306";
            string dbCatalog = "tickets";
            string connectionString = "datasource=" + dbHost + ";port=" + dbPort + ";Initial Catalog=" + dbCatalog + ";username=" + dbUsername + ";password=" + dbPassword;

            connectdb = new MySqlConnection(connectionString);




        }
    }
}
