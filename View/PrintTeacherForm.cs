using MySqlConnector;
using StudentManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.View
{
    public partial class PrintTeacherForm : Form
    {
        private TeacherClass teacherControl = new TeacherClass();
        public PrintTeacherForm()
        {
            InitializeComponent();
        }

        private void DataGridView_addTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showData(MySqlCommand command)
        {
            DataGridView_teacher.ReadOnly = true;
            DataGridView_teacher.DataSource = teacherControl.getList(command);
        }
        private void PrintTeacherForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM teacher"));
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;

            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM teacher";
            }
            else if (radioButton_man.Checked)
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender='Man'";
            }
            else
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender='Woman'";                
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.DataGridView_teacher.Width, this.DataGridView_teacher.Height);
            DataGridView_teacher.DrawToBitmap(btm, new Rectangle(0, 0, this.DataGridView_teacher.Width, this.DataGridView_teacher.Height));
            e.Graphics.DrawImage(btm, 40, 120);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(300, 50));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
