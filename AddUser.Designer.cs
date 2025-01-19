namespace Movies_Project
{
    partial class AddUser
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
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.fullname_box = new System.Windows.Forms.TextBox();
            this.gmail_box = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.gmail_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(95, 56);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(305, 34);
            this.username_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(95, 137);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(305, 34);
            this.password_box.TabIndex = 1;
            // 
            // fullname_box
            // 
            this.fullname_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_box.Location = new System.Drawing.Point(95, 218);
            this.fullname_box.Name = "fullname_box";
            this.fullname_box.Size = new System.Drawing.Size(305, 34);
            this.fullname_box.TabIndex = 2;
            // 
            // gmail_box
            // 
            this.gmail_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_box.Location = new System.Drawing.Point(95, 298);
            this.gmail_box.Name = "gmail_box";
            this.gmail_box.Size = new System.Drawing.Size(305, 34);
            this.gmail_box.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(156, 359);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(170, 49);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.Color.Red;
            this.username_lb.Location = new System.Drawing.Point(100, 25);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(103, 28);
            this.username_lb.TabIndex = 6;
            this.username_lb.Text = "UserName";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.Color.Red;
            this.password_lb.Location = new System.Drawing.Point(100, 106);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(93, 28);
            this.password_lb.TabIndex = 7;
            this.password_lb.Text = "Password";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.Red;
            this.FullName.Location = new System.Drawing.Point(100, 187);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(95, 28);
            this.FullName.TabIndex = 8;
            this.FullName.Text = "FullName";
            // 
            // gmail_btn
            // 
            this.gmail_btn.AutoSize = true;
            this.gmail_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_btn.ForeColor = System.Drawing.Color.Red;
            this.gmail_btn.Location = new System.Drawing.Point(100, 267);
            this.gmail_btn.Name = "gmail_btn";
            this.gmail_btn.Size = new System.Drawing.Size(63, 28);
            this.gmail_btn.TabIndex = 9;
            this.gmail_btn.Text = "Gmail";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.gmail_btn);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.gmail_box);
            this.Controls.Add(this.fullname_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox fullname_box;
        private System.Windows.Forms.TextBox gmail_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label gmail_btn;
    }
}