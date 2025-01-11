using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbBanka;integrated security=true;trustServerCertificate=true");
        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            LblHesapNo.Text = hesap;
            SqlCommand komut = new SqlCommand("Select * From TblKisiler where HesapNo=@P1",baglan);
            komut.Parameters.AddWithValue("@P1",hesap);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblHesapNo.Text = dr[5].ToString(); //String bir ifade olmadığından tostring() ile dönüşüm uyguladım.
                LblTelefon.Text= dr[4].ToString();//String bir ifade olmadığından tostring() ile dönüşüm uyguladım.
                LblTC.Text = dr[3].ToString();//String bir ifade olmadığından tostring() ile dönüşüm uyguladım.
            }
            baglan.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblHesap Set Bakiye=Bakiye+@P1 where HesapNo=@P2",baglan);
            komut.Parameters.AddWithValue("@P1",decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P2",int.Parse(MskHesapNoo.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşlem Gerçekleşti.");

            //Gönderen Hesabın Para Azalışı
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("Update TblHesap Set Bakiye=Bakiye-@K1 where HesapNo=@K2",baglan);
            komut1.Parameters.AddWithValue("@K1",decimal.Parse(TxtTutar.Text));
            komut1.Parameters.AddWithValue("@K2",int.Parse(MskHesapNoo.Text));
            komut1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşlem Gerçekleşti.");
        }

        private void BtnBakiyeGoruntule_Click(object sender, EventArgs e)
        {
            Form4 fr=new Form4();
            fr.Show();
        }
    }
}
