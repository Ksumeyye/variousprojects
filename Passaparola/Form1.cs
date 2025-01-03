using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class FrmPassaparola : Form
    {
        public FrmPassaparola()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    //Cevap 1
                    case 1:
                        if(textBox1.Text=="Akdeniz")
                        {
                            BtnA.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                        //Cevap 2
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 3
                    case 3:
                        if (textBox1.Text == "Cönk Bayırı")
                        {
                            BtnC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 4
                    case 4:
                        if (textBox1.Text == "Dünya")
                        {
                            BtnD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 5
                    case 5:
                        if (textBox1.Text == "Eskişehir")
                        {
                            BtnE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 6
                    case 6:
                        if (textBox1.Text == "Fransa")
                        {
                            BtnF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 7
                    case 7:
                        if (textBox1.Text == "Grönland")
                        {
                            BtnG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 8
                    case 8:
                        if (textBox1.Text == "Hattuşa")
                        {
                            BtnH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 9
                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            BtnI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 10
                    case 10:
                        if (textBox1.Text == "İstanbul")
                        {
                            Btnİ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            Btnİ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 11
                    case 11:
                        if (textBox1.Text == "Jandarma")
                        {
                            BtnJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 12
                    case 12:
                        if (textBox1.Text == "Kızılırmak")
                        {
                            BtnK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 13
                    case 13:
                        if (textBox1.Text == "Lale Devri")
                        {
                            BtnL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 14
                    case 14:
                        if (textBox1.Text == "Maldivler")
                        {
                            BtnM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 15
                    case 15:
                        if (textBox1.Text == "Nar")
                        {
                            BtnN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 16
                    case 16:
                        if (textBox1.Text == "Ozan")
                        {
                            BtnM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 17
                    case 17:
                        if (textBox1.Text == "Paris")
                        {
                            BtnP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 18
                    case 18:
                        if (textBox1.Text == "Raspberry Pi")
                        {
                            BtnR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 19
                    case 19:
                        if (textBox1.Text == "Samanyolu")
                        {
                            BtnS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 20
                    case 20:
                        if (textBox1.Text == "Trablusgarp Savaşı")
                        {
                            BtnT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 21
                    case 21:
                        if (textBox1.Text == "Uranüs")
                        {
                            BtnU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 22
                    case 22:
                        if (textBox1.Text == "Viyana")
                        {
                            BtnV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 23
                    case 23:
                        if (textBox1.Text == "Yağmur")
                        {
                            BtnY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 24
                    case 24:
                        if (textBox1.Text == "Zeytin")
                        {
                            BtnZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                BtnA.BackColor = Color.Yellow;
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz?";
                BtnB.BackColor = Color.Yellow;
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Çanakkale Savaşı'nda Türk askerlerinin büyük bir kahramanlık gösterdiği, 1915 yılında önemli bir muharebenin yaşandığı yerin adı ne?";
                BtnC.BackColor = Color.Yellow;
            }
            if(soruno==4)
            {
                richTextBox1.Text = "Güneşe en yakın üçüncü gezegen?";
                BtnD.BackColor = Color.Yellow;
            }
            if(soruno==5)
            {
                richTextBox1.Text = "Plakası 26 olan ilimiz";
                BtnE.BackColor = Color.Yellow;
            }
            if (soruno==6)
            {
                richTextBox1.Text = "Paris hangi ülkede yer alır?";
                
                    BtnF.BackColor = Color.Yellow;
                
            }
            if(soruno==7)
            {
                richTextBox1.Text = "Dünyanın en büyük adası hangisidir?";
                
                    BtnG.BackColor = Color.Yellow;
                
            }
            if(soruno==8)
            {
                richTextBox1.Text = "Çorum il sınırlarında bulunan önemli bir arkeolojik alan?";
                
                    BtnH.BackColor = Color.Yellow;
                
            }
            if(soruno==9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                    
                    BtnI.BackColor = Color.Yellow;
                
            }
            if(soruno==10)
            {
                richTextBox1.Text = "Türkiye'nin en kalabalık ili?";
                
                    Btnİ.BackColor = Color.Yellow;
                
            }
            if (soruno == 11)
                richTextBox1.Text = "Yolda durdurup kimlik kontrolü yapar, güvenliği sağlar, devletin kanunu için görev alır. Bu kişi kimdir?";
            
                BtnJ.BackColor = Color.Yellow;
            
            if(soruno==12)
            {
                richTextBox1.Text = "Türkiye'nin kendi sınırları içerisinde doğup kendi sınırları içinde denize dökülen en uzun akarsuyu?";
                
                    BtnK.BackColor = Color.Yellow;
                
            }
            if(soruno==13)
            {
                richTextBox1.Text = "Osmanlı İmparatorluğu'nda, 18. yüzyılın başlarında, özellikle kültürel alanda batıya açılmanın, sanat ve çiçeklerin popüler olduğu dönem hangi adla anılmaktadır?";
                
                    BtnL.BackColor = Color.Yellow;
                
            }
            if(soruno== 14)
            {
                richTextBox1.Text = "Hint Okyanusu'nda, tropikal iklimi, beyaz kumsalları ve turkuaz renkli deniziyle ünlü, tatil cennetlerinden biri olan, 26 atolle bulunan ada ülkesi hangisidir?";
                
                    BtnM.BackColor = Color.Yellow;
                
            }
            if(soruno==15)
            {
                richTextBox1.Text = "Kırmızı taneleriyle bilinen, sağlığa faydalı, C vitamini açısından zengin ve özellikle kış aylarında sıkça tüketilen meyve nedir?";
                
                    BtnN.BackColor = Color.Yellow;
                
            }
            if(soruno==16)
            {
                richTextBox1.Text = "Halk şairi?";
                
                    BtnO.BackColor = Color.Yellow;
                
            }
            if(soruno==17)
            {
                richTextBox1.Text = "Eiffel Kulesi'ne ev sahipliği yapan, dünyaca ünlü Louvre Müzesi'ni ve Champs-Élysées Caddesi'ni barındıran, romantizmin simgesi olan başkent hangi şehirde bulunur?";
                
                    BtnP.BackColor = Color.Yellow;
                
            }
            if (soruno == 18)
            { 
                richTextBox1.Text = "Birçok hobi sahibi ve eğitimci tarafından kullanılan, düşük maliyetli, mini bir bilgisayar olan, genellikle programlama ve elektronik projelerde tercih edilen cihaz nedir?";
                
                BtnR.BackColor = Color.Yellow;
                
            }
            if(soruno==19)
            {
                richTextBox1.Text = "Geceleri gökyüzünde en fazla görülen, spiral yapıya sahip olan ve içerisinde milyarlarca yıldız barındıran galaksi hangisidir?";
                
                    BtnS.BackColor = Color.Yellow;
                
            }
            if(soruno==20)
            {
                richTextBox1.Text = "Osmanlı İmparatorluğu'nun 1911-1912 yılları arasında İtalya'ya karşı, Kuzey Afrika'da yer alan Libya bölgesinin kontrolü için savaştığı çatışma hangisidir?";
                
                    BtnT.BackColor = Color.Yellow;
                
            }
            if(soruno==21)
            {
                richTextBox1.Text = "Güneş Sistemi'nde yedinci sırada yer alan, mavi-yeşil rengindeki atmosferiyle tanınan ve yan yatmış bir eksende dönen gezegen hangisidir?";
                
                    BtnU.BackColor = Color.Yellow;
                
            }
            if (soruno == 22)
            { richTextBox1.Text = "Avusturya'nın başkenti, tarihi opera binaları, ünlü kahvehaneleri ve Saraylar bölgesiyle tanınan, müzik ve sanatla özdeşleşmiş şehir hangisidir?";
                
                    BtnV.BackColor = Color.Yellow;
                
            }
            if(soruno==23)
            {
                richTextBox1.Text = "Havadaki su buharının yoğunlaşarak yere düşmesiyle gerçekleşen, doğanın en yaygın atmosfer olaylarından biri nedir?";
                
                    BtnY.BackColor = Color.Yellow;
                
            }
            if(soruno==24)
            {
                richTextBox1.Text = "Akdeniz iklimine özgü, hem sofralarda hem de yağ olarak tüketilen, yeşil veya siyah renkte olan, vitamin ve antioksidan bakımından zengin meyve nedir?";
                
                    BtnZ.BackColor = Color.Yellow;
                
            }
        }
    }
}
