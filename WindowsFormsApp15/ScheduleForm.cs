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
    public partial class ScheduleForm : MetroForm
    {
        private MySqlConnection connection;
        private EditScheduleClass editScheduleClass;
        public ScheduleForm()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
            editScheduleClass = new EditScheduleClass(connection);
        }
        
        private void EditScheduleForm_Load(object sender, EventArgs e)
        {
            editScheduleClass.DisplaySchedule(dataGridView1, connection);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            editScheduleClass.DisplaySchedule(dataGridView1, connection);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            this.Hide();
        }
    }
}
