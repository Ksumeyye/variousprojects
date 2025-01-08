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


namespace Mesajlasma
{
    public partial class MesajGonderAl : Form
    {
        public MesajGonderAl()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbMesajlasma;integrated security=true;trustServerCertificate=true");
        public string numara;
        void gelenkutusu()

        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select Ad+' '+Soyad As 'Alıcı Ad-Soyad',Baslık,Icerik From TblKisiler Inner Join TblMesajlar On TblKisiler.Numara=TblMesajlar.Alıcı", baglan);               
            DataTable dt = new DataTable();
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //"Select * From TblMesajlar Where Gonderen=" +numara,baglan
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select Ad+' '+Soyad As 'Gönderen Ad-Soyad',Baslık,Icerik From TblKisiler Inner Join TblMesajlar On TblKisiler.Numara=TblMesajlar.Gonderen",baglan);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
        }
        private void MesajGonderAl_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();

            //Ad Soyad Çekme
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select Ad,Soyad from TblKisiler where numara=" +numara,baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglan.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblMesajlar (Gonderen,Alıcı,Baslık,Icerik) values(@P1,@P2,@P3,@P4)",baglan);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2",MskAlici.Text);
            komut.Parameters.AddWithValue("@P3",TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4",richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Mesajınız Gönderildi.","Bilgi",MessageBoxButtons.OK);
            gidenkutusu();
            
        }
    }
}
