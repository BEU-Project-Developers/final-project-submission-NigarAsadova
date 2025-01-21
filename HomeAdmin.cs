using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Project
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }



        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            userData.Show();
            this.Hide();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Actors_btn_Click(object sender, EventArgs e)
        {
            ActorsData ad = new ActorsData();
            ad.Show();
            this.Hide();
        }

        private void movies_btn_Click(object sender, EventArgs e)
        {
            MoviesData m = new MoviesData();
            m.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LoginAdmin la = new LoginAdmin();
            la.Show();
            this.Hide();
        }
    }
}
