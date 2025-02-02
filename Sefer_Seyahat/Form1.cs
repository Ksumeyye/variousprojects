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

namespace Sefer_Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbYolcuBilet;integrated security=true;trustServerCertificate=true");

        void SeferListesi()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select * from TblSeferBilgi", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void YolcuListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select*From TblYolcuBilgi",baglan);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into TblYolcuBilgi (Ad,Soyad,TC,Cinsiyet,Telefon,Mail) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglan);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", TxtCinsiyet.Text);
            komut.Parameters.AddWithValue("@p5", MskTel.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text); 
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            YolcuListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into TblKaptan (KaptanNo,AdSoyad,Telefon) values(@p1,@p2,@p3)", baglan);
            komut.Parameters.AddWithValue("@p1", TxtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskKaptanTel.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into TblSeferBilgi (Kalkis,Varis,Tarih,Saat,Kaptan,Fiyat) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan);
            komut.Parameters.AddWithValue("@p1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", MskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SeferListesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeferListesi();
            YolcuListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            TxtSeferNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "10";
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "11";
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "12";
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "13";
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "14";
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "15";
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "16";
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "17";
        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "18";
        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "19";
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "20";
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "21";
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "22";
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "23";
        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "24";
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into TblSeferDetay (SeferNo,YolcuTC,Koltuk) values(@p1,@p2,@p3)", baglan);
            komut.Parameters.AddWithValue("@p1", TxtSfrNo.Text);
            komut.Parameters.AddWithValue("@p2", MskYolcuTC.Text);
            komut.Parameters.AddWithValue("@p3", TxtKoltukNo.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Rezervasyon İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            MskYolcuTC.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
