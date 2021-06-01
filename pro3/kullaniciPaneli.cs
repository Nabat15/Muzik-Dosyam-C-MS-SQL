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

//kullaniciPAneli
namespace pro3
{
    public partial class kullaniciPaneli : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        int deger = Form1.k_id;
        int t_id;
        public kullaniciPaneli()
        {
            InitializeComponent();
            premium_kullanicilar();
            takipciler();
        }

        private void kullaniciPaneli_Load(object sender, EventArgs e)
        {

        }
        void premium_kullanicilar()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT Id,kullaniciAdi ,abonelikTuru,ulke FROM kullanici WHERE abonelikTuru='Premium'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        void takipciler()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT Id,kullaniciAdi ,abonelikTuru,ulke , takipciId FROM" +
                " kullanici AS k INNER JOIN takipci AS t ON k.Id=t.takipId WHERE t.takipId='"+deger+"'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView3.DataSource = sarki_tablo;

            baglanti.Close();
        }
        void popGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=1 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=1 AND kullaniciId='" + t_id + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView4.DataSource = sarki_tablo;
            baglanti.Close();
        }

        void jazzGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=2 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=2 AND kullaniciId='" + t_id + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView4.DataSource = sarki_tablo;
            baglanti.Close();
        }
       void klasikGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=3 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE turId=3 AND kullaniciId='" + t_id + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView4.DataSource = sarki_tablo;
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> s_Id = new List<int>();
            s_Id.Clear();
            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int p_id = Convert.ToInt32(drow.Cells[0].Value);

                    baglanti.Open();
                    kayit = "SELECT takipciId FROM takipci WHERE takipId='"+ deger + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    SqlDataReader oku1 = cmd.ExecuteReader();

                    while (oku1.Read())
                    {
                        s_Id.Add(int.Parse(oku1["takipciId"].ToString()));
                    }
                    oku1.Close();
                  


                    if (s_Id.Contains(p_id) == false)
                    {
                        kayit = "INSERT INTO takipci(takipId,takipciId) " +
                        "VALUES(@takipId,@takipciId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@takipId", deger);
                        cmd.Parameters.AddWithValue("@takipciId", p_id);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Eklendi", "KAYIT BAŞARILI");

                    }
                    else if (s_Id.Contains(p_id) == true)
                    {
                        MessageBox.Show("" + p_id + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                    }

                }
                baglanti.Close();
                takipciler();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
       
        }

        private void POP_Click(object sender, EventArgs e)
        {
            popGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView3.SelectedRows)
                {
                 t_id = Convert.ToInt32(drow.Cells[4].Value);
                    baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT Id,sarkiAdi,turId,sure,albumId,kullaniciId FROM sarki INNER JOIN calmaListesi ON Id=sarkiId WHERE kullaniciId='" + t_id+ "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView4.DataSource = sarki_tablo;
            baglanti.Close();
                }
                baglanti.Close();
                takipciler();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            jazzGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            klasikGetir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<int> s_Id = new List<int>();
            s_Id.Clear();
            try
            {
                foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);

                    baglanti.Open();
                    kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    SqlDataReader oku1 = cmd.ExecuteReader();

                    while (oku1.Read())
                    {
                        s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
                    }
                    oku1.Close();
                    int sayi = 0;


                    if (s_Id.Contains(id) == false)
                    {
                        kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                        "VALUES(@kullaniciId,@sarkiId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@kullaniciId", deger);
                        cmd.Parameters.AddWithValue("@sarkiId", id);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Eklendi", "KAYIT BAŞARILI");

                    }
                    else if (s_Id.Contains(id) == true)
                    {
                        MessageBox.Show("" + id + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                    }




                }
                baglanti.Close();
                popGetir();
               


            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
         

        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<int> s_Id = new List<int>();
            s_Id.Clear();
            try
            {
                foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);

                    baglanti.Open();
                    kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    SqlDataReader oku1 = cmd.ExecuteReader();

                    while (oku1.Read())
                    {
                        s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
                    }
                    oku1.Close();
                    int sayi = 0;


                    if (s_Id.Contains(id) == false)
                    {
                        kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                        "VALUES(@kullaniciId,@sarkiId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@kullaniciId", deger);
                        cmd.Parameters.AddWithValue("@sarkiId", id);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Eklendi", "KAYIT BAŞARILI");

                    }
                    else if (s_Id.Contains(id) == true)
                    {
                        MessageBox.Show("" + id + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                    }




                }
                baglanti.Close();
                jazzGetir();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<int> s_Id = new List<int>();
            s_Id.Clear();
            try
            {
                foreach (DataGridViewRow drow in dataGridView4.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);

                    baglanti.Open();
                    kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    SqlDataReader oku1 = cmd.ExecuteReader();

                    while (oku1.Read())
                    {
                        s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
                    }
                    oku1.Close();
                    int sayi = 0;


                    if (s_Id.Contains(id) == false)
                    {
                        kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                        "VALUES(@kullaniciId,@sarkiId)";
                        cmd = new SqlCommand(kayit, baglanti);
                        cmd.Parameters.AddWithValue("@kullaniciId", deger);
                        cmd.Parameters.AddWithValue("@sarkiId", id);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Eklendi", "KAYIT BAŞARILI");

                    }
                    else if (s_Id.Contains(id) == true)
                    {
                        MessageBox.Show("" + id + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                    }




                }

                baglanti.Close();
                klasikGetir();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            List<int> s_Id = new List<int>();
            kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
            cmd = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {
                s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
            }
            oku1.Close();
            
            for (int i=0; i< dataGridView4.SelectedRows.Count; i++)
            {
               // MessageBox.Show(+i+":" + dataGridView4.SelectedRows.Count + " !", "KAYIT BAŞARILI");
                String  sayi = dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString();
                if (s_Id.Contains(Convert.ToInt32(sayi)) == false)
                {
                    kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                   "VALUES(@kullaniciId,@sarkiId)";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.Parameters.AddWithValue("@kullaniciId", deger);
                cmd.Parameters.AddWithValue("@sarkiId", dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Eklendi", "KAYIT BAŞARILI");
                }
                else if (s_Id.Contains(Convert.ToInt32(sayi)) == true)
                {
                    MessageBox.Show("" + Convert.ToInt32(sayi) + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                }
            }
            baglanti.Close();
            popGetir();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            List<int> s_Id = new List<int>();
            kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
            cmd = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {
                s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
            }
            oku1.Close();

            for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
            {
                // MessageBox.Show(+i+":" + dataGridView4.SelectedRows.Count + " !", "KAYIT BAŞARILI");
                String sayi = dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString();
                if (s_Id.Contains(Convert.ToInt32(sayi)) == false)
                {
                    kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                   "VALUES(@kullaniciId,@sarkiId)";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciId", deger);
                    cmd.Parameters.AddWithValue("@sarkiId", dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Eklendi", "KAYIT BAŞARILI");
                }
                else if (s_Id.Contains(Convert.ToInt32(sayi)) == true)
                {
                    MessageBox.Show("" + Convert.ToInt32(sayi) + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                }
            }
            baglanti.Close();
            jazzGetir();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            List<int> s_Id = new List<int>();
            kayit = "SELECT sarkiId FROM calmaListesi WHERE kullaniciId='" + deger + "'";
            cmd = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {
                s_Id.Add(int.Parse(oku1["sarkiId"].ToString()));
            }
            oku1.Close();

            for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
            {
                // MessageBox.Show(+i+":" + dataGridView4.SelectedRows.Count + " !", "KAYIT BAŞARILI");
                String sayi = dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString();
                if (s_Id.Contains(Convert.ToInt32(sayi)) == false)
                {
                    kayit = "INSERT INTO calmaListesi(kullaniciId,sarkiId) " +
                   "VALUES(@kullaniciId,@sarkiId)";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciId", deger);
                    cmd.Parameters.AddWithValue("@sarkiId", dataGridView4.SelectedRows[i].Cells["Id"].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Eklendi", "KAYIT BAŞARILI");
                }
                else if (s_Id.Contains(Convert.ToInt32(sayi)) == true)
                {
                    MessageBox.Show("" + Convert.ToInt32(sayi) + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                }
            }
            baglanti.Close();
            klasikGetir();
        }
    }
}
