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

namespace Kitaplar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      KitapVT vtSinif = new KitapVT();

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtSinif.Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif=new Kitap();
            ktpsinif.KitapAd = textBox1.Text;
            ktpsinif.Yazar = textBox2.Text;
            vtSinif.KitapEkle(ktpsinif);
            MessageBox.Show("Kitap Eklendi");
        }
    }
}
