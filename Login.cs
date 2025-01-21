using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Project
{
    public partial class Login : Form
    {

        public static int UserId { get; private set; }



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
                        // Assign the retrieved UserId to the static UserId property
                        UserId = Convert.ToInt32(result);
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



        public Login()
        {
            InitializeComponent();
            
        }


        private void loginTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void showMovie()
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void user_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            checkUsers();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser();
            aou.Show();
            this.Hide();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
