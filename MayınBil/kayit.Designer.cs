
namespace MayınBil
{
    partial class kayit
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
            this.etiket1 = new System.Windows.Forms.Label();
            this.etiket2 = new System.Windows.Forms.Label();
            this.etiket3 = new System.Windows.Forms.Label();
            this.metin1 = new System.Windows.Forms.TextBox();
            this.metin2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiket1
            // 
            this.etiket1.AutoSize = true;
            this.etiket1.BackColor = System.Drawing.Color.Transparent;
            this.etiket1.Font = new System.Drawing.Font("Segoe UI Black", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etiket1.Location = new System.Drawing.Point(86, 20);
            this.etiket1.Name = "etiket1";
            this.etiket1.Size = new System.Drawing.Size(273, 38);
            this.etiket1.TabIndex = 1;
            this.etiket1.Text = "KULLANICI KAYITI";
            this.etiket1.Click += new System.EventHandler(this.etiket1_Click);
            // 
            // etiket2
            // 
            this.etiket2.AutoSize = true;
            this.etiket2.BackColor = System.Drawing.Color.Transparent;
            this.etiket2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etiket2.Location = new System.Drawing.Point(39, 157);
            this.etiket2.Name = "etiket2";
            this.etiket2.Size = new System.Drawing.Size(88, 35);
            this.etiket2.TabIndex = 4;
            this.etiket2.Text = "Şifre :";
            // 
            // etiket3
            // 
            this.etiket3.AutoSize = true;
            this.etiket3.BackColor = System.Drawing.Color.Transparent;
            this.etiket3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etiket3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.etiket3.Location = new System.Drawing.Point(39, 122);
            this.etiket3.Name = "etiket3";
            this.etiket3.Size = new System.Drawing.Size(182, 35);
            this.etiket3.TabIndex = 5;
            this.etiket3.Text = "Kullanıcı adı :";
            // 
            // metin1
            // 
            this.metin1.Location = new System.Drawing.Point(227, 130);
            this.metin1.Name = "metin1";
            this.metin1.Size = new System.Drawing.Size(195, 27);
            this.metin1.TabIndex = 6;
            // 
            // metin2
            // 
            this.metin2.Location = new System.Drawing.Point(227, 165);
            this.metin2.Name = "metin2";
            this.metin2.Size = new System.Drawing.Size(195, 27);
            this.metin2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(175, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "KAYIT OL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(383, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MayınBil.Properties.Resources._360_F_42537001_JMwYOwBmDJ4pXlkMNRUZl8LkZ7TYoa9x;
            this.ClientSize = new System.Drawing.Size(478, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metin2);
            this.Controls.Add(this.metin1);
            this.Controls.Add(this.etiket3);
            this.Controls.Add(this.etiket2);
            this.Controls.Add(this.etiket1);
            this.Name = "kayit";
            this.Text = "kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiket1;
        private System.Windows.Forms.Label etiket2;
        private System.Windows.Forms.Label etiket3;
        private System.Windows.Forms.TextBox metin1;
        private System.Windows.Forms.TextBox metin2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}