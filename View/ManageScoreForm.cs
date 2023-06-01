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
    public partial class ManageScoreForm : Form
    {
        private ValidationClass val = new ValidationClass();
        private Connection conn = new Connection();
        private CourseClass courseControl = new CourseClass();
        private ScoreClass scoreControl = new ScoreClass();
        public ManageScoreForm()
        { 
            InitializeComponent();
        }
        private void idcodeSubjt()
        {
            DataTable data = new DataTable();
            string idcodeSubjt = "SELECT Codesubjects FROM subjects";
            conn.cmd = new MySqlCommand(idcodeSubjt, conn.GetConn());
            conn.dr = conn.cmd.ExecuteReader();
            data.Columns.Add("Codesubjects", typeof(string));
            data.Load(conn.dr);
            comboBox_subjtCode.ValueMember = "Codesubjects";
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            idcodeSubjt();
            nis();
            textBox_score.MaxLength = 2;
            textBox_description.MaxLength = 80;
            comboBox_semester.SelectedIndex = 0;
            comboBox_schoolyear.SelectedIndex = 0;
            comboBox_selectSubject.DataSource = courseControl.getCompetency(new MySqlCommand("SELECT * FROM subjects"));
            comboBox_selectSubject.DisplayMember = "SubjectsName";
            comboBox_selectSubject.ValueMember = "SubjectsName";

            showScore();
        }
        public void showScore()
        {
            DataGridView_manageScore.DataSource = scoreControl.getScore(new MySqlCommand("SELECT score.NIS,student.FirstName,subjects.CodeSubjects,subjects.SubjectsName,subjects.LevelClass,score, " +
                "score.Semester,score.SchoolYear,score.Description FROM student INNER JOIN score ON score.NIS=student.NIS INNER JOIN subjects ON subjects.CodeSubjects=score.SubjCode"));
        }
        private void button_update_Click(object sender, EventArgs e)
        {
          
            if ((textBox_score.Text == "") || (comboBox_schoolyear.Text == "") || (textBox_description.Text == ""))
            {
                MessageBox.Show("Need Score Data","Field Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            { 
                if(val.valkalimat(textBox_description.Text))
                {
                    try
                    {
                        scoreControl.updateScore(comboBox_nis.Text, comboBox_subjtCode.Text, textBox_score.Text, comboBox_semester.Text, comboBox_schoolyear.Text, textBox_description.Text);
                        showScore();
                        MessageBox.Show("New Score update", "update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox_nis.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_score.Clear();
            textBox_description.Clear();
            textBox_search.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
           
            if (comboBox_nis.Text == "")
            {
                MessageBox.Show("Field Error - we need student NISN","Delete Score",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Are you sure you want to remove this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                    
                    try
                    {
                        scoreControl.deleteScore(comboBox_nis.Text);
                        showScore();
                        button_clear.PerformClick();
                        MessageBox.Show("Score Deleted succesfully", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox_nis.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
        }

        private void DataGridView_manageCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_nis.Text = DataGridView_manageScore.CurrentRow.Cells[0].Value.ToString();
            comboBox_subjtCode.Text = DataGridView_manageScore.CurrentRow.Cells[3].Value.ToString();
            comboBox_selectSubject.Text = DataGridView_manageScore.CurrentRow.Cells[4].Value.ToString();
            textBox_score.Text = DataGridView_manageScore.CurrentRow.Cells[5].Value.ToString();
            comboBox_semester.Text = DataGridView_manageScore.CurrentRow.Cells[6].Value.ToString();
            comboBox_schoolyear.Text = DataGridView_manageScore.CurrentRow.Cells[7].Value.ToString();
            textBox_description.Text = DataGridView_manageScore.CurrentRow.Cells[8].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_manageScore.DataSource = scoreControl.searchScore(textBox_search.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
