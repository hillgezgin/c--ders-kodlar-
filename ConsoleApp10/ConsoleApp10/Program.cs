using System;

namespace ConsoleApp10
{
    class dikdortgen
    {
        private int boy;

        public int Boy
        {
            get { return boy; }
            set
            {
                if (value < 0)
                { boy = 0; }
                else
                { boy = value; }
            }
        }

        private int en;
        public int En
        {
            get { return en; }
            set { 
            if (value<0)
                { en = 0; }
                else { en = value; }
            }
        }

        public int alanhesapla()
        {
            int sonuc;
            sonuc = en * boy;
            return sonuc;
        }

    }
    class Program
    {
                static void Main(string[] args)
        {
            dikdortgen d1 = new dikdortgen();
            d1.Boy = Convert.ToInt32(Console.ReadLine());
            d1.En = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boy:{0} En:{1}", d1.Boy, d1.En);
            Console.WriteLine(d1.alanhesapla());
            Console.ReadLine();
        }
    }
}
