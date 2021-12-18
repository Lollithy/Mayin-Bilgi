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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection server = new SqlConnection("Data Source=DESKTOP-O0D7T2D\\SQLEXPRESS;Initial Catalog=VPQuestions;Integrated Security=True");

        private void etiket1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Open();
            SqlCommand ekle = new SqlCommand("Insert into kayıtlar (ID, pass) Values ('" + metin1.Text.ToString() + "' , '" + metin2.Text.ToString() + "' )", server);
            //yüklediğimiz parametre değerleri geri bilgisayar hafızasına kaydedip gösteriyor
            ekle.ExecuteNonQuery();
            server.Close();
            giris grs = new giris();
            grs.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.Show();
            this.Hide();
        }
    }
}
