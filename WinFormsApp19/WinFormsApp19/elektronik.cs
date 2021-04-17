using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp19
{
    public class elektronik:urun
    {
        public string Marka { get; set; }
        public elektronik(string ad, double fiyat, string marka)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Marka = marka;
        }
        public override double KDVUygula()
        {
            return Fiyat * 1.08;
        }
    }
}
