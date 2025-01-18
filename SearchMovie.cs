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
    public partial class SearchMovie : Form
    {
        public SearchMovie()
        {
            InitializeComponent();

            home_btn.MouseEnter += btn_MouseEnter;
            home_btn.MouseLeave += btn_MouseLeave;
            add_btn.MouseEnter += btn_MouseEnter;
            add_btn.MouseLeave += btn_MouseLeave;
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
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

    }
}
