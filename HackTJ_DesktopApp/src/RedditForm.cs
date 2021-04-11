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
    public partial class RedditForm : Form
    {
        private RedditClass rc;

        public RedditForm()
        {
            InitializeComponent();
            rc = new RedditClass();
        }

        private void RedditForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            rc.subreddit = textBox3.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Posting to Reddit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            if(rc.username == "" || rc.password == "" || rc.subreddit == "")
            {
                if(rc.url == "" && rc.text == "")
                {
                    pleaseFill.Text = "Please Fill In All Required Fields";
                }
                else
                {
                    pleaseFill.Text = "";
                }
            }

            
            else
            {
                await rc.SendPost();
                rc.InstantiateUser();
                rc.RedditPost();

                if (!rc.subredditExists)
                {   
                    pleaseFill.Text = "The subreddit you tried to post to does not exist";
                }


            }

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }

            }
            rc.ResetValues();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rc.username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            rc.password = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            rc.title = textBox4.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            rc.text = richTextBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            rc.url = textBox5.Text;
        }

        private void pleaseFill_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
