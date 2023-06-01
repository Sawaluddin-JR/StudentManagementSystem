using MySqlConnector;
using StudentManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.View
{
    public partial class ManageTeacherForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private TeacherClass teacherControl = new TeacherClass();
        public ManageTeacherForm()
        {
            InitializeComponent();
        }
        public void showTable()
        {
            DataGridView_teacher.DataSource = teacherControl.selectTeacher(new MySqlCommand("SELECT * FROM teacher"));
            DataGridView_teacher.RowTemplate.Height = 80;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_addTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageTeacherForm_Load(object sender, EventArgs e)
        {
            textBox_nip.MaxLength = 9;
            textBox_address.MaxLength = 45;
            textBox_firstname.MaxLength = 25;
            textBox_lastname.MaxLength = 25;
            textBox_phone.MaxLength = 13;
            comboBox_lastEduc.SelectedIndex = 0;
            showTable();
        }

        private void DataGridView_addTeacher_Click(object sender, EventArgs e)
        {
            textBox_nip.Text = DataGridView_teacher.CurrentRow.Cells[0].Value.ToString();
            textBox_firstname.Text = DataGridView_teacher.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = DataGridView_teacher.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_date.Value = (DateTime)DataGridView_teacher.CurrentRow.Cells[3].Value;

            if (DataGridView_teacher.CurrentRow.Cells[4].Value.ToString() == "Man")
                radioButton_man.Checked = true;

            textBox_phone.Text = DataGridView_teacher.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGridView_teacher.CurrentRow.Cells[6].Value.ToString();  
            comboBox_lastEduc.Text = DataGridView_teacher.CurrentRow.Cells[7].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_teacher.DataSource = teacherControl.searchTeacher(textBox_search.Text);
            DataGridView_teacher.RowTemplate.Height = 80;           
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_nip.Clear();
            textBox_firstname.Clear();
            textBox_lastname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_man.Checked = true;
            dateTimePicker_date.Value = DateTime.Now;
        }
        bool verify()
        {
            if ((textBox_nip.Text == "") || (textBox_lastname.Text == "") || (textBox_firstname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string gender = radioButton_man.Checked ? "Man" : "Woman";

            int born_year = dateTimePicker_date.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) <= 20 || (this_year - born_year) >= 60)
            {
                MessageBox.Show("Age 20 s/d 60 year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                if(val.valName(textBox_firstname.Text) && val.valName(textBox_lastname.Text) && val.valAlamat(textBox_address.Text))
                {
                    try
                    {
                        teacherControl.updateTeacher(textBox_nip.Text, textBox_firstname.Text, textBox_lastname.Text, dateTimePicker_date.Value, gender,
                            textBox_phone.Text, textBox_address.Text, comboBox_lastEduc.Text);
                        showTable();
                        button_clear.PerformClick();
                        MessageBox.Show("Teacher data Update", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_nip.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fieled Update", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    teacherControl.deleteTeacher(textBox_nip.Text);
                    showTable();
                    button_clear.PerformClick();
                    MessageBox.Show("Teacher Deleted succesfully", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_nip.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Teacher not delete", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_nip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
