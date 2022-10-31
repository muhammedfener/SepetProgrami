namespace SepetProgrami
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
            this.gbSepeteUrunEkle = new System.Windows.Forms.GroupBox();
            this.btnSepeteUrunEkle = new System.Windows.Forms.Button();
            this.ndUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.cmbUrunListesi = new System.Windows.Forms.ComboBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.gbSepet = new System.Windows.Forms.GroupBox();
            this.lblSepetTutar = new System.Windows.Forms.Label();
            this.btnUrunSepetSil = new System.Windows.Forms.Button();
            this.gbUrunIslemler = new System.Windows.Forms.GroupBox();
            this.gbUrunSil = new System.Windows.Forms.GroupBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.cmbSilinecekUrunler = new System.Windows.Forms.ComboBox();
            this.lblSilinecekUrunAd = new System.Windows.Forms.Label();
            this.gbUrunDuzenle = new System.Windows.Forms.GroupBox();
            this.btnDuzenlenenUrunKaydet = new System.Windows.Forms.Button();
            this.ndDuzenlenecekFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblUrunYeniFiyat = new System.Windows.Forms.Label();
            this.txtDuzenlenenAd = new System.Windows.Forms.TextBox();
            this.lblYeniUrunIsmi = new System.Windows.Forms.Label();
            this.lblDuzenlenecekUrunIsmi = new System.Windows.Forms.Label();
            this.cmbDuzenlenecekUrunler = new System.Windows.Forms.ComboBox();
            this.gbYeniUrunEkle = new System.Windows.Forms.GroupBox();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.ndYeniUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtYeniUrunAd = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblYeniUrunAd = new System.Windows.Forms.Label();
            this.gbSepeteUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndUrunAdet)).BeginInit();
            this.gbSepet.SuspendLayout();
            this.gbUrunIslemler.SuspendLayout();
            this.gbUrunSil.SuspendLayout();
            this.gbUrunDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndDuzenlenecekFiyat)).BeginInit();
            this.gbYeniUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndYeniUrunFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSepeteUrunEkle
            // 
            this.gbSepeteUrunEkle.Controls.Add(this.btnSepeteUrunEkle);
            this.gbSepeteUrunEkle.Controls.Add(this.ndUrunAdet);
            this.gbSepeteUrunEkle.Controls.Add(this.lblUrunAdet);
            this.gbSepeteUrunEkle.Controls.Add(this.cmbUrunListesi);
            this.gbSepeteUrunEkle.Controls.Add(this.lblUrunAd);
            this.gbSepeteUrunEkle.Location = new System.Drawing.Point(13, 13);
            this.gbSepeteUrunEkle.Name = "gbSepeteUrunEkle";
            this.gbSepeteUrunEkle.Size = new System.Drawing.Size(212, 129);
            this.gbSepeteUrunEkle.TabIndex = 0;
            this.gbSepeteUrunEkle.TabStop = false;
            this.gbSepeteUrunEkle.Text = "Sepete Ürün Ekleme";
            // 
            // btnSepeteUrunEkle
            // 
            this.btnSepeteUrunEkle.Location = new System.Drawing.Point(76, 98);
            this.btnSepeteUrunEkle.Name = "btnSepeteUrunEkle";
            this.btnSepeteUrunEkle.Size = new System.Drawing.Size(120, 23);
            this.btnSepeteUrunEkle.TabIndex = 4;
            this.btnSepeteUrunEkle.Text = "Ürünü Sepete Ekle";
            this.btnSepeteUrunEkle.UseVisualStyleBackColor = true;
            this.btnSepeteUrunEkle.Click += new System.EventHandler(this.btnSepeteUrunEkle_Click);
            // 
            // ndUrunAdet
            // 
            this.ndUrunAdet.Location = new System.Drawing.Point(76, 62);
            this.ndUrunAdet.Name = "ndUrunAdet";
            this.ndUrunAdet.Size = new System.Drawing.Size(120, 20);
            this.ndUrunAdet.TabIndex = 3;
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(6, 64);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(60, 13);
            this.lblUrunAdet.TabIndex = 2;
            this.lblUrunAdet.Text = "Ürün Adedi";
            // 
            // cmbUrunListesi
            // 
            this.cmbUrunListesi.FormattingEnabled = true;
            this.cmbUrunListesi.Location = new System.Drawing.Point(75, 27);
            this.cmbUrunListesi.Name = "cmbUrunListesi";
            this.cmbUrunListesi.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunListesi.TabIndex = 1;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(6, 30);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 3);
            this.label1.TabIndex = 1;
            // 
            // lbSepet
            // 
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.Location = new System.Drawing.Point(6, 19);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(238, 95);
            this.lbSepet.TabIndex = 2;
            // 
            // gbSepet
            // 
            this.gbSepet.Controls.Add(this.lblSepetTutar);
            this.gbSepet.Controls.Add(this.btnUrunSepetSil);
            this.gbSepet.Controls.Add(this.lbSepet);
            this.gbSepet.Location = new System.Drawing.Point(318, 13);
            this.gbSepet.Name = "gbSepet";
            this.gbSepet.Size = new System.Drawing.Size(251, 151);
            this.gbSepet.TabIndex = 3;
            this.gbSepet.TabStop = false;
            this.gbSepet.Text = "Sepet";
            // 
            // lblSepetTutar
            // 
            this.lblSepetTutar.AutoSize = true;
            this.lblSepetTutar.Location = new System.Drawing.Point(3, 125);
            this.lblSepetTutar.Name = "lblSepetTutar";
            this.lblSepetTutar.Size = new System.Drawing.Size(68, 13);
            this.lblSepetTutar.TabIndex = 4;
            this.lblSepetTutar.Text = "Sepet Tutarı:";
            // 
            // btnUrunSepetSil
            // 
            this.btnUrunSepetSil.Location = new System.Drawing.Point(119, 120);
            this.btnUrunSepetSil.Name = "btnUrunSepetSil";
            this.btnUrunSepetSil.Size = new System.Drawing.Size(125, 23);
            this.btnUrunSepetSil.TabIndex = 3;
            this.btnUrunSepetSil.Text = "Ürünü Sepetten Kaldır";
            this.btnUrunSepetSil.UseVisualStyleBackColor = true;
            this.btnUrunSepetSil.Click += new System.EventHandler(this.btnUrunSepetSil_Click);
            // 
            // gbUrunIslemler
            // 
            this.gbUrunIslemler.Controls.Add(this.gbUrunSil);
            this.gbUrunIslemler.Controls.Add(this.gbUrunDuzenle);
            this.gbUrunIslemler.Controls.Add(this.gbYeniUrunEkle);
            this.gbUrunIslemler.Location = new System.Drawing.Point(13, 173);
            this.gbUrunIslemler.Name = "gbUrunIslemler";
            this.gbUrunIslemler.Size = new System.Drawing.Size(556, 225);
            this.gbUrunIslemler.TabIndex = 4;
            this.gbUrunIslemler.TabStop = false;
            this.gbUrunIslemler.Text = "Ürün İşlemleri";
            // 
            // gbUrunSil
            // 
            this.gbUrunSil.Controls.Add(this.btnUrunSil);
            this.gbUrunSil.Controls.Add(this.cmbSilinecekUrunler);
            this.gbUrunSil.Controls.Add(this.lblSilinecekUrunAd);
            this.gbUrunSil.Location = new System.Drawing.Point(12, 146);
            this.gbUrunSil.Name = "gbUrunSil";
            this.gbUrunSil.Size = new System.Drawing.Size(223, 73);
            this.gbUrunSil.TabIndex = 2;
            this.gbUrunSil.TabStop = false;
            this.gbUrunSil.Text = "Ürün Sil";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(142, 44);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 2;
            this.btnUrunSil.Text = "Ürünü Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // cmbSilinecekUrunler
            // 
            this.cmbSilinecekUrunler.FormattingEnabled = true;
            this.cmbSilinecekUrunler.Location = new System.Drawing.Point(92, 17);
            this.cmbSilinecekUrunler.Name = "cmbSilinecekUrunler";
            this.cmbSilinecekUrunler.Size = new System.Drawing.Size(125, 21);
            this.cmbSilinecekUrunler.TabIndex = 1;
            // 
            // lblSilinecekUrunAd
            // 
            this.lblSilinecekUrunAd.AutoSize = true;
            this.lblSilinecekUrunAd.Location = new System.Drawing.Point(10, 20);
            this.lblSilinecekUrunAd.Name = "lblSilinecekUrunAd";
            this.lblSilinecekUrunAd.Size = new System.Drawing.Size(76, 13);
            this.lblSilinecekUrunAd.TabIndex = 0;
            this.lblSilinecekUrunAd.Text = "Silinecek Ürün";
            // 
            // gbUrunDuzenle
            // 
            this.gbUrunDuzenle.Controls.Add(this.btnDuzenlenenUrunKaydet);
            this.gbUrunDuzenle.Controls.Add(this.ndDuzenlenecekFiyat);
            this.gbUrunDuzenle.Controls.Add(this.lblUrunYeniFiyat);
            this.gbUrunDuzenle.Controls.Add(this.txtDuzenlenenAd);
            this.gbUrunDuzenle.Controls.Add(this.lblYeniUrunIsmi);
            this.gbUrunDuzenle.Controls.Add(this.lblDuzenlenecekUrunIsmi);
            this.gbUrunDuzenle.Controls.Add(this.cmbDuzenlenecekUrunler);
            this.gbUrunDuzenle.Location = new System.Drawing.Point(311, 20);
            this.gbUrunDuzenle.Name = "gbUrunDuzenle";
            this.gbUrunDuzenle.Size = new System.Drawing.Size(221, 127);
            this.gbUrunDuzenle.TabIndex = 1;
            this.gbUrunDuzenle.TabStop = false;
            this.gbUrunDuzenle.Text = "Ürün Düzenle";
            // 
            // btnDuzenlenenUrunKaydet
            // 
            this.btnDuzenlenenUrunKaydet.Location = new System.Drawing.Point(66, 98);
            this.btnDuzenlenenUrunKaydet.Name = "btnDuzenlenenUrunKaydet";
            this.btnDuzenlenenUrunKaydet.Size = new System.Drawing.Size(148, 23);
            this.btnDuzenlenenUrunKaydet.TabIndex = 6;
            this.btnDuzenlenenUrunKaydet.Text = "Düzenlenmiş Ürünü Kaydet";
            this.btnDuzenlenenUrunKaydet.UseVisualStyleBackColor = true;
            this.btnDuzenlenenUrunKaydet.Click += new System.EventHandler(this.btnDuzenlenenUrunKaydet_Click);
            // 
            // ndDuzenlenecekFiyat
            // 
            this.ndDuzenlenecekFiyat.DecimalPlaces = 2;
            this.ndDuzenlenecekFiyat.Location = new System.Drawing.Point(88, 71);
            this.ndDuzenlenecekFiyat.Name = "ndDuzenlenecekFiyat";
            this.ndDuzenlenecekFiyat.Size = new System.Drawing.Size(127, 20);
            this.ndDuzenlenecekFiyat.TabIndex = 5;
            // 
            // lblUrunYeniFiyat
            // 
            this.lblUrunYeniFiyat.AutoSize = true;
            this.lblUrunYeniFiyat.Location = new System.Drawing.Point(10, 73);
            this.lblUrunYeniFiyat.Name = "lblUrunYeniFiyat";
            this.lblUrunYeniFiyat.Size = new System.Drawing.Size(53, 13);
            this.lblUrunYeniFiyat.TabIndex = 4;
            this.lblUrunYeniFiyat.Text = "Yeni Fiyat";
            // 
            // txtDuzenlenenAd
            // 
            this.txtDuzenlenenAd.Location = new System.Drawing.Point(66, 43);
            this.txtDuzenlenenAd.Name = "txtDuzenlenenAd";
            this.txtDuzenlenenAd.Size = new System.Drawing.Size(149, 20);
            this.txtDuzenlenenAd.TabIndex = 3;
            // 
            // lblYeniUrunIsmi
            // 
            this.lblYeniUrunIsmi.AutoSize = true;
            this.lblYeniUrunIsmi.Location = new System.Drawing.Point(7, 46);
            this.lblYeniUrunIsmi.Name = "lblYeniUrunIsmi";
            this.lblYeniUrunIsmi.Size = new System.Drawing.Size(49, 13);
            this.lblYeniUrunIsmi.TabIndex = 2;
            this.lblYeniUrunIsmi.Text = "Yeni İsim";
            // 
            // lblDuzenlenecekUrunIsmi
            // 
            this.lblDuzenlenecekUrunIsmi.AutoSize = true;
            this.lblDuzenlenecekUrunIsmi.Location = new System.Drawing.Point(7, 19);
            this.lblDuzenlenecekUrunIsmi.Name = "lblDuzenlenecekUrunIsmi";
            this.lblDuzenlenecekUrunIsmi.Size = new System.Drawing.Size(102, 13);
            this.lblDuzenlenecekUrunIsmi.TabIndex = 1;
            this.lblDuzenlenecekUrunIsmi.Text = "Düzenlenecek Ürün";
            // 
            // cmbDuzenlenecekUrunler
            // 
            this.cmbDuzenlenecekUrunler.FormattingEnabled = true;
            this.cmbDuzenlenecekUrunler.Location = new System.Drawing.Point(113, 16);
            this.cmbDuzenlenecekUrunler.Name = "cmbDuzenlenecekUrunler";
            this.cmbDuzenlenecekUrunler.Size = new System.Drawing.Size(102, 21);
            this.cmbDuzenlenecekUrunler.TabIndex = 0;
            this.cmbDuzenlenecekUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbDuzenlenecekUrunler_SelectedIndexChanged);
            // 
            // gbYeniUrunEkle
            // 
            this.gbYeniUrunEkle.Controls.Add(this.btnYeniUrunEkle);
            this.gbYeniUrunEkle.Controls.Add(this.ndYeniUrunFiyat);
            this.gbYeniUrunEkle.Controls.Add(this.txtYeniUrunAd);
            this.gbYeniUrunEkle.Controls.Add(this.lblFiyat);
            this.gbYeniUrunEkle.Controls.Add(this.lblYeniUrunAd);
            this.gbYeniUrunEkle.Location = new System.Drawing.Point(12, 20);
            this.gbYeniUrunEkle.Name = "gbYeniUrunEkle";
            this.gbYeniUrunEkle.Size = new System.Drawing.Size(200, 105);
            this.gbYeniUrunEkle.TabIndex = 0;
            this.gbYeniUrunEkle.TabStop = false;
            this.gbYeniUrunEkle.Text = "Yeni Ürün Ekleme";
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(88, 75);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(100, 23);
            this.btnYeniUrunEkle.TabIndex = 4;
            this.btnYeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.btnYeniUrunEkle_Click);
            // 
            // ndYeniUrunFiyat
            // 
            this.ndYeniUrunFiyat.DecimalPlaces = 2;
            this.ndYeniUrunFiyat.Location = new System.Drawing.Point(88, 47);
            this.ndYeniUrunFiyat.Name = "ndYeniUrunFiyat";
            this.ndYeniUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.ndYeniUrunFiyat.TabIndex = 3;
            // 
            // txtYeniUrunAd
            // 
            this.txtYeniUrunAd.Location = new System.Drawing.Point(88, 17);
            this.txtYeniUrunAd.Name = "txtYeniUrunAd";
            this.txtYeniUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtYeniUrunAd.TabIndex = 2;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(7, 49);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(57, 13);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Ürün Fiyatı";
            // 
            // lblYeniUrunAd
            // 
            this.lblYeniUrunAd.AutoSize = true;
            this.lblYeniUrunAd.Location = new System.Drawing.Point(7, 20);
            this.lblYeniUrunAd.Name = "lblYeniUrunAd";
            this.lblYeniUrunAd.Size = new System.Drawing.Size(75, 13);
            this.lblYeniUrunAd.TabIndex = 0;
            this.lblYeniUrunAd.Text = "Yeni Ürün İsmi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 402);
            this.Controls.Add(this.gbUrunIslemler);
            this.Controls.Add(this.gbSepet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSepeteUrunEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSepeteUrunEkle.ResumeLayout(false);
            this.gbSepeteUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndUrunAdet)).EndInit();
            this.gbSepet.ResumeLayout(false);
            this.gbSepet.PerformLayout();
            this.gbUrunIslemler.ResumeLayout(false);
            this.gbUrunSil.ResumeLayout(false);
            this.gbUrunSil.PerformLayout();
            this.gbUrunDuzenle.ResumeLayout(false);
            this.gbUrunDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndDuzenlenecekFiyat)).EndInit();
            this.gbYeniUrunEkle.ResumeLayout(false);
            this.gbYeniUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndYeniUrunFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSepeteUrunEkle;
        private System.Windows.Forms.Button btnSepeteUrunEkle;
        private System.Windows.Forms.NumericUpDown ndUrunAdet;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.ComboBox cmbUrunListesi;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.GroupBox gbSepet;
        private System.Windows.Forms.Button btnUrunSepetSil;
        private System.Windows.Forms.GroupBox gbUrunIslemler;
        private System.Windows.Forms.GroupBox gbYeniUrunEkle;
        private System.Windows.Forms.TextBox txtYeniUrunAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblYeniUrunAd;
        private System.Windows.Forms.NumericUpDown ndYeniUrunFiyat;
        private System.Windows.Forms.GroupBox gbUrunSil;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.ComboBox cmbSilinecekUrunler;
        private System.Windows.Forms.Label lblSilinecekUrunAd;
        private System.Windows.Forms.GroupBox gbUrunDuzenle;
        private System.Windows.Forms.Button btnDuzenlenenUrunKaydet;
        private System.Windows.Forms.NumericUpDown ndDuzenlenecekFiyat;
        private System.Windows.Forms.Label lblUrunYeniFiyat;
        private System.Windows.Forms.TextBox txtDuzenlenenAd;
        private System.Windows.Forms.Label lblYeniUrunIsmi;
        private System.Windows.Forms.Label lblDuzenlenecekUrunIsmi;
        private System.Windows.Forms.ComboBox cmbDuzenlenecekUrunler;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.Label lblSepetTutar;
    }
}

