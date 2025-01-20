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
    public partial class Watched : Form
    {
        public Watched()
        {
            InitializeComponent();
            this.Load += LoadingMovies;
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void Watched_Load(object sender, EventArgs e)
        {

        }
        private void LoadMovies()
        {
            using (SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MovieId, Name, Genre, Rating FROM Movies";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    movies_dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadingMovies(object sender, EventArgs e)
        {
            LoadMovies();
        }

    }
}
