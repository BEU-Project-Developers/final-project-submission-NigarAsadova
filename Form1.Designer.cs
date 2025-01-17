namespace Movies_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movies_title = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sideBg = new System.Windows.Forms.PictureBox();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sideBg)).BeginInit();
            this.SuspendLayout();
            // 
            // movies_title
            // 
            this.movies_title.AutoSize = true;
            this.movies_title.BackColor = System.Drawing.Color.Black;
            this.movies_title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movies_title.ForeColor = System.Drawing.Color.OldLace;
            this.movies_title.Location = new System.Drawing.Point(545, 139);
            this.movies_title.Name = "movies_title";
            this.movies_title.Size = new System.Drawing.Size(208, 124);
            this.movies_title.TabIndex = 0;
            this.movies_title.Text = "MOVIES\r\nSEARCH";
            this.movies_title.Click += new System.EventHandler(this.movies_title_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Gold;
            this.progressBar1.Location = new System.Drawing.Point(122, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(545, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // sideBg
            // 
            this.sideBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBg.Image = ((System.Drawing.Image)(resources.GetObject("sideBg.Image")));
            this.sideBg.Location = new System.Drawing.Point(0, 0);
            this.sideBg.Name = "sideBg";
            this.sideBg.Size = new System.Drawing.Size(495, 450);
            this.sideBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sideBg.TabIndex = 3;
            this.sideBg.TabStop = false;
            this.sideBg.Click += new System.EventHandler(this.sideBg_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sideBg);
            this.Controls.Add(this.movies_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sideBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movies_title;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox sideBg;
        private System.Windows.Forms.Timer timerProgress;
    }
}

