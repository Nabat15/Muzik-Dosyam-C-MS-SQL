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

//ayarlar
namespace pro3
{
    public partial class ayarlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        String kontrol;
        public ayarlar()
        {
            InitializeComponent();
            kullaniciGetir();
            turGetir();
            calmaListesi();
        }
        void kullaniciGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM kullanici", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM takipci", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;
            baglanti.Close();
        }
        void turGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM tur", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView3.DataSource = sarki_tablo;
            baglanti.Close();
        }

        void calmaListesi()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM calmaListesi", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView4.DataSource = sarki_tablo;
            baglanti.Close();
        }
        private void k_ekle_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (kullaniciAdiText.Text != "" && emailText.Text != "" && sifreText.Text != "" && abonelikTuruText.Text != "" && ulkeText.Text != "" )
                    {
                        String kayit = "INSERT INTO kullanici(kullaniciAdi,email,sifre,abonelikTuru,ulke,odendiBilgisi) " +
                       "VALUES(@kullaniciAdi,@email,@sifre,@abonelikTuru,@ulke,@odendiBilgisi)";
                        SqlCommand cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdiText.Text);
                        cmd.Parameters.AddWithValue("@email", emailText.Text);
                        cmd.Parameters.AddWithValue("@sifre", sifreText.Text);
                        cmd.Parameters.AddWithValue("@abonelikTuru", abonelikTuruText.Text);
                        cmd.Parameters.AddWithValue("@ulke", ulkeText.Text);

                        if (String.Equals(abonelikTuruText.Text, "Normal") == true)
                        {


                            cmd.Parameters.AddWithValue("@odendiBilgisi", "odenmedi");
                        }
                        else if (String.Equals(abonelikTuruText.Text, "Premium") == true)
                        {
                            cmd.Parameters.AddWithValue("@odendiBilgisi", "odendi");
                        }
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Kullanıcı Eklendi", "KAYIT BAŞARILI");
                    }



                    kayit = "SELECT odendiBilgisi FROM kullanici WHERE Id='" + takipciId.Text + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        SqlDataReader oku1 = cmd.ExecuteReader();

                        while (oku1.Read())
                        {
                           kontrol= oku1["odendiBilgisi"].ToString();
                       
                        }
                        oku1.Close();
                        if (takipId.Text != "" && takipciId.Text != "" && kontrol == "odendi")
                        {
                            kayit = "INSERT INTO takipci(takipId,takipciId) " +
                            "VALUES(@takipId,@takipciId)";
                            cmd = new SqlCommand(kayit, baglanti);
                            cmd.Parameters.AddWithValue("@takipId", takipId.Text);
                            cmd.Parameters.AddWithValue("@takipciId", takipciId.Text);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        MessageBox.Show("Kullanıcı Eklendi", "KAYIT BAŞARILI");
                    }
                        else
                        {
                        MessageBox.Show("Premium Kullanıcısı degil!");
                    }

                      
                    baglanti.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            kullaniciGetir();
        }

        private void k_sil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                baglanti.Open();
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayit = "DELETE FROM takipci WHERE takipId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM takipci WHERE takipciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM calmaListesi WHERE kullaniciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM kullanici WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM takipci WHERE takipId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            kullaniciGetir();
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
                        kayit = "UPDATE kullanici SET kullaniciAdi='" + kullaniciAdiText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }


                    if (emailText.Text != "")
                    {
                        kayit = "UPDATE kullanici SET email='" + emailText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    if (sifreText.Text != "")
                    {
                        kayit = "UPDATE kullanici SET sifre='" + sifreText.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    if (abonelikTuruText.Text != "")
                    {
                        if (String.Equals(abonelikTuruText.Text, "Normal") == true)
                        {

                            kayit = "UPDATE kullanici SET abonelikTuru ='" + abonelikTuruText.Text + "', odendiBilgisi=@odendiBilgisi WHERE Id= '" + id + "'";
                            cmd = new SqlCommand(kayit, baglanti);
                            cmd.Parameters.AddWithValue("@odendiBilgisi", "odenmedi");
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                           
                        }
                        else if (String.Equals(abonelikTuruText.Text, "Premium") == true)
                        {
                            kayit = "UPDATE kullanici SET abonelikTuru ='" + abonelikTuruText.Text + "', odendiBilgisi=@odendiBilgisi WHERE Id= '" + id + "'";
                            cmd = new SqlCommand(kayit, baglanti);
                            cmd.Parameters.AddWithValue("@odendiBilgisi", "odendi");
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            
                        }

                    }
                    if (ulkeText.Text != "")
                    {
                        kayit = "UPDATE kullanici SET ulke ='" + ulkeText.Text + "' WHERE Id= '" + id + "'";
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
            try
            {
                foreach (DataGridViewRow drow1 in dataGridView2.SelectedRows)
                {
                    int id = Convert.ToInt32(drow1.Cells[0].Value);
                    baglanti.Open();
                    if (takip.Text != "")
                    {
                        kayit = "UPDATE takipci SET takipId='" + takipId.Text + "' WHERE takipId='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                    }
                    if (takipciId.Text != "")
                    {
                        kayit = "UPDATE takipci SET sarkiId='" + takipciId.Text + "' WHERE sanatciId='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                    }

                }
                MessageBox.Show("GÜNCELLENDİ", "KAYIT BAŞARILI");
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(takipId.Text + "nolu takip veya" + takipciId.Text + "nolu takipci bulunmamaktadır! " + hata.Message);
            }
            kullaniciGetir();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void t_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (turAdi.Text != "")
            {
                kayit = "INSERT INTO tur(turAdi) " +
                "VALUES(@turAdi)";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.Parameters.AddWithValue("@turAdi", turAdi.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            baglanti.Close();
            turGetir();
        }

        private void t_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            foreach (DataGridViewRow drow in dataGridView3.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
               
                kayit = "DELETE FROM tur WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            baglanti.Close();
            turGetir();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                if (c_kullaniciId.Text != "" && c_sarkiId.Text != "")
                {
                    kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId)" +
                    "VALUES(@kullaniciId,@sarkiId)";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciId", c_kullaniciId.Text);
                    cmd.Parameters.AddWithValue("@sarkiId", c_sarkiId.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("eklendi", "KAYIT BAŞARILI");
                }

              
            }
            catch(Exception hata)
            {
                MessageBox.Show(" hata var " + hata.Message);
            }
            baglanti.Close();
            calmaListesi();
        }

        private void c_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM calmaListesi WHERE kullaniciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Silindi", "KAYIT BAŞARILI");
            }
            baglanti.Close();
            calmaListesi();
        }

        private void t_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                foreach (DataGridViewRow drow1 in dataGridView3.SelectedRows)
                {
                    int id = Convert.ToInt32(drow1.Cells[0].Value);
                  
                    if (turAdi.Text != "")
                    {
                        kayit = "UPDATE tur SET turAdi='" + turAdi.Text + "' WHERE Id='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        MessageBox.Show("Güncellendi", "KAYIT BAŞARILI");
                    }
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(" hata var " + hata.Message);
            }
            baglanti.Close();
            turGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow1 in dataGridView4.SelectedRows)
                {
                    int id = Convert.ToInt32(drow1.Cells[0].Value);
                    baglanti.Open();
                    if (c_kullaniciId.Text != "")
                    {
                        kayit = "UPDATE calmaListesi SET kullaniciId='" + c_kullaniciId.Text + "' WHERE kullaniciId='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
    
                    }

                    if (c_sarkiId.Text != "")
                    {
                        kayit = "UPDATE calmaListesi SET sarkiId='" + c_sarkiId.Text + "' WHERE kullanıcıId='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
 
                    }
                }
                MessageBox.Show("Güncellendi", "KAYIT BAŞARILI");
            }
            catch (Exception hata)
            {
                MessageBox.Show(" hata var " + hata.Message);
            }
            baglanti.Close();
            calmaListesi();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

          
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }

}

        private void ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void c_kullaniciId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
