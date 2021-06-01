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

//admin
namespace pro3
{
    public partial class admin : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        public admin()
        {
            InitializeComponent();
        }

        void SarkiGetir()
        {
            baglanti.Open();
            adaptor = new SqlDataAdapter("SELECT * FROM sarki", baglanti);
            DataTable sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }
        void albumGetir()
        {
            baglanti.Open();
            adaptor = new SqlDataAdapter("SELECT * FROM album", baglanti);
            DataTable album_tablo = new DataTable();
            adaptor.Fill(album_tablo);
            dataGridView4.DataSource = album_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM album_sanatci", baglanti);
            album_tablo = new DataTable();
            adaptor.Fill(album_tablo);
            dataGridView5.DataSource = album_tablo;
            baglanti.Close();
        }
        void sanatciGetir()
        {
            baglanti.Open();
            adaptor = new SqlDataAdapter("SELECT * FROM  sanatci", baglanti);
            DataTable sanatci_tablo = new DataTable();
            adaptor.Fill(sanatci_tablo);
            dataGridView2.DataSource = sanatci_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki_sanatci", baglanti);
            sanatci_tablo = new DataTable();
            adaptor.Fill(sanatci_tablo);
            dataGridView3.DataSource = sanatci_tablo;

            baglanti.Close();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            SarkiGetir();
            albumGetir();
            sanatciGetir();
        }


