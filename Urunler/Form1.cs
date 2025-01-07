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

namespace Urunler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbUrunler;integrated security=true;trustServerCertificate=true");
        void listele()
        {
            DataTable dt = new DataTable();//dt nesnesi sayesinde verileri sanal hafızada tutuyorum.
            SqlDataAdapter da = new SqlDataAdapter("Select HareketID,UrunAd,(Ad+' '+Soyad) as 'Müşteri Ad Soyad', AdSoyad as 'Personel Ad Soyad',Fıyat From TblHareket Inner Join TblUrun On TblUrun.UrunID=TblHareket.HareketID Inner Join TblMusteri On TblMusteri.MusteriID=TblHareket.Musteri Inner Join TblPersonel On TblPersonel.PersonelID=TblHareket.Personel",baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
