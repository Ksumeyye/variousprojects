namespace Resim_Proje
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
            this.BtnResim = new System.Windows.Forms.Button();
            this.BtnRenk = new System.Windows.Forms.Button();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMetin = new System.Windows.Forms.TextBox();
            this.TxtBoyut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnResim
            // 
            this.BtnResim.Location = new System.Drawing.Point(32, 32);
            this.BtnResim.Name = "BtnResim";
            this.BtnResim.Size = new System.Drawing.Size(139, 23);
            this.BtnResim.TabIndex = 0;
            this.BtnResim.Text = "Resim Seç";
            this.BtnResim.UseVisualStyleBackColor = true;
            this.BtnResim.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRenk
            // 
            this.BtnRenk.Location = new System.Drawing.Point(32, 84);
            this.BtnRenk.Name = "BtnRenk";
            this.BtnRenk.Size = new System.Drawing.Size(139, 23);
            this.BtnRenk.TabIndex = 1;
            this.BtnRenk.Text = "Renk Seç";
            this.BtnRenk.UseVisualStyleBackColor = true;
            this.BtnRenk.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(32, 141);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(139, 23);
            this.BtnYazdir.TabIndex = 2;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(32, 196);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(139, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // TxtMetin
            // 
            this.TxtMetin.Location = new System.Drawing.Point(71, 247);
            this.TxtMetin.Name = "TxtMetin";
            this.TxtMetin.Size = new System.Drawing.Size(100, 20);
            this.TxtMetin.TabIndex = 5;
            // 
            // TxtBoyut
            // 
            this.TxtBoyut.Location = new System.Drawing.Point(71, 298);
            this.TxtBoyut.Name = "TxtBoyut";
            this.TxtBoyut.Size = new System.Drawing.Size(100, 20);
            this.TxtBoyut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(806, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.BtnRenk);
            this.Controls.Add(this.BtnResim);
            this.Name = "Form1";
            this.Text = "Dosya İşlemleri & Resim Üzerine Yazı Yazma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnResim;
        private System.Windows.Forms.Button BtnRenk;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMetin;
        private System.Windows.Forms.TextBox TxtBoyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

