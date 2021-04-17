using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int haftaninkacincigünü;
            Console.WriteLine("Haftanın kaçıncı günü?(1-7):");
            haftaninkacincigünü = Convert.ToInt32(Console.ReadLine());
            switch(haftaninkacincigünü)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Lütfen 1-7 arasında bir değer girin!");
                    break;
            }
            Console.ReadLine();
        
        }
    }
}
