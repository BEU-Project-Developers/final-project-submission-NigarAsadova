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
    public partial class SearchMovie : Form
    {
        public SearchMovie()
        {
            InitializeComponent();
            this.Load += SearchMovie_Load;
            textBox1.KeyDown += textBox1_KeyDown;
            home_btn.MouseEnter += btn_MouseEnter;
            home_btn.MouseLeave += btn_MouseLeave;
            add_btn.MouseEnter += btn_MouseEnter;
            add_btn.MouseLeave += btn_MouseLeave;
        }
        private string getConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString;
        }


        private void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "Select * from Movies";
                    SqlDataAdapter data = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    moviesDGV.DataSource = dt;
                } catch(Exception ex)
                {
                    errorBox.Text = ex.Message;

                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchingMovie();
            }
        }

        private void SearchingMovie()
        {
            using(SqlConnection conn = new SqlConnection(getConnectionStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Movies WHERE UPPER(Name) LIKE @Name";
                    SqlCommand cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@Name", "%" + textBox1.Text + "%");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    moviesDGV.DataSource = dt;
                    if(dt.Rows.Count == 0)
                    {
                        errorBox.Text = "No result";
                    }
                } catch(Exception e)
                {
                    errorBox.Text = e.Message;
                }
            }
        }

        private void SearchMovie_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void search_icon_Click(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
            SearchingMovie();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Red;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void errorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
