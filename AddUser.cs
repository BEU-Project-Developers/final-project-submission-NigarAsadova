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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }


        private void AddUser_Load(object sender, EventArgs e)
        {


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Users (Username, Password, Gmail, FullName) VALUES(" +
                        "@Username, @Password, @Gmail, @FullName)";
                    SqlCommand cm = new SqlCommand(query, con);
                    cm.Parameters.AddWithValue("@Username", username_box.Text);
                    cm.Parameters.AddWithValue("@Password", password_box.Text);
                    cm.Parameters.AddWithValue("@Gmail", gmail_box.Text);
                    cm.Parameters.AddWithValue("@FullName", fullname_box.Text);
                    int rowsAffected = cm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        UserData ud = new UserData();
                        ud.Update();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("There is a problem");
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
