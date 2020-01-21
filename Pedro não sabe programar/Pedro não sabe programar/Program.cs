using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedro_não_sabe_programar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string input;
            Console.WriteLine("Digite o primeiro valor e pressione enter");
            input = Console.ReadLine();
            int.TryParse(input,out a);
            Console.WriteLine("Valor inserido");
            Console.WriteLine("Digite o segundo valor e pressione enter");
            input = Console.ReadLine();
            int.TryParse(input, out b);
            Console.WriteLine("Valor inserido");
            for (; a < b; a++)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        
    }
}
