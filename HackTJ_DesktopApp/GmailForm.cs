using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Diagnostics;

namespace HackTJ_DesktopApp
{
    public partial class GmailForm : Form
    {
        private GmailClass gc;
        public OpenFileDialog o;

        public GmailForm()
        {
            InitializeComponent();
            gc = new GmailClass();
            o = new OpenFileDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gc.username = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GmailForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method sends the email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(gc.username == "" || gc.accessKey == "" || gc.recipient == "" || gc.body == "")
            {
                return;
            }
            else
            {
                if(gc.subject == "")
                {
                    gc.subject = "(no subject)";
                }
                gc.WriteEmail();
                
                
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
            gc.ResetVariables();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            gc.accessKey = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            gc.recipient = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            gc.subject = textBox4.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            gc.body = richTextBox1.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            o.ShowDialog();
            try
            {
                gc.media = Image.FromFile(o.FileName);
                gc.mediaPath = o.FileName;
                textBox5.Text = o.FileName;
            }
            catch(Exception)
            {
                gc.media = null;
                gc.mediaPath = "";
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
