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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initUserControlList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<UserControl> uc_list = new List<UserControl>();
        List<Button> uc_mapped_buttons = new List<Button>();

        void initUserControlList()
        {
            uc_list.Add(defaultHomePage1);
            uc_mapped_buttons.Add(HomeButton);
            uc_list.Add(trendingPage1);
            uc_mapped_buttons.Add(TrendingButton);
            uc_list.Add(settingsPage1);
            uc_mapped_buttons.Add(SettingsButton);
        }

        void openUc(int uc_index) 
        {
            uc_list[uc_index].Enabled = true;
            uc_mapped_buttons[uc_index].Enabled = false;
            bunifuTransition1.ShowSync(uc_list[uc_index]);
        }

        void closeUc(int uc_index)
        {
            uc_list[uc_index].Enabled = false;
            uc_mapped_buttons[uc_index].Enabled = true;
            bunifuTransition2.HideSync(uc_list[uc_index]);
        }

        void hideAllExcept(UserControl selectedUC)
        {
            int closingUc=-1, openingUc=-1;  // to avoid async calls

            for (int uc_index=0; uc_index < uc_list.Count; uc_index++)
            {
                if (uc_list[uc_index].Equals(selectedUC))
                {
                    Console.WriteLine("Clicked on " + selectedUC.Name);
                    openingUc = uc_index;

                }
                else if(uc_mapped_buttons.ElementAt(uc_index).Enabled == false)
                {
                    Console.WriteLine("Closing " + uc_list[uc_index].Name);
                    closingUc = uc_index;
                }
            }

            if(closingUc != -1 && openingUc != -1)
            {
                closeUc(closingUc);
                openUc(openingUc);
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            hideAllExcept(defaultHomePage1);
        }

        private void TrendingButton_Click(object sender, EventArgs e)
        {
            hideAllExcept(trendingPage1);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            hideAllExcept(settingsPage1);
        }
    }
}
