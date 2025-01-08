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

namespace Mesajlasma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbMesajlasma;integrated security=true;trustServerCertificate=true");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKisiler where Numara=@P1 And Sifre=@P2",baglan);
            komut.Parameters.AddWithValue("@P1",MskNumara.Text);
            komut.Parameters.AddWithValue("@P2",TxtSifre.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                MesajGonderAl mga = new MesajGonderAl();
                mga.numara = MskNumara.Text;
                mga.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglan.Close();
            
        }
    }
}
