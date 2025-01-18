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
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
   
        }

        private void fav_movies_btn_Click(object sender, EventArgs e)
        {
            FavoriteMovies favMovies = new FavoriteMovies();
            favMovies.Show();
            this.Hide();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void fav_actors_btn_Click(object sender, EventArgs e)
        {
            FavoriteActors favActors = new FavoriteActors();
            favActors.Show();
            this.Hide();
        }

        private void fav_driectors_btn_Click(object sender, EventArgs e)
        {
            FavoritesDirectors favDirectors = new FavoritesDirectors();
            favDirectors.Show();
            this.Hide();
        }
    }
}
