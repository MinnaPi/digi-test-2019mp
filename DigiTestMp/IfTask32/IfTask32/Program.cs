using System;

namespace IfTask32
{
    class Program
    {
        private static bool i;

        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N lukujen summan");
            Console.Write("Syötä luku");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i <userInput; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("------------");

            int j = 0; // Laskurin määritys
            while(j<userInput) //Silmukan ehto. Silmukkaan tehdään niin pitkään kunnes ehto on epätosi.
            {
                Console.WriteLine(j + 1);
                j++; //Laskurin kasvatus yhdellä
                Console.WriteLine(j); // Tulostus

                int n = 11;
                do
                {
                    n++;
                    Console.WriteLine(n);
                } while (n < userInput);

                Console.WriteLine("Ohjelman suoritus on päättynyt!");
            }
        }
    }
}
