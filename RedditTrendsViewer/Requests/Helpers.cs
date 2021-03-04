using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RedditTrendsViewer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RedditTrendsViewer.Requests
{
    class Helpers
    {
        public static JObject toJson(string jsonStr)
        {
            JObject json = JObject.Parse(jsonStr);

            return json;
        }

        public static Listing toList(string json)
        {
            Listing m_list= new Listing();

            dynamic data = JObject.Parse(json);
            m_list.kind = data.kind;
            
            return m_list;
        }
    }
}
