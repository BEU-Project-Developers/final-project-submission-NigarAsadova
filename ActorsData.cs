using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Movies_Project
{
    public partial class ActorsData : Form
    {
        public ActorsData()
        {
            InitializeComponent();
            searchBar.KeyDown += searchBar_KeyDown;
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadActors();
        }

        // Loading Actors

        private void LoadActors()
        {
            using(SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "Select * FROM Actors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    result_dgv.DataSource = tb;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Deleting actor

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (result_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = result_dgv.SelectedRows[0];
                if (selectedRow.Cells["ActorId"].Value != null)
                {
                    int ActorId = Convert.ToInt32(selectedRow.Cells["ActorId"].Value);
                    MessageBox.Show("Deleting Actor with ID " + ActorId);

                    using(SqlConnection con = new SqlConnection(getConnectionStr()))
                    {
                        try
                        {
                             con.Open();
                            string querySet = "DELETE FROM MoviesSet WHERE ActorId = @ActorId";
                            SqlCommand cmm = new SqlCommand(querySet, con);
                            cmm.Parameters.AddWithValue("@ActorId", ActorId);

                            string query = "DELETE FROM Actors WHERE ActorId = @ActorId";
                            SqlCommand cm = new SqlCommand(query, con);
                            cm.Parameters.AddWithValue("@ActorId", ActorId);

                            int rowsAffected = cm.ExecuteNonQuery();
                            if(rowsAffected > 0)
                            {
                                MessageBox.Show("Actor deleted successfully!!");
                                LoadActors(); // Refreshing
                            }
                            else
                            {
                                MessageBox.Show("Error deleting actor. No actor with the provided ID found.");
                            }
                        } catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain valid 'ActorId'.");
                }
            }
            else MessageBox.Show("Select Actor to delete");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddActors aa = new AddActors();
            aa.ShowDialog();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchingActor();
            }
        }

        private void ActorsData_Load(object sender, EventArgs e)
        {

        }
        
        // Searching Actor

        private void SearchingActor()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "Select * FROM Actors WHERE UPPER(ActorName) LIKE @Name";
                    SqlCommand cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@Name", "%" + searchBar.Text + "%");
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
            SearchingActor();
            search_icon.BorderStyle = BorderStyle.Fixed3D;
            if(searchBar.Text == "")
            {
                LoadActors();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            this.Hide();
        }

        private void result_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
