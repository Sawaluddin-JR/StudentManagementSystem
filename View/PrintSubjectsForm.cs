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
    public partial class PrintSubjectsForm : Form
    {
        private SubjectsClass subjectControl = new SubjectsClass();
        public PrintSubjectsForm()
        {
            InitializeComponent();
        }
        public void showData(MySqlCommand command)
        {
            DataGridView_subjects.ReadOnly = true;
            DataGridView_subjects.DataSource = subjectControl.getSubjects(command);
        }
        private void PrintSubjectsForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM subjects"));
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_subjects.DataSource = subjectControl.searchSubjects(textBox_search.Text);
            DataGridView_subjects.RowTemplate.Height = 80;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.DataGridView_subjects.Width, this.DataGridView_subjects.Height);
            DataGridView_subjects.DrawToBitmap(btm, new Rectangle(0, 0, this.DataGridView_subjects.Width, this.DataGridView_subjects.Height));
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
