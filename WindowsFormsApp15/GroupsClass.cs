using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    internal class GroupsClass
    {
        private SqlConnection connection;

        public GroupsClass(SqlConnection conn)
        {
            connection = conn;
        }

        public DataTable FindGroupsByLastName(string lastName)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Groups WHERE ID IN (SELECT Group_ID FROM Children WHERE Last_name = @LastName)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час виконання запиту: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
