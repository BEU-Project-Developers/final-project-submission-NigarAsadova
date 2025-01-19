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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void checkAdmin()
        {
            using(SqlConnection connection= new SqlConnection(getConnectionStr()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT AdminId FROM Admins WHERE Username = @Username AND Password = @Password";
                    SqlCommand cm = new SqlCommand(query, connection);
                    cm.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@Password", codeBox.Text);
                    object count = cm.ExecuteScalar();
                    if(count != null)
                    {
                        HomeAdmin homeAdmin = new HomeAdmin();
                        this.Hide();
                        homeAdmin.Show();
                    }
                    else
                    {
                        error_msgBox.Text = "Please enter correct username or password";
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            checkAdmin();  
        }

        private void error_msgBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
