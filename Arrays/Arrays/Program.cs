using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string Carl_Sagan = "We are made of Star Dust";
            char[] charArray = Carl_Sagan.ToCharArray();
            Array.Reverse(charArray);
            foreach (char Carlchar in charArray)
            {
                Console.Write(Carlchar);
            }
            Console.ReadLine();
            */
            int[] numbers = new int[10] {0 , 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

        }
    }
}
