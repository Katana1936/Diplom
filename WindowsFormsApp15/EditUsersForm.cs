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
    public partial class EditUsersForm : MetroForm
    {
        private MySqlConnection connection;

        public EditUsersForm()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {

        }
        private EditUsersClass editUsersClass = new EditUsersClass();
       
        

        private void EditUsersForm_Load(object sender, EventArgs e)
        {
            EditUsersClass.LoadUsers(dataGridView1);
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                bool success = EditUsersClass.AddUser(login, password);
                if (success)
                {
                    MessageBox.Show("Пользователь успешно добавлен.");
                    // Очистка текстовых полей после успешного добавления
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении пользователя.");
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль.");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            EditUsersClass.LoadUsers(dataGridView1);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTextBox.Text) && int.TryParse(IDTextBox.Text, out int userId))
            {
                bool success = EditUsersClass.DeleteUser(userId);
                if (success)
                {
                    MessageBox.Show("Пользователь успешно удален.");
                    // После успешного удаления обновите данные в DataGridView, чтобы отобразить изменения
                    EditUsersClass.LoadUsers(dataGridView1);
                    IDTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении пользователя.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID пользователя для удаления.");
            }
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
