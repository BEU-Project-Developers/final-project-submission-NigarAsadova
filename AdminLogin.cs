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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void checkUsers()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "Select UserId From Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand cm = new SqlCommand(checkQuery, conn);
                    cm.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@Password", codeBox.Text);

                    // Retrieve UserId 
                    object result = cm.ExecuteScalar();

                    if (result != null)
                    {
                        showMovie();  // After login, show the movie screen and load data for the current user
                    }
                    else
                    {
                        error_msgBox.Text = "Sign up first";
                    }
                }
                catch (Exception e)
                {
                    error_msgBox.Text = "Error: " + e.Message;
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
