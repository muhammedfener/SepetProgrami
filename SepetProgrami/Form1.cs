using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SepetProgrami
{
    public partial class Form1 : Form
    {
        List<Urun> varOlanUrunler = new List<Urun>();
        Sepet sepet = new Sepet() {};
        Urun duzenlenecekUrun;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtYeniUrunAd.Text;
            decimal urunFiyati = ndYeniUrunFiyat.Value;
            Urun yeniUrun = new Urun(urunAdi,urunFiyati);
            varOlanUrunler.Add(yeniUrun);
            //MessageBox.Show(urunAdi + " Eklendi!");
            ComboBoxGuncelle();

            txtYeniUrunAd.Text = "";
            ndYeniUrunFiyat.Value = 0;
        }

        private void btnSepeteUrunEkle_Click(object sender, EventArgs e)
        {
            String urunAdi = cmbUrunListesi.Items[cmbUrunListesi.SelectedIndex].ToString();
            decimal urunFiyati = (from urun in varOlanUrunler where urunAdi == urun.UrunAdi select urun.Fiyat).FirstOrDefault();
            int urunAdet = (int) ndUrunAdet.Value;
            decimal urunToplamTutar = urunFiyati * urunAdet;
            
            Urun sepetYeniUrun = new Urun(urunAdi, urunFiyati,urunAdet,urunToplamTutar);
            
            sepet.UrunEkle(sepetYeniUrun);
            sepet.SepetTutar += urunToplamTutar;

            ListBoxDoldur();

            SepetTutarEkranaYaz();
            ndUrunAdet.Value = 0;
        }

        private void ComboBoxGuncelle()
        {
            cmbUrunListesi.Items.Clear();
            cmbSilinecekUrunler.Items.Clear();
            cmbDuzenlenecekUrunler.Items.Clear();
            cmbUrunListesi.Text = "";
            cmbSilinecekUrunler.Text = "";
            cmbDuzenlenecekUrunler.Text = "";
            foreach (Urun urun in varOlanUrunler)
            {
                cmbUrunListesi.Items.Add(urun.UrunAdi);
                cmbSilinecekUrunler.Items.Add(urun.UrunAdi);
                cmbDuzenlenecekUrunler.Items.Add(urun.UrunAdi);
            }
        }

        private void ListBoxDoldur()
        {
            lbSepet.Items.Clear();

            foreach (Urun urun in sepet.UrunListesi)
            {
                lbSepet.Items.Add(urun.UrunAdi + " Adet: " + urun.UrunAdet);
            }
        }

        private void btnUrunSepetSil_Click(object sender, EventArgs e)
        {
            int ID = lbSepet.SelectedIndex;

            sepet.UrunSil(ID);

            ListBoxDoldur();
            SepetTutarEkranaYaz();
        }

        private void SepetTutarEkranaYaz()
        {
            lblSepetTutar.Text = "Sepet Tutarı: " + sepet.SepetTutar;
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            varOlanUrunler.RemoveAt(cmbSilinecekUrunler.SelectedIndex);
            ComboBoxGuncelle();
        }

        private void cmbDuzenlenecekUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            duzenlenecekUrun = varOlanUrunler[cmbDuzenlenecekUrunler.SelectedIndex];
            txtDuzenlenenAd.Text = duzenlenecekUrun.UrunAdi;
            ndDuzenlenecekFiyat.Value = duzenlenecekUrun.Fiyat;
        }

        private void btnDuzenlenenUrunKaydet_Click(object sender, EventArgs e)
        {
            duzenlenecekUrun.UrunAdi = txtDuzenlenenAd.Text;
            duzenlenecekUrun.Fiyat = ndDuzenlenecekFiyat.Value;
        }
    }
}