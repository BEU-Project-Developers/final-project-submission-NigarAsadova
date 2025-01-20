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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            watchList.MouseEnter += Label_MouseEnter;
            watchList.MouseLeave += Label_MouseLeave;

            watched_lb.MouseEnter+= Label_MouseEnter;
            watched_lb.MouseLeave+= Label_MouseLeave;

            search_movie.MouseEnter += Label_MouseEnter;
            search_movie.MouseLeave += Label_MouseLeave;

            actors.MouseEnter += Label_MouseEnter;
            actors.MouseLeave += Label_MouseLeave;

            favorites.MouseEnter += Label_MouseEnter;
            favorites.MouseLeave += Label_MouseLeave;

            log_out.MouseEnter += Label_MouseEnter;
            log_out.MouseLeave += Label_MouseLeave;

            inside_out_pic.MouseEnter += Pic_MouseEnter;
            inside_out_pic.MouseLeave+= Pic_MouseLeave;

            monster_pic.MouseEnter += Pic_MouseEnter;
            monster_pic.MouseLeave += Pic_MouseLeave;

            tagiyev_oil_pic.MouseEnter += Pic_MouseEnter;
            tagiyev_oil_pic.MouseLeave += Pic_MouseLeave;

            The_Adventures_of_the_Electronic_pic.MouseEnter += Pic_MouseEnter;
            The_Adventures_of_the_Electronic_pic.MouseLeave += Pic_MouseLeave;

            madame_pic.MouseEnter += Pic_MouseEnter;
            madame_pic.MouseLeave += Pic_MouseLeave;

            a_beautiful_mind_pic.MouseEnter += Pic_MouseEnter;
            a_beautiful_mind_pic.MouseLeave += Pic_MouseLeave;

            The_Imitation_Game_pic.MouseEnter += Pic_MouseEnter;
            The_Imitation_Game_pic.MouseLeave += Pic_MouseLeave;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actors_Click(object sender, EventArgs e)
        {
            Actors actors = new Actors();
            actors.Show();
            this.Hide();
        }

        private void add_movie_Click(object sender, EventArgs e)
        {
            Watchlist wl = new Watchlist();
            wl.Show();
            this.Hide();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.White;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Black;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.None;
        }

        private void search_movie_Click(object sender, EventArgs e)
        {
            SearchMovie search = new SearchMovie();
            search.Show();
            this.Hide();
        }



        private void favorites_Click(object sender, EventArgs e)
        {
            Favorites fav = new Favorites();
            fav.Show();
            this.Hide();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void watched_lb_Click(object sender, EventArgs e)
        {
            Watched w = new Watched();
            w.Show();
            this.Hide();
        }
    }
}
