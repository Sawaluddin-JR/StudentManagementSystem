using MySqlConnector;
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
    public partial class LoginForm : Form
    {
        StudentClass studentControl;
        public LoginForm()
        {
            studentControl = new StudentClass();    
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if((textBox_admin.Text == "") || (textBox_password.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBox_admin.Text;
                string pass = textBox_password.Text;
                DataTable table = studentControl.getList(new MySqlCommand("SELECT * FROM admin WHERE Nama = '" + name + "' AND Pasword ='" + pass + "'"));

                if (table.Rows.Count > 0)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox_buka.Visible = false;
            pictureBox_tutup.Visible = true;
 
        }

        private void pictureBox_buka_Click(object sender, EventArgs e)
        {
           if(pictureBox_buka.Visible == true)
           {
                pictureBox_buka.Visible = false;
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_tutup_Click(object sender, EventArgs e)
        {
            if(pictureBox_buka.Visible == false)
            {
                pictureBox_buka.Visible = true;
                textBox_password.UseSystemPasswordChar = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
