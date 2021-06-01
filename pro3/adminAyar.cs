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

//adminAyar
namespace pro3
{
    public partial class adminAyar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        String kontrol;
        public adminAyar()
        {
            InitializeComponent();
            adminGetir();
        }
        void adminGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM admin", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }
        private void k_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (kullaniciAdiText.Text != "" && emailText.Text != "" && sifreText.Text != "" && ulkeText.Text != "")
                    {
                        String kayit = "INSERT INTO admin(adminAdi,email,sifre,ulke) " +
                       "VALUES(@adminAdi,@email,@sifre,@ulke)";
                        SqlCommand cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@adminAdi", kullaniciAdiText.Text);
                        cmd.Parameters.AddWithValue("@email", emailText.Text);
                        cmd.Parameters.AddWithValue("@sifre", sifreText.Text);
                        cmd.Parameters.AddWithValue("@ulke", ulkeText.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Admin Eklendi", "KAYIT BAŞARILI");
                    }
                    baglanti.Close();
                }
            }
            catch (Exception hata)
            {
            MessageBox.Show("Bir hata var!" + hata.Message);
            }
            adminGetir();
        }

        private void k_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                baglanti.Open();
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayit = "DELETE FROM admin WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }

            adminGetir();
        }

        private void k_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    baglanti.Open();
                    if (kullaniciAdiText.Text != "")
                    {
                        kayit = "UPDATE admin SET adminAdi='" + kullaniciAdiText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }


                    if (emailText.Text != "")
                    {
                        kayit = "UPDATE admin SET email='" + emailText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    if (sifreText.Text != "")
                    {
                        kayit = "UPDATE admin SET sifre='" + sifreText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    
                    if (ulkeText.Text != "")
                    {
                        kayit = "UPDATE admin SET ulke ='" + ulkeText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }


                }
                baglanti.Close();
                MessageBox.Show("GÜNCELLENDİ", "KAYIT BAŞARILI");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            adminGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminAyar_Load(object sender, EventArgs e)
        {

        }
    }
}
