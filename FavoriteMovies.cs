using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                // Make sure to filter based on UserId (the current logged-in user)
                string query = "SELECT f.FavoriteMovieId, m.Name, m.Rating, m.ReleaseDate, m.Description, m.Genre, d.FullName AS 'Director' FROM Favorite_Movies f INNER JOIN Movies m ON f.MovieId = m.MovieId LEFT JOIN Directors d ON m.DirectorId = d.DirectorId WHERE f.UserId = @UserId ";  // Filter by the logged-in UserId

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@UserId", Login.UserId);  // Pass the UserId from Login class

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
                    string query = "SELECT f.FavoriteMovieId, m.Name, m.Rating, m.ReleaseDate, m.Description, m.Genre , d.FullName FROM Favorite_Movies f INNER JOIN Movies m ON f.MovieId = m.MovieId LEFT JOIN Directors d ON m.DirectorId = d.DirectorId WHERE m.Name Like @Name";
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
        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            if (fav_movies_dgv.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = fav_movies_dgv.SelectedRows[0];

                // Check if the 'FavoriteMovieId' column exists and fetch its value
                if (selectedRow.Cells["FavoriteMovieId"].Value != null)
                {
                    int favoriteMovieId = Convert.ToInt32(selectedRow.Cells["FavoriteMovieId"].Value);
                    MessageBox.Show("Deleting Movie with ID: " + favoriteMovieId);  // Debugging: Show the ID of the selected movie

                    using (SqlConnection conn = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Favorite_Movies WHERE FavoriteMovieId = @FavoriteMovieId";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@FavoriteMovieId", favoriteMovieId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Favorite movie deleted successfully.");
                                LoadData();  // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Error deleting movie. No movie with the provided ID found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain valid 'FavoriteMovieId'.");
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.");
            }
        }

        private void FavoriteMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
