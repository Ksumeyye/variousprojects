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

namespace MiniSqlDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=LAPTOP-O1DRK0LF;database=DbOgrenciNot;integrated security=true;trustServerCertificate=true");
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;


            try //İşimi yapan kısım
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception) //Hata verir.
            {

                MessageBox.Show("Sorgunuzu Kontrol Edin.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            try
            {
                
                baglan.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.ExecuteNonQuery();
                baglan.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * From TblDersler", baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol Edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
