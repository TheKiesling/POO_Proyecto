using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public MySqlConnection Connect()
        {
            try
            {
                connection.ConnectionString = connect;
                connection.Open();
                MessageBox.Show("Conexión exitosa");
            } catch (MySqlException e)
            {
                MessageBox.Show("Error en la conexión de base de datos");
            }
            return connection;
        }
    }
}
