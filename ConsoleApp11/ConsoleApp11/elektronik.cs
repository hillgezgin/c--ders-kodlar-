using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class elektronik:urun
    {
        public string Marka;
        public elektronik(string ad,double fiyat,string marka)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Marka = marka;
        }
    }
}
