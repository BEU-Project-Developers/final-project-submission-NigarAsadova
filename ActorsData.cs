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

namespace Movies_Project
{
    public partial class ActorsData : Form
    {
        public ActorsData()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            LoadActors();
        }

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
                                MessageBox.Show("Error deleting movie. No actor with the provided ID found.");
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
    }
}
