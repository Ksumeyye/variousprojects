using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_OgrenciBilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Doga");
            karakterler.Add("Ali");
            karakterler.Add("Veli");
            karakterler.Add("Murat");
            karakterler.Add("Esma");
            karakterler.Add("Esin ");
            karakterler.Add("Mehmet");

            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar=new List<int>();
            sayilar.Add(9);
            sayilar.Add(16);
            sayilar.Add(26);
            sayilar.Add(45);
            sayilar.Add(78);
            sayilar.Add(98);

            foreach(int s in sayilar)
            {
                if(s%5==0)
                {
                    listBox2.Items.Add(s);
                }
            }
            if (sayilar.Contains(74))
            {
                MessageBox.Show("Bu Sayı Var");
            }
            else
            {
                MessageBox.Show("Bu Sayı Yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();
            kisi.Add(new Kisiler()
            {
                ADI = "Doga",
                SOYADI = "Yılmaz",
                MESLEK = "Öğrenci"
            });
            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEK);
            }
        }
    }
}
