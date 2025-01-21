namespace Movies_Project
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.name_box = new System.Windows.Forms.TextBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.director_lb = new System.Windows.Forms.Label();
            this.dir_box = new System.Windows.Forms.TextBox();
            this.rate_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.TextBox();
            this.genre_lb = new System.Windows.Forms.Label();
            this.genre_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.rate_box = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.bdate_lb = new System.Windows.Forms.Label();
            this.bdate_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rate_box)).BeginInit();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(28, 60);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(233, 38);
            this.name_box.TabIndex = 0;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(28, 37);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(125, 20);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "Name Of Movie";
            // 
            // director_lb
            // 
            this.director_lb.AutoSize = true;
            this.director_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director_lb.Location = new System.Drawing.Point(24, 116);
            this.director_lb.Name = "director_lb";
            this.director_lb.Size = new System.Drawing.Size(142, 20);
            this.director_lb.TabIndex = 3;
            this.director_lb.Text = "Name Of Director";
            // 
            // dir_box
            // 
            this.dir_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir_box.Location = new System.Drawing.Point(24, 139);
            this.dir_box.Name = "dir_box";
            this.dir_box.Size = new System.Drawing.Size(233, 38);
            this.dir_box.TabIndex = 2;
            // 
            // rate_lb
            // 
            this.rate_lb.AutoSize = true;
            this.rate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_lb.Location = new System.Drawing.Point(28, 260);
            this.rate_lb.Name = "rate_lb";
            this.rate_lb.Size = new System.Drawing.Size(44, 20);
            this.rate_lb.TabIndex = 5;
            this.rate_lb.Text = "Rate";
            this.rate_lb.Click += new System.EventHandler(this.label2_Click);
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(371, 39);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(111, 20);
            this.date_lb.TabIndex = 7;
            this.date_lb.Text = "Release Date";
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_box.Location = new System.Drawing.Point(371, 62);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(233, 38);
            this.date_box.TabIndex = 6;
            // 
            // genre_lb
            // 
            this.genre_lb.AutoSize = true;
            this.genre_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lb.Location = new System.Drawing.Point(371, 130);
            this.genre_lb.Name = "genre_lb";
            this.genre_lb.Size = new System.Drawing.Size(55, 20);
            this.genre_lb.TabIndex = 9;
            this.genre_lb.Text = "Genre";
            // 
            // genre_box
            // 
            this.genre_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_box.Location = new System.Drawing.Point(371, 153);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(233, 38);
            this.genre_box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // desc_box
            // 
            this.desc_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_box.Location = new System.Drawing.Point(371, 248);
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(233, 38);
            this.desc_box.TabIndex = 10;
            // 
            // rate_box
            // 
            this.rate_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_box.Location = new System.Drawing.Point(33, 291);
            this.rate_box.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate_box.Name = "rate_box";
            this.rate_box.Size = new System.Drawing.Size(120, 30);
            this.rate_box.TabIndex = 12;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_btn.Location = new System.Drawing.Point(257, 322);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(154, 37);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // bdate_lb
            // 
            this.bdate_lb.AutoSize = true;
            this.bdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_lb.Location = new System.Drawing.Point(28, 192);
            this.bdate_lb.Name = "bdate_lb";
            this.bdate_lb.Size = new System.Drawing.Size(197, 20);
            this.bdate_lb.TabIndex = 15;
            this.bdate_lb.Text = "Directors\'s Date Of Birth";
            // 
            // bdate_box
            // 
            this.bdate_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_box.Location = new System.Drawing.Point(24, 215);
            this.bdate_box.Name = "bdate_box";
            this.bdate_box.Size = new System.Drawing.Size(233, 38);
            this.bdate_box.TabIndex = 14;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 386);
            this.Controls.Add(this.bdate_lb);
            this.Controls.Add(this.bdate_box);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.rate_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desc_box);
            this.Controls.Add(this.genre_lb);
            this.Controls.Add(this.genre_box);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.rate_lb);
            this.Controls.Add(this.director_lb);
            this.Controls.Add(this.dir_box);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.name_box);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rate_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label director_lb;
        private System.Windows.Forms.TextBox dir_box;
        private System.Windows.Forms.Label rate_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.Label genre_lb;
        private System.Windows.Forms.TextBox genre_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc_box;
        private System.Windows.Forms.NumericUpDown rate_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label bdate_lb;
        private System.Windows.Forms.TextBox bdate_box;
    }
}