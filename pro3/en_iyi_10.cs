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
//en iyi10
namespace pro3
{

    public partial class en_iyi_10 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        public en_iyi_10()
        {
            InitializeComponent();
            sarkiGetir();
        }
        void sarkiGetir()
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;
  
            baglanti.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            kullaniciPaneli  k_p = new kullaniciPaneli();
            k_p.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT TOP 10 * FROM sarki ORDER BY  dinlenmeSayisi DESC ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT TOP 10 * FROM sarki WHERE turId=1 ORDER BY  dinlenmeSayisi DESC ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT TOP 10 * FROM sarki WHERE turId=2 ORDER BY  dinlenmeSayisi DESC ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT TOP 10 * FROM sarki WHERE turId=3 ORDER BY  dinlenmeSayisi DESC ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT TOP 10 sarkiAdi,ulke ,dinlenmeSayisi,turId FROM sarki AS s INNER JOIN calmaListesi AS c ON s.Id=c.sarkiId INNER JOIN kullanici AS k ON c.kullaniciId=k.Id  ORDER BY  dinlenmeSayisi DESC ", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView1.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable sarki_tablo;
            adaptor = new SqlDataAdapter("SELECT * FROM sarki WHERE sarkiAdi like '%" +ara.Text+"'", baglanti);
            sarki_tablo = new DataTable();
            adaptor.Fill(sarki_tablo);
            dataGridView2.DataSource = sarki_tablo;

            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi;
            baglanti.Open();
            try
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    int dinlenme = Convert.ToInt32(drow.Cells[6].Value);
                    dinlenme += 1;
                    
                    kayit = "UPDATE sarki SET dinlenmeSayisi='" + dinlenme + "' WHERE Id= '" + id + "'";
                    cmd = new SqlCommand(kayit, baglanti);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    DataTable sarki_tablo;
                    adaptor = new SqlDataAdapter("SELECT * FROM sarki WHERE Id= '" + id + "'", baglanti);
                    sarki_tablo = new DataTable();
                    adaptor.Fill(sarki_tablo);
                    dataGridView2.DataSource = sarki_tablo;

                }

                baglanti.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }

        private void en_iyi_10_Load(object sender, EventArgs e)
        {

        }
    }
}
