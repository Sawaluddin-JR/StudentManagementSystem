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
    public partial class TeacherForm : Form
    {
        ValidationClass val = new ValidationClass();
        TeacherClass teacherControl = new TeacherClass();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            textBox_nispReg.MaxLength = 9;
            textBox_addressReg.MaxLength = 45;
            textBox_firstnameReg.MaxLength = 25;
            textBox_lastnameReg.MaxLength = 25;
            textBox_phoneReg.MaxLength = 13;
            comboBox_lastEduc.SelectedIndex = 0;
            showTable();
        }
        bool verify()
        {
            if ((textBox_lastnameReg.Text == "") || (textBox_firstnameReg.Text == "") ||
                (textBox_phoneReg.Text == "") || (textBox_addressReg.Text == "") || (comboBox_lastEduc.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void showTable()
        {
            DataGridView_addTeacher.DataSource = teacherControl.selectTeacher(new MySqlCommand("SELECT * FFROM teacher"));
            DataGridView_addTeacher.RowTemplate.Height = 80;          
        }

        private void button_addReg_Click(object sender, EventArgs e)
        {
            string gender = radioButton_man.Checked ? "Man" : "Woman";
            int born_year = dateTimePicker_date.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) <= 21 || (this_year - born_year) >= 60)
            {
                MessageBox.Show("Age 21 s/d 60 year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                if(val.valName(textBox_firstnameReg.Text) && val.valName(textBox_lastnameReg.Text) && val.valAlamat(textBox_addressReg.Text))
                {
                    try
                    {
                        teacherControl.insertTeacher(textBox_nispReg.Text, textBox_firstnameReg.Text, textBox_lastnameReg.Text, dateTimePicker_date.Value,
                            gender, textBox_phoneReg.Text, textBox_addressReg.Text, comboBox_lastEduc.Text);
                        MessageBox.Show("New Teacher Added", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                        textBox_nispReg.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empety field", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clearReg_Click(object sender, EventArgs e)
        {
            textBox_nispReg.Clear();
            textBox_firstnameReg.Clear();
            textBox_lastnameReg.Clear();
            textBox_phoneReg.Clear();
            textBox_addressReg.Clear();
            radioButton_man.Checked = true;
            dateTimePicker_date.Value = DateTime.Now;
        }

        private void textBox_nispReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_firstnameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_lastnameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_phoneReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_addressReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
