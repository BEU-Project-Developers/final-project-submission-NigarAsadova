﻿namespace Movies_Project
{
    partial class Watched
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
            this.movies_dgv = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // movies_dgv
            // 
            this.movies_dgv.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.movies_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movies_dgv.Location = new System.Drawing.Point(194, 155);
            this.movies_dgv.Name = "movies_dgv";
            this.movies_dgv.RowHeadersWidth = 51;
            this.movies_dgv.RowTemplate.Height = 24;
            this.movies_dgv.Size = new System.Drawing.Size(590, 223);
            this.movies_dgv.TabIndex = 0;
            this.movies_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movies_dgv_CellContentClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(375, 414);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 50);
            this.delete.TabIndex = 1;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Watched List";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 31);
            this.back_btn.TabIndex = 23;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Watched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 530);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.movies_dgv);
            this.Name = "Watched";
            this.Text = "Watched";
            this.Load += new System.EventHandler(this.Watched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movies_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movies_dgv;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}