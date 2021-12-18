
namespace MayınBil
{
    partial class giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 27);
            this.textBox2.TabIndex = 10;
            // 
            // tab
            // 
            this.tab.BackColor = System.Drawing.Color.Gold;
            this.tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab.Location = new System.Drawing.Point(293, 228);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(124, 44);
            this.tab.TabIndex = 11;
            this.tab.Text = "Giriş";
            this.tab.UseVisualStyleBackColor = false;
            this.tab.Click += new System.EventHandler(this.tab_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(156, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MayınBil.Properties.Resources._360_F_42537001_JMwYOwBmDJ4pXlkMNRUZl8LkZ7TYoa9x;
            this.ClientSize = new System.Drawing.Size(480, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button tab;
        private System.Windows.Forms.Button button1;
    }
}