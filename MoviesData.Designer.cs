namespace Movies_Project
{
    partial class MoviesData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesData));
            this.movies_dgv = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.reload_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.movies_lb = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // movies_dgv
            // 
            this.movies_dgv.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movies_dgv.Location = new System.Drawing.Point(327, 101);
            this.movies_dgv.Name = "movies_dgv";
            this.movies_dgv.RowHeadersWidth = 51;
            this.movies_dgv.RowTemplate.Height = 24;
            this.movies_dgv.Size = new System.Drawing.Size(768, 400);
            this.movies_dgv.TabIndex = 0;
            this.movies_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movies_dgv_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(61, 206);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(219, 53);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // reload_btn
            // 
            this.reload_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload_btn.Location = new System.Drawing.Point(61, 280);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(219, 48);
            this.reload_btn.TabIndex = 2;
            this.reload_btn.Text = "Reload";
            this.reload_btn.UseVisualStyleBackColor = true;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(61, 355);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(219, 48);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // movies_lb
            // 
            this.movies_lb.AutoSize = true;
            this.movies_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movies_lb.Location = new System.Drawing.Point(229, 46);
            this.movies_lb.Name = "movies_lb";
            this.movies_lb.Size = new System.Drawing.Size(130, 46);
            this.movies_lb.TabIndex = 4;
            this.movies_lb.Text = "Movies";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 31);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.Tan;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(406, 75);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(610, 20);
            this.errorBox.TabIndex = 23;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(414, 72);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 20);
            this.message.TabIndex = 22;
            // 
            // search_icon
            // 
            this.search_icon.BackColor = System.Drawing.Color.White;
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(965, 26);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(51, 43);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 21;
            this.search_icon.TabStop = false;
            this.search_icon.Click += new System.EventHandler(this.search_icon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(406, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 43);
            this.textBox1.TabIndex = 20;
            // 
            // MoviesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 548);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.search_icon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.movies_lb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reload_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.movies_dgv);
            this.Name = "MoviesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviesData";
            this.Load += new System.EventHandler(this.MoviesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movies_dgv;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button reload_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label movies_lb;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.TextBox textBox1;
    }
}