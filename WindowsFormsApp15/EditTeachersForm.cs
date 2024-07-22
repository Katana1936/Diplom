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
    public partial class EditTeachersForm : MetroForm
    {
        private MySqlConnection connection;
        private EditTeachersClass editTeachersClass;
        public EditTeachersForm()
        {
            InitializeComponent();
            connection = DB.GetSqlConnection();
            editTeachersClass = new EditTeachersClass(connection);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string position = PositionTextBox.Text;
            string contactInfo = ContactInfoTextBox.Text;

            editTeachersClass.InsertTeacher(lastName, firstName, position, contactInfo);
            RefreshData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDTextBox.Text, out int id))
            {
                editTeachersClass.DeleteTeacher(id);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Введіть коректний ID для видалення викладача.");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = editTeachersClass.LoadTeachers();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
