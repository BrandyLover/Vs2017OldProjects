using System;
using System.Globalization;


class URI {
    static void Main(string[] args) {
        int input = int.Parse(Console.ReadLine());
        int[] cont = { 0, 0, 0 };

        while (input != 4) {
            if (input == 1)
                cont[0]++;
            else if (input == 2)
                cont[1]++;
            else if (input == 3)
                cont[2]++;
            input = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO" +
            Environment.NewLine + "Alcool: " + cont[0] +
            Environment.NewLine + "Gasolina: " + cont[1] +
            Environment.NewLine + "Diesel: " + cont[2]);

    }
}

