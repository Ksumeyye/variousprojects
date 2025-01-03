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

namespace Veri_Tabanlı_Parti_Secim_Grafik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbSecimProje;integrated security=true;trustServerCertificate=true");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblIlce(IlceAd,AParti,BParti,CParti,DParti,EParti) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtilceAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtAParti.Text);
            komut.Parameters.AddWithValue("@p3", TxtBParti.Text);
            komut.Parameters.AddWithValue("@p4", TxtCParti.Text);
            komut.Parameters.AddWithValue("@p5",TxtDParti.Text);
            komut.Parameters.AddWithValue("@p6",TxtEParti.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Oy Girişi Gerçekleşti.");
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
