﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay fr = new FrmOgrenciDetay();
            fr.numara = maskedTextBox1.Text;
            fr.Show();
           
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e) //TextChange MEtin Değiştiği an demektir.
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();

            }
        }
    }
}
