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

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbBanka;integrated security=true;trustServerCertificate=true");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*From TblKisiler where HesapNo=@P1 and Sifre=@P2",baglan);
            komut.Parameters.AddWithValue("@P1",MskHesapNo.Text);
            komut.Parameters.AddWithValue("@P2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = MskHesapNo.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
        }
    }
}
