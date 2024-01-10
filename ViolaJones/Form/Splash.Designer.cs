namespace ViolaJones
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Label2 = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.Lbelsplash = new System.Windows.Forms.Label();
            this.ProgresSplash = new System.Windows.Forms.ProgressBar();
            this.Keluar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(102, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(375, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nhận dạng khuôn mặt bằng phương pháp Viola Jones";
            // 
            // timerSplash
            // 
            this.timerSplash.Interval = 20;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // Lbelsplash
            // 
            this.Lbelsplash.Location = new System.Drawing.Point(71, 276);
            this.Lbelsplash.Name = "Lbelsplash";
            this.Lbelsplash.Size = new System.Drawing.Size(435, 22);
            this.Lbelsplash.TabIndex = 0;
            this.Lbelsplash.Text = "Loading...";
            this.Lbelsplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgresSplash
            // 
            this.ProgresSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgresSplash.Location = new System.Drawing.Point(12, 301);
            this.ProgresSplash.Name = "ProgresSplash";
            this.ProgresSplash.Size = new System.Drawing.Size(550, 15);
            this.ProgresSplash.Step = 1;
            this.ProgresSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgresSplash.TabIndex = 0;
            this.ProgresSplash.Value = 2;
            // 
            // Keluar
            // 
            this.Keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keluar.AutoSize = true;
            this.Keluar.FlatAppearance.BorderSize = 0;
            this.Keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keluar.ForeColor = System.Drawing.SystemColors.Window;
            this.Keluar.Location = new System.Drawing.Point(529, 12);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(33, 32);
            this.Keluar.TabIndex = 27;
            this.Keluar.Text = "X";
            this.Keluar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 195);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(574, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Lbelsplash);
            this.Controls.Add(this.ProgresSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label Lbelsplash;
        private System.Windows.Forms.ProgressBar ProgresSplash;
		private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}