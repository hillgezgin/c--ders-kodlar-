using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class tekstil : urun
    {
        public string KumasTuru;
        public int Beden;
        public string UreticiFirma;
        public tekstil(string ad,double fiyat,int beden,string ufirma)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Beden = beden;
            UreticiFirma = ufirma;
        }
    }
}
