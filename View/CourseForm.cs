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
    public partial class CourseForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private CourseClass courseControl = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void textBox_nisn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        bool verify()
        {
            if ((textBox_competencyName.Text == "") || (textBox_expertiseProg.Text == "") || (textBox_code.Text.Equals("")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {          
            if (verify() && val.valName(textBox_competencyName.Text) && val.valName(textBox_expertiseProg.Text))
            {
                try
                {
                    courseControl.insertCompetency(textBox_code.Text, textBox_competencyName.Text, textBox_expertiseProg.Text);
                    MessageBox.Show("New Competency Added", "Add Competency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    textBox_competencyName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empety field", "Add Competency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showData()
        {
            DataGridView_course.DataSource = courseControl.getCompetency(new MySqlConnector.MySqlCommand("SELECT * FROM competency"));
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            textBox_code.MaxLength = 2;
            textBox_competencyName.MaxLength = 50;
            textBox_expertiseProg.MaxLength = 50;
            showData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_code.Clear();
            textBox_competencyName.Clear();
            textBox_expertiseProg.Clear();
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_competencyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_expertiseProg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
