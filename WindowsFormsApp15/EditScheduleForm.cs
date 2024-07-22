using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15
{
    public partial class EditScheduleForm : MetroForm
    {
        private MySqlConnection connection;
        private EditScheduleClass editScheduleClass;
        public EditScheduleForm()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
            editScheduleClass = new EditScheduleClass(connection);
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання даних з текстових полів
                string date = dateTextBox.Text;
                TimeSpan startTime = TimeSpan.Parse(Start_timeTextBox.Text);
                TimeSpan endTime = TimeSpan.Parse(End_timeTextBox.Text);
                int teacherID = int.Parse(Teacher_IDTextBox.Text);
                string group = GroupTextBox.Text;
                string activity = activityTextBox.Text;

                // Виклик методу для додавання запису з переданими даними
                editScheduleClass.AddSchedule(date, startTime, endTime, teacherID, group, activity);

                // Оновлення DataGridView для відображення нових даних
                editScheduleClass.DisplaySchedule(dataGridView1, connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час додавання запису: " + ex.Message);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            editScheduleClass.DisplaySchedule(dataGridView1);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text); // Передбачаю, що у вас є текстове поле для введення ID
            editScheduleClass.DeleteSchedule(id);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text);
            string date = dateTextBox.Text;
            TimeSpan startTime = TimeSpan.Parse(Start_timeTextBox.Text);
            TimeSpan endTime = TimeSpan.Parse(End_timeTextBox.Text);
            int teacherID = int.Parse(Teacher_IDTextBox.Text);
            string group = GroupTextBox.Text;
            string activity = activityTextBox.Text;

            editScheduleClass.UpdateSchedule(id, date, startTime, endTime, teacherID, group, activity);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
