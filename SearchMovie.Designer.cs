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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 327);
            this.dataGridView1.TabIndex = 1;
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
            this.add_btn.Location = new System.Drawing.Point(633, 525);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(193, 53);
            this.add_btn.TabIndex = 16;
            this.add_btn.Text = "Add To Favorites";
            this.add_btn.UseVisualStyleBackColor = false;
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
            // SearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 692);
            this.Controls.Add(this.message);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchMovie";
            this.Text = "SearchMovie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label message;
    }
}