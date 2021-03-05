using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*{
	"keys": [{
		"tokens": [
				"NOK",
				"Nokia"
			],
			"count": 0
		},
		{
		"tokens": [
				"GME"
			],
			"count": 0
		}
	]
}*/

namespace RedditTrendsViewer.Objects
{
	public class ListKey
	{
		public List<Keyword> keys { get; set; }
	}
	public class Keyword
    {
		public int count { get; set; }
        public List<string> tokens { get; set; }

		public void display()
        {
			string output = "{ ";
			foreach(var token in tokens)
            {
				output += token + " ";
            }
			output += "}";

			Console.WriteLine(output);
        }
    }
}
