using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1,2 or 3:");
            string userValue = Console.ReadLine();
            string message = "";
            if(userValue == "1")          
            {
                  message = "You won a new car!";                
            }
            else if(userValue == "2")
            {
                  message = "You won a new boat!";
            }
            else if(userValue == "3")
            {
                 message = "You won a new cat!";            
            }
            else
            {
                message = "Sorry we didn't undestrand";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1,2 or 3:");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.WriteLine("You choose {0}, therefore you won a {1}", userValue, message);

            /*
            if (userValue != "1")
            {
                Console.WriteLine("Try again? Y or N?");
                Console.ReadLine();
                bool YorN;
                if(userValue == "Y")
                {
                    YorN = true;
                }
                else if(userValue == "y")
                {
                    YorN = true;
                }
                else
                {
                    YorN = false;
                }

                if (YorN == true)
                {
                    Program.Main();
                }
                else
                {
                    Console.ReadLine();
                }
            }
            else {
                Console.ReadLine();
            }
            */
            Console.ReadLine();
        }

    }
}


