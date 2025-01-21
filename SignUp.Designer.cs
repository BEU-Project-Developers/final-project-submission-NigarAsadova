namespace Movies_Project
{
    partial class SignUp
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
            this.signUpTitle = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.FullNameLb = new System.Windows.Forms.Label();
            this.gmailLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.gmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signUpTitle
            // 
            this.signUpTitle.AutoSize = true;
            this.signUpTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpTitle.ForeColor = System.Drawing.Color.White;
            this.signUpTitle.Location = new System.Drawing.Point(246, 24);
            this.signUpTitle.Name = "signUpTitle";
            this.signUpTitle.Size = new System.Drawing.Size(170, 54);
            this.signUpTitle.TabIndex = 1;
            this.signUpTitle.Text = "Sign Up";
            this.signUpTitle.Click += new System.EventHandler(this.signUpTitle_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(95, 151);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(185, 40);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(337, 151);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.PasswordChar = '*';
            this.codeBox.Size = new System.Drawing.Size(229, 40);
            this.codeBox.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.AllowDrop = true;
            this.submitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(255, 341);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 39);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.username_label.Location = new System.Drawing.Point(108, 112);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(87, 23);
            this.username_label.TabIndex = 9;
            this.username_label.Text = "Username";
            this.username_label.UseWaitCursor = true;
            // 
            // password_label
            // 
            this.password_label.AllowDrop = true;
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.password_label.Location = new System.Drawing.Point(352, 112);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(80, 23);
            this.password_label.TabIndex = 10;
            this.password_label.Text = "Password";
            this.password_label.UseWaitCursor = true;
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.Black;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.ForeColor = System.Drawing.Color.Red;
            this.messageBox.Location = new System.Drawing.Point(116, 306);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(100, 15);
            this.messageBox.TabIndex = 14;
            // 
            // FullNameLb
            // 
            this.FullNameLb.AllowDrop = true;
            this.FullNameLb.AutoSize = true;
            this.FullNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLb.ForeColor = System.Drawing.Color.OrangeRed;
            this.FullNameLb.Location = new System.Drawing.Point(352, 219);
            this.FullNameLb.Name = "FullNameLb";
            this.FullNameLb.Size = new System.Drawing.Size(79, 23);
            this.FullNameLb.TabIndex = 18;
            this.FullNameLb.Text = "Fullname";
            this.FullNameLb.UseWaitCursor = true;
            // 
            // gmailLabel
            // 
            this.gmailLabel.AutoSize = true;
            this.gmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.gmailLabel.Location = new System.Drawing.Point(108, 219);
            this.gmailLabel.Name = "gmailLabel";
            this.gmailLabel.Size = new System.Drawing.Size(54, 23);
            this.gmailLabel.TabIndex = 17;
            this.gmailLabel.Text = "Gmail";
            this.gmailLabel.UseWaitCursor = true;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(337, 258);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(229, 40);
            this.nameBox.TabIndex = 16;
            // 
            // gmailBox
            // 
            this.gmailBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailBox.Location = new System.Drawing.Point(95, 258);
            this.gmailBox.Multiline = true;
            this.gmailBox.Name = "gmailBox";
            this.gmailBox.Size = new System.Drawing.Size(185, 40);
            this.gmailBox.TabIndex = 15;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(678, 440);
            this.Controls.Add(this.FullNameLb);
            this.Controls.Add(this.gmailLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.gmailBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.signUpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpTitle;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label FullNameLb;
        private System.Windows.Forms.Label gmailLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox gmailBox;
    }
}