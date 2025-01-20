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
    public partial class Watched : Form
    {
        public Watched()
        {
            InitializeComponent();
            this.Load += LoadingMovies;
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void Watched_Load(object sender, EventArgs e)
        {

        }
        private void LoadMovies()
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT m.Name As 'Movie', m.Genre, m.Description, wl.Rate As 'Your Rate', wl.UserId, wl.WatchedListId FROM WatchedMovieList wl " +
                        "INNER JOIN Users u ON wl.UserId = u.UserId " +
                        "INNER JOIN Movies m ON wl.MovieId = m.MovieId WHERE u.UserId = @UserId";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@UserId", Login.UserId);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    movies_dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadingMovies(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void movies_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (movies_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = movies_dgv.SelectedRows[0];
                if (selectedRow.Cells["WatchedListId"].Value != null)

                {
                    int WatchedListId = Convert.ToInt32(selectedRow.Cells["WatchedListId"].Value);
                    using (SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM WatchedMovieList WHERE WatchedListId = @id";
                            SqlCommand cm = new SqlCommand(query, con);
                            cm.Parameters.AddWithValue("id", WatchedListId);

                            int affectedRow = cm.ExecuteNonQuery();
                            if (affectedRow > 0)
                            {
                                MessageBox.Show("Deleted successfully");
                                LoadMovies();
                            }
                            else
                            {
                                MessageBox.Show("Some error occurs");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else MessageBox.Show("id is null");
            }
            else MessageBox.Show("Select row to delete");
        }
    }
}
