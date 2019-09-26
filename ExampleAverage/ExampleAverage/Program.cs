using System;

namespace ExampleAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int i = 1;
            Console.Write("Ohjelma laskee annettujen lukujen keskiarvon. Kuinka monta lukua syötät? ");
            int lkm = int.Parse(Console.ReadLine());


            while (i <= lkm)
            {

                int x = int.Parse(Console.ReadLine());
                summa = summa + x;
                i = i + 1;
            }
            if (lkm < 0)
            {
                double ka = summa / lkm;
                double ka1 = ka;
                NewMethod1(ka1);
            }
            else
            {
                Console.WriteLine("Lukuja ei ole syötetty!");
            }
        }

        private static void NewMethod1(double ka1)
        {
            NewMethod(ka1);
        }

    private static void NewMethod(double ka1) => Console.WriteLine("Keskiarvo on:"ka1);
    }
     
