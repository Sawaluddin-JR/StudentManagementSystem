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

namespace StudentManagementSystem.View
{
    public partial class ManageSubjectsForm : Form
    {
        ValidationClass val = new ValidationClass();
        private Connection conn = new Connection();
        private SubjectsClass subjectControl = new SubjectsClass();
        public ManageSubjectsForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_subject.DataSource = subjectControl.getSubjects(new MySqlCommand("SELECT * FROM subjects"));
            DataGridView_subject.RowTemplate.Height = 80;
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
        private void ManageSubjectsForm_Load(object sender, EventArgs e)
        {
            nip();
            idcodeCompt();
            showTable();
            textBox_code.MaxLength = 3;
            textBox_description.MaxLength = 80;
            textBox_hour.MaxLength = 1;
            textBox_nameSubjects.MaxLength = 50;
            comboBox_levelClass.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_code.Text = DataGridView_subject.CurrentRow.Cells[0].Value.ToString();
            comboBox_codeCompt.Text = DataGridView_subject.CurrentRow.Cells[1].Value.ToString();
            comboBox_nip.Text = DataGridView_subject.CurrentRow.Cells[2].Value.ToString();
            textBox_nameSubjects.Text = DataGridView_subject.CurrentRow.Cells[3].Value.ToString();
            textBox_hour.Text = DataGridView_subject.CurrentRow.Cells[4].Value.ToString();
            comboBox_levelClass.Text = DataGridView_subject.CurrentRow.Cells[5].Value.ToString();
            textBox_description.Text = DataGridView_subject.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_subject.DataSource = subjectControl.searchSubjects(textBox_search.Text);
            DataGridView_subject.RowTemplate.Height = 80;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_code.Clear();
            textBox_description.Clear();
            textBox_hour.Clear();
            textBox_nameSubjects.Clear();
            textBox_search.Clear();
        }
        bool verify()
        {
            if ((comboBox_nip.Text == "") || (textBox_code.Text == "") || (comboBox_codeCompt.Text == "") ||
                (textBox_description.Text == "") || (textBox_hour.Text == "") || (comboBox_levelClass.Text == "") || (textBox_nameSubjects.Text == "") )
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
            if (verify())
            {
                if(val.valName(textBox_nameSubjects.Text) && val.valkalimat(textBox_description.Text))
                {
                    try
                    {
                        subjectControl.updateSubjects(textBox_code.Text, comboBox_codeCompt.Text, comboBox_nip.Text, textBox_nameSubjects.Text, textBox_hour.Text,
                           comboBox_levelClass.Text, textBox_description.Text);
                        showTable();
                        button_clear.PerformClick();
                        MessageBox.Show("Subjects data Update", "Update Subjects", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_code.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fieled Update", "Update Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    subjectControl.deleteSubjects(textBox_code.Text);
                    showTable();
                    button_clear.PerformClick();
                    MessageBox.Show("Subjects Deleted succesfully", "Delete Subjects", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_code.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Subjects not delete", "Delete Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
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
    }
}
