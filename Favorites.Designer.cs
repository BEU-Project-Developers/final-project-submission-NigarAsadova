namespace Movies_Project
{
    partial class Favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorites));
            this.fav_movies_btn = new System.Windows.Forms.Button();
            this.fav_actors_btn = new System.Windows.Forms.Button();
            this.fav_driectors_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fav_movies_btn
            // 
            this.fav_movies_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fav_movies_btn.Location = new System.Drawing.Point(88, 316);
            this.fav_movies_btn.Name = "fav_movies_btn";
            this.fav_movies_btn.Size = new System.Drawing.Size(241, 71);
            this.fav_movies_btn.TabIndex = 2;
            this.fav_movies_btn.Text = "Favorite Movies";
            this.fav_movies_btn.UseVisualStyleBackColor = true;
            this.fav_movies_btn.Click += new System.EventHandler(this.fav_movies_btn_Click);
            // 
            // fav_actors_btn
            // 
            this.fav_actors_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fav_actors_btn.Location = new System.Drawing.Point(533, 310);
            this.fav_actors_btn.Name = "fav_actors_btn";
            this.fav_actors_btn.Size = new System.Drawing.Size(241, 71);
            this.fav_actors_btn.TabIndex = 3;
            this.fav_actors_btn.Text = "Favorite Actors";
            this.fav_actors_btn.UseVisualStyleBackColor = true;
            this.fav_actors_btn.Click += new System.EventHandler(this.fav_actors_btn_Click);
            // 
            // fav_driectors_btn
            // 
            this.fav_driectors_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fav_driectors_btn.Location = new System.Drawing.Point(971, 310);
            this.fav_driectors_btn.Name = "fav_driectors_btn";
            this.fav_driectors_btn.Size = new System.Drawing.Size(241, 71);
            this.fav_driectors_btn.TabIndex = 4;
            this.fav_driectors_btn.Text = "Favorite Directors";
            this.fav_driectors_btn.UseVisualStyleBackColor = true;
            this.fav_driectors_btn.Click += new System.EventHandler(this.fav_driectors_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 38;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 691);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.fav_driectors_btn);
            this.Controls.Add(this.fav_actors_btn);
            this.Controls.Add(this.fav_movies_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Favorites";
            this.Text = "Favorites";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fav_movies_btn;
        private System.Windows.Forms.Button fav_actors_btn;
        private System.Windows.Forms.Button fav_driectors_btn;
        private System.Windows.Forms.Button home_btn;
    }
}