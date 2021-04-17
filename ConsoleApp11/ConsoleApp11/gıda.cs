using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class gıda : urun
    {
        public string Gidaturu;
        public int Gramaj;
        public gıda(string ad,double fiyat,string gidatutu,int gramaj)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Gidaturu = gidatutu;
            Gramaj = gramaj;
        }
    }
}
