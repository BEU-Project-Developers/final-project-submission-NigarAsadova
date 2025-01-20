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
            this.add_fav = new System.Windows.Forms.Button();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
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
            this.actors_dgv.Location = new System.Drawing.Point(492, 120);
            this.actors_dgv.Name = "actors_dgv";
            this.actors_dgv.RowHeadersWidth = 51;
            this.actors_dgv.RowTemplate.Height = 24;
            this.actors_dgv.Size = new System.Drawing.Size(659, 300);
            this.actors_dgv.TabIndex = 1;
            // 
            // add_fav
            // 
            this.add_fav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_fav.Location = new System.Drawing.Point(111, 291);
            this.add_fav.Name = "add_fav";
            this.add_fav.Size = new System.Drawing.Size(277, 53);
            this.add_fav.TabIndex = 8;
            this.add_fav.Text = "Add Favorites";
            this.add_fav.UseVisualStyleBackColor = true;
            this.add_fav.Click += new System.EventHandler(this.add_fav_Click);
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
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(111, 217);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(277, 53);
            this.show_btn.TabIndex = 16;
            this.show_btn.Text = "Show Actors";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 502);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.add_fav);
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
        private System.Windows.Forms.Button add_fav;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button show_btn;
    }
}