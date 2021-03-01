using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditTrendsViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(trendingPage1);
            bunifuTransition1.ShowSync(defaultHomePage1);
        }

        private void TrendingButton_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(defaultHomePage1);
            bunifuTransition1.ShowSync(trendingPage1);
        }
    }
}
