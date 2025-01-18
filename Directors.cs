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
    public partial class Directors : Form
    {
        public Directors()
        {
            InitializeComponent();
            remove.MouseEnter += btn_MouseEnter;
            remove.MouseLeave += btn_MouseLeave;
            edit.MouseEnter += btn_MouseEnter;
            edit.MouseLeave += btn_MouseLeave;
            save.MouseEnter += btn_MouseEnter;
            save.MouseLeave += btn_MouseLeave;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
            search_icon.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.Black;
        }

        private void movie_name_Click(object sender, EventArgs e)
        {

        }
    }
}
