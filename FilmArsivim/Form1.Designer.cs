namespace FilmArsivim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnTamEkran = new System.Windows.Forms.Button();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.BtnRenkDegistir = new System.Windows.Forms.Button();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 101);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(372, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(794, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 429);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(495, 404);
            this.webBrowser1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1087, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİNEMASYON";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.TxtLink);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtKategori);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtFilmAd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 429);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Ad:";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(85, 40);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(252, 26);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(85, 83);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(252, 26);
            this.TxtKategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(85, 126);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(252, 26);
            this.TxtLink.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(85, 172);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(252, 30);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnÇıkış);
            this.groupBox4.Controls.Add(this.BtnRenkDegistir);
            this.groupBox4.Controls.Add(this.BtnHakkimizda);
            this.groupBox4.Controls.Add(this.BtnTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(23, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 187);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // BtnTamEkran
            // 
            this.BtnTamEkran.Location = new System.Drawing.Point(6, 34);
            this.BtnTamEkran.Name = "BtnTamEkran";
            this.BtnTamEkran.Size = new System.Drawing.Size(314, 30);
            this.BtnTamEkran.TabIndex = 7;
            this.BtnTamEkran.Text = "Tam Ekran";
            this.BtnTamEkran.UseVisualStyleBackColor = true;
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.Location = new System.Drawing.Point(6, 70);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(314, 30);
            this.BtnHakkimizda.TabIndex = 8;
            this.BtnHakkimizda.Text = "Hakkımızda";
            this.BtnHakkimizda.UseVisualStyleBackColor = true;
            this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
            // 
            // BtnRenkDegistir
            // 
            this.BtnRenkDegistir.Location = new System.Drawing.Point(6, 106);
            this.BtnRenkDegistir.Name = "BtnRenkDegistir";
            this.BtnRenkDegistir.Size = new System.Drawing.Size(314, 30);
            this.BtnRenkDegistir.TabIndex = 9;
            this.BtnRenkDegistir.Text = "Renk Değiştir";
            this.BtnRenkDegistir.UseVisualStyleBackColor = true;
            this.BtnRenkDegistir.Click += new System.EventHandler(this.BtnRenkDegistir_Click);
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.Location = new System.Drawing.Point(6, 142);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(314, 30);
            this.BtnÇıkış.TabIndex = 10;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = true;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1295, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Button BtnRenkDegistir;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.Button BtnTamEkran;
    }
}

