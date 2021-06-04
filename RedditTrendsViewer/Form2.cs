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

namespace RedditTrendsViewer
{
    public partial class Form2 : Form
    {
        private Form1 form1Reference;
        private List<string> lines = new List<string>();

        public Form2(Form1 parent)
        {
            form1Reference = parent;
            InitializeComponent();

            readWordsOfInterest();
            updateListView();
        }

        void readWordsOfInterest()
        {
            // save all keywords in a string, int map which will be used when
            //   displaying the number of apparations respective to each one
            
            string filePath = @"trendsKeywords.txt";
            if (File.Exists(filePath))
            {
                lines.Clear();
                lines = new List<string>(System.IO.File.ReadAllLines(filePath));

            }
            else
            {
                string initialDefaultContent = "NOK\nGME\nMSFT\nAMC";

                File.WriteAllText(@"trendsKeywords.txt", initialDefaultContent);
            }

        }

        void updateListView()
        { 
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("Stocks", -2, HorizontalAlignment.Center);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = System.Windows.Forms.View.List;
            foreach (var item in lines)
            {
                var item1 = new ListViewItem(new[] { item });

                listView1.Items.Add(item1);
            }
            
        }

        private void TrendingButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
            form1Reference.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                lines.Add(textBox1.Text);
                textBox1.Text = "";
                //writeFile();
                updateListView();
            }
        }

        private void writeFile()
        {
            System.IO.File.WriteAllText(@"trendsKeywords.txt", string.Empty);
            string input = "";
            foreach (var item in lines.ToList())
            {
                input += (item+"\n");
            }
            System.IO.File.WriteAllText(@"trendsKeywords.txt", input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item in listView1.SelectedItems)
            {
                Console.WriteLine(item.ToString());
                foreach(string str in lines.ToList())
                {
                    if(item.ToString().Contains(str))
                    {
                        lines.Remove(str);
                        break;
                    }
                }
            }
            updateListView();
            // writeFile();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*Session.RedditTop.globalNrPosts = Decimal.ToInt32(numericUpDown1.Value);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Session.RedditTop.globalNrPosts = Decimal.ToInt32(numericUpDown1.Value);
            writeFile();

            this.Close();

            form1Reference.Show();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Session.RedditTop.globalNrPosts;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1Reference.Close();
        }

        private void AnalyticsButton_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3(form1Reference);
            this.Close();
            f2.ShowDialog();
            this.Dispose();
        }
    }
}
