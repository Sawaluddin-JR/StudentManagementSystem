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
    public partial class PrintScoreForm : Form
    {
        private ScoreClass scoreControl = new ScoreClass();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        public void showScore()
        {
            DataGridView_score.DataSource = scoreControl.getScore(new MySqlCommand("SELECT score.NIS,student.FirstName,student.LastName,score.SubjCode,score,Description FROM student INNER JOIN score ON score.NIS=student.NIS"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = scoreControl.searchScore(textBox_search.Text);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.DataGridView_score.Width, this.DataGridView_score.Height);
            DataGridView_score.DrawToBitmap(btm, new Rectangle(0, 0, this.DataGridView_score.Width, this.DataGridView_score.Height));
            e.Graphics.DrawImage(btm, 40, 120);
            e.Graphics.DrawString(label1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(300, 50));
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }
    }
}
