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
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fav_movies_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // fav_movies_dgv
            // 
            this.fav_movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fav_movies_dgv.Location = new System.Drawing.Point(74, 183);
            this.fav_movies_dgv.Name = "fav_movies_dgv";
            this.fav_movies_dgv.RowHeadersWidth = 51;
            this.fav_movies_dgv.RowTemplate.Height = 24;
            this.fav_movies_dgv.Size = new System.Drawing.Size(1202, 370);
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
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(401, 103);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(562, 43);
            this.search_box.TabIndex = 42;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // search_icon
            // 
            this.search_icon.BackColor = System.Drawing.Color.White;
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(969, 103);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(51, 43);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 43;
            this.search_icon.TabStop = false;
            this.search_icon.Click += new System.EventHandler(this.search_icon_Click);
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.Black;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(401, 152);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(486, 20);
            this.errorBox.TabIndex = 44;
            // 
            // FavoriteMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1358, 686);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.favorite_movies_lb);
            this.Controls.Add(this.fav_movies_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FavoriteMovies";
            this.Text = "FavoriteMovies";
            ((System.ComponentModel.ISupportInitialize)(this.fav_movies_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fav_movies_dgv;
        private System.Windows.Forms.Label favorite_movies_lb;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.TextBox errorBox;
    }
}