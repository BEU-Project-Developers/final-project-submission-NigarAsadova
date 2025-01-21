namespace Movies_Project
{
    partial class FavoriteActors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteActors));
            this.home_btn = new System.Windows.Forms.Button();
            this.favorite_actors_lb = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.fav_actors_dgv = new System.Windows.Forms.DataGridView();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fav_actors_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 42;
            this.home_btn.Text = "Back";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // favorite_actors_lb
            // 
            this.favorite_actors_lb.AutoSize = true;
            this.favorite_actors_lb.BackColor = System.Drawing.Color.Transparent;
            this.favorite_actors_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_actors_lb.ForeColor = System.Drawing.Color.White;
            this.favorite_actors_lb.Location = new System.Drawing.Point(538, 67);
            this.favorite_actors_lb.Name = "favorite_actors_lb";
            this.favorite_actors_lb.Size = new System.Drawing.Size(246, 45);
            this.favorite_actors_lb.TabIndex = 41;
            this.favorite_actors_lb.Text = "Favorite Actors";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Transparent;
            this.delete_btn.Location = new System.Drawing.Point(351, 614);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(299, 51);
            this.delete_btn.TabIndex = 40;
            this.delete_btn.Text = "Delete from Favorites";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // fav_actors_dgv
            // 
            this.fav_actors_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fav_actors_dgv.Location = new System.Drawing.Point(351, 172);
            this.fav_actors_dgv.Name = "fav_actors_dgv";
            this.fav_actors_dgv.RowHeadersWidth = 51;
            this.fav_actors_dgv.RowTemplate.Height = 24;
            this.fav_actors_dgv.Size = new System.Drawing.Size(654, 398);
            this.fav_actors_dgv.TabIndex = 39;
            this.fav_actors_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fav_actors_dgv_CellContentClick);
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.Red;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.ForeColor = System.Drawing.Color.Transparent;
            this.show_btn.Location = new System.Drawing.Point(706, 614);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(299, 51);
            this.show_btn.TabIndex = 43;
            this.show_btn.Text = "Show Favorite Actors";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // FavoriteActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 702);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.favorite_actors_lb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.fav_actors_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FavoriteActors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FavoriteActors";
            ((System.ComponentModel.ISupportInitialize)(this.fav_actors_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label favorite_actors_lb;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView fav_actors_dgv;
        private System.Windows.Forms.Button show_btn;
    }
}