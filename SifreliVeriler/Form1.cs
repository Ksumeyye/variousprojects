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

namespace SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=PersonelVeriTabani;integrated security=true;trustServerCertificate=true");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select*From TblVeriler",baglan);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string Ad = TxtAd.Text;
            byte[] Addizi=ASCIIEncoding.ASCII.GetBytes(Ad); //Metinin byte olarak değerini parçalayarak al.
            string Adsifre=Convert.ToBase64String(Addizi); //ToBase64 kullanılan şifreleme yöntemlerinden birisidir. Burada veri diziyi ToBase64 formatına çevirdim.
            //label6.Text = adsifre; //Şifrelenen veriyi label6 içine yazdırır.

            string Soyad = TxtSoyad.Text;
            byte[] Soyaddizi = ASCIIEncoding.ASCII.GetBytes(Soyad);
            string Soyadsifre=Convert.ToBase64String(Soyaddizi);

            string Mail = TxtMail.Text;
            byte[] Maildizi= ASCIIEncoding.ASCII.GetBytes(Mail);
            string Mailsifre = Convert.ToBase64String(Maildizi);

            string Sifre = TxtSifre.Text;
            byte[] Sifredizi = ASCIIEncoding.ASCII.GetBytes(Sifre);
            string Sifresifre = Convert.ToBase64String(Sifredizi);

            string Hesapno = TxtHesapNo.Text;
            byte[] Hesapnodizi = ASCIIEncoding.ASCII.GetBytes(Hesapno);
            string Hesapnosifre = Convert.ToBase64String(Hesapnodizi);

            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblVeriler (Ad,Soyad,Mail,Sifre,HesapNo) values(@P1,@P2,@P3,@P4,@P5)",baglan);
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",TxtMail.Text);
            komut.Parameters.AddWithValue("@P4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@P5",TxtHesapNo.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Verileriniz Başarılı Şekilde Şifrelendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adcozum = TxtAd.Text;
            byte[] Adcozumdizi=Convert.FromBase64String(Adcozum);
            string Adverisi = ASCIIEncoding.ASCII.GetString(Adcozumdizi);
            label6.Text = Adverisi;

            string Soyadcozum = TxtSoyad.Text;
            byte[] Soyadcozumdizi = Convert.FromBase64String(Soyadcozum);
            string Soyadverisi = ASCIIEncoding.ASCII.GetString(Soyadcozumdizi);
            label6.Text = Soyadverisi;

            string Mailcozum = TxtMail.Text;
            byte[] Mailcozumdizi = Convert.FromBase64String(Mailcozum);
            string Mailverisi = ASCIIEncoding.ASCII.GetString(Mailcozumdizi);
            label6.Text = Mailverisi;

            string Sifrecozum = TxtSifre.Text;
            byte[] Sifrecozumdizi = Convert.FromBase64String(Sifrecozum);
            string Sifreverisi = ASCIIEncoding.ASCII.GetString(Sifrecozumdizi);
            label6.Text = Sifreverisi;

            string Hesapnocozum = TxtHesapNo.Text;
            byte[] Hesapnocozumdizi = Convert.FromBase64String(Hesapnocozum);
            string Hesapnoverisi = ASCIIEncoding.ASCII.GetString(Hesapnocozumdizi);
            label6.Text = Hesapnoverisi;
        }
    }
}
