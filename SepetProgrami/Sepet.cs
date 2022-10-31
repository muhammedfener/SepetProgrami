using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepetProgrami
{
    public class Sepet
    {
        private decimal sepetTutar;
        private List<Urun> sepetUrunListesi = new List<Urun>();

        public List<Urun> UrunListesi { get => sepetUrunListesi; }
        public decimal SepetTutar { get => sepetTutar; set => sepetTutar = value < 0 ? 0 : value; }

        public void UrunEkle(Urun YeniUrun)
        {
            sepetUrunListesi.Add(YeniUrun);
        }

        public void UrunSil(int ID)
        {
            sepetTutar -= sepetUrunListesi[ID].UrunToplamTutar;
            sepetUrunListesi.RemoveAt(ID);
        }

        public decimal SepetTutarHesapla()
        {
            sepetTutar = 0;
            foreach (Urun urun in sepetUrunListesi)
            {
                sepetTutar += urun.Fiyat * urun.UrunAdet;
            }
            return sepetTutar;
        }
    }
}
