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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }


        private void AddMovie_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();

                    //getting director id

                    string query = "SELECT DirectorId FROM Directors WHERE FullName = @name";
                    SqlCommand cm = new SqlCommand(query, con);
                    cm.Parameters.AddWithValue("@name", dir_box.Text);
                    int dirId = Convert.ToInt32(cm.ExecuteScalar());
                    DateTime date = Convert.ToDateTime(date_box.Text);

                    // Query to add the movie
                    string addActorQuery = "INSERT INTO Movies (Name, DirectorId, Rating, ReleaseDate, Genre, Description) VALUES" +
                        " (@Name, @DirectorId, @Rating, @ReleaseDate, @Genre, @Description)";
                    SqlCommand addActorCmd = new SqlCommand(addActorQuery, con);
                    addActorCmd.Parameters.AddWithValue("@Name", name_box.Text);
                    addActorCmd.Parameters.AddWithValue("@DirectorId", dirId);
                    addActorCmd.Parameters.AddWithValue("@Rating", rate_box.Value);
                    addActorCmd.Parameters.AddWithValue("@ReleaseDate", date);
                    addActorCmd.Parameters.AddWithValue("@Genre", genre_box.Text);
                    addActorCmd.Parameters.AddWithValue("@Description", desc_box.Text);
                    // Execute the actor insertion query
                    int rowsAffected = addActorCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Movie added successfully.");
                        MoviesData ad = new MoviesData();
                        ad.Update();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to add movie.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
