using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp19
{
    public class tekstil:urun
    {
        
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }
        public tekstil(string ad, double fiyat, int beden, string ufirma)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Beden = beden;
            UreticiFirma = ufirma;
        }
    }
}
