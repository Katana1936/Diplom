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
    internal class EditScheduleClass
    {
        private MySqlConnection connection;

        public EditScheduleClass(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public void AddSchedule(string date, TimeSpan startTime, TimeSpan endTime, int teacherID, string group, string activity)
        {
            try
            {
                string query = "INSERT INTO schedule (Date, Start_time, End_time, Teacher_ID, `Group`, activity) VALUES (@Date, @StartTime, @EndTime, @TeacherID, @Group, @Activity)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                cmd.Parameters.AddWithValue("@Group", group);
                cmd.Parameters.AddWithValue("@Activity", activity);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Запис успішно додано до таблиці schedule.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час додавання запису: " + ex.Message);
            }
        }
        public void DeleteSchedule(int id)
        {
            try
            {
                string query = "DELETE FROM schedule WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запис успішно видалено з таблиці schedule.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час видалення запису: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateSchedule(int id, string date, TimeSpan startTime, TimeSpan endTime, int teacherID, string group, string activity)
        {
            try
            {
                string query = "UPDATE schedule SET Date = @Date, Start_time = @StartTime, End_time = @EndTime, Teacher_ID = @TeacherID, `Group` = @Group, activity = @Activity WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                cmd.Parameters.AddWithValue("@Group", group);
                cmd.Parameters.AddWithValue("@Activity", activity);
                cmd.Parameters.AddWithValue("@ID", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запис у таблиці schedule успішно оновлено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час оновлення запису: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DisplaySchedule(DataGridView dataGridView, MySqlConnection connection = null)
        {
            try
            {
                if (connection == null)
                {
                    connection = DB.GetSqlConnection();
                }

                string query = "SELECT * FROM schedule";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
