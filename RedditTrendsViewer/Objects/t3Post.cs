using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditTrendsViewer.Objects
{
    public class t3Post
    {
       
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }

        public int gilded { get; set; }

        public string title { get; set; }

        public string name { get; set; }

        public double upvote_ratio { get; set; }

        
        public int ups { get; set; }
        public int total_awards_received { get; set; }

        public int score { get; set; }
        public string author { get; set; }
        public string permalink { get; set; }
        public string url { get; set; }
    }
}
