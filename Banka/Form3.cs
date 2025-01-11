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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbBanka;integrated security=true;trustServerCertificate=true");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblKisiler (Ad,Soyad,TC,Telefon,HesapNo,Sifre) values(@P1,@P2,@P3,@P4,@P5,@P6)",baglan);
            komut.Parameters.AddWithValue("@P1",TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",MskTC.Text);
            komut.Parameters.AddWithValue("@P4",MskTel.Text);
            komut.Parameters.AddWithValue("@P5",int.Parse(MskHesapNo.Text));
            komut.Parameters.AddWithValue("@P6",int.Parse(TxtSifre.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000,1000000);
            MskHesapNo.Text = sayi.ToString();
        }
    }
}
