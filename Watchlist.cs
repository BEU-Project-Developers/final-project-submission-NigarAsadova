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
    public partial class Watchlist : Form
    {
        public Watchlist()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void LoadWatchlist()
        {
            using(SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT m.Name, m.Genre, m.Rating, m.Description, w.AddingDate, w.WatchListId " +
                        "FROM WatchList w INNER JOIN Users u ON w.UserId = u.UserId " +
                        "INNER JOIN Movies m ON w.MovieId = m.MovieId WHERE u.UserId = @UserId";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@UserId", Login.UserId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    watchlist_dgv.DataSource = dt;
                    con.Close();
                } catch(Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }

        private void Watchlist_Load(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadWatchlist();
        }

        // Delete movie from watchlist

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Check that user select row or not
            if (watchlist_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = watchlist_dgv.SelectedRows[0];
                if (selectedRow.Cells["WatchListId"].Value != null)
                {
                    int WatchListId = Convert.ToInt32(selectedRow.Cells["WatchListId"].Value);
                    using (SqlConnection conn = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM WatchList WHERE WatchListId = @WatchListId";
                            SqlCommand com = new SqlCommand(query, conn);
                            com.Parameters.AddWithValue("@WatchListId", WatchListId);

                            int affectedRow = com.ExecuteNonQuery();
                            if (affectedRow > 0)
                            {
                                MessageBox.Show("Movie with ID :" + WatchListId + " deleted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Error deleting movie. No movie with the provided ID found in Watchlist.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The movie does not contain id");
                }
            }
            else MessageBox.Show("Select movie's row to delete");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
