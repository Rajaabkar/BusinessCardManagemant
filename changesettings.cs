﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BusinessCardManagemant
{
    public partial class changesettings : Form
    {
        public changesettings()
        {
            InitializeComponent();
        }

        private void changesettings_Load(object sender, EventArgs e)
        {
            usern.Text = Properties.Settings.Default.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = usern.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.password)
            {
                if (textBox3.Text == textBox2.Text)
                {
                    Properties.Settings.Default.password = textBox2.Text;
                    Properties.Settings.Default.Save();
                }
                else
                    label5.Visible = true;
            }
            else
                label6.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
