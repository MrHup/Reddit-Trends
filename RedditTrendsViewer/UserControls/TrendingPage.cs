
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
            string url = "https://www.reddit.com/r/wallstreetbets/top.json?limit=3";
            string response = RequestHandler.Get(url);

            Console.WriteLine(response);

            var responseObject = JsonConvert.DeserializeObject<Listing>(response);

            foreach (var child in responseObject.data.children)
            {
                Console.WriteLine(child.data.title);

    
            }

        }
    }
}
