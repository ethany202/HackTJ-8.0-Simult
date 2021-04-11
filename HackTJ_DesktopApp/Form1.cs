using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackTJ_DesktopApp
{
    public partial class Form1 : Form
    {

        public OpenFileDialog odj;

        public Form1()
        {
            InitializeComponent();
            InitializeFileDialog();


        }

        public void InitializeFileDialog()
        {
            odj = new OpenFileDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void OpenGmailForm()
        {
            GmailForm gf = new GmailForm();
            gf.ShowDialog();
        }

        private void gmail_Click(object sender, EventArgs e)
        {
            OpenGmailForm();
        }

        private void OpenRedditForm()
        {
            RedditForm rf = new RedditForm();
            rf.ShowDialog();
        }

        private void discord_Click(object sender, EventArgs e)
        {
            OpenDiscordForm();
        }

        private void Reddit_Click(object sender, EventArgs e)
        {
            OpenRedditForm();
        }

        private void OpenDiscordForm()
        {
            DiscordForm df = new DiscordForm();
            df.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
