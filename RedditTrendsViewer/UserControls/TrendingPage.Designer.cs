
namespace RedditTrendsViewer.UserControls
{
    partial class TrendingPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.getTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trending page";
            // 
            // getTestButton
            // 
            this.getTestButton.FlatAppearance.BorderSize = 0;
            this.getTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTestButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTestButton.ForeColor = System.Drawing.Color.White;
            this.getTestButton.Location = new System.Drawing.Point(31, 76);
            this.getTestButton.Name = "getTestButton";
            this.getTestButton.Size = new System.Drawing.Size(170, 39);
            this.getTestButton.TabIndex = 2;
            this.getTestButton.Text = "GET";
            this.getTestButton.UseVisualStyleBackColor = true;
            this.getTestButton.Click += new System.EventHandler(this.getTestButton_Click);
            // 
            // TrendingPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::RedditTrendsViewer.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.getTestButton);
            this.Controls.Add(this.label1);
            this.Name = "TrendingPage";
            this.Size = new System.Drawing.Size(782, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getTestButton;
    }
}
