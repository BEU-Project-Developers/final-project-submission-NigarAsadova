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
    public partial class Actors : Form
    {
        public Actors()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void LoadActors()
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT a.ActorName, m.Name As 'Movie', m.Rating, m.ReleaseDate, m.Genre, m.Description, a.ActorId " +
                        "FROM Actors a LEFT JOIN MoviesSet ms ON a.ActorId = ms.ActorId " +
                        "LEFT JOIN Movies m ON ms.MovieId = m.MovieId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    actors_dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadActors();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Actors_Load(object sender, EventArgs e)
        {
           
        }

        private void add_fav_Click(object sender, EventArgs e)
        {
            if(actors_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = actors_dgv.SelectedRows[0];
                if (selectedRow.Cells["ActorId"].Value != null)
                {
                    int ActorId = Convert.ToInt32(selectedRow.Cells["ActorId"].Value);
                    using(SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            con.Open();
                            string query = @"
                IF NOT EXISTS (SELECT 1 FROM Favorite_Actors WHERE UserId = @UserId AND ActorId = @ActorId)
                BEGIN
                    INSERT INTO Favorite_Actors (UserId, ActorId) VALUES (@UserId, @ActorId)
                END";
                            SqlCommand com = new SqlCommand(query, con);
                            com.Parameters.AddWithValue("@UserId", Login.UserId);
                            com.Parameters.AddWithValue("@ActorId", ActorId);
                            int rowsAffected = com.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Actor added into Favorite_Actors successfully.");
                                LoadActors();  // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Error adding actor. No actor with the provided ID found.");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                } else MessageBox.Show("Selected row does not contain valid 'ActorId'.");
            } else MessageBox.Show("Please select an actor to add.");
        }
    }
}
