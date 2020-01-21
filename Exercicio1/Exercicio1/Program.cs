using System;
using System.Globalization;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {
            /*
            int volvene, vazao, tempo;
            volvene = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());
            if(tempo * vazao > volvene) {
                Console.WriteLine("nao eh possivel");
            }
            else {
                Console.WriteLine(volvene - tempo * vazao );
            }
            Console.ReadLine();
            */

            /*
            double nota1, nota2, nota3;
            string[] input = Console.ReadLine().Split(" ");
            nota1 = double.Parse(input[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(input[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(input[2], CultureInfo.InvariantCulture);
            if(nota1 + nota2 + nota3 < 60){
                Console.WriteLine((nota1 + nota2 + nota3).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DEPENDENCIA");
            }
            else {
                Console.WriteLine((nota1 + nota2 + nota3).ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
            */
            /*
            string[] dimenfoto = Console.ReadLine().Split(" ");
            string[] dimenmold = Console.ReadLine().Split(" ");

            int xf, xr, yf, yr;
            yf = int.Parse(dimenfoto[0]);
            xf = int.Parse(dimenfoto[1]);
            yr = int.Parse(dimenmold[0]);
            xr = int.Parse(dimenmold[1]);

            if (xf > xr || yf > yr)
                if (yf > xr || xf > yr)
                    Console.WriteLine("NAO");
                else
                    Console.WriteLine("SIM");
            else
                Console.WriteLine("SIM");
            Console.ReadLine();
            */
            /*
            float glicose = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (glicose <= 100)
                Console.WriteLine("Normal");
            else if (glicose > 100 && glicose <= 140)
                Console.WriteLine("Elevado");
            else
                Console.WriteLine("Diabetes");
            Console.ReadLine();
            */
            /*
            string[] input = Console.ReadLine().Split(" ");
            float dist1, dist2, dist3;
            dist1 = float.Parse(input[0], CultureInfo.InvariantCulture);
            dist2 = float.Parse(input[1], CultureInfo.InvariantCulture);
            dist3 = float.Parse(input[2], CultureInfo.InvariantCulture);

            if (dist1 > dist2 && dist1 > dist3)
                Console.WriteLine(dist1.ToString("F2", CultureInfo.InvariantCulture));
            else if ( dist2 > dist3)
                Console.WriteLine(dist2.ToString("F2", CultureInfo.InvariantCulture));
            else
                Console.WriteLine(dist3.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            */

            /*
            string[] input = Console.ReadLine().Split(" ");
            int a, b, r = 0;
            
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);

            while(a <= b) {
                if ( a % 2 != 0) {
                    r = r + a;
                }
                a++;
            }
            Console.WriteLine(r);
            Console.ReadLine();
            */
            /*
            int input = int.Parse(Console.ReadLine());
            while (input != 0) {
                Console.WriteLine(input + " * " + input + " = " + Math.Pow(input, 2));
                input = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
            */
            /*
            int n, a, b;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            while (a <= b) {
                if (a % n == 0)
                    Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
            */
            /*
            double duracao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int numero = int.Parse(Console.ReadLine());
            for(int i = 0; i < numero; i++) {
                duracao = duracao - double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (duracao >= 0)
                    Console.WriteLine(duracao.ToString("F1",CultureInfo.InvariantCulture));
                else
                    Console.WriteLine("recarregar");
            }
            Console.ReadLine();
            */
            
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++) {
                string[] vet = Console.ReadLine().Split(" ");
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                Console.WriteLine((n1 + n2 + n3).ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
