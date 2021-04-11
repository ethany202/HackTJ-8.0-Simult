using System;
using System.Windows.Forms;

namespace HackTJ_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.discord = new System.Windows.Forms.Button();
            this.gmail = new System.Windows.Forms.Button();
            this.Reddit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Simult!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(782, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please choose a social media platform. At this time, we only offer Discord, Gmail" +
    ", and Reddit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.discord.FlatAppearance.BorderSize = 0;
            this.discord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.discord.Image = ((System.Drawing.Image)(resources.GetObject("discord.Image")));
            this.discord.Location = new System.Drawing.Point(102, 226);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(198, 162);
            this.discord.TabIndex = 6;
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // gmail
            // 
            this.gmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gmail.FlatAppearance.BorderSize = 0;
            this.gmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gmail.Image = ((System.Drawing.Image)(resources.GetObject("gmail.Image")));
            this.gmail.Location = new System.Drawing.Point(383, 226);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(207, 162);
            this.gmail.TabIndex = 7;
            this.gmail.UseVisualStyleBackColor = false;
            this.gmail.Click += new System.EventHandler(this.gmail_Click);
            // 
            // Reddit
            // 
            this.Reddit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Reddit.FlatAppearance.BorderSize = 0;
            this.Reddit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reddit.Image = ((System.Drawing.Image)(resources.GetObject("Reddit.Image")));
            this.Reddit.Location = new System.Drawing.Point(680, 226);
            this.Reddit.Name = "Reddit";
            this.Reddit.Size = new System.Drawing.Size(207, 162);
            this.Reddit.TabIndex = 8;
            this.Reddit.UseVisualStyleBackColor = false;
            this.Reddit.Click += new System.EventHandler(this.Reddit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Note: Currently, among the media options, you can only upload images in the featu" +
    "re\'s early phases";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reddit);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simult: The Social Media Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SendTweet()
        {
            //Console.WriteLine("Opening Twitter");
        }


        #endregion
        private Label label1;
        private Label label2;
        private Button discord;
        private Button gmail;
        private Button Reddit;
        private Label label3;
    }
}

