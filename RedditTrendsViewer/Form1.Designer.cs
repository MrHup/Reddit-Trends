
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AnalyticsButton = new System.Windows.Forms.Button();
            this.TrendingButton = new System.Windows.Forms.Button();
            this.subreddit_textBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleMessage = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 34);
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
            this.panel2.Size = new System.Drawing.Size(733, 55);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reddit Trend Viewer";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SettingsButton);
            this.panel3.Controls.Add(this.AnalyticsButton);
            this.panel3.Controls.Add(this.TrendingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 120);
            this.panel3.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Image = global::RedditTrendsViewer.Properties.Resources.settings_b;
            this.SettingsButton.Location = new System.Drawing.Point(502, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(168, 120);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AnalyticsButton
            // 
            this.AnalyticsButton.FlatAppearance.BorderSize = 0;
            this.AnalyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyticsButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyticsButton.Image = global::RedditTrendsViewer.Properties.Resources.analytics_b;
            this.AnalyticsButton.Location = new System.Drawing.Point(265, -3);
            this.AnalyticsButton.Name = "AnalyticsButton";
            this.AnalyticsButton.Size = new System.Drawing.Size(168, 120);
            this.AnalyticsButton.TabIndex = 2;
            this.AnalyticsButton.Text = "Analytics";
            this.AnalyticsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AnalyticsButton.UseVisualStyleBackColor = true;
            // 
            // TrendingButton
            // 
            this.TrendingButton.FlatAppearance.BorderSize = 0;
            this.TrendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrendingButton.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingButton.Image = global::RedditTrendsViewer.Properties.Resources.leaderboard_b;
            this.TrendingButton.Location = new System.Drawing.Point(36, 0);
            this.TrendingButton.Name = "TrendingButton";
            this.TrendingButton.Size = new System.Drawing.Size(168, 120);
            this.TrendingButton.TabIndex = 1;
            this.TrendingButton.Text = "Trending";
            this.TrendingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TrendingButton.UseVisualStyleBackColor = true;
            this.TrendingButton.Click += new System.EventHandler(this.TrendingButton_Click);
            // 
            // subreddit_textBox
            // 
            this.subreddit_textBox.Location = new System.Drawing.Point(76, 431);
            this.subreddit_textBox.Name = "subreddit_textBox";
            this.subreddit_textBox.Size = new System.Drawing.Size(170, 20);
            this.subreddit_textBox.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(417, 114);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 300);
            this.listView1.TabIndex = 9;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 114);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(385, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "Current trends";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subreddit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(252, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // titleMessage
            // 
            this.titleMessage.AutoSize = true;
            this.titleMessage.Location = new System.Drawing.Point(12, 98);
            this.titleMessage.Name = "titleMessage";
            this.titleMessage.Size = new System.Drawing.Size(141, 13);
            this.titleMessage.TabIndex = 14;
            this.titleMessage.Text = "Current trends for r/investing";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(733, 588);
            this.Controls.Add(this.titleMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.subreddit_textBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reddit Trends - Trending";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox subreddit_textBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titleMessage;
    }
}

