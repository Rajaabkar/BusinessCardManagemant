using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace BusinessCardManagemant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=RAJA-LAPTOP\\SQLEXPRESS;Initial Catalog=BusinessCard;Integrated Security=True");
       /* private void Filltable() { 
        SqlDataAdapter sda = new SqlDataAdapter("Select * from Business card", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
           
            }*/

        //about selecat all at table  and connection data base 

        // SqlConnection con = new SqlConnection("Data Source=RAJA-LAPTOP\\SQLEXPRESS;Initial Catalog=BusinessCard;Integrated Security=True");
        // SqlDataAdapter sda = new SqlDataAdapter("Select * from Business card", con);

         SqlDataAdapter dl;
         SqlCommand cmd;
         DataTable dt = new DataTable();
        // string table_name;

         private void Filltable()
         {

             dl = new SqlDataAdapter("Select * from Businesscard", con);

             dl.Fill(dt);
             dgv.DataSource = dt;
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
            if (Properties.Settings.Default.password != "" && Properties.Settings.Default.Username != "")
            {
                Login l = new Login();
                l.ShowDialog();
            }

            dgv.ForeColor = Color.Black;
            comboBox1.SelectedIndex = 9;   
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7ToolStripItemClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
          //  table_name = "Business card";
            Filltable();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter d2 = new SqlDataAdapter("select * from Businesscard where " + comboBox1.Text+" like '%"+search.Text+"%' ", con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            dgv.DataSource = dt2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delet The record?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Businesscard where Mobile =" + dgv.CurrentRow.Cells[0].Value, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Filltable();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left = panel2.Left - 15;
            if (panel2.Left >= 25)
                timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Left = panel2.Left + 15;
            if (panel2.Left <= -280)
                timer2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(!(t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text == "" && t1.Text  == null))
            {
                con.Open();
                cmd = new SqlCommand("insert into Businesscard (Name,Position,Mobile,Email,Address ,City ,Website,Telephone,Fax,[Company Name]) values('" + t1.Text + "','" + t2.Text + "','" + Convert.ToInt32(t3.Text) + "','" + t4.Text + "','" + t5.Text + "','" + t6.Text + "','" + t7.Text + "','" + Convert.ToInt32(t8.Text) + "','" + Convert.ToInt32(t9.Text) + "','" + t10.Text + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                t1.Clear(); t2.Clear(); t3.Clear(); t4.Clear(); t5.Clear();
                t6.Clear(); t7.Clear(); t8.Clear(); t9.Clear(); t10.Clear();
            }
            Filltable();
        }
    }
}
