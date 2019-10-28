using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            string isStudent = "";
            string isMTKmember = "";
            double ticketPrice = 16;
            Console.WriteLine("Ticket Price");
            Console.WriteLine("Oletko varusmies? K/E");
            string isConscript = Console.ReadLine();
            if (isConscript == "K") ;
            {
                discount = 0.5;
            }
            else
            {
                Console.WriteLine("Oletko opiskelija? K/E");
                isStudent = Console.ReadLine();
                if (isStudent == "K")
                {
                    Console.WriteLine("Oletko MTK:n jäsen? K/E");
                    isMTKmember = Console.ReadLine();
                    if (isMTKmember == "K")
                    {
                        discount = 0.6;
                    }
                    else
                    {
                        discount = 0.45;
                    }


                }
                Console.WriteLine("Minkä ikäinen olet?");
            
        }

    }
}
}