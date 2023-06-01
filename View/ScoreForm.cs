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

namespace StudentManagementSystem.View
{
    public partial class ScoreForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private Connection conn = new Connection();
        private CourseClass courseControl;
        private ScoreClass scoreControl;
        private StudentClass studentControl;
        private SubjectsClass subjectControl = new SubjectsClass();

        public ScoreForm()
        {
            studentControl = new StudentClass();
            courseControl = new CourseClass();
            scoreControl = new ScoreClass();
            InitializeComponent();
        }
        private void idcodeSubjt()
        {
            DataTable data = new DataTable();
            string idcodeSubjt = "SELECT CodeSubjects FROM subjects";
            conn.cmd = new MySqlCommand(idcodeSubjt, conn.GetConn());
            conn.dr = conn.cmd.ExecuteReader();
            data.Columns.Add("CodeSubjects", typeof(string));
            data.Load(conn.dr);
            comboBox_subjtCode.ValueMember = "CodeSubjects";
            comboBox_subjtCode.DataSource = data;
        }
        private void nis()
        {
            DataTable data = new DataTable();
            string nis = "SELECT NIS FROM student";
            conn.cmd = new MySqlCommand(nis, conn.GetConn());
            conn.dr = conn.cmd.ExecuteReader();
            data.Columns.Add("NIS", typeof(string));
            data.Load(conn.dr);
            comboBox_nis.ValueMember = "NIS";
            comboBox_nis.DataSource = data;
        }
        public void showScore()
        {
            DataGridView_student.DataSource = scoreControl.getScore(new MySqlCommand("SELECT score.NIS,student.FirstName,student.LastName,subjects.CodeSubjects,subjects.SubjectsName,subjects.LevelClass,score, " +
                "score.Semester,score.SchoolYear,score.Description FROM student INNER JOIN score ON score.NIS=student.NIS INNER JOIN subjects ON subjects.CodeSubjects=score.SubjCode"));
        }
        private void ScoreForm_Load(object sender, EventArgs e)
        {
            idcodeSubjt();
            nis();
            textBox_score.MaxLength = 2;
            textBox_description.MaxLength = 80;
            comboBox_semester.SelectedIndex = 0;
            comboBox_schoolYear.SelectedIndex = 0;
            comboBox_selectSubject.DataSource = courseControl.getCompetency(new MySqlCommand("SELECT * FROM subjects"));
            comboBox_selectSubject.DisplayMember = "SubjectsName";
            comboBox_selectSubject.ValueMember = "SubjectsName";
            DataGridView_student.DataSource = studentControl.getList(new MySqlCommand("SELECT NIS,FirstName,LastName FROM student"));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool verify()
        {
            if ((textBox_description.Text == "") || (comboBox_schoolYear.Text == "") ||
                (textBox_score.Text == ""))
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
            if (verify() && val.valkalimat(textBox_description.Text))
            {
                try
                {
                    scoreControl.insertScore(comboBox_nis.Text, comboBox_subjtCode.Text, textBox_score.Text, comboBox_semester.Text, comboBox_schoolYear.Text, textBox_description.Text);
                    showScore();
                    MessageBox.Show("New Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Score not insert", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_score.Clear();
            textBox_description.Clear();
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_showCompt_Click(object sender, EventArgs e)
        {
            showScore();
        }

        private void button_showTeacher_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = studentControl.getList(new MySqlCommand("SELECT NIS,FirstName,LastName FROM student"));
        }

        private void button_showSubjects_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = subjectControl.getSubjects(new MySqlCommand("SELECT * FROM subjects"));
        }

        private void textBox_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_score_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
