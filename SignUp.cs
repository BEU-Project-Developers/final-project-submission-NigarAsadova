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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }

        private void InsertUsers()
        {
            using (SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "Select COUNT(*) From Users WHERE username = @username AND Password = @Password";
                    SqlCommand cm = new SqlCommand(checkQuery, conn);
                    cm.Parameters.AddWithValue("@username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@Password", codeBox.Text);
                    int count = (int) cm.ExecuteScalar();
                    if(count > 0)
                    {
                        messageBox.Text = "You already have an account";
                    }
                    else
                    {
                        string query = "Insert into Users(username, Password) Values (@username, @Password)";
                        SqlCommand cmm = new SqlCommand(query, conn);
                        cmm.Parameters.AddWithValue("@username", usernameBox.Text);
                        cmm.Parameters.AddWithValue("@Password", codeBox.Text);
                        cmm.ExecuteNonQuery();
                        messageBox.Text = "Success";
                    }

                }
                catch (Exception e)
                {
                    messageBox.Text = "Error";
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            InsertUsers();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void signUpTitle_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
