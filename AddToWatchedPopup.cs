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
    public partial class AddToWatchedPopup : Form
    {
        public int SelectedRate { get; private set; }
        public bool IsConfirmed { get; private set; }
        public AddToWatchedPopup()
        {
            InitializeComponent();
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            IsConfirmed = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SelectedRate = Convert.ToInt32(rate_numeric.Value);  // Get the selected rate
            IsConfirmed = true;
            MessageBox.Show( ", Rate: " + SelectedRate.ToString());  // Debugging line
            this.Hide();  // Close the popup
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Hide();  // Close the popup
        }

        private void AddToWatchedPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
