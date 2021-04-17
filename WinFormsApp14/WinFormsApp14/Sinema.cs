using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp14
{
    class Sinema
    {
        public int toplamkoltuksayisi;
        public int boskoltuksayisi;
        public int Skoltuk;
        public double bakiye;
        public string salonno;

        const double tam = 15.0;
        const double ogrenci = 10.0;

        public Sinema(string salonN,int koltuksayi)
        {
            toplamkoltuksayisi = koltuksayi;
            salonno = salonN;
            boskoltuksayisi = toplamkoltuksayisi;
            bakiye = 0;
            
        }

        public void Biletsat(bool indirimli,int satilankoltuk)
        {
            boskoltuksayisi--;
            if (indirimli)
                bakiye = bakiye + (ogrenci*satilankoltuk);
            else
                bakiye += (tam*satilankoltuk);
        }

        public void Biletİptal(bool indirimli,int satilankoltuk)
        {
            boskoltuksayisi++;
            if (indirimli)
                bakiye = bakiye - (ogrenci*satilankoltuk);
            else
                bakiye -= (tam*satilankoltuk);
        }

        public double BakiyeSor()
        {
            return bakiye;
        }


    }
}
