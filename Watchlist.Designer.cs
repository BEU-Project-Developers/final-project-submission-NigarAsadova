namespace Movies_Project
{
    partial class Watchlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watchlist));
            this.watchlist_dgv = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.watchlist_lb = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // watchlist_dgv
            // 
            this.watchlist_dgv.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.watchlist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchlist_dgv.Location = new System.Drawing.Point(47, 91);
            this.watchlist_dgv.Name = "watchlist_dgv";
            this.watchlist_dgv.RowHeadersWidth = 51;
            this.watchlist_dgv.RowTemplate.Height = 24;
            this.watchlist_dgv.Size = new System.Drawing.Size(732, 186);
            this.watchlist_dgv.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(317, 351);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(189, 53);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // watchlist_lb
            // 
            this.watchlist_lb.AutoSize = true;
            this.watchlist_lb.BackColor = System.Drawing.Color.Transparent;
            this.watchlist_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchlist_lb.Location = new System.Drawing.Point(308, 25);
            this.watchlist_lb.Name = "watchlist_lb";
            this.watchlist_lb.Size = new System.Drawing.Size(177, 50);
            this.watchlist_lb.TabIndex = 2;
            this.watchlist_lb.Text = "Watchlist";
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(317, 292);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(189, 53);
            this.show_btn.TabIndex = 3;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.watchlist_lb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.watchlist_dgv);
            this.Name = "Watchlist";
            this.Text = "Watchlist";
            this.Load += new System.EventHandler(this.Watchlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView watchlist_dgv;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label watchlist_lb;
        private System.Windows.Forms.Button show_btn;
    }
}