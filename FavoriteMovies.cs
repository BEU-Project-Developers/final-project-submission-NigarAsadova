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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Movies_Project
{
    public partial class FavoriteMovies : Form
    {
        public FavoriteMovies()
        {
            InitializeComponent(); 
            this.Load += ShowingDatas; // Then subscribe to the Load event
            search_icon.MouseClick += btn_MouseEnter;
            search_icon.MouseLeave+= btn_MouseLeave;
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                conn.Open();
                String query = "SELECT f.FavoriteMovieId, m.Name, m.Rating, m.ReleaseDate, m.Description, m.Genre , d.FullName, a.FullName AS 'Main Actor'\r\nFROM Favorite_Movies f INNER JOIN Movies m ON f.MovieId = m.MovieId\r\nLEFT JOIN Directors d ON m.DirectorId = d.DirectorId\r\nLEFT JOIN Actors a ON a.ActorId = m.FirstActorId";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable tb = new DataTable();
                dataAdapter.Fill(tb);
                fav_movies_dgv.DataSource = tb;
            }

        }

        private void ShowingDatas(object sender, EventArgs e)
        {
            LoadData();
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

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchingFavMovie()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT f.FavoriteMovieId, m.Name, m.Rating, m.ReleaseDate, m.Description, m.Genre , d.FullName, a.FullName AS 'Main Actor' FROM Favorite_Movies f INNER JOIN Movies m ON f.MovieId = m.MovieId\r\nLEFT JOIN Directors d ON m.DirectorId = d.DirectorId LEFT JOIN Actors a ON a.ActorId = m.FirstActorId WHERE m.Name Like @Name";
                    SqlCommand cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@Name", "%" + search_box.Text + "%");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    fav_movies_dgv.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        errorBox.Text = "No result";
                    }
                }
                catch (Exception e)
                {
                    errorBox.Text = e.Message;
                }
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.None;
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
            if (search_box.Text != "") SearchingFavMovie();
            else LoadData();
        }
    }
}
