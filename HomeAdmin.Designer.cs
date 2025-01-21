namespace Movies_Project
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.users_btn = new System.Windows.Forms.Button();
            this.Actors_btn = new System.Windows.Forms.Button();
            this.movies_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // users_btn
            // 
            this.users_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.Location = new System.Drawing.Point(46, 114);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(479, 56);
            this.users_btn.TabIndex = 1;
            this.users_btn.Text = "Users";
            this.users_btn.UseVisualStyleBackColor = true;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // Actors_btn
            // 
            this.Actors_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Actors_btn.Location = new System.Drawing.Point(46, 196);
            this.Actors_btn.Name = "Actors_btn";
            this.Actors_btn.Size = new System.Drawing.Size(479, 56);
            this.Actors_btn.TabIndex = 2;
            this.Actors_btn.Text = "Actors";
            this.Actors_btn.UseVisualStyleBackColor = true;
            this.Actors_btn.Click += new System.EventHandler(this.Actors_btn_Click);
            // 
            // movies_btn
            // 
            this.movies_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.movies_btn.Location = new System.Drawing.Point(46, 286);
            this.movies_btn.Name = "movies_btn";
            this.movies_btn.Size = new System.Drawing.Size(479, 56);
            this.movies_btn.TabIndex = 3;
            this.movies_btn.Text = "Movies";
            this.movies_btn.UseVisualStyleBackColor = true;
            this.movies_btn.Click += new System.EventHandler(this.movies_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(477, 483);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 31);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 543);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.movies_btn);
            this.Controls.Add(this.Actors_btn);
            this.Controls.Add(this.users_btn);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button Actors_btn;
        private System.Windows.Forms.Button movies_btn;
        private System.Windows.Forms.Button back_btn;
    }
}