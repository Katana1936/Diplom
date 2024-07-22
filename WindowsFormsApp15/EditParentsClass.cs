using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    internal class EditParentsClass
    {
        public static bool AddParent(string lastName, string firstName, string contactInfo)
        {
            string query = "INSERT INTO Parents (Last_name, First_name, Contact_info) VALUES (@LastName, @FirstName, @ContactInfo)";
            using (MySqlCommand command = new MySqlCommand(query, DB.GetSqlConnection()))
            {
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@ContactInfo", contactInfo);

                try
                {
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    return true; // Успешно добавлено
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding parent: " + ex.Message);
                    return false; // Ошибка при добавлении
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
        }

        public static void LoadParents(DataGridView dataGridView)
        {
            string query = "SELECT * FROM Parents";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DB.GetSqlConnection()))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }

        public static bool DeleteParent(int parentId)
        {
            string query = "DELETE FROM Parents WHERE ID = @ParentID";
            using (MySqlCommand command = new MySqlCommand(query, DB.GetSqlConnection()))
            {
                command.Parameters.AddWithValue("@ParentID", parentId);

                try
                {
                    DB.OpenConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return true; // Успешно удалено
                    else
                        return false; // Запись с указанным ID не найдена
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting parent: " + ex.Message);
                    return false; // Ошибка при удалении
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
        }
    }
}
