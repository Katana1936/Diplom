using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp15
{
    public partial class Group : MetroForm
    {
        private MySqlConnection connection;
        public Group()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
            
        }
        private void LoadChildrenByGroup()
        {
            string selectedGroup = metroComboBox1.SelectedItem.ToString(); 

            try
            {
                connection.Open();
                string query = "SELECT * FROM Children WHERE `Group` = @Group"; 
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Group", selectedGroup);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt; 
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
            }
            finally
            {
                connection.Close();
            }
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChildrenByGroup();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            this.Hide();
        }
    }
}
