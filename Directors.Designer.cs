namespace Movies_Project
{
    partial class Directors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directors));
            this.home_btn = new System.Windows.Forms.Button();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.movie_name = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.movie_name_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.directors_dgv = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directors_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 29;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // search_icon
            // 
            this.search_icon.BackColor = System.Drawing.Color.White;
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(1048, 78);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(51, 38);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 28;
            this.search_icon.TabStop = false;
            this.search_icon.Click += new System.EventHandler(this.search_icon_Click);
            // 
            // movie_name
            // 
            this.movie_name.AutoSize = true;
            this.movie_name.BackColor = System.Drawing.Color.Black;
            this.movie_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.ForeColor = System.Drawing.Color.White;
            this.movie_name.Location = new System.Drawing.Point(66, 382);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(124, 28);
            this.movie_name.TabIndex = 26;
            this.movie_name.Text = "Movie Name";
            this.movie_name.Click += new System.EventHandler(this.movie_name_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Black;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(68, 296);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(122, 28);
            this.date.TabIndex = 25;
            this.date.Text = "Date of Birth";
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.BackColor = System.Drawing.Color.Black;
            this.fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.White;
            this.fullname.Location = new System.Drawing.Point(90, 210);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(100, 28);
            this.fullname.TabIndex = 24;
            this.fullname.Text = "Full Name";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Red;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(209, 528);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(277, 53);
            this.save.TabIndex = 23;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.Black;
            this.remove.Location = new System.Drawing.Point(349, 469);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(137, 53);
            this.remove.TabIndex = 22;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Red;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(209, 469);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(137, 53);
            this.edit.TabIndex = 21;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // movie_name_box
            // 
            this.movie_name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_box.Location = new System.Drawing.Point(209, 377);
            this.movie_name_box.Name = "movie_name_box";
            this.movie_name_box.Size = new System.Drawing.Size(339, 38);
            this.movie_name_box.TabIndex = 19;
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_box.Location = new System.Drawing.Point(209, 291);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(339, 38);
            this.date_box.TabIndex = 18;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(209, 205);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(339, 38);
            this.name_box.TabIndex = 17;
            // 
            // directors_dgv
            // 
            this.directors_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directors_dgv.Location = new System.Drawing.Point(643, 154);
            this.directors_dgv.Name = "directors_dgv";
            this.directors_dgv.RowHeadersWidth = 51;
            this.directors_dgv.RowTemplate.Height = 24;
            this.directors_dgv.Size = new System.Drawing.Size(659, 455);
            this.directors_dgv.TabIndex = 16;
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(396, 78);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(659, 38);
            this.search_box.TabIndex = 15;
            // 
            // Directors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 699);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.movie_name);
            this.Controls.Add(this.date);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.save);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.movie_name_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.directors_dgv);
            this.Controls.Add(this.search_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Directors";
            this.Text = "Directors";
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directors_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.Label movie_name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox movie_name_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.DataGridView directors_dgv;
        private System.Windows.Forms.TextBox search_box;
    }
}