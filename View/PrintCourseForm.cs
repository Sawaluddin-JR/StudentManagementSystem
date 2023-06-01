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
    public partial class PrintCourseForm : Form
    {
        private CourseClass courseControl = new CourseClass();
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        public void showData(MySqlCommand command)
        {          
            DataGridView_course.DataSource = courseControl.getCompetency(new MySqlConnector.MySqlCommand("SELECT * FROM competency"));
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM competency"));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.DataGridView_course.Width, this.DataGridView_course.Height);
            DataGridView_course.DrawToBitmap(btm, new Rectangle(0, 0, this.DataGridView_course.Width, this.DataGridView_course.Height));
            e.Graphics.DrawImage(btm, 40, 120);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(300, 50));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = courseControl.searchCompetency(textBox_search.Text);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
