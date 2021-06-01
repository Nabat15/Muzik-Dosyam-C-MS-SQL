namespace pro3
{
    partial class adminAyar
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
            this.label6 = new System.Windows.Forms.Label();
            this.ulkeText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.k_güncelle = new System.Windows.Forms.Button();
            this.k_sil = new System.Windows.Forms.Button();
            this.k_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "KULLANICILAR";
            // 
            // ulkeText
            // 
            this.ulkeText.AccessibleName = "";
            this.ulkeText.Location = new System.Drawing.Point(116, 185);
            this.ulkeText.Name = "ulkeText";
            this.ulkeText.Size = new System.Drawing.Size(188, 20);
            this.ulkeText.TabIndex = 30;
            // 
            // emailText
            // 
            this.emailText.AccessibleName = "";
            this.emailText.Location = new System.Drawing.Point(116, 151);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(188, 20);
            this.emailText.TabIndex = 29;
            // 
            // sifreText
            // 
            this.sifreText.AccessibleName = "";
            this.sifreText.Location = new System.Drawing.Point(116, 117);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(188, 20);
            this.sifreText.TabIndex = 28;
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.AccessibleName = "";
            this.kullaniciAdiText.Location = new System.Drawing.Point(116, 82);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(188, 20);
            this.kullaniciAdiText.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ülke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "E mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Admin Adı";
            // 
            // k_güncelle
            // 
            this.k_güncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.k_güncelle.Location = new System.Drawing.Point(230, 223);
            this.k_güncelle.Name = "k_güncelle";
            this.k_güncelle.Size = new System.Drawing.Size(75, 23);
            this.k_güncelle.TabIndex = 34;
            this.k_güncelle.Text = "GÜNCELLE";
            this.k_güncelle.UseVisualStyleBackColor = false;
            this.k_güncelle.Click += new System.EventHandler(this.k_güncelle_Click);
            // 
            // k_sil
            // 
            this.k_sil.BackColor = System.Drawing.Color.CadetBlue;
            this.k_sil.Location = new System.Drawing.Point(127, 223);
            this.k_sil.Name = "k_sil";
            this.k_sil.Size = new System.Drawing.Size(75, 23);
            this.k_sil.TabIndex = 33;
            this.k_sil.Text = "SİL";
            this.k_sil.UseVisualStyleBackColor = false;
            this.k_sil.Click += new System.EventHandler(this.k_sil_Click);
            // 
            // k_ekle
            // 
            this.k_ekle.BackColor = System.Drawing.Color.CadetBlue;
            this.k_ekle.Location = new System.Drawing.Point(24, 223);
            this.k_ekle.Name = "k_ekle";
            this.k_ekle.Size = new System.Drawing.Size(75, 23);
            this.k_ekle.TabIndex = 32;
            this.k_ekle.Text = "EKLE";
            this.k_ekle.UseVisualStyleBackColor = false;
            this.k_ekle.Click += new System.EventHandler(this.k_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 272);
            this.dataGridView1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(664, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.k_güncelle);
            this.Controls.Add(this.k_sil);
            this.Controls.Add(this.k_ekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ulkeText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciAdiText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminAyar";
            this.Text = "adminAyar";
            this.Load += new System.EventHandler(this.adminAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ulkeText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button k_güncelle;
        private System.Windows.Forms.Button k_sil;
        private System.Windows.Forms.Button k_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}