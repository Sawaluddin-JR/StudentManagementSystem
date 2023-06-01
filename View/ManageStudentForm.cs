
using MySqlConnector;
using StudentManagementSystem.Controller;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageStudentForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private Connection conn = new Connection();
        private StudentClass studentControl = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        private void textBox_firstname_TextChanged(object sender, EventArgs e)
        {

        }
        private void showTable()
        {
            DataGridView_student.DataSource = studentControl.selectStudent(new MySqlCommand("SELECT *,competency.CodeCompetency FROM student INNER JOIN competency ON competetncy.CodeCompetency = student.CodeCompt"));
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            textBox_nisn.MaxLength = 10;
            textBox_address.MaxLength = 35;
            textBox_firstname.MaxLength = 20;
            textBox_lastname.MaxLength = 20;
            textBox_phone.MaxLength = 13;
            idcodeCompt();
            showTable();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_nisn.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            comboBox_codeCompt.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_firstname.Text= DataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_lastname.Text = DataGridView_student.CurrentRow.Cells[3].Value.ToString();          
            dateTimePicker_date.Value = (DateTime)DataGridView_student.CurrentRow.Cells[4].Value;

            if(DataGridView_student.CurrentRow.Cells[5].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            textBox_phone.Text = DataGridView_student.CurrentRow.Cells[6].Value.ToString();
            textBox_address.Text = DataGridView_student.CurrentRow.Cells[7].Value.ToString();
            byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[8].Value;
            MemoryStream gambar = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(gambar);
        }

        private void button_uploadmanage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = studentControl.searchStudent(textBox_search.Text);
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void button_clearmanage_Click(object sender, EventArgs e)
        {
            textBox_nisn.Clear();
            textBox_lastname.Clear();
            textBox_firstname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker_date.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }
        bool verify()
        {
            if ((textBox_nisn.Text.Equals(""))|| (textBox_lastname.Text == "") || (textBox_firstname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") || (pictureBox_student.Image == null))
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
            string gender = radioButton_male.Checked ? "Male" : "Female";
            int born_year = dateTimePicker_date.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) <= 15 || (this_year - born_year) >= 21)
            {
                MessageBox.Show("Age 15 s/d 21 year", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                if(val.valName(textBox_firstname.Text) && val.valName(textBox_lastname.Text) && val.valAlamat(textBox_address.Text))
                {
                    try
                    {
                        MemoryStream memori = new MemoryStream();
                        pictureBox_student.Image.Save(memori, pictureBox_student.Image.RawFormat);
                        byte[] img = memori.ToArray();
                        studentControl.updateStudent(textBox_nisn.Text, comboBox_codeCompt.Text, textBox_firstname.Text, textBox_lastname.Text,
                                dateTimePicker_date.Value, gender, textBox_phone.Text, textBox_address.Text, img);
                        showTable();
                        button_clear.PerformClick();
                        MessageBox.Show("Student data Update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_firstname.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input Update field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Fieled Update", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    studentControl.deleteStudent(textBox_nisn.Text);
                    showTable();
                    button_clear.PerformClick();
                    MessageBox.Show("Student Deleted succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_nisn.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Student not delete", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nisn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
