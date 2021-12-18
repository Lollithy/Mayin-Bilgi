using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MayınBil
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }
    
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O0D7T2D\\SQLEXPRESS;Initial Catalog=VPQuestions;Integrated Security=True");
        static string b;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand com = new SqlCommand("Select * from dbo.Table_2 order by NEWID()", baglan);
            SqlDataReader readd = com.ExecuteReader();
            while (readd.Read())
            {
                ba.Text = (readd["a"].ToString());
                bb.Text = (readd["b"].ToString());
                bc.Text = (readd["c"].ToString());
                bd.Text = (readd["d"].ToString());
                textBox1.Text = (readd["sorular"].ToString());
                b= (readd["dogru"].ToString());
            }
            baglan.Close();
            ba.Enabled = true;
            bb.Enabled = true;
            bc.Enabled = true;
            bd.Enabled = true;
        }

        private void bc_Click(object sender, EventArgs e)
        {
            if (bc.Text == b)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Soruya yalnış cevap verdiğiniz için kaybettiniz.");
                Application.Exit();
            }

        }

        private void bb_Click(object sender, EventArgs e)
        {
            if (bb.Text == b)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Soruya yalnış cevap verdiğiniz için kaybettiniz.");
                Application.Exit();
            }


        }
        private void bd_Click(object sender, EventArgs e)
        {
            if (bd.Text == b)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Soruya yalnış cevap verdiğiniz için kaybettiniz.");
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ba_Click(object sender, EventArgs e)
        {
            if (ba.Text == b)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Soruya yalnış cevap verdiğiniz için kaybettiniz.");
                Application.Exit();
            }
        }

        
    }
}
