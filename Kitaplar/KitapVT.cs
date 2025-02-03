using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kitaplar
{ 
    class KitapVT
    {
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=Kitaplik;integrated security=true;trustServerCertificate=true");

        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from TblKitaplar", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(dr[0]);
                k.KitapAd = dr[1].ToString();
                k.Yazar = dr[2].ToString();
                ktp.Add(k);
            }
            baglan.Close();
            return ktp;
        }
        public void KitapEkle(Kitap kt)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into TblKitaplar (KitapAd,Yazar) values(@p1,@p2)", baglan);
            komut.Parameters.AddWithValue("@p1", kt.KitapAd);
            komut.Parameters.AddWithValue("@p2", kt.Yazar);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
