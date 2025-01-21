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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void back_btn_Click(object sender, EventArgs e)
        {
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            this.Hide();
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
                            string deleteWatchListQuery = "DELETE FROM WatchList WHEREWHERE UserId = @UserId";
                            SqlCommand deleteWatchListmd = new SqlCommand(deleteWatchListQuery, con);
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
                                    errorBox.Text = "";
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

        private void SearchingUser()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserId,username,FullName ,Gmail FROM Users WHERE UPPER(username) LIKE @Name";
                    SqlCommand cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@Name", "%" + textBox1.Text + "%");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    result_dgv.DataSource = dt;
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
            SearchingUser();
            search_icon.BorderStyle = BorderStyle.Fixed3D;
            if (textBox1.Text == "")
            {
                LoadUserData();
            }
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            this.Hide();
        }
    }
}
