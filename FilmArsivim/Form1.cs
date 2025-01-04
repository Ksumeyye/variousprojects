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
using System.Data.SqlClient;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-O1DRK0LF;database=FilmArsivim;integrated security=true;trustServerCertificate=true");
        void Filmler() //Method tanımladım
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblFilmler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TblFilmler(Ad,Kategori,Link) values (@P1,@P2,@P3)",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtKategori.Text);
            komut.Parameters.AddWithValue("@P3",TxtLink.Text);
            komut.ExecuteNonQuery();    
            baglanti.Close();
            MessageBox.Show("Film Listenize Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Sümeyye Kaya tarafından 5.01.2025 tarihinde kodlandı.","Arşiv Hakkında",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRenkDegistir_Click(object sender, EventArgs e)
        {

        }
    }
}
