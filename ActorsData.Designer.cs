namespace Movies_Project
{
    partial class ActorsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorsData));
            this.show_btn = new System.Windows.Forms.Button();
            this.actorDataLb = new System.Windows.Forms.Label();
            this.result_dgv = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.show_btn.Location = new System.Drawing.Point(26, 183);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(156, 52);
            this.show_btn.TabIndex = 18;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // actorDataLb
            // 
            this.actorDataLb.AutoSize = true;
            this.actorDataLb.BackColor = System.Drawing.Color.White;
            this.actorDataLb.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorDataLb.Location = new System.Drawing.Point(29, 35);
            this.actorDataLb.Name = "actorDataLb";
            this.actorDataLb.Size = new System.Drawing.Size(158, 60);
            this.actorDataLb.TabIndex = 17;
            this.actorDataLb.Text = "Actors";
            // 
            // result_dgv
            // 
            this.result_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dgv.Location = new System.Drawing.Point(205, 35);
            this.result_dgv.Name = "result_dgv";
            this.result_dgv.RowHeadersWidth = 51;
            this.result_dgv.RowTemplate.Height = 24;
            this.result_dgv.Size = new System.Drawing.Size(359, 364);
            this.result_dgv.TabIndex = 16;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_btn.Location = new System.Drawing.Point(26, 332);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(156, 52);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(26, 259);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(156, 52);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ActorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.actorDataLb);
            this.Controls.Add(this.result_dgv);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "ActorsData";
            this.Text = "ActorsData";
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label actorDataLb;
        private System.Windows.Forms.DataGridView result_dgv;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
    }
}