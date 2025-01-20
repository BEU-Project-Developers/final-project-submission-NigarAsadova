namespace Movies_Project
{
    partial class AddToWatchedPopup
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
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rate_numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rate_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(88, 184);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(172, 56);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(88, 257);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(172, 56);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rate Movie";
            // 
            // rate_numeric
            // 
            this.rate_numeric.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.rate_numeric.Location = new System.Drawing.Point(75, 103);
            this.rate_numeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate_numeric.Name = "rate_numeric";
            this.rate_numeric.Size = new System.Drawing.Size(120, 38);
            this.rate_numeric.TabIndex = 7;
            // 
            // AddToWatchedPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(347, 379);
            this.Controls.Add(this.rate_numeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "AddToWatchedPopup";
            this.Text = "AddToWatchedPopup";
            this.Load += new System.EventHandler(this.AddToWatchedPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rate_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rate_numeric;
    }
}