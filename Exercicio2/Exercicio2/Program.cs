using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Retangulo R = new Retangulo();
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + R.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + R.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + R.diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
