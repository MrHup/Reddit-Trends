
namespace RedditTrendsViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.TrendingButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AnalyticsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 55);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SettingsButton);
            this.panel3.Controls.Add(this.AnalyticsButton);
            this.panel3.Controls.Add(this.TrendingButton);
            this.panel3.Controls.Add(this.HomeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 120);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RedditTrendsViewer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reddit Trend Viewer";
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Image = global::RedditTrendsViewer.Properties.Resources.home_b;
            this.HomeButton.Location = new System.Drawing.Point(76, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(168, 120);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // TrendingButton
            // 
            this.TrendingButton.FlatAppearance.BorderSize = 0;
            this.TrendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrendingButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingButton.Image = global::RedditTrendsViewer.Properties.Resources.leaderboard_b;
            this.TrendingButton.Location = new System.Drawing.Point(248, 0);
            this.TrendingButton.Name = "TrendingButton";
            this.TrendingButton.Size = new System.Drawing.Size(168, 120);
            this.TrendingButton.TabIndex = 1;
            this.TrendingButton.Text = "Trending";
            this.TrendingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TrendingButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Image = global::RedditTrendsViewer.Properties.Resources.settings_b;
            this.SettingsButton.Location = new System.Drawing.Point(591, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(168, 120);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // AnalyticsButton
            // 
            this.AnalyticsButton.FlatAppearance.BorderSize = 0;
            this.AnalyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyticsButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyticsButton.Image = global::RedditTrendsViewer.Properties.Resources.analytics_b;
            this.AnalyticsButton.Location = new System.Drawing.Point(419, 0);
            this.AnalyticsButton.Name = "AnalyticsButton";
            this.AnalyticsButton.Size = new System.Drawing.Size(168, 120);
            this.AnalyticsButton.TabIndex = 2;
            this.AnalyticsButton.Text = "Analytics";
            this.AnalyticsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AnalyticsButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RedditTrendsViewer.Properties.Resources.close_b;
            this.button1.Location = new System.Drawing.Point(1068, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1101, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AnalyticsButton;
        private System.Windows.Forms.Button TrendingButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button button1;
    }
}

