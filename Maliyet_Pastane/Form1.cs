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

namespace Maliyet_Pastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=Pastane_Maliyet;integrated security=true;trustServerCertificate=true");

        void malzemeListele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*From TblMalzemeler",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        void urunListele()
        {
            baglan.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("Select*From TblUrunler", baglan);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglan.Close();
        }
        void kasaListele()
        {
            baglan.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("Select*From TblKasa", baglan);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            baglan.Close();
        }
        void urunler()
        {
            baglan.Open();
            SqlDataAdapter da4=new SqlDataAdapter("Select*From TblUrunler", baglan);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbUrun.ValueMember = "UrunID";
            CmbUrun.DisplayMember = "Ad";
            CmbUrun.DataSource = dt4;
            baglan.Close();
        }
        void malzemeler()
        {
            baglan.Open();
            SqlDataAdapter da5 = new SqlDataAdapter("Select*From TblMalzemeler", baglan);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            CmbMalzeme.ValueMember = "MalzemeID";
            CmbMalzeme.DisplayMember = "Ad";
            CmbMalzeme.DataSource = dt5;
            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListele();
            urunler();
            malzemeler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunListele();
        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemeListele();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            kasaListele();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblMalzemeler (Ad,Stok,Fiyat,Notlar) values(@p1,@p2,@p3,@p4)",baglan);
            komut.Parameters.AddWithValue("@p1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Malzeme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            malzemeListele();

        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Insert Into TblUrunler (ad) values (@p1)",baglan);
            komut3.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut3.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunListele();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("Insert Into TblFırın (UrunID,MalzemeID,Miktar,Maliyet) values(@p1,@p2,@p3,@p4)",baglan);
            komut4.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut4.Parameters.AddWithValue("@p2", CmbMalzeme.SelectedValue);
            komut4.Parameters.AddWithValue("@p3", decimal.Parse(TxtMiktar.Text));
            komut4.Parameters.AddWithValue("@p4", decimal.Parse(TxtMaliyet.Text));
            komut4.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add(CmbMalzeme.Text + " - " + TxtMaliyet.Text);
        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (TxtMiktar.Text == " ")
            {
                TxtMaliyet.Text = "0";
            }
            baglan.Open();
            SqlCommand komut5 = new SqlCommand("Select Fiyat From TblMalzemeler where MalzemeID=@p1", baglan);
            komut5.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut5.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyet.Text = dr[3].ToString();
            }
            baglan.Close();
            maliyet=Convert.ToDouble(TxtMaliyet.Text)/1000*Convert.ToDouble(TxtMiktar.Text);
            TxtMaliyet.Text = maliyet.ToString();
        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunID.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglan.Open();
            SqlCommand komut6 = new SqlCommand("Select Sum(Maliyet) from TblFırın where UrunID=@p1", baglan);
            komut6.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            SqlDataReader dr = komut6.ExecuteReader();
            while (dr.Read())
            {
                TxtMFiyat.Text = dr[0].ToString();

            }
            baglan.Close();

        }
    }
}
