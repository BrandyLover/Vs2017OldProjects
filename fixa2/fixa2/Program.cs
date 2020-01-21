using System;


namespace fixa2 {
    class Program {
        static void Main(string[] args) {
            Registro[] registros = new Registro[10];
            Console.WriteLine("Quantos aluguéis serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Dados do " + i + "° aluguel:" + Environment.NewLine
                    + "Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int nquarto = int.Parse(Console.ReadLine());
                registros[nquarto] = new Registro(nome, email, nquarto);
            }
            for (int i = 0; i < 10; i++)
                if (registros[i] != null)
                    Console.WriteLine(registros[i]);
            Console.ReadLine();
        }
    }
}
