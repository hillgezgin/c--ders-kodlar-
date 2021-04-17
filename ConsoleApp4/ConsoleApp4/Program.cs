using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 defa şifre giriş programı

            string sifre;
            for(int i=1; i<=3; i++)
            { 
           // Console.WriteLine("Deneme:{0}şifrenizi giriniz:",i);
            Console.WriteLine("Deneme:" + i + " şifrenizi giriniz:");
            sifre = Console.ReadLine();
            }
            Console.WriteLine("Şifrenizi sıfırlamak ister misiniz?");
            Console.ReadLine();

                      
            
        }
    }
}
