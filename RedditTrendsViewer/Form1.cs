using RedditTrendsViewer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;


namespace RedditTrendsViewer
{
    
    public partial class Form1 : Form
    {
        public Dictionary<string, int> keyWordsList = new Dictionary<string, int>();

        
        void readWordsOfInterest ()
        {
            // save all keywords in a string, int map which will be used when
            //   displaying the number of apparations respective to each one
            string[] lines;
            string filePath = @"trendsKeywords.txt";
            if (File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                keyWordsList.Clear();
                foreach (string line in lines)
                {
                    keyWordsList[line] = 0;
                }
            }
            else
            {
                string initialDefaultContent = "NOK\nGME\nMSFT\nAMC";
     
                File.WriteAllText(@"trendsKeywords.txt", initialDefaultContent);
            }
                
        }
        public Form1()
        {
            InitializeComponent();
            readWordsOfInterest(); // read keywords from file

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
        private void HomeButton_Click(object sender, EventArgs e) {}

        void checkIfStringContainsKeys(string str)
        {
            foreach(var item in keyWordsList.Keys.ToList())
            {
                if(str.Contains(item))
                {
                    keyWordsList[item]++;
                }
            }
        }

        void resetDictionary()
        {
            foreach(var item in keyWordsList.Keys.ToList())
            {
                keyWordsList[item] = 0;
            }
        }

        private void TrendingButton_Click(object sender, EventArgs e)
        {


        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            this.Hide();
            f2.ShowDialog();
        }

        void updateChart()
        {
            int i = 0;
            chart1.Series.Clear();
      
            foreach (var item in keyWordsList)
            {
                
                chart1.Series.Add(item.Key);
                chart1.Series[i].LegendText = item.Key;
                chart1.Series[i].Points.AddXY("Keys", item.Value);
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                // chart1.Series[i]["PointWidth"] = "0.75";
                chart1.Series[i].IsValueShownAsLabel = true;
                chart1.Series[i].ChartType = SeriesChartType.Bar;

                i++;
            }

        }

        private async void buildGraph()
        {
            readWordsOfInterest();

            titleMessage.Text = "Current trends for r/" + subreddit_textBox.Text;
            topTitle.Text = "Top " +Session.RedditTop.globalNrPosts.ToString() +" posts from r/" + subreddit_textBox.Text;
            if (subreddit_textBox.Text != "")
                Session.RedditTop.updateSubredditName(subreddit_textBox.Text);
            else
            {
                titleMessage.Text = "Current trends for r/wallstreetbets";
                topTitle.Text = "Top " + Session.RedditTop.globalNrPosts.ToString() + " posts from r/wallstreetbets";
            }
                
            Session.RedditTop.updateTopRedditPosts(Session.RedditTop.globalNrPosts);

            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Subreddit");
            listView1.Columns.Add("Author");
            listView1.Columns.Add("Title");

            listView1.Items.Clear();

            Listing elements = Session.RedditTop.getTopRedditPosts();
            if (elements == null) return;

            resetDictionary();

            foreach (var child in elements.data.children)
            {
                Console.WriteLine(child.data.title);

                var item1 = new ListViewItem(new[] { child.data.subreddit, child.data.author, child.data.title });

                checkIfStringContainsKeys(child.data.selftext);
                checkIfStringContainsKeys(child.data.title);

                listView1.Items.Add(item1);
            }

            updateChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            buildGraph();

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            buildGraph();
        }

        private void AnalyticsButton_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3(this);
            this.Hide();
            f2.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
