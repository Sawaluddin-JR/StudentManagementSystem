using Guna.UI2.WinForms.Suite;
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
using static System.Formats.Asn1.AsnWriter;

namespace StudentManagementSystem.View
{
    public partial class SubjectsForm : Form
    {
        ValidationClass val = new ValidationClass();
        private Connection conn = new Connection();
        private SubjectsClass subjectsControl = new SubjectsClass();
        public SubjectsForm()
        {
            InitializeComponent();
        }
        public void showSubjects()
        {
            DataGridView_subjects.DataSource = subjectsControl.getSubjects(new MySqlCommand("SELECT subjects.CodeSubjects,subjects.CodeCompt,subjects.NIP,teacher.FirstName,teacher.LastName, " +
                "subjects.SubjectsName,subjects.Hour,subjects.LevelClass,subjects.Description FROM subjects INNER JOIN teacher ON subjects.NIP=teacher.NIP INNER JOIN competency ON subjects.CodeCompt=competency.CodeCompetency"));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void nip()
        {
            DataTable data = new DataTable();
            string nip = "SELECT NIP FROM teacher";
            conn.cmd = new MySqlCommand(nip, conn.GetConn());
            conn.dr = conn.cmd.ExecuteReader();
            data.Columns.Add("NIP", typeof(string));
            data.Load(conn.dr);
            comboBox_nip.ValueMember = "NIP";
            comboBox_nip.DataSource = data;
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            nip();
            idcodeCompt();
            showSubjects();
            textBox_code.MaxLength = 3;
            textBox_description.MaxLength = 80;
            textBox_hour.MaxLength = 1;
            textBox_nameSubjects.MaxLength = 50;
            comboBox_levelClass.SelectedIndex = 0;
            comboBox_levelClass.SelectedIndex = 0;
        }
        bool verify()
        {
            if ((textBox_hour.Text == "") || (textBox_description.Text == "") || (comboBox_nip.Text == "") ||
                (textBox_code.Text == "") || (comboBox_codeCompt.Text == "") || (textBox_nameSubjects.Text == "") || (comboBox_levelClass.Text == ""))
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
            if (verify())
            {
                if(val.valName(textBox_nameSubjects.Text) && val.valkalimat(textBox_description.Text))
                {
                    try
                    {
                        subjectsControl.insertSubjects(textBox_code.Text, comboBox_codeCompt.Text, comboBox_nip.Text, textBox_nameSubjects.Text, textBox_hour.Text,
                            comboBox_levelClass.Text, textBox_description.Text);
                        showSubjects();
                        MessageBox.Show("New Subjects Added", "Add Subjects", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
            else
            {
                MessageBox.Show("Subjects not insert", "Add Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_code.Clear();
            textBox_description.Clear();
            textBox_hour.Clear();
            textBox_nameSubjects.Clear();
        }

        private void DataGridView_subjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button_showSubjects_Click(object sender, EventArgs e)
        {
           
        }

        private void button_showCompt_Click(object sender, EventArgs e)
        {
            
        }

        private void button_showTeacher_Click(object sender, EventArgs e)
        {

        }

        private void button_showCompt_Click_1(object sender, EventArgs e)
        {
            DataGridView_subjects.DataSource = subjectsControl.getSubjects(new MySqlCommand("SELECT * FROM competency"));
        }

        private void button_showTeacher_Click_1(object sender, EventArgs e)
        {
            DataGridView_subjects.DataSource = subjectsControl.getSubjects(new MySqlCommand("SELECT NIP,Firstname,LastName FROM teacher"));
        }

        private void button_showSubjects_Click_1(object sender, EventArgs e)
        {
            showSubjects();
        }

        private void textBox_hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_nameSubjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
