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

//uyeOl
namespace pro3
{
    public partial class uyeOl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
       public static int Id;
        public uyeOl()
        {
            InitializeComponent();
            sifreText.PasswordChar = '•';
            sifreText.MaxLength = 10;
           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                List<String> s_Id = new List<String>();
                s_Id.Clear();
                
                       
                        kayit = "SELECT kullaniciAdi FROM kullanici ";
                        cmd = new SqlCommand(kayit, baglanti);
                        SqlDataReader oku3 = cmd.ExecuteReader();

                        while (oku3.Read())
                        {
                            s_Id.Add(oku3["kullaniciAdi"].ToString());
                        }
                        oku3.Close();
               
                if (s_Id.Contains(kullaniciAdiText.Text) == false)
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
                        kayit = "SELECT Id FROM Kullanici WHERE kullaniciAdi='" + kullaniciAdiText.Text + "'";
                        cmd = new SqlCommand(kayit, baglanti);
                        SqlDataReader oku = cmd.ExecuteReader();

                        while (oku.Read())
                        {

                            Id = int.Parse(oku["Id"].ToString());
                        }
                        oku.Close();

                        MessageBox.Show("" + Id + "," + kullaniciAdiText.Text, "KAYIT BAŞARILI");

               

                    this.Close();

                }
                else if (s_Id.Contains(kullaniciAdiText.Text) == true)
                {
                    MessageBox.Show("Kullanıcı adı mevcut", "KAYIT BAŞARILI");
                    
                }

                baglanti.Close();

            }
            catch(Exception hata)
            {
                MessageBox.Show(""+ hata.Message);
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
