namespace Movies_Project
{
    partial class Actors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actors));
            this.search_box = new System.Windows.Forms.TextBox();
            this.actors_dgv = new System.Windows.Forms.DataGridView();
            this.name_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.movie_name_box = new System.Windows.Forms.TextBox();
            this.role_box = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.movie_name = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actors_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(350, 49);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(659, 38);
            this.search_box.TabIndex = 0;
            // 
            // actors_dgv
            // 
            this.actors_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actors_dgv.Location = new System.Drawing.Point(597, 125);
            this.actors_dgv.Name = "actors_dgv";
            this.actors_dgv.RowHeadersWidth = 51;
            this.actors_dgv.RowTemplate.Height = 24;
            this.actors_dgv.Size = new System.Drawing.Size(659, 455);
            this.actors_dgv.TabIndex = 1;
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(153, 141);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(339, 38);
            this.name_box.TabIndex = 2;
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_box.Location = new System.Drawing.Point(153, 227);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(339, 38);
            this.date_box.TabIndex = 3;
            // 
            // movie_name_box
            // 
            this.movie_name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_box.Location = new System.Drawing.Point(153, 313);
            this.movie_name_box.Name = "movie_name_box";
            this.movie_name_box.Size = new System.Drawing.Size(339, 38);
            this.movie_name_box.TabIndex = 4;
            // 
            // role_box
            // 
            this.role_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_box.Location = new System.Drawing.Point(153, 404);
            this.role_box.Name = "role_box";
            this.role_box.Size = new System.Drawing.Size(339, 38);
            this.role_box.TabIndex = 5;
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(178, 505);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(137, 53);
            this.edit.TabIndex = 6;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(318, 505);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(137, 53);
            this.remove.TabIndex = 7;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(178, 564);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(277, 53);
            this.save.TabIndex = 8;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.BackColor = System.Drawing.Color.Black;
            this.fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.White;
            this.fullname.Location = new System.Drawing.Point(34, 146);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(100, 28);
            this.fullname.TabIndex = 9;
            this.fullname.Text = "Full Name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Black;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(12, 232);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(122, 28);
            this.date.TabIndex = 10;
            this.date.Text = "Date of Birth";
            // 
            // movie_name
            // 
            this.movie_name.AutoSize = true;
            this.movie_name.BackColor = System.Drawing.Color.Black;
            this.movie_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.ForeColor = System.Drawing.Color.White;
            this.movie_name.Location = new System.Drawing.Point(10, 318);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(124, 28);
            this.movie_name.TabIndex = 11;
            this.movie_name.Text = "Movie Name";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.Black;
            this.role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(84, 409);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(50, 28);
            this.role.TabIndex = 12;
            this.role.Text = "Role";
            // 
            // search_icon
            // 
            this.search_icon.BackColor = System.Drawing.Color.White;
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(1002, 49);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(51, 38);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 13;
            this.search_icon.TabStop = false;
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 23);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 14;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1389, 687);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.role);
            this.Controls.Add(this.movie_name);
            this.Controls.Add(this.date);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.save);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.role_box);
            this.Controls.Add(this.movie_name_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.actors_dgv);
            this.Controls.Add(this.search_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Actors";
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.Actors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actors_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.DataGridView actors_dgv;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.TextBox movie_name_box;
        private System.Windows.Forms.TextBox role_box;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label movie_name;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.Button home_btn;
    }
}