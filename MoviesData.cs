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
    public partial class MoviesData : Form
    {
        public MoviesData()
        {
            InitializeComponent();
            this.Load += LoadingMovies;
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        // Loading Movies

        private void LoadMovies()
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "Select * FROM Movies";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    movies_dgv.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadingMovies(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void MoviesData_Load(object sender, EventArgs e)
        {

        }

        private void movies_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (movies_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = movies_dgv.SelectedRows[0];
                if (selectedRow.Cells["MovieId"].Value != null)
                {
                    int MovieId = Convert.ToInt32(selectedRow.Cells["MovieId"].Value);
                    MessageBox.Show("Deleting Movie with ID " + MovieId);

                    using (SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try 
                        {
                            con.Open();
                            // Delete relative table
                            string relquery = "DELETE FROM MoviesSet WHERE MovieId = @MovieId";
                            SqlCommand cmm = new SqlCommand(relquery, con);
                            cmm.Parameters.AddWithValue("@MovieId", MovieId);

                            //Delete main table
                            string query = "DELETE FROM Movies WHERE MovieId = @MovieId";
                            SqlCommand cm = new SqlCommand(query, con);
                            cm.Parameters.AddWithValue("@MovieId", MovieId);

                            int rowsAffected = cm.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Movie deleted successfully!!");
                                LoadMovies(); // Refreshing
                            }
                            else
                            {
                                MessageBox.Show("Error deleting movie. No movie with the provided ID found.");
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
                    MessageBox.Show("Selected row does not contain valid 'MovieId'.");
                }
            }
            else MessageBox.Show("Select Movie to delete");
       
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            this.Hide();
        }

        private void SearchingMovie()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Movies WHERE UPPER(Name) LIKE @Name";
                    SqlCommand cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@Name", "%" + textBox1.Text + "%");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    movies_dgv.DataSource = dt;
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

        private void search_icon_Click(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
            SearchingMovie();
            if (textBox1.Text == "")
            {
                LoadMovies();
            }
        }
    }
}
