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
    public partial class giris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public giris()
        {
            InitializeComponent();
        }
        
       
       
        private void giris_Load(object sender, EventArgs e)
        {


        }

        private void tab_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-O0D7T2D\\SQLEXPRESS;Initial Catalog=VPQuestions;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kayıtlar where ID='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayit kyt = new kayit();
            kyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
