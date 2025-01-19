namespace Movies_Project
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.error_msgBox = new System.Windows.Forms.TextBox();
            this.lockIcon = new System.Windows.Forms.PictureBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // error_msgBox
            // 
            this.error_msgBox.BackColor = System.Drawing.Color.Black;
            this.error_msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error_msgBox.ForeColor = System.Drawing.Color.Red;
            this.error_msgBox.Location = new System.Drawing.Point(221, 303);
            this.error_msgBox.Name = "error_msgBox";
            this.error_msgBox.Size = new System.Drawing.Size(307, 15);
            this.error_msgBox.TabIndex = 23;
            // 
            // lockIcon
            // 
            this.lockIcon.Image = ((System.Drawing.Image)(resources.GetObject("lockIcon.Image")));
            this.lockIcon.Location = new System.Drawing.Point(167, 245);
            this.lockIcon.Name = "lockIcon";
            this.lockIcon.Size = new System.Drawing.Size(35, 37);
            this.lockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockIcon.TabIndex = 22;
            this.lockIcon.TabStop = false;
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(221, 242);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.PasswordChar = '*';
            this.codeBox.Size = new System.Drawing.Size(438, 40);
            this.codeBox.TabIndex = 19;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(221, 185);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(438, 40);
            this.usernameBox.TabIndex = 18;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(142, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.AllowDrop = true;
            this.submitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(547, 303);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 39);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Login";
            this.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(300, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = ".";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.White;
            this.loginTitle.Location = new System.Drawing.Point(176, 85);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(127, 54);
            this.loginTitle.TabIndex = 15;
            this.loginTitle.Text = "Login";
            // 
            // back_btn
            // 
            this.back_btn.AllowDrop = true;
            this.back_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 39);
            this.back_btn.TabIndex = 24;
            this.back_btn.Text = "Back";
            this.back_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.error_msgBox);
            this.Controls.Add(this.lockIcon);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTitle);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox error_msgBox;
        private System.Windows.Forms.PictureBox lockIcon;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Button back_btn;
    }
}