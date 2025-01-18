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
    public partial class FavoriteMovies : Form
    {
        public FavoriteMovies()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Favorites home = new Favorites();
            home.Show();
            this.Hide();
        }

        private void favorite_movies_lb_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void fav_movies_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
