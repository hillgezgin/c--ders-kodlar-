using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp19
{
    public class gida :urun
    {
        public string Gidaturu { get; set; }
        public int Gramaj { get; set; }
        public gida(string ad, double fiyat, string gidaturu, int gramaj)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Gidaturu = gidaturu;
            Gramaj = gramaj;
        }
        public override double KDVUygula()
        {
            return Fiyat* 1.01;
        }
    }
}
