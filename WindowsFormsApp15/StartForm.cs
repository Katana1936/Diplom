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

namespace WindowsFormsApp15
{
    public partial class StartForm : MetroForm
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EditUsersForm form = new EditUsersForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUsersForm form = new EditUsersForm();
            form.ShowDialog();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (CheckUserCredentials(login, password))
            {
                // Если логин и пароль совпадают с записью в таблице, открываем другую форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
            
        }
        private bool CheckUserCredentials(string login, string password)
        {
            bool isValid = false;
            MySqlConnection connection = null;

            try
            {
                connection = DB.GetSqlConnection();
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE Login = @Login AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                isValid = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке логина и пароля: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return isValid;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
