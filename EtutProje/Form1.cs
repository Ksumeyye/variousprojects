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
using System.IO; //Dosya Giriş-Çıkış (Fotograf) İşlemi İçin Kullandım.

namespace EtutProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbEtut;integrated security=true;trustServerCertificate=true");
        
        void dersListesi()
        {
            
            //verileri çekmek için kullanıyorum
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblDersler",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DersID"; //Combobox'dan seçtiğim dersin Id'sini getirir,Arka tarafta çalışır.
            CmbDers.DisplayMember = "DersAd"; //Combobox'dan seçtiğim dersin adını getirir,Ön tarafta çalışır.
            CmbDers.DataSource = dt;
         
        }
        // Etüt Listesi
        void etutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut1",baglan);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            // Duruma göre renk değiştirme
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Durum"].Value!=null)
                {
                    // Durumun True veya False olmasına göre renk ayarlama
                    if (row.Cells["Durum"].Value.ToString() == "True")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                }

            }

        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select OgrtID, Ad+' '+Soyad As AdSoyad From TblOgretmen Where BransID=" + CmbDers.SelectedValue,baglan);
            DataTable dt2=new DataTable();
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OgrtID";
            CmbOgretmen.DisplayMember = "AdSoyad";
            CmbOgretmen.DataSource = dt2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi(); // Form açıldığında etüt listesi yüklenir ve renkler ayarlanır
        }

        private void BtnEtutOls_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblEtut (DersID,OgretmenID,Tarih,Saat) values(@P1,@P2,@P3,@P4)",baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@P1",CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@P2",CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@P3",MskTarih.Text);
            komut.Parameters.AddWithValue("@P4",MskSaat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Etütünüz Oluşturulmuştur.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblEtut set OgrenciID=@P1, Durum=@P2 where EtutID=@P3",baglan);
            komut.Parameters.AddWithValue("@P1",TxtOgrenci.Text);
            komut.Parameters.AddWithValue("@P2","True");
            komut.Parameters.AddWithValue("@P3",TxtEtutId.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            // Veritabanı güncellemesinin ardından DataGridView'i tekrar yükle ve renk değiştir
            etutListesi();
           
        }

        private void BtnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //OpenFileDialog Dosya açmak için kullanılır. 
            pictureBox1.ImageLocation = openFileDialog1.FileName; //Picturebox'ın içerisine openFileDialogun içinden filename ile seçtiğim dosyayı gönderir.
        }

        private void BtnOgrEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblOgrenci (Ad,Soyad,Fotograf,Sınıf,Telefon,Mail) values(@P1,@P2,@P3,@P4,@P5,@P6)",baglan);
            komut.Parameters.AddWithValue("@P1",TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@P3",pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@P4",TxtOgrSınıf.Text);
            komut.Parameters.AddWithValue("@P5",MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@P6",TxtOgrMail.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglan.Close();
        }

        private void BtnOgrtEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblOgretmen (Ad,Soyad,Ders) values(@P1,@P2,@P3)", baglan);
            komut.Parameters.AddWithValue("@P1", TxtOgrtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtOgrtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", CmbBrans.SelectedValue);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğretmen Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BransID From TblOgretmen Inner Join TblDersler On TblDersler.DersID=TblOgretmen.BransID", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "BransID"; //Combobox'dan seçtiğim dersin Id'sini getirir,Arka tarafta çalışır.
            CmbDers.DisplayMember = "DersAd"; //Combobox'dan seçtiğim dersin adını getirir,Ön tarafta çalışır.
            CmbDers.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblDersler (DersAd) values(@P1)", baglan);
            komut.Parameters.AddWithValue("@P1", TxtDersAd.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ders Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
        }
    }
    
}
