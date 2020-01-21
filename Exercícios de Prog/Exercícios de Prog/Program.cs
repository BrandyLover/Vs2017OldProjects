using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_de_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o programa:");
            if (Console.ReadLine() == "1") Exercicio1();
        }
        static void Exercicio1()
        {
            Console.WriteLine("Digite o valor do fator a:");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine("Digite o valor do fator b:");
           input = Console.ReadLine();
            int b = int.Parse(input);
            Console.WriteLine(a + " X " + b + " = " + (a * b));
            Console.Beep();
            Console.ReadLine();
        }
    }
}
