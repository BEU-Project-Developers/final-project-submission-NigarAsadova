namespace Movies_Project
{
    partial class AddActors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActors));
            this.name_box = new System.Windows.Forms.TextBox();
            this.movieName_box = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.name_lb = new System.Windows.Forms.Label();
            this.movie_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(135, 115);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(305, 34);
            this.name_box.TabIndex = 10;
            // 
            // movieName_box
            // 
            this.movieName_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName_box.Location = new System.Drawing.Point(135, 196);
            this.movieName_box.Name = "movieName_box";
            this.movieName_box.Size = new System.Drawing.Size(305, 34);
            this.movieName_box.TabIndex = 11;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(182, 278);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(170, 49);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.ForeColor = System.Drawing.Color.Red;
            this.name_lb.Location = new System.Drawing.Point(140, 84);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(117, 28);
            this.name_lb.TabIndex = 16;
            this.name_lb.Text = "Actor Name";
            // 
            // movie_lb
            // 
            this.movie_lb.AutoSize = true;
            this.movie_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_lb.ForeColor = System.Drawing.Color.Red;
            this.movie_lb.Location = new System.Drawing.Point(140, 165);
            this.movie_lb.Name = "movie_lb";
            this.movie_lb.Size = new System.Drawing.Size(124, 28);
            this.movie_lb.TabIndex = 17;
            this.movie_lb.Text = "Movie Name";
            // 
            // AddActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.movie_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.movieName_box);
            this.Controls.Add(this.name_box);
            this.Name = "AddActors";
            this.Text = "AddActors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox movieName_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label movie_lb;
    }
}