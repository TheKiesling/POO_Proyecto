using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_POO.SQL
{
    class Connection
    {
        MySqlConnection connection = new MySqlConnection();

        private static string server = "localhost";
        private static string database = "sgh";
        private static string user = "root";
        private static string password = "";

        private string connect = "server=" + server + ";" + "user=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";
    }
}
