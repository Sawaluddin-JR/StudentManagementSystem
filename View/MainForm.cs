using StudentManagementSystem.Controller;
using StudentManagementSystem.View;
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
    public partial class MainForm : Form
    {
        private StudentClass studentControl;
        public MainForm()
        {
            studentControl = new StudentClass();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
        }
        public void studentCount()
        {
            label_totStd.Text = "Total Student : " + studentControl.totalStudent();
            label_male.Text = "Male : " + studentControl.manStudent();
            label_female.Text = "Female : " + studentControl.womanStudent();
        }

        private void hideSubmenu()
        {
            if(panel_stdsubmenu.Visible == true)
            {
                panel_stdsubmenu.Visible = false;
            }
            if (panel_teacherSubmenu.Visible == true)
            {
                panel_teacherSubmenu.Visible = false;
            }
            if (panel_competencySubmenu.Visible == true)
            {
                panel_competencySubmenu.Visible = false;
            }
            if(panel_scoreSubmenu.Visible == true)
            {
                panel_scoreSubmenu.Visible = false;
            }
            if(panel_subjectsSubmenu.Visible == true)
            {
                panel_subjectsSubmenu.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button_std_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        private void button_registration_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //hideSubmenu();
        }

        private void button_manageStd_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //hideSubmenu();
        }

        private void button_stdPrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintStudentForm());
            //hideSubmenu();
        }
        private void button_course_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_teacherSubmenu);
        }

        private void button_newCourse_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TeacherForm());
            //hideSubmenu();
        }

        private void button_manageCourse_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageTeacherForm());
            //hideSubmenu();
        }

        private void button_coursePrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintTeacherForm());
            //hideSubmenu();
        }

        private void button_score_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_competencySubmenu);
        }

        private void button_newScore_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            //hideSubmenu();
        }

        private void button_manageScore_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageForm());
            //hideSubmenu();
        }

        private void button_scorePrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            //hideSubmenu();
        }

        private void button_dashboard_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_subjectsSubmenu);
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
           
        }

        #region failed
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        private void button_registration_Click(object sender, EventArgs e)
        {

        }
        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            hideSubmenu();
        }
        private void button_status_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudentForm());
            hideSubmenu();
        }
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_teacherSubmenu);
        }
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_competencySubmenu);
        }
        private void button_newScore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_manageScore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void button_exit_Click(object sender, EventArgs e)
        {

        }
        private void button_dashboard_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion failed

        private void button_newScore_Click_2(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            //hideSubmenu();
        }

        private void button_score_Click_2(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        private void button_manageScore_Click_2(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());
           // hideSubmenu();
        }

        private void button_classPrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
            hideSubmenu();
        }

        private void button_exit_Click_2(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_class_Click(object sender, EventArgs e)
        {
/*            showSubmenu(panel_classSubMenu);*/
        }

        private void button_newSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new SubjectsForm());
            //hideSubmenu();
        }

        private void button_manageSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSubjectsForm());
            //hideSubmenu();
        }

        private void button_subjectsPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintSubjectsForm());
            //hideSubmenu();
        }

        private void button_newClass_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_manageClass_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_scorePrint_Click_2(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
        }
    }
}
