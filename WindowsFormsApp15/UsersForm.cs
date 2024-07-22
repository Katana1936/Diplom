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
    public partial class UsersForm : MetroForm
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ScheduleForm frm = new ScheduleForm();  
            frm.ShowDialog();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Group frm = new Group();
            frm.ShowDialog();
            this.Hide();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Teachers frm = new Teachers();
            frm.ShowDialog();
            this.Hide();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.ShowDialog();
            this.Hide();
        }
    }
}
