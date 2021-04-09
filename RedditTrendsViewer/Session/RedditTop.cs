using RedditTrendsViewer.Objects;
using RedditTrendsViewer.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditTrendsViewer.Session
{
    // save top N reddit posts to be processed and displayed throughout the app
    class RedditTop
    {
        private static Listing topRedditPosts = null;
        private static string current_subreddit = "wallstreetbets";

        public static Listing getTopRedditPosts(int nrOfPosts = 3)
        {
            return topRedditPosts;

        }

        public static void updateTopRedditPosts(int nrOfPosts = 3)
        {
            string url = "https://www.reddit.com/r/"+ current_subreddit + "/top.json?limit=" + nrOfPosts.ToString();
            string response = RequestHandler.Get(url);
            Console.WriteLine(response);
            if (response == null) return;
            topRedditPosts =  Newtonsoft.Json.JsonConvert.DeserializeObject<Listing>(response);
        }

        public static void updateSubredditName(string subreddit)
        {
            current_subreddit = subreddit;
        }
    }
}
