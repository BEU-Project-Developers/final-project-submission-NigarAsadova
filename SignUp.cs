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
                    string checkQuery = "Select COUNT(*) From Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand cm = new SqlCommand(checkQuery, conn);
                    cm.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@Password", codeBox.Text);
                    int count = (int) cm.ExecuteScalar();
                    if(count > 0)
                    {
                        messageBox.Text = "You already have an account";
                    }
                    else
                    {
                        // Insert a new user into the Users table
                        string query = "INSERT INTO Users (Username, Password, Gmail, FullName) VALUES (@Username, @Password, @Gmail, @FullName)";
                        SqlCommand cmm = new SqlCommand(query, conn);

                        // Add parameters to the SQL query
                        cmm.Parameters.AddWithValue("@Username", usernameBox.Text);
                        cmm.Parameters.AddWithValue("@Password", codeBox.Text);  // Consider hashing the password before storing it
                        cmm.Parameters.AddWithValue("@Gmail", gmailBox.Text);    // Ensure this field is filled correctly
                        cmm.Parameters.AddWithValue("@FullName", nameBox.Text);  // Ensure this field is filled correctly

                        // Execute the query to insert the new user
                        cmm.ExecuteNonQuery();

                        messageBox.Text = "Success! You have been registered.";
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

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
