using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Silindir
    {
        private double r;
        private double h;
        private double Pi = 3.1415;

        public Silindir(double yaricap,double yükseklik)
        {
            r = yaricap;
            h = yükseklik;
        }
        public Silindir(double yaricap,double yükseklik,double Pisayisi)
        {
            r = yaricap;
            h = yükseklik;
            Pi = Pisayisi;
        }
        public double Hacim()
        {
            return (Pi * r * r * h);
        }
        public double Alan()
        {
            return (2 * Pi * r * h);
        }

    }

    
    class Program   {       

        static void Main(string[] args)
        {
            Silindir s1 = new Silindir(5, 8);
            Console.WriteLine("1. Silindirin hacmi:{0}", s1.Hacim());
            Silindir s2 = new Silindir(5, 8, 3);
            Console.WriteLine("2. Silindirin hacmi:{0}", s2.Hacim());
            Console.Read();
        }
    }
}
