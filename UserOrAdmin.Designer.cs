namespace Movies_Project
{
    partial class UserOrAdmin
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
            this.label_admin_or_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.admin_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(88, 251);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(240, 80);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // user_btn
            // 
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.user_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.Location = new System.Drawing.Point(434, 251);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(240, 80);
            this.user_btn.TabIndex = 1;
            this.user_btn.Text = "User";
            this.user_btn.UseVisualStyleBackColor = true;
            // 
            // label_admin_or_user
            // 
            this.label_admin_or_user.AutoSize = true;
            this.label_admin_or_user.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_or_user.Location = new System.Drawing.Point(303, 138);
            this.label_admin_or_user.Name = "label_admin_or_user";
            this.label_admin_or_user.Size = new System.Drawing.Size(168, 46);
            this.label_admin_or_user.TabIndex = 2;
            this.label_admin_or_user.Text = "You are ...";
            // 
            // UserOrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_admin_or_user);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.admin_btn);
            this.Name = "UserOrAdmin";
            this.Text = "UserOrAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Label label_admin_or_user;
    }
}