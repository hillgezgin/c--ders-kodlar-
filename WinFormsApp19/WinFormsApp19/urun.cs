using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp19
{
    public class urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public virtual double KDVUygula()
        {
            return Fiyat * 1.05;
        }
        public urun()
        { }
        public urun(string ad, double fiyat)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
        }
    }
}
