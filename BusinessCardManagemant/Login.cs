using System;
using System.Windows.Forms;

namespace BusinessCardManagemant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textname.Text == Properties.Settings.Default.Username && textpass.Text == Properties.Settings.Default.password)
            {
                this.Visible = false;
            }
            else if (textname.Text != Properties.Settings.Default.Username && textpass.Text != Properties.Settings.Default.password)
            {
                textname.Clear();
                textpass.Clear();
                MessageBox.Show("The information does not match");
            }
            else if (textpass.Text != Properties.Settings.Default.password)
            {
                textpass.ClearUndo();
                MessageBox.Show("The password is wrong");
            }
        }

        private void textname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textpass.Focus();

        }

        private void textpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}