        private void label33_Click(object sender, EventArgs e)
        {

        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    kayit = "INSERT INTO sarki(albumId,sarkiAdi,tarih,turId,sure,dinlenmeSayisi) " +
                       "VALUES(@albumId,@sarkiAdi,@tarih,@turId,@sure,@dinlenmeSayisi)";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.Parameters.AddWithValue("@albumId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@sarkiAdi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@turId", textBox3.Text);
                    cmd.Parameters.AddWithValue("@sure", textBox4.Text);
                     Random rastgele = new Random();
                    
                    int sayi = rastgele.Next(Int32.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@dinlenmeSayisi", sayi);


                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("ŞARKI EKLENDİ", "KAYIT BAŞARILI");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            SarkiGetir();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                baglanti.Open();
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayit = "DELETE FROM calmaListesi WHERE sarkiId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM sarki_sanatci WHERE sarkiId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM sarki WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            SarkiGetir();
            sanatciGetir();
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    baglanti.Open();
                    if (textBox1.Text != "")
                    {
                        kayit = "UPDATE sarki SET albumId='" + textBox1.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }


                    if (textBox2.Text != "")
                    {
                        kayit = "UPDATE sarki SET sarkiAdi='" + textBox2.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                 
                        kayit = "UPDATE sarki SET tarih=@tarih WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@tarih", dateTimePicker2.Value);
                       cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    
                    if (textBox3.Text != "")
                    {
                        kayit = "UPDATE sarki SET turId='" + textBox3.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    if (textBox4.Text != "")
                    {
                        kayit = "UPDATE sarki SET sure='" + textBox4.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    if (textBox5.Text != "")
                    {
                        kayit = "UPDATE sarki SET dinlenmeSayisi='" + textBox5.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    baglanti.Close();
                    MessageBox.Show("GÜNCELLENDİ", "KAYIT BAŞARILI");
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }


            SarkiGetir();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    if (textBox6.Text != "" && textBox7.Text != "")
                    {
                        kayit = "INSERT INTO sanatci(sanatciAdi,ulke) " +
                            "VALUES(@sanatciAdi,@ulke)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@sanatciAdi", textBox6.Text);
                        cmd.Parameters.AddWithValue("@ulke", textBox7.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("KAYIT BAŞARILI", "KAYIT BAŞARILI");
                    }
                    if (textBox8.Text != "" && textBox9.Text != "")
                    {
                        kayit = "INSERT INTO sarki_sanatci(sanatciId,sarkiId) " +
                        "VALUES(@sanatciId,@sarkiId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@sanatciId", textBox8.Text);
                        cmd.Parameters.AddWithValue("@sarkiId", textBox9.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("KAYIT BAŞARILI", "KAYIT BAŞARILI");
                    }

                    baglanti.Close();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            sanatciGetir();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM sarki_sanatci WHERE sanatciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM album_sanatci WHERE sanatciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM sanatci WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            foreach (DataGridViewRow drow in dataGridView3.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM sarki_sanatci WHERE sanatciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            sanatciGetir();
            albumGetir();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                if (textBox6.Text != "")
                {
                    kayit = "UPDATE sanatci SET sanatciAdi='" + textBox6.Text + "' WHERE Id= '" + id + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                if (textBox7.Text != "")
                {
                    kayit = "UPDATE sanatci SET ulke ='" + textBox7.Text + "' WHERE Id='" + id + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

            }
            try
            {
                foreach (DataGridViewRow drow1 in dataGridView3.SelectedRows)
                {
                    int id = Convert.ToInt32(drow1.Cells[0].Value);
                    baglanti.Open();
                    if (textBox8.Text != "")
                    {
                        kayit = "UPDATE sarki_sanatci SET sanatciId='" + textBox8.Text + "' WHERE sanatciId='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        
                    }
                    if (textBox9.Text != "")
                    {
                        kayit = "UPDATE sarki_sanatci SET sarkiId='" + textBox9.Text + "' WHERE sanatciId='" + id + "'";
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
                MessageBox.Show(textBox8.Text + "nolu sanatci veya" + textBox9.Text + "nolu şarki bulunmamaktadır! " + hata.Message);
            }

            sanatciGetir();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    if (textBox10.Text != "" && dateTimePicker3.Value.ToString() != "")
                    {
                        kayit = "INSERT INTO  album(albumAdi,tarih) " +
                            "VALUES(@albumAdi,@tarih)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@albumAdi", textBox10.Text);
                        cmd.Parameters.AddWithValue("@tarih", dateTimePicker3.Value);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("KAYIT BAŞARILI", "KAYIT BAŞARILI");
                    }
                    if (textBox11.Text != "" || textBox12.Text != "")
                    {
                        kayit = "INSERT INTO album_sanatci(sanatciId,albumId) " +
                        "VALUES(@sanatciId,@albumId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@sanatciId", textBox11.Text);
                        cmd.Parameters.AddWithValue("@albumId", textBox12.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("KAYIT BAŞARILI", "KAYIT BAŞARILI");
                    }

                    baglanti.Close();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            albumGetir();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM sarki WHERE albumId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM album_sanatci WHERE albumId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                kayit = "DELETE FROM album WHERE Id= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            foreach (DataGridViewRow drow in dataGridView5.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();kayit = "DELETE FROM album_sanatci WHERE sanatciId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();baglanti.Close();
            }
            sanatciGetir();
            albumGetir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    
                    baglanti.Open();
                    if (textBox10.Text != "")
                    {
                        kayit = "UPDATE album SET albumAdi='" + textBox10.Text + "' WHERE Id= '" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                   
                        kayit = "UPDATE album SET tarih =@tarih WHERE Id='" + id + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker3.Value);
                    cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        
                    

                }

                    foreach (DataGridViewRow drow1 in dataGridView5.SelectedRows)
                    {
                        int id = Convert.ToInt32(drow1.Cells[0].Value);
                        baglanti.Open();
                        if (textBox11.Text != "")
                        {
                            kayit = "UPDATE album_sanatci SET sanatciId='" + textBox11.Text + "' WHERE sanatciId='" + id + "'";
                            cmd = new SqlCommand(kayit, baglanti);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                           
                        }
                        if (textBox12.Text != "")
                        {
                            kayit = "UPDATE album_sanatci SET  albumId='" + textBox12.Text + "' WHERE sanatciId='" + id + "'";
                            cmd = new SqlCommand(kayit, baglanti);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                        }

                    }
                    MessageBox.Show("GÜNCELLENDİ", "KAYIT BAŞARILI");
            }
            catch (Exception hata)
            {
                    MessageBox.Show(textBox11.Text +": nolu sanatci veya" + textBox12.Text + ": nolu album bulunmamaktadır! " + hata.Message);
            }

                
                baglanti.Close();
               albumGetir();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ayarlar ayar = new ayarlar();
                ayar.ShowDialog();
                this.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
          
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}

