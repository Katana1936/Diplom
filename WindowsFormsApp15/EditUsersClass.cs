using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15
{
    internal class EditUsersClass
    {
        public static bool AddUser(string login, string password)
        {
            string query = "INSERT INTO users (Login, Password) VALUES (@Login, @Password)";
            using (MySqlCommand command = new MySqlCommand(query, DB.GetSqlConnection()))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    return true; // Успешно добавлено
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding user: " + ex.Message);
                    return false; // Ошибка при добавлении
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
        }

        // Метод для загрузки данных из таблицы в DataGridView
        public static void LoadUsers(DataGridView dataGridView)
        {
            string query = "SELECT * FROM users";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DB.GetSqlConnection()))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }

        // Метод для удаления записи по ID
        public static bool DeleteUser(int userId)
        {
            string query = "DELETE FROM users WHERE ID = @UserID";
            using (MySqlCommand command = new MySqlCommand(query, DB.GetSqlConnection()))
            {
                command.Parameters.AddWithValue("@UserID", userId);

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
                    Console.WriteLine("Error deleting user: " + ex.Message);
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
