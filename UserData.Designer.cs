namespace Movies_Project
{
    partial class UserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserData));
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.result_dgv = new System.Windows.Forms.DataGridView();
            this.userDataLb = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_btn.Location = new System.Drawing.Point(19, 324);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(156, 52);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(19, 251);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(156, 52);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // result_dgv
            // 
            this.result_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dgv.Location = new System.Drawing.Point(195, 44);
            this.result_dgv.Name = "result_dgv";
            this.result_dgv.RowHeadersWidth = 51;
            this.result_dgv.RowTemplate.Height = 24;
            this.result_dgv.Size = new System.Drawing.Size(572, 364);
            this.result_dgv.TabIndex = 11;
            // 
            // userDataLb
            // 
            this.userDataLb.AutoSize = true;
            this.userDataLb.BackColor = System.Drawing.Color.White;
            this.userDataLb.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataLb.Location = new System.Drawing.Point(22, 27);
            this.userDataLb.Name = "userDataLb";
            this.userDataLb.Size = new System.Drawing.Size(137, 60);
            this.userDataLb.TabIndex = 12;
            this.userDataLb.Text = "Users";
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.show_btn.Location = new System.Drawing.Point(19, 175);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(156, 52);
            this.show_btn.TabIndex = 13;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.userDataLb);
            this.Controls.Add(this.result_dgv);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "UserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserData";
            this.Load += new System.EventHandler(this.UserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView result_dgv;
        private System.Windows.Forms.Label userDataLb;
        private System.Windows.Forms.Button show_btn;
    }
}