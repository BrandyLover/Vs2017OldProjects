using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_básico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mas quem vai construir as estradas?");
            bool loop = true;
            while (loop == true)
            {
                ANCAP();
                Console.WriteLine("Mas quem vai construir as estradas?");
            }
           

        }

        static void ANCAP()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            if (input == "EU")
            { 
               
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("SEU FACISTX!! EU LACRX TUDX!!");
            }
            }
        }
    }


