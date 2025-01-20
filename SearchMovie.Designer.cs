namespace Movies_Project
{
    partial class SearchMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMovie));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.moviesDGV = new System.Windows.Forms.DataGridView();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.add_to_watched_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(418, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // moviesDGV
            // 
            this.moviesDGV.BackgroundColor = System.Drawing.Color.Black;
            this.moviesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDGV.Location = new System.Drawing.Point(297, 162);
            this.moviesDGV.Name = "moviesDGV";
            this.moviesDGV.RowHeadersWidth = 51;
            this.moviesDGV.RowTemplate.Height = 24;
            this.moviesDGV.Size = new System.Drawing.Size(850, 327);
            this.moviesDGV.TabIndex = 1;
            this.moviesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_icon
            // 
            this.search_icon.BackColor = System.Drawing.Color.White;
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(977, 73);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(51, 43);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 2;
            this.search_icon.TabStop = false;
            this.search_icon.Click += new System.EventHandler(this.search_icon_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Tomato;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(109, 53);
            this.home_btn.TabIndex = 15;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            this.home_btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.home_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Red;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(486, 522);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(193, 53);
            this.add_btn.TabIndex = 16;
            this.add_btn.Text = "Add To Favorites";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.Black;
            this.desc.Location = new System.Drawing.Point(414, 45);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(278, 20);
            this.desc.TabIndex = 17;
            this.desc.Text = "Search movie and add to your favorites";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(426, 119);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 20);
            this.message.TabIndex = 18;
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.Tan;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(418, 122);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(100, 20);
            this.errorBox.TabIndex = 19;
            this.errorBox.TextChanged += new System.EventHandler(this.errorBox_TextChanged);
            // 
            // add_to_watched_btn
            // 
            this.add_to_watched_btn.BackColor = System.Drawing.Color.Red;
            this.add_to_watched_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_to_watched_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_watched_btn.Location = new System.Drawing.Point(739, 522);
            this.add_to_watched_btn.Name = "add_to_watched_btn";
            this.add_to_watched_btn.Size = new System.Drawing.Size(241, 53);
            this.add_to_watched_btn.TabIndex = 20;
            this.add_to_watched_btn.Text = "Add To Watched List";
            this.add_to_watched_btn.UseVisualStyleBackColor = false;
            this.add_to_watched_btn.Click += new System.EventHandler(this.add_to_watched_btn_Click);
            // 
            // SearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 692);
            this.Controls.Add(this.add_to_watched_btn);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.moviesDGV);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchMovie";
            this.Text = "SearchMovie";
            this.Load += new System.EventHandler(this.SearchMovie_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView moviesDGV;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Button add_to_watched_btn;
    }
}