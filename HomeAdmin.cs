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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void UserData()
        {
            using(SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT UserId,username,FullName ,Gmail FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    result_dgv.DataSource = dt;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            UserData();
        }
    }
}
