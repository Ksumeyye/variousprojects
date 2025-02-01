namespace Trigger_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.TxtYayınevi = new System.Windows.Forms.TextBox();
            this.Txttur = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblKitap = new System.Windows.Forms.Label();
            this.LblKitapSayi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.Txttur);
            this.groupBox1.Controls.Add(this.TxtYayınevi);
            this.groupBox1.Controls.Add(this.TxtSayfa);
            this.groupBox1.Controls.Add(this.TxtYazar);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yayınevi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tür:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(71, 39);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(153, 20);
            this.TxtId.TabIndex = 6;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(71, 67);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(153, 20);
            this.TxtAd.TabIndex = 7;
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(71, 97);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(153, 20);
            this.TxtYazar.TabIndex = 8;
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(71, 123);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(153, 20);
            this.TxtSayfa.TabIndex = 9;
            // 
            // TxtYayınevi
            // 
            this.TxtYayınevi.Location = new System.Drawing.Point(71, 149);
            this.TxtYayınevi.Name = "TxtYayınevi";
            this.TxtYayınevi.Size = new System.Drawing.Size(153, 20);
            this.TxtYayınevi.TabIndex = 10;
            // 
            // Txttur
            // 
            this.Txttur.Location = new System.Drawing.Point(71, 174);
            this.Txttur.Name = "Txttur";
            this.Txttur.Size = new System.Drawing.Size(153, 20);
            this.Txttur.TabIndex = 11;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(71, 200);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(71, 23);
            this.BtnEkle.TabIndex = 12;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(146, 200);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(78, 23);
            this.BtnSil.TabIndex = 13;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1232, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1219, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblKitapSayi);
            this.groupBox3.Controls.Add(this.LblKitap);
            this.groupBox3.Location = new System.Drawing.Point(274, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1226, 36);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // LblKitap
            // 
            this.LblKitap.AutoSize = true;
            this.LblKitap.Location = new System.Drawing.Point(6, 16);
            this.LblKitap.Name = "LblKitap";
            this.LblKitap.Size = new System.Drawing.Size(59, 13);
            this.LblKitap.TabIndex = 0;
            this.LblKitap.Text = "Kitap Adet:";
            // 
            // LblKitapSayi
            // 
            this.LblKitapSayi.AutoSize = true;
            this.LblKitapSayi.Location = new System.Drawing.Point(72, 15);
            this.LblKitapSayi.Name = "LblKitapSayi";
            this.LblKitapSayi.Size = new System.Drawing.Size(13, 13);
            this.LblKitapSayi.TabIndex = 1;
            this.LblKitapSayi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1518, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox Txttur;
        private System.Windows.Forms.TextBox TxtYayınevi;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKitapSayi;
        private System.Windows.Forms.Label LblKitap;
    }
}

