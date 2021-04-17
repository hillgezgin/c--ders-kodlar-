using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class urun
    {
        public string UrunAdi;
        public double Fiyat;
        public double KDVUygula()
        {
            return Fiyat * 1.05;
        }
        public urun()
        { }
        public urun(string ad,double fiyat)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
        }
    }
}
