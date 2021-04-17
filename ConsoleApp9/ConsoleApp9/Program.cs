using System;

namespace ConsoleApp9
{
    class Program
    {
        enum gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        };
        static void Main(string[] args)
        {
            gunler secim = gunler.Perşembe;

            if(secim==gunler.Cumartesi || secim==gunler.Pazar)
            {
                Console.WriteLine("Haftasonu seçtiniz.");
            }
            else
            {
                Console.WriteLine("Haftaiçi seçtiniz.");
            }
        }
    }
}
