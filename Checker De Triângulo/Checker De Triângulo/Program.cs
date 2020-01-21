using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checker_De_Triângulo
{
    class Program
    {
        public string userInputa;
        public string userInputb;
        public string userInputc;

        static void Main(string[] args)
        {
            while (true)
            {
                Program myProgram = new Program();
                Console.WriteLine("Digite o valor de a");
                myProgram.userInputa = Console.ReadLine();
                Console.WriteLine("Digite o valor de b");
                myProgram.userInputb = Console.ReadLine();
                Console.WriteLine("Digite o valor de c");
                myProgram.userInputc = Console.ReadLine();

                int a, b, c;

                if (Int32.TryParse(myProgram.userInputa, out a)) ;
                else
                {
                    Console.WriteLine("Input Inválida!");
                }

                if (Int32.TryParse(myProgram.userInputb, out b)) ;
                else
                {
                    Console.WriteLine("Input Inválida!");
                }


                if (Int32.TryParse(myProgram.userInputc, out c)) ;

                else
                {
                    Console.WriteLine("Input Inválida!");
                }

                Console.WriteLine(Checker(a, b, c));
            }
           
            

        }
       static string Checker (int a, int b, int c)
        {
            string TriIso = "Isóceles";
            string TriEqui = "Equilátero";
            string TriEsc = "Escaleno";
            string TriType = "";

            if (a == b & a == c)
            {
                TriType = TriEqui;
                
            }
            if (a == b & a != c | a == c & a != b | b == c & b != a)
            {
                TriType = TriIso;
                
            }
            if (a != b & a != c)
            {
                TriType = TriEsc;
                
            }
            string returnString = TriType;

            return returnString;
            
        }

    }
}
