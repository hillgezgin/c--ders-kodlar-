using System;

namespace ConsoleApp8
{
    class Program
    {
        enum kadrolar : int
        {
            Müdür,
            Müdür_Yardımcısı,
            Öğretim_Görevlisi,
            Araştırma_Görevlisi
        }

        static void PersonelMaas(kadrolar e)
        {
            switch(e)
            {
                case kadrolar.Müdür:
                    Console.WriteLine("Maaş değeri: 8000 tl");
                    break;
                case kadrolar.Müdür_Yardımcısı:
                    Console.WriteLine("Maaş değeri: 7500 tl");
                    break;
                case kadrolar.Öğretim_Görevlisi:
                    Console.WriteLine("Maaş değeri: 7000 tl");
                    break;
                case kadrolar.Araştırma_Görevlisi:
                    Console.WriteLine("Maaş değeri: 6500 tl");
                    break;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Maaşını öğrenmek istediğiniz kadroyu seçiniz:");
             kadrolar k;
             for(k=kadrolar.Müdür;k<=kadrolar.Araştırma_Görevlisi;k++)
             {
                 Console.WriteLine("{0} için : {1}", k, ((int)k)+1);
             }            
            Console.WriteLine("seçiminiz:"); 
            kadrolar secim = (kadrolar)Convert.ToInt32(Console.ReadLine());
            PersonelMaas(secim-1);
            Console.Read();
        }
    }
}
