namespace pro3
{
    partial class uyeOl
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.ulkeText = new System.Windows.Forms.TextBox();
            this.abonelikTuruText = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Abonelik Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ülke";
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.AccessibleName = "";
            this.kullaniciAdiText.Location = new System.Drawing.Point(133, 96);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(203, 20);
            this.kullaniciAdiText.TabIndex = 6;
            this.kullaniciAdiText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sifreText
            // 
            this.sifreText.AccessibleName = "";
            this.sifreText.Location = new System.Drawing.Point(133, 139);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(203, 20);
            this.sifreText.TabIndex = 7;
            this.sifreText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailText
            // 
            this.emailText.AccessibleName = "";
            this.emailText.Location = new System.Drawing.Point(133, 187);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(203, 20);
            this.emailText.TabIndex = 8;
            // 
            // ulkeText
            // 
            this.ulkeText.AccessibleName = "";
            this.ulkeText.Location = new System.Drawing.Point(133, 231);
            this.ulkeText.Name = "ulkeText";
            this.ulkeText.Size = new System.Drawing.Size(203, 20);
            this.ulkeText.TabIndex = 9;
            // 
            // abonelikTuruText
            // 
            this.abonelikTuruText.AccessibleName = "";
            this.abonelikTuruText.FormattingEnabled = true;
            this.abonelikTuruText.Items.AddRange(new object[] {
            "Normal",
            "Premium"});
            this.abonelikTuruText.Location = new System.Drawing.Point(133, 276);
            this.abonelikTuruText.Name = "abonelikTuruText";
            this.abonelikTuruText.Size = new System.Drawing.Size(203, 21);
            this.abonelikTuruText.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ÜYELİK BİLGİLERİ";
            // 
            // uyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.abonelikTuruText);
            this.Controls.Add(this.ulkeText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciAdiText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uyeOl";
            this.Text = "uyeOl";
            this.Load += new System.EventHandler(this.uyeOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox ulkeText;
        private System.Windows.Forms.ComboBox abonelikTuruText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}