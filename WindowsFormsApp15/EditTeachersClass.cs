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
    internal class EditTeachersClass
    {
        private MySqlConnection connection;
        public EditTeachersClass(MySqlConnection conn)
        {
            connection = conn;
        }

        public void InsertTeacher(string lastName, string firstName, string position, string contactInfo)
        {
            try
            {
                string query = "INSERT INTO Teachers (Last_name, First_name, Position, Contact_info) VALUES (@LastName, @FirstName, @Position, @ContactInfo)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Новий викладач успішно доданий.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час додавання викладача: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteTeacher(int id)
        {
            try
            {
                string query = "DELETE FROM Teachers WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Викладач успішно видалений.");
                else
                    MessageBox.Show("Викладача з таким ID не знайдено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час видалення викладача: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable LoadTeachers()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Teachers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Помилка під час завантаження викладачів: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    
}
}
