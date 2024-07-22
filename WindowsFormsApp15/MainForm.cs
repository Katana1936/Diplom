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

namespace WindowsFormsApp15
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void openGroup_Click(object sender, EventArgs e)
        //{
        //    EditGroupForm editg = new EditGroupForm();
        //    editg.ShowDialog();
        //    this.Hide();
        //}

        private void openParents_Click(object sender, EventArgs e)
        {
            ParentsForm frm = new ParentsForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void openSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm editScheduleForm = new ScheduleForm();     
            editScheduleForm.ShowDialog();
            this.Hide();
        }

        private void openTeachers_Click(object sender, EventArgs e)
        {
            EditTeachersForm edit = new EditTeachersForm();
            edit.ShowDialog();
            this.Close();
        }

        private void openUsers_Click(object sender, EventArgs e)
        {
            EditUsersForm edit = new EditUsersForm();   
            edit.ShowDialog();
                this.Hide();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            EditScheduleForm form = new EditScheduleForm();
            form.ShowDialog();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
