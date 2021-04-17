using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)    
        {
            
            int count = 0;
            string Pass; // 9999
            do
            {
                if (count > 2)
                {
                    
                    Console.WriteLine("Şifre başarısız");
                    break; 
                }
                Console.Write("şifre giriniz : "); //9876-1234-9999
                Pass = Console.ReadLine();
                if (Pass == "9999")
                {
                    Console.WriteLine("Giriş Başarılı!");
                    break;  
                }
                count++;  // 1,2
            } while (Pass != "9999");

            Console.ReadLine();
        }
    }
}
