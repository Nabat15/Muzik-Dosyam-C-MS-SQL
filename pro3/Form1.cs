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

// form1
namespace pro3
{
      
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NABAT\\SQLEXPRESS;Initial Catalog=muzikDosyam;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor;
        SqlCommand cmd;
        String kayit;
        int a_id;
        String a_a;
        String aa_sifre;
        String k_a, sifre;
       public static int k_id;
        List<int> s_Id = new List<int>();
        public Form1()
        {
            InitializeComponent();
            k_sifre.PasswordChar = '•';
            a_sifre.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeOl uye = new uyeOl();
            uye.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            kayit = "SELECT Id ,adminAdi , sifre FROM admin WHERE adminAdi='" + adminAdi.Text + "' AND sifre='" + a_sifre.Text + "'";
            cmd = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {

                a_a = oku1["adminAdi"].ToString();
                aa_sifre = oku1["sifre"].ToString();
                a_id = int.Parse(oku1["Id"].ToString());
            }
            oku1.Close();
            if (a_a == adminAdi.Text && aa_sifre == a_sifre.Text)
            {
                admin admn = new admin();
                admn.ShowDialog();
                MessageBox.Show("" + a_id , "KAYIT BAŞARILI");
            }
            else
            {
                MessageBox.Show("Admin adı veya Şifre hatalı!", "KAYIT BAŞARILI");
            }
            baglanti.Close();

            
        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            adminAyar c_l = new adminAyar();
            c_l.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            kayit = "SELECT Id ,kullaniciAdi , sifre FROM kullanici WHERE kullaniciAdi='"+Kullanici_Adi.Text+"' AND sifre='"+k_sifre.Text+"'";
            cmd = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = cmd.ExecuteReader();

            while (oku1.Read())
            {

                k_a =oku1["kullaniciAdi"].ToString();
                sifre= oku1["sifre"].ToString();
                k_id = int.Parse(oku1["Id"].ToString());
            }
            oku1.Close();
            if (k_a== Kullanici_Adi.Text && sifre== k_sifre.Text)
            {

                calmaListesi c_l = new calmaListesi();
                c_l.ShowDialog();
                MessageBox.Show(""+k_id, "KAYIT BAŞARILI");
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı!", "KAYIT BAŞARILI");
            }
            baglanti.Close();

        }
    }
}
