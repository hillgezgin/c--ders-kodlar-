using System;

namespace ConsoleApp12
{
    class Program
    {
        
        public static void DiziyiYazdir(int[] sayilar)
        {
            for(int i=0;i<sayilar.Length; i++)
            {
                Console.WriteLine("{0} ", sayilar[i]);
            }
        }
       
        static void Main(string[] args)
        {
            int gecici;
            int[] sayilar = { 5, 24, 9, 1, 87, 13 };
            for (int i = 0; i <= sayilar.Length - 1; i++)
            {
                for (int j = 1; j <= sayilar.Length - 1; j++)
                {
                    if (sayilar[j - 1] > sayilar[j])
                    {
                        gecici = sayilar[j - 1];
                        sayilar[j - 1] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }
            }
            Console.WriteLine("Dizinin Sıralı hali");
            DiziyiYazdir(sayilar);
            Console.ReadLine();

        }
    }
}
