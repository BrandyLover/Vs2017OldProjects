using System;
using System.Globalization;

namespace Exerciciofixa1 {
    class Program {
        static void Main(string[] args) {
            Conta conta;
            Console.Write("Digite o número da conta: ");
            string numeroConta = Console.ReadLine();
            Console.Write("Digite o nome do titular da conta: ");
            string nomeConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            double depositoIni;
            if(Console.ReadLine() == "s") {
                Console.Write("Digite o valor do depósito inicial: ");
                depositoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(int.Parse(numeroConta), nomeConta, depositoIni);
            }
            else {
                conta = new Conta(int.Parse(numeroConta), nomeConta);
            }
            Console.WriteLine("Conta Criada:");
            Console.WriteLine(conta);

            Console.WriteLine("Digite um valor para depósito: ");
            conta.depositoConta(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(conta);

            Console.WriteLine("Digite um valor para saque: ");
            conta.saqueConta(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(conta);

            Console.ReadLine();

        }
    }
}
