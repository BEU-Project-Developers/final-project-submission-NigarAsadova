using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Project
{
    public partial class AddMovies : Form
    {
        public AddMovies()
        {
            InitializeComponent();
        }

        private void add_btn_MouseEnter(object sender, EventArgs e)
        {
            add_btn.BackColor = Color.White;
            add_btn.ForeColor = Color.OrangeRed;
        }

        private void add_btn_MouseLeave(object sender, EventArgs e)
        {
            add_btn.BackColor = Color.OrangeRed;
            add_btn.ForeColor = Color.White;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
