using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ortalama;

            Console.WriteLine("Vize Notunuzu Giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Notunuzu Giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (vize * 0.4) + (final * 0.6);  

            if (ortalama <= 100 && ortalama >= 85)
            {
                Console.WriteLine("Ortalamanız: " + ortalama + " " + "Harf Notu : AA");

            }
            else if (ortalama < 85 && ortalama >= 70)
            {
                Console.WriteLine("Ortalamanız: " + ortalama + " " + "Harf Notu BB");

            }
            else if (ortalama < 70 && ortalama >= 55)
            {
                Console.WriteLine("Ortalamanız: " + ortalama + " " + "Harf Notu CC");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }
            Console.ReadLine();
        }
    }
}
