using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            sepet alisveris = new sepet();
            gıda ekmek = new gıda("Uno",1,"ekmek",80);
            sepet.Ekle(ekmek);
            Console.WriteLine(sepet.ToplamTutar().ToString());

        }
    }
}
