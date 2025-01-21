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
    public partial class SearchMovie : Form
    {
        public SearchMovie()
        {
            InitializeComponent();
            this.Load += SearchMovie_Load;
            textBox1.KeyDown += textBox1_KeyDown;
            home_btn.MouseEnter += btn_MouseEnter;
            home_btn.MouseLeave += btn_MouseLeave;
            add_btn.MouseEnter += btn_MouseEnter;
            add_btn.MouseLeave += btn_MouseLeave;
        }
        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }


        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MovieId, Name, Rating, Genre, ReleaseDate, Description FROM Movies";
                    SqlDataAdapter data = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    moviesDGV.DataSource = dt;

                    // Check if 'MovieId' column exists
                    if (!moviesDGV.Columns.Contains("MovieId"))
                    {
                        errorBox.Text = "MovieId column is missing from the data grid.";
                    }
                }
                catch (Exception ex)
                {
                    errorBox.Text = ex.Message;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchingMovie();
            }
        }

        private void SearchingMovie()
        {
            using(SqlConnection conn = new SqlConnection(getConnectionStr()))
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
                    moviesDGV.DataSource = dt;
                    if(dt.Rows.Count == 0)
                    {
                        errorBox.Text = "No result";
                    }
                } catch(Exception e)
                {
                    errorBox.Text = e.Message;
                }
            }
        }

        private void SearchMovie_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
            SearchingMovie();
            if (textBox1.Text == "")
            {
                LoadData();
            }
        }

        private int selectedMovieId = -1;


        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Red;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = moviesDGV.Rows[e.RowIndex];

                // Ensure 'MovieId' exists and get its value
                if (row.Cells["MovieId"].Value != DBNull.Value)
                {
                    selectedMovieId = Convert.ToInt32(row.Cells["MovieId"].Value);
                }
                else
                {
                    MessageBox.Show("MovieId is missing.");
                }
            }
        }



        private void errorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
            if (moviesDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = moviesDGV.SelectedRows[0];
                if (selectedRow.Cells["MovieId"].Value != null)
                {
                    int MovieId = Convert.ToInt32(selectedRow.Cells["MovieId"].Value);
                    using (SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            con.Open();
                            string query = @"
                IF NOT EXISTS (SELECT 1 FROM Favorite_Movies WHERE UserId = @UserId AND MovieId = @MovieId)
                BEGIN
                    INSERT INTO Favorite_Movies (UserId, MovieId) VALUES (@UserId, @MovieId)
                END";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@UserId", Login.UserId); // Use the static UserId
                            cmd.Parameters.AddWithValue("@MovieId", MovieId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Movie added to favorites successfully.");
                            }
                            else
                            {
                                MessageBox.Show("This movie is already in your favorites.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else MessageBox.Show("Selected row does not contain valid 'MovieId'.");
            }
            else MessageBox.Show("Please select a movie to add.");
        }

        private void SearchMovie_Load_1(object sender, EventArgs e)
        {

        }


        private void add_to_watched_btn_Click(object sender, EventArgs e)
        {
            if (moviesDGV.SelectedRows.Count > 0) // Ensure a movie is selected
            {
                DataGridViewRow selectedRow = moviesDGV.SelectedRows[0];

                if (selectedRow.Cells["MovieId"].Value != null) // Ensure MovieId exists
                {
                    int MovieId = Convert.ToInt32(selectedRow.Cells["MovieId"].Value);

                    // Create an instance of the AddToWatchedPopup form
                    AddToWatchedPopup popup = new AddToWatchedPopup();
                    popup.ShowDialog(); // Show the popup and wait for it to close

                    // Check if the user confirmed the action
                    if (popup.IsConfirmed)
                    {
                        int selectedRate = popup.SelectedRate; // Get the rate from the popup

                        // Save to the database
                        using (SqlConnection con = new SqlConnection(getConnectionStr()))
                        {
                            try
                            {
                                con.Open();
                                string query = "INSERT INTO WatchedMovieList (UserId, MovieId, Rate) VALUES (@UserId, @MovieId, @Rate)";
                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.Parameters.AddWithValue("@UserId", Login.UserId);
                                cmd.Parameters.AddWithValue("@MovieId", MovieId);
                                cmd.Parameters.AddWithValue("@Rate", selectedRate);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Movie added to the Watched List successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add movie to the Watched List.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid rate.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a movie to add to the Watched List.");
                }
            }
        }

        private void message_Click(object sender, EventArgs e)
        {

        }
    }
}
