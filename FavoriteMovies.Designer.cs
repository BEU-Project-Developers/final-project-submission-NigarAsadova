namespace Movies_Project
{
    partial class FavoriteMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteMovies));
            this.fav_movies_dgv = new System.Windows.Forms.DataGridView();
            this.favorite_movies_lb = new System.Windows.Forms.Label();
            this.home_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fav_movies_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fav_movies_dgv
            // 
            this.fav_movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fav_movies_dgv.Location = new System.Drawing.Point(381, 105);
            this.fav_movies_dgv.Name = "fav_movies_dgv";
            this.fav_movies_dgv.RowHeadersWidth = 51;
            this.fav_movies_dgv.RowTemplate.Height = 24;
            this.fav_movies_dgv.Size = new System.Drawing.Size(597, 448);
            this.fav_movies_dgv.TabIndex = 0;
            this.fav_movies_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fav_movies_dgv_CellContentClick);
            // 
            // favorite_movies_lb
            // 
            this.favorite_movies_lb.AutoSize = true;
            this.favorite_movies_lb.BackColor = System.Drawing.Color.Transparent;
            this.favorite_movies_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_movies_lb.ForeColor = System.Drawing.Color.White;
            this.favorite_movies_lb.Location = new System.Drawing.Point(553, 30);
            this.favorite_movies_lb.Name = "favorite_movies_lb";
            this.favorite_movies_lb.Size = new System.Drawing.Size(259, 45);
            this.favorite_movies_lb.TabIndex = 2;
            this.favorite_movies_lb.Text = "Favorite Movies";
            this.favorite_movies_lb.Click += new System.EventHandler(this.favorite_movies_lb_Click);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 38;
            this.home_btn.Text = "Back";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Transparent;
            this.delete_btn.Location = new System.Drawing.Point(536, 572);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(299, 70);
            this.delete_btn.TabIndex = 41;
            this.delete_btn.Text = "Delete from Favorites";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // FavoriteMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1358, 686);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.favorite_movies_lb);
            this.Controls.Add(this.fav_movies_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FavoriteMovies";
            this.Text = "FavoriteMovies";
            ((System.ComponentModel.ISupportInitialize)(this.fav_movies_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fav_movies_dgv;
        private System.Windows.Forms.Label favorite_movies_lb;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}