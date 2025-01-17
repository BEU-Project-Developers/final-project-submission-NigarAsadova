namespace Movies_Project
{
    partial class FavoritesDirectors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesDirectors));
            this.back_btn = new System.Windows.Forms.Button();
            this.favorite_directors_lb = new System.Windows.Forms.Label();
            this.fav_driectors_dgv = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fav_driectors_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 53);
            this.back_btn.TabIndex = 42;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // favorite_directors_lb
            // 
            this.favorite_directors_lb.AutoSize = true;
            this.favorite_directors_lb.BackColor = System.Drawing.Color.Transparent;
            this.favorite_directors_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_directors_lb.ForeColor = System.Drawing.Color.White;
            this.favorite_directors_lb.Location = new System.Drawing.Point(561, 36);
            this.favorite_directors_lb.Name = "favorite_directors_lb";
            this.favorite_directors_lb.Size = new System.Drawing.Size(287, 45);
            this.favorite_directors_lb.TabIndex = 41;
            this.favorite_directors_lb.Text = "Favorite Directors";
            // 
            // fav_driectors_dgv
            // 
            this.fav_driectors_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fav_driectors_dgv.Location = new System.Drawing.Point(381, 129);
            this.fav_driectors_dgv.Name = "fav_driectors_dgv";
            this.fav_driectors_dgv.RowHeadersWidth = 51;
            this.fav_driectors_dgv.RowTemplate.Height = 24;
            this.fav_driectors_dgv.Size = new System.Drawing.Size(622, 448);
            this.fav_driectors_dgv.TabIndex = 39;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Transparent;
            this.delete_btn.Location = new System.Drawing.Point(549, 595);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(299, 70);
            this.delete_btn.TabIndex = 43;
            this.delete_btn.Text = "Delete from Favorites";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // FavoritesDirectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 696);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.favorite_directors_lb);
            this.Controls.Add(this.fav_driectors_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FavoritesDirectors";
            this.Text = "FavoritesDirectors";
            ((System.ComponentModel.ISupportInitialize)(this.fav_driectors_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label favorite_directors_lb;
        private System.Windows.Forms.DataGridView fav_driectors_dgv;
        private System.Windows.Forms.Button delete_btn;
    }
}