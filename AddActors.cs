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
    public partial class AddActors : Form
    {
        public AddActors()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();

                    // Query to check if the movie exists
                    string movieCheckQuery = "SELECT COUNT(*) FROM Movies WHERE Name = @MovieName";
                    SqlCommand movieCheckCmd = new SqlCommand(movieCheckQuery, con);
                    movieCheckCmd.Parameters.AddWithValue("@MovieName", movieName_box.Text);

                    int movieExists = (int)movieCheckCmd.ExecuteScalar(); // Check if the movie exists

                    if (movieExists == 0)
                    {
                        // If the movie does not exist, show an error and exit
                        MessageBox.Show("Error: The specified movie does not exist. Please add the movie first.");
                        return; // Stop further execution
                    }

                    // Query to add the actor
                    string addActorQuery = "INSERT INTO Actors (ActorName) VALUES (@ActorName)";
                    SqlCommand addActorCmd = new SqlCommand(addActorQuery, con);
                    addActorCmd.Parameters.AddWithValue("@ActorName", name_box.Text);

                    // Execute the actor insertion query
                    int rowsAffected = addActorCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Actor added successfully.");
                        ActorsData ad = new ActorsData();
                        ad.Update();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to add actor.");
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
