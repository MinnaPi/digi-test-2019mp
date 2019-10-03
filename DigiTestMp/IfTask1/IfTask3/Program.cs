using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            string  isSignNegativeOrPositive= "positiivinen";
            string IsEvenOdd = "parillinen";

            Console.WriteLine("Ohjelma selvittää onko käyttäjän syöttämä luku positiivinen vai negatiivinen, ja parillinen vai pariton!");
            Console.WriteLine("Syötä kokonaisluku: ");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
                Console.WriteLine($"luku{userNumber} on nolla! ");
            else if (userNumber < 0)
            {
                isSignNegativeOrPositive = "Negatiivinen";
            }
            else
            {
                isSignNegativeOrPositive = "Positiivinen";
         
               
               
              
                
            }


        }
        
    }
}
