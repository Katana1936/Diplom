using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp15
{
    internal class DB
    {
        

        private const string connectionString = "server=localhost;port=3306;user=root;password=root;database=childcarecenter";
        private static MySqlConnection connection;

        public static MySqlConnection GetSqlConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }

        public static void OpenConnection()
        {
            try
            {
                if (connection != null && connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }
    }
}
