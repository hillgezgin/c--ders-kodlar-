using System;

namespace uyugulama2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* for (başlangıc değişkeni; koşul; adım sayisi;)
              {
                 yapılacak işlemler;

             }
            int i; 
            for(i=1;i<=100; i++) //for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);    // 12345.....100 altalta
            }
            Console.Read();
            */

            Console.WriteLine("Bir tamsayı girin");
            int sayi =Convert.ToInt16(Console.ReadLine()); //4
            int toplam = 0;
            for(int i=1; i<=sayi; i++)
            {
                toplam = toplam + i;// 0+1 =1 1+2=3 3+3=6  6+4=10
            }
            Console.WriteLine("1'den girilen sayıya kadar olanların toplamı=" + toplam);
            Console.ReadLine();






            /* soru 1 : 1) kullanıcıya ekrana toplama için +,çarpma için *,
             * bölme için /, çıkarma için - seçin diye mesaj vericek
             * 2) Kullanıcı bu tuşlardan bir tanesine bastığında program tarafından 
             * belirlenmiş 2 sayıyaya kullanıcının işlemi uygulayacak ve sonucu ekrana 
             * yazacak programı kodlayınız.  
             */

        }
    }
}
