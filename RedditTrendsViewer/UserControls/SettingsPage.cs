using Newtonsoft.Json;
using RedditTrendsViewer.Objects;
using RedditTrendsViewer.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditTrendsViewer.UserControls
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        void updateSessionObjects(string listObjJson)
        {
            // convert the string into json object
            ListKey responseObject;
            try
            {
                responseObject = JsonConvert.DeserializeObject<ListKey>(listObjJson);

                
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("Error");
                return;
            }

            foreach (var child in responseObject.keys)
            {
                child.display();
            }

            SessionObj.currentKeys = responseObject;


        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            string input = Helpers.TrimAllWithInplaceCharArray(richTextBox1.Text);
            updateSessionObjects(input);

            // await File.WriteAllTextAsync("WriteText.txt", input);
        }
    }
}
