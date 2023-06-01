using MySqlConnector;
using StudentManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.View
{
    public partial class PrintStudentForm : Form
    {
        private StudentClass studentControl = new StudentClass();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM student"));
        }
        public void showData(MySqlCommand command)
        {
            DataGridView_student.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_student.DataSource = studentControl.getList(command);
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if(radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM student";
            }
            else if(radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM student WHERE Gender='Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM student WHERE Gender='Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }
        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.DataGridView_student.Width, this.DataGridView_student.Height);
            DataGridView_student.DrawToBitmap(btm, new Rectangle(0, 0, this.DataGridView_student.Width, this.DataGridView_student.Height));
            e.Graphics.DrawImage(btm, 40, 120);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(300, 50));
        }

        private void button_search1_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = studentControl.searchStudent(textBox_search.Text);
        }
    }
}
