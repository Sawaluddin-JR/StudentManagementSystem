using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using StudentManagementSystem.Controller;
using MySqlConnector;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;
using Guna.UI2.WinForms;
using StudentManagementSystem.Model;

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        private Connection conn = new Connection();
        private ValidationClass val = new ValidationClass();
        private StudentClass studentControl = new StudentClass();
        private CourseClass competencyControl = new CourseClass();
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load_1(object sender, EventArgs e)
        {
            textBox_nisnReg.MaxLength = 10;
            textBox_addressReg.MaxLength = 35;
            textBox_firstnameReg.MaxLength = 20;
            textBox_lastnameReg.MaxLength = 20;
            textBox_phoneReg.MaxLength = 13;
            idcodeCompt();
            showStudent();
        }
        bool verify()
        {
            if ((textBox_lastnameReg.Text == "") || (textBox_firstnameReg.Text == "") ||
                (textBox_phoneReg.Text == "") || (textBox_addressReg.Text == "") || (pictureBox_studentreg.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void idcodeCompt()
        {
            DataTable data = new DataTable();
            string idcodeCompt = "SELECT CodeCompetency FROM competency";
            conn.cmd = new MySqlCommand(idcodeCompt, conn.GetConn());
            conn.dr = conn.cmd.ExecuteReader();
            data.Columns.Add("CodeCompetency", typeof(string));
            data.Load(conn.dr);
            comboBox_codeCompt.ValueMember = "CodeCompetency";
            comboBox_codeCompt.DataSource = data;
        }
        bool showStudent()
        {
            DataGridView_studentreg.DataSource = studentControl.selectStudent(new MySqlCommand("SELECT * FROM student"));
            DataGridView_studentreg.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_studentreg.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }
        bool showCompetency()
        {
            DataGridView_studentreg.DataSource = competencyControl.selectCompetency(new MySqlCommand("SELECT * FROM competency"));
            DataGridView_studentreg.RowTemplate.Height = 80;

            return true;
        }
        private void button_addReg_Click(object sender, EventArgs e)
        {
            string gender = radioButton_male.Checked ? "Male" : "Female";

            int born_year = dateTimePicker_date.Value.Year;
            int this_year = DateTime.Now.Year;           
            if ((this_year - born_year) <= 15 || (this_year - born_year) >= 21)
            {
                MessageBox.Show("Age 15 s/d 21 year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                if (val.valName(textBox_firstnameReg.Text) && val.valName(textBox_lastnameReg.Text) && val.valAlamat(textBox_addressReg.Text)) 
                {
                    try
                    {

                        MemoryStream memori = new MemoryStream();
                        pictureBox_studentreg.Image.Save(memori, pictureBox_studentreg.Image.RawFormat);
                        byte[] img = memori.ToArray();
                        studentControl.insertStudent(textBox_nisnReg.Text, comboBox_codeCompt.Text, textBox_firstnameReg.Text, textBox_lastnameReg.Text,
                            dateTimePicker_date.Value, gender, textBox_phoneReg.Text, textBox_addressReg.Text, img);
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showStudent();
                        textBox_nisnReg.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empety field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clearReg_Click(object sender, EventArgs e)
        {
            textBox_nisnReg.Clear();
            textBox_firstnameReg.Clear();
            textBox_lastnameReg.Clear();
            textBox_phoneReg.Clear();
            textBox_addressReg.Clear();
            radioButton_maleReg.Checked = true;
            dateTimePicker_date.Value = DateTime.Now;
            pictureBox_studentreg.Image = null;
        }

        private void button_uploadReg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_studentreg.Image = Image.FromFile(opf.FileName);
        }

        private void DataGridView_studentreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void textBox_codeComp_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showCompetency();
        }
        private void button_showStudent_Click(object sender, EventArgs e)
        {
            showStudent();
        }
        private void textBox_nisnReg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_firstnameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char) Keys.Back;
        }

        private void textBox_lastnameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_addressReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_phoneReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_nisnReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
