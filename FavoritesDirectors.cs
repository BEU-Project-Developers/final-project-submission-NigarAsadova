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
    public partial class FavoritesDirectors : Form
    {
        public FavoritesDirectors()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Favorites favs = new Favorites();
            favs.Show();
            this.Hide();
        }
    }
}
