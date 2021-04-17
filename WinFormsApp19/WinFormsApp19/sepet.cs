using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp19
{
    public class sepet 
    {
        private List<urun> urunler = new List<urun>();

        public double ToplamTutar()
        {
            double toplamfiyat = 0;
            foreach (urun item in urunler)
            {
                toplamfiyat += item.KDVUygula();
            }
            return toplamfiyat;
        }


        public void Ekle(urun yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
