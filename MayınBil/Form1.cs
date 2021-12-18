using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MayınBil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       static int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.White;
            str.BackColor = Color.Red;
            bomba(15, 10);
        }

            void bomba (int bomb, int b)
            {
            flowLayoutPanel1.Width = b * 60;
            flowLayoutPanel1.Height = b * 60;
            flowLayoutPanel1.Controls.Clear();

            int[] bombs = new int[bomb];
            Random r = new Random();

            for (int i = 0; i < bomb; i++) {

              int chosen = r.Next(0, b * b);
                if (bombs.Contains(chosen))
                {
                    i--;
                    continue;
                } bombs[i] = chosen;
            }

            for (int i = 0; i < b * b; i++)
                {
                    Button button = new Button();
                button.Width = 50;
                button.Height = 50;
                button.BackColor = Color.Red;
                button.FlatStyle = FlatStyle.Popup;
                button.Tag = bombs.Contains(i);
                button.Click += button_Click;
                flowLayoutPanel1.Controls.Add(button);
                }

            }

        private void button_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            bool state = (bool)clicked.Tag;
            if (state == true) 
            {
                clicked.BackColor = Color.DarkRed;
                Questions question = new Questions();
                question.Show();
                score++;
                textBox1.Text = score.ToString();
                clicked.Enabled = false;

            }

            else 
            {
                clicked.BackColor = Color.Green;
                score++;
                textBox1.Text = score.ToString();
                clicked.Enabled = false;
            }

        }

        void Question()
        {
            
        }
        void GameOver()
        {
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                bool state = (bool)item.Tag;
                if (state)
                {
                    item.BackColor = Color.Red;
                  
                }
                else
                {
                    item.BackColor = Color.Green;
                }
               
                
            }
            textBox1.Clear();
            MessageBox.Show("Skorunuz " + score + " tebrikler.");
            score = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
