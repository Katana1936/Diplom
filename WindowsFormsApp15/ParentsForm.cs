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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15
{
    public partial class ParentsForm : MetroForm
    {
        public ParentsForm()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string contactInfo = ContactInfoTextBox.Text;

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(contactInfo))
            {
                bool success = EditParentsClass.AddParent(lastName, firstName, contactInfo);
                if (success)
                {
                    MessageBox.Show("Родитель успешно добавлен.");
                    // Очистка текстовых полей после успешного добавления
                    LastNameTextBox.Clear();
                    FirstNameTextBox.Clear();
                    ContactInfoTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении родителя.");
                }
            }
            else
            {
                MessageBox.Show("Введите фамилию, имя и контактную информацию родителя.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTextBox.Text) && int.TryParse(IDTextBox.Text, out int parentId))
            {
                bool success = EditParentsClass.DeleteParent(parentId);
                if (success)
                {
                    MessageBox.Show("Родитель успешно удален.");
                    // После успешного удаления обновите данные в DataGridView, чтобы отобразить изменения
                    EditParentsClass.LoadParents(dataGridView1);
                    IDTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении родителя.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID родителя для удаления.");
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            EditParentsClass.LoadParents(dataGridView1);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
