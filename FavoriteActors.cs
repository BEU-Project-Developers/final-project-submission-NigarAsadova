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
    public partial class FavoriteActors : Form
    {
        public FavoriteActors()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Favorites home = new Favorites();
            home.Show();
            this.Hide();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void LoadFavActors()
        {
            using(SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT a.ActorName, m.Name, m.Genre, m.Rating, m.Description , f.FavoriteActorId " + 
                        "FROM Favorite_Actors f INNER JOIN Actors a ON f.ActorId = a.ActorId " +
                        "INNER JOIN MoviesSet ms ON a.ActorId = ms.ActorId " +
                        "INNER JOIN Movies m ON ms.MovieId = m.MovieId WHERE f.UserId = @UserId";

                    SqlCommand cm = new SqlCommand(query, con);
                    cm.Parameters.AddWithValue("@UserId", Login.UserId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    fav_actors_dgv.DataSource = dt;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fav_actors_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (fav_actors_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = fav_actors_dgv.SelectedRows[0];
                if (selectedRow.Cells["FavoriteActorId"].Value != null) // Ensure column name matches the alias
                {
                    int FavActorId = Convert.ToInt32(selectedRow.Cells["FavoriteActorId"].Value);
                    using (SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM Favorite_Actors WHERE FavoriteActorId = @FavActorId"; // Use consistent table name
                            SqlCommand cm = new SqlCommand(query, con);
                            cm.Parameters.AddWithValue("@FavActorId", FavActorId);

                            int rowsAffected = cm.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Actor deleted from Favorites successfully!!");
                                LoadFavActors(); // Refresh grid
                            }
                            else
                            {
                                MessageBox.Show("Error deleting actor. No actor with the provided ID found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain valid 'FavoriteActorId'.");
                }
            }
            else
            {
                MessageBox.Show("Select an Actor to delete.");
            }
        }


        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadFavActors();
        }
    }
}
