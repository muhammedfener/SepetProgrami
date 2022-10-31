using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SepetProgrami
{
    public class SepetUrun
    {
        private int urunAdet;
        private decimal urunToplamTutar;

        public int UrunAdet { 
            get => urunAdet;
            set
            {
                if(value < 0)
                {
                    MessageBox.Show("Ürün Adedi 0 veya Negatif Olamaz!");
                }
                else
                {
                    urunAdet = value;
                }
            }
        }

        public decimal UrunToplamTutar { 
            get => urunToplamTutar; 
            set 
            {
                if (value < 0)
                {
                    MessageBox.Show("Ürün Adedi 0 veya Negatif Olamaz!");
                }
                else
                {
                    urunToplamTutar = value;
                }
            } 
        }
    }

    public class Urun : SepetUrun
    {
        private string urunAdi;
        private decimal fiyat;

        public string UrunAdi
        {
            get => urunAdi;
            set
            {
                if(value == "")
                {
                    MessageBox.Show("Ürün Adı Boş Bırakılamaz!");
                }
                else
                {
                    urunAdi = value;
                }
            }
        }

        
        public decimal Fiyat { 
            get => fiyat;
            set 
            { 
                if(value < 0)
                {
                    MessageBox.Show("Ürün Fiyatı Negatif Olamaz!");
                }
                else
                {
                    fiyat = value;
                }
            }
        }

        public Urun(string urunAdi, decimal fiyat, int urunAdet=0, decimal urunToplamTutar=0)
        {
            this.UrunAdi = urunAdi;
            this.Fiyat = fiyat;
            this.UrunAdet = urunAdet;
            this.UrunToplamTutar = urunToplamTutar;
        }
    }
}
