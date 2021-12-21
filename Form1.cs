using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCardManagemant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void toolStripMenultem6ToolStripItemClick(object sender, EventArgs e)
        {
            Form frm = new changesettings();
            frm.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.password!=""&&Properties.Settings.Default.Username!="")
            {
                Login l = new Login();
                l.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7ToolStripItemClick(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
