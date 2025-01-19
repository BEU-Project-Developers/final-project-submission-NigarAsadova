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
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT UserId,username,FullName ,Gmail FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    result_dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (result_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = result_dgv.SelectedRows[0];

                // Ensure the UserId cell exists and is not null
                if (selectedRow.Cells["UserId"].Value != null &&
                    int.TryParse(selectedRow.Cells["UserId"].Value.ToString(), out int userId))
                {
                    using (SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                            con.Open();
                            // Delete related records in Favorite_Movies
                            string deleteFavoritesQuery = "DELETE FROM Favorite_Movies WHERE UserId = @UserId";
                            SqlCommand deleteFavoritesCmd = new SqlCommand(deleteFavoritesQuery, con);
                            deleteFavoritesCmd.Parameters.AddWithValue("@UserId", userId);
                            deleteFavoritesCmd.ExecuteNonQuery();

                            //Delete records from User
                            string query = "DELETE FROM Users WHERE UserId = @UserId";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@UserId", userId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User deleted successfully.");
                                    LoadUserData(); // Refresh DataGridView
                                }
                                else
                                {
                                    MessageBox.Show("No user found with the specified ID.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting user: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid UserId.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user row to delete.");
            }
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
        }
    }
}
