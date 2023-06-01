using Guna.UI2.WinForms.Suite;
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
    public partial class ManageForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private CourseClass courseControl = new CourseClass();
        public ManageForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_code.Clear();
            textBox_competencyname.Clear();
            textBox_expertiseProg.Clear();
        }
        private void showData()
        {
            DataGridView_manageCourse.DataSource = courseControl.getCompetency(new MySqlConnector.MySqlCommand("SELECT * FROM competency"));
        }
        private void ManageForm_Load(object sender, EventArgs e)
        {
            textBox_code.MaxLength = 2;
            textBox_competencyname.MaxLength = 50;
            textBox_expertiseProg.MaxLength = 50;
            showData();
        }
        bool verify()
        {
            if ((textBox_code.Text == "") || (textBox_competencyname.Text == "") || (textBox_expertiseProg.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (verify() && val.valName(textBox_competencyname.Text) && val.valName(textBox_expertiseProg.Text))
            {
                try
                {
                    courseControl.updateCompetency(textBox_code.Text,textBox_competencyname.Text, textBox_expertiseProg.Text);
                    MessageBox.Show("Competency Update succesfully", "Update Competency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Competency not edit", "Update Competency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DataGridView_manageCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    courseControl.deleteCompetency(textBox_code.Text);
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Competency Deleted succesfully", "Delete Competency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_code.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Competency not delete", "Delete Competency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridView_manageCourse_Click(object sender, EventArgs e)
        {
            textBox_code.Text = DataGridView_manageCourse.CurrentRow.Cells[0].Value.ToString();
            textBox_competencyname.Text = DataGridView_manageCourse.CurrentRow.Cells[1].Value.ToString();
            textBox_expertiseProg.Text = DataGridView_manageCourse.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_manageCourse.DataSource = courseControl.searchCompetency(textBox_search.Text);
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_competencyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_expertiseProg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
