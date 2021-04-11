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
    public partial class DiscordForm : Form
    {

        public DiscordClass dc;

        public DiscordForm()
        {
            InitializeComponent();
            dc = new DiscordClass();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dc.alias = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dc.token = textBox2.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            dc.message = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dc.SendMessage();
        }

        private void DiscordForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
