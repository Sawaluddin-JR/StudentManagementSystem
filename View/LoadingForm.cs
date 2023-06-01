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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int starPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starPoint += 1;
            ProgressIndicator_load.Start();
            if(starPoint > 100)
            {
                LoginForm log = new LoginForm();
                ProgressIndicator_load.Stop();
                timer1.Stop();
                this.Hide();
                log.Show();
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
