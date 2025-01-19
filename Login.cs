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
    public partial class Login : Form
    {

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
                    string checkQuery = "Select COUNT(*) From Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand cm = new SqlCommand(checkQuery, conn);
                    cm.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cm.Parameters.AddWithValue("@Password", codeBox.Text) ;

                    int count = (int) cm.ExecuteScalar();
                    if (count > 0) showMovie();
                    else error_msgBox.Text = "sign up first";
                } catch(Exception e)
                {
                    error_msgBox.Text = "Error";
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
    }
}
