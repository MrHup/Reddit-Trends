
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RedditTrendsViewer.Objects;
using RedditTrendsViewer.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditTrendsViewer.UserControls
{
    public partial class TrendingPage : UserControl
    {
        public TrendingPage()
        {
            InitializeComponent();
        }

        private void getTestButton_Click(object sender, EventArgs e)
        {

            if (subreddit_textBox.Text != "")
                Session.RedditTop.updateSubredditName(subreddit_textBox.Text);
            Session.RedditTop.updateTopRedditPosts(10);

            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Subreddit");
            listView1.Columns.Add("Author");
            listView1.Columns.Add("Title");

            listView1.Items.Clear();

            Listing elements = Session.RedditTop.getTopRedditPosts();
            if (elements == null) return;

            foreach (var child in elements.data.children)
            {
                Console.WriteLine(child.data.title);

                var item1 = new ListViewItem(new[] { child.data.subreddit, child.data.author, child.data.title });
               
                listView1.Items.Add(item1);
            }

        }
    }
}
