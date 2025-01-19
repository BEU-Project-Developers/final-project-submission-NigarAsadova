using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timerProgress.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timerProgress_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timerProgress.Stop();
                showLogin();
            }
        }

        private void movies_title_Click(object sender, EventArgs e)
        {

        }

        private void sideBg_Click(object sender, EventArgs e)
        {

        }

        private void showLogin()
        {
            AdminOrUser adminOrUser = new AdminOrUser();
            adminOrUser.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
