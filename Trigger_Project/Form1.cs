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

namespace Trigger_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-O1DRK0LF;database=PersonelVeriTabani;integrated security=true;trustServerCertificate=true");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From TblKitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From TblSayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKitapSayi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tblkitaplar (ad,yazar,sayfa,yayınevi,tur) values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p3", TxtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", TxtYayınevi.Text);
            komut.Parameters.AddWithValue("@p5", Txttur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYayınevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Txttur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblKitaplar where Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            sayac();
        }
    }
}
