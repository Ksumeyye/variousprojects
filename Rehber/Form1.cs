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
namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=Rehber;integrated security=true;trustServerCertificate=true");
        void listele() //Geriye döndürmeyen method
        {
            DataTable dt = new DataTable(); //dt nesnesi sayesinde verileri sanal hafızada tutuyorum.
            SqlDataAdapter da = new SqlDataAdapter("Select*From TblKisiler", baglan);
            da.Fill(dt);//DataAdapter'dan gelen veriyi doldurur.
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtID.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTel.Text = "";
            TxtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblKisiler (Ad,Soyad,Mail,Telefon) values(@P1,@P2,@P3,@P4)",baglan);
            komut.Parameters.AddWithValue("@P1",TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",TxtMail.Text);
            komut.Parameters.AddWithValue("@P4",MskTel.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kişi sisteme kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From TblKisiler where Id="+TxtID.Text,baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kişi rehberden silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblKisiler set Ad=@P1,Soyad=@P2,Telefon=@P3,Mail=@P4 where Id=@P5",baglan);
            komut.Parameters.AddWithValue("@P1",TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",MskTel.Text);
            komut.Parameters.AddWithValue("@P4",TxtMail.Text);
            komut.Parameters.AddWithValue("@P5",TxtID.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kşi rehberi güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
