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
    public partial class Form3 : Form
    {
        private Form1 form1Reference;
        public Form3(Form1 form1)
        {
            form1Reference = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1Reference.Close();

        }

        private void TrendingButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form1Reference.Show();
            this.Dispose();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(form1Reference);
            this.Close();
            f2.ShowDialog();
            this.Dispose();
        }
    }
}
