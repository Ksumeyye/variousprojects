﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbNotKayıt;integrated security=true;trustServerCertificate=true");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayıtDataSet.TblDers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblDers (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)",baglan);
            komut.Parameters.AddWithValue("@p1",MskNumara.Text);
            komut.Parameters.AddWithValue("@p2",TxtAd.Text);
            komut.Parameters.AddWithValue("@p3",TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi.");
            this.tblDersTableAdapter.Fill(this.dbNotKayıtDataSet.TblDers);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();
            if(ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblDers set OGRS1=@P1,OGRS2=@P2,OGR3=@P3,ORTALAMA=@P4,DURUM=@P5 where OGRNUMARA=@P6",baglan);
            komut.Parameters.AddWithValue("@P1",TxtSinav1.Text);
            komut.Parameters.AddWithValue("@P2", TxtSinav2.Text);
            komut.Parameters.AddWithValue("@P3", TxtSinav3.Text);
            komut.Parameters.AddWithValue("@P4",decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5",bool.Parse(durum));
            komut.Parameters.AddWithValue("@P6", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi.");
            this.tblDersTableAdapter.Fill(this.dbNotKayıtDataSet.TblDers);

        }
    }
}
