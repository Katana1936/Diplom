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
    public partial class Teachers : MetroForm
    {
        private MySqlConnection connection;
        private EditTeachersClass editTeachersClass;
        public Teachers()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
            editTeachersClass = new EditTeachersClass(connection);
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = editTeachersClass.LoadTeachers();
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            this.Hide();
        }
    }
}
