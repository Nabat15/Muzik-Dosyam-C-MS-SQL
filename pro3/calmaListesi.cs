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

// calmaListesi
namespace pro3
{
    public partial class calmaListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        int deger;
        public calmaListesi()
        {
            InitializeComponent();
            sarkiGetir();
        }
        void sarkiGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki s INNER JOIN sarki_sanatci AS ss ON s.Id = ss.sarkiId ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;
            deger = Form1.k_id;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki AS s INNER JOIN calmaListesi AS c ON s.Id=c.sarkiId " +
              "INNER JOIN sarki_sanatci AS ss ON s.Id = ss.sarkiId  WHERE kullaniciId='" + deger+"'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }
        private void sarki_ekle_Click(object sender, EventArgs e)
        {
            List<int> s_Id = new List<int>();
            s_Id.Clear();
            try
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
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
                    


                    if(s_Id.Contains(id)==false )
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
                    else if(s_Id.Contains(id) == true)
                    {
                        MessageBox.Show("" + id + "Şarkı Listesinde mevcut !", "KAYIT BAŞARILI");
                    }
                        
                  


                }       

                    baglanti.Close();
                   
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            sarkiGetir();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                baglanti.Open();
                kayit = "DELETE FROM calmaListesi WHERE sarkiId= '" + id + "'";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            sarkiGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki AS s INNER JOIN calmaListesi AS c ON s.Id=c.sarkiId " +
                "INNER JOIN sarki_sanatci AS ss ON s.Id=ss.sarkiId WHERE turId=1 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki AS s INNER JOIN calmaListesi AS c ON s.Id=c.sarkiId " +
                "INNER JOIN sarki_sanatci AS ss ON s.Id=ss.sarkiId  WHERE turId=2 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki AS s INNER JOIN calmaListesi AS c ON s.Id=c.sarkiId " +
                "INNER JOIN sarki_sanatci AS ss ON s.Id=ss.sarkiId  WHERE turId=3 AND kullaniciId='" + deger + "'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
            baglanti.Close();
        }

        private void calmaListesi_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            en_iyi_10 c_l = new en_iyi_10();
            c_l.ShowDialog();
            this.Close();
        }
    }
}
