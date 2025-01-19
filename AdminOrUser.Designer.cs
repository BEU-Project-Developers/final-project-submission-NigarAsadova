namespace Movies_Project
{
    partial class AdminOrUser
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
            this.admin_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.adminoruserlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(114, 247);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(236, 76);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.user_btn.Location = new System.Drawing.Point(432, 247);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(236, 76);
            this.user_btn.TabIndex = 1;
            this.user_btn.Text = "User";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // adminoruserlb
            // 
            this.adminoruserlb.AutoSize = true;
            this.adminoruserlb.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminoruserlb.ForeColor = System.Drawing.Color.Snow;
            this.adminoruserlb.Location = new System.Drawing.Point(296, 118);
            this.adminoruserlb.Name = "adminoruserlb";
            this.adminoruserlb.Size = new System.Drawing.Size(202, 50);
            this.adminoruserlb.TabIndex = 2;
            this.adminoruserlb.Text = "You are .....";
            // 
            // AdminOrUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminoruserlb);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.admin_btn);
            this.Name = "AdminOrUser";
            this.Text = "AdminOrUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Label adminoruserlb;
    }
}