using System;


namespace Exercicio2 {
    class Retangulo {
        public double largura;
        public double altura;
        public double area() {
            return largura * altura;
        }
        public double perimetro() {
            return 2 * altura + 2 * largura;
        }
        public double diagonal() {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
        }

    }
}
