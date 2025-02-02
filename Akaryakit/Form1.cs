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

namespace Akaryakit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan= new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbAkaryakit;integrated security=true;trustServerCertificate=true");
       void Listele()
        {
            //Kursunsuz95
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*From TblBenzin where PetrolTur='Kursunsuz95'", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKursunsuzMiktar.Text = dr[4].ToString();
            }
            baglan.Close();

            //Diesel
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select*From TblBenzin where PetrolTur='Diesel'", baglan);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiesel.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                LblDieselMiktar.Text = dr2[4].ToString();
            }
            baglan.Close();

            //Otogaz
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Select*From TblBenzin where PetrolTur='Otogaz'", baglan);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblOtogaz.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                LblOtogazMiktar.Text = dr3[4].ToString();
            }
            baglan.Close();

            //Kasa
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("Select*From TblKasa", baglan);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblKasamiktar.Text = dr4[0].ToString();
            }
            baglan.Close();      
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95.Text);
            litre=Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuzFiyat.Text=tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double diesel, litre2, tutar2;
            diesel = Convert.ToDouble(LblDiesel.Text);
            litre2=Convert.ToDouble(numericUpDown2.Value);
            tutar2= diesel * litre2;
            TxtDieselFiyat.Text=tutar2.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double otogaz, litre3, tutar3;
            otogaz = Convert.ToDouble(LblOtogaz.Text);
            litre3=  Convert.ToDouble(numericUpDown3.Value);
            tutar3 = otogaz * litre3;
            TxtOtogazFiyat.Text = tutar3.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into TblHareket (Plaka,BenzinTuru,Litre,Fiyat) values(@p1,@p2,@p3,@p4)", baglan);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kursunsuz 95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtKursunsuzFiyat.Text));
                komut.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                SqlCommand komut2 = new SqlCommand("Update Tblkasa set  miktar=miktar+@p1", baglan);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuzFiyat.Text));
                komut2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Satış Yapıldı.");

                baglan.Open();
                SqlCommand komut3 = new SqlCommand("Update TblBenzin set Stok=Stok-@p1 where PetrolTur = 'Kursunsuz95'", baglan);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Satış Yapıldı.");
                Listele();
            }

                if (numericUpDown2.Value!=0)
            {
                baglan.Open();
                SqlCommand komut4 = new SqlCommand("Insert Into TblHareket(Plaka,BenzinTuru,Litre,Fiyat) values(@p5,@p6,@p7,@p8)", baglan);
                komut4.Parameters.AddWithValue("@p5", TxtPlaka.Text);
                komut4.Parameters.AddWithValue("@p6", "Diesel");
                komut4.Parameters.AddWithValue("@p7", numericUpDown2.Value);
                komut4.Parameters.AddWithValue("@p8", decimal.Parse(TxtDieselFiyat.Text));
                komut4.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                SqlCommand komut6 = new SqlCommand("Update TblKasa set miktar=miktar+@p5", baglan);
                komut6.Parameters.AddWithValue("@p5", decimal.Parse(TxtDieselFiyat.Text));
                komut6.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                SqlCommand komut7 = new SqlCommand("Update TblBenzin set Stok=Stok-@p5 where PetrolTur='Diesel'", baglan);
                komut7.Parameters.AddWithValue("@p5", numericUpDown2.Value);
                komut7.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
            if (numericUpDown3.Value!=0)
            {
                    baglan.Open();
                    SqlCommand komut5 = new SqlCommand("Insert Into TblHareket(Plaka,BenzinTuru,Litre,Fiyat) values(@p9,@p10,@p11,@p12)", baglan);
                    komut5.Parameters.AddWithValue("@p9",  TxtPlaka.Text);
                    komut5.Parameters.AddWithValue("@p10", "Otogaz");
                    komut5.Parameters.AddWithValue("@p11", numericUpDown3.Value);
                    komut5.Parameters.AddWithValue("@p12", decimal.Parse(TxtOtogazFiyat.Text));
                    komut5.ExecuteNonQuery();
                    baglan.Close();


                    baglan.Open();
                    SqlCommand komut8 = new SqlCommand("Update TblKasa set miktar=miktar+@p9", baglan);
                    komut8.Parameters.AddWithValue("@p9", decimal.Parse(TxtOtogazFiyat.Text));
                    komut8.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Satış Yapıldı.");

                    baglan.Open();
                    SqlCommand komut9 = new SqlCommand("Update TblBenzin set Stok=Stok-@p9 where PetrolTur='Otogaz'", baglan);
                    komut9.Parameters.AddWithValue("@p9",numericUpDown3.Value);
                    komut9.ExecuteNonQuery();
                    baglan.Close();
                    Listele();
                
            }
        }
    }
}
